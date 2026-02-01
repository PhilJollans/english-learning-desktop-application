#nullable disable
using System;
using System.Windows.Forms;
using System.Speech.Synthesis;
using EngApp.Business.Services;
using EngApp.Business.Interfaces;
using EngApp.Core.Entities;
using System.Linq;

namespace EngApp.UI
{
    public partial class WordForm : Form
    {
        private readonly IWordService _wordService;
        private readonly SpeechSynthesizer _synthesizer;
        private int? _selectedWordId = null;
        private bool _isUpdateMode = false;
        private List<Word> _allWords = new List<Word>(); // Store all words for search filtering

        public WordForm()
        {
            InitializeComponent();

            // Initialize services
            _wordService = new WordService();
            _synthesizer = new SpeechSynthesizer();

            // Configure speech synthesizer
            _synthesizer.Rate = -1; // Slightly slower for clarity
            _synthesizer.Volume = 100; // Max volume

            // Populate PartOfSpeech ComboBox
            cmbPartOfSpeech.Items.AddRange(EngApp.Core.Constants.PartOfSpeechConstants.GetAllValues().ToArray());
            cmbPartOfSpeech.SelectedIndex = 0; // Default to first item (Noun)

            // Wire up event handlers
            btnAdd.Click += BtnAdd_Click;
            btnCancel.Click += BtnCancel_Click;
            dgvWords.CellClick += DgvWords_CellClick;
            txtSearch.TextChanged += TxtSearch_TextChanged;

            // Load words from database
            LoadWordsFromDatabase();
        }




        private void LoadWordsFromDatabase()
        {
            try
            {
                // Load all words from database and store them
                _allWords = _wordService.GetAll().ToList();
                
                // Display all words initially
                DisplayWords(_allWords);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Veritabanından kelimeler yüklenirken hata oluştu:\n{ex.Message}",
                    "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DisplayWords(List<Word> words)
        {
            dgvWords.Rows.Clear();
            
            foreach (var word in words)
            {
                dgvWords.Rows.Add(
                    word.Id,
                    word.Text,
                    word.Meaning,
                    word.MySentence
                );
            }
        }

        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                var searchText = txtSearch.Text.Trim().ToLower();

                // If search is empty, show all words
                if (string.IsNullOrWhiteSpace(searchText))
                {
                    DisplayWords(_allWords);
                    return;
                }

                // Filter words based on search text
                var filteredWords = _allWords.Where(w =>
                    (w.Text?.ToLower().Contains(searchText) ?? false) ||
                    (w.Meaning?.ToLower().Contains(searchText) ?? false) ||
                    (w.MySentence?.ToLower().Contains(searchText) ?? false)
                ).ToList();

                // Display filtered results
                DisplayWords(filteredWords);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Arama sırasında hata oluştu:\n{ex.Message}",
                    "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            // Validate fields
            if (string.IsNullOrWhiteSpace(txtWord.Text))
            {
                MessageBox.Show("Lütfen bir kelime girin!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtWord.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtMeaning.Text))
            {
                MessageBox.Show("Lütfen kelimenin anlamını girin!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMeaning.Focus();
                return;
            }

            if (cmbPartOfSpeech.SelectedItem == null)
            {
                MessageBox.Show("Lütfen kelime türünü seçin!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbPartOfSpeech.Focus();
                return;
            }

            try
            {
                var wordText = txtWord.Text.Trim();
                var selectedPartOfSpeech = cmbPartOfSpeech.SelectedItem.ToString();

                // Check if we are in update mode
                if (_isUpdateMode && _selectedWordId.HasValue)
                {
                    // UPDATE MODE
                    // Check for duplicate (different word with same text + PartOfSpeech)
                    var existingWords = _wordService.GetAll();
                    if (existingWords.Any(w => 
                        w.Id != _selectedWordId.Value && 
                        w.Text.Equals(wordText, StringComparison.OrdinalIgnoreCase) && 
                        w.PartOfSpeech.Equals(selectedPartOfSpeech, StringComparison.OrdinalIgnoreCase)))
                    {
                        MessageBox.Show($"'{wordText}' kelimesi ({selectedPartOfSpeech}) zaten mevcut!", 
                            "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtWord.Focus();
                        txtWord.SelectAll();
                        return;
                    }

                    // Create word object with updated values
                    var wordToUpdate = new Word
                    {
                        Id = _selectedWordId.Value,
                        Text = wordText,
                        Meaning = txtMeaning.Text.Trim(),
                        MySentence = txtExample.Text.Trim(),
                        Note = string.Empty,
                        PartOfSpeech = selectedPartOfSpeech
                    };

                    // Save to database (Update method will fetch existing entity and update)
                    _wordService.Update(wordToUpdate);

                    // Reload grid to show updated word
                    LoadWordsFromDatabase();

                    // Clear fields and exit update mode
                    ClearFields();

                    // Success message
                    MessageBox.Show("✅ Kelime başarıyla güncellendi!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Focus on first field
                    txtWord.Focus();
                    return;
                }

                // ADD MODE
                // Check for duplicate word with same PartOfSpeech
                var existingWords2 = _wordService.GetAll();
                if (existingWords2.Any(w => 
                    w.Text.Equals(wordText, StringComparison.OrdinalIgnoreCase) && 
                    w.PartOfSpeech.Equals(selectedPartOfSpeech, StringComparison.OrdinalIgnoreCase)))
                {
                    MessageBox.Show($"'{wordText}' kelimesi ({selectedPartOfSpeech}) zaten mevcut!\n\nAynı kelimeyi farklı bir kelime türü ile ekleyebilirsiniz.", 
                        "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtWord.Focus();
                    txtWord.SelectAll();
                    return;
                }

                // Create new word entity
                var word = new Word
                {
                    Text = wordText,
                    Meaning = txtMeaning.Text.Trim(),
                    MySentence = txtExample.Text.Trim(),
                    Note = string.Empty,
                    PartOfSpeech = cmbPartOfSpeech.SelectedItem.ToString() ?? "Unknown"
                };

                // Save to database
                _wordService.Add(word);

                // Reload grid to show new word
                LoadWordsFromDatabase();

                // Clear fields
                ClearFields();

                // Success message
                MessageBox.Show("✅ Kelime başarıyla eklendi!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Focus on first field
                txtWord.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Kelime eklenirken hata oluştu:\n{ex.Message}",
                    "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DgvWords_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Ignore header clicks
            if (e.RowIndex < 0) return;

            try
            {
                // Get the clicked column
                var clickedColumn = dgvWords.Columns[e.ColumnIndex];

                // Safety check: ensure row and cells exist
                if (e.RowIndex >= dgvWords.Rows.Count) return;
                
                var row = dgvWords.Rows[e.RowIndex];
                if (row.Cells["colId"].Value == null || row.Cells["colWord"].Value == null)
                    return;

                // Get word ID from hidden column
                var wordId = Convert.ToInt32(row.Cells["colId"].Value);
                var wordText = row.Cells["colWord"].Value.ToString();

                // Handle Speak button click
                if (clickedColumn.Name == "colSpeak")
                {
                    SpeakWord(wordText);
                }
                // Handle Delete button click
                else if (clickedColumn.Name == "colDelete")
                {
                    DeleteWord(wordId, wordText);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"İşlem sırasında hata oluştu:\n{ex.Message}",
                    "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SpeakWord(string wordText)
        {
            if (string.IsNullOrWhiteSpace(wordText))
                return;

            try
            {
                // Stop any current speech
                _synthesizer.SpeakAsyncCancelAll();

                // Speak the word asynchronously
                _synthesizer.SpeakAsync(wordText);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Kelime seslendirilirken hata oluştu:\n{ex.Message}",
                    "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DeleteWord(int wordId, string wordText)
        {
            // Confirm deletion
            var result = MessageBox.Show(
                $"'{wordText}' kelimesini silmek istediğinizden emin misiniz?",
                "Silme Onayı",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {
                    // Delete from database
                    _wordService.Delete(wordId);

                    // Reload grid
                    LoadWordsFromDatabase();

                    MessageBox.Show("✅ Kelime başarıyla silindi!", "Başarılı",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Kelime silinirken hata oluştu:\n{ex.Message}",
                        "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void DgvWords_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Ignore header clicks
            if (e.RowIndex < 0) return;

            try
            {
                // Get the clicked column
                var clickedColumn = dgvWords.Columns[e.ColumnIndex];

                // If user clicked on Speak or Delete buttons, don't enter edit mode
                if (clickedColumn.Name == "colSpeak" || clickedColumn.Name == "colDelete")
                    return;

                // Safety check: ensure row and cells exist
                if (e.RowIndex >= dgvWords.Rows.Count) return;
                
                var row = dgvWords.Rows[e.RowIndex];
                if (row.Cells["colId"].Value == null)
                    return;

                // Get word ID and load word data
                var wordId = Convert.ToInt32(row.Cells["colId"].Value);
                var word = _wordService.GetById(wordId);

                if (word != null)
                {
                    SetUpdateMode(word);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Kelime yüklenirken hata oluştu:\n{ex.Message}",
                    "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SetUpdateMode(Word word)
        {
            _isUpdateMode = true;
            _selectedWordId = word.Id;

            // Populate form fields
            txtWord.Text = word.Text;
            txtMeaning.Text = word.Meaning;
            txtExample.Text = word.MySentence;
            
            // Set PartOfSpeech
            var index = cmbPartOfSpeech.Items.IndexOf(word.PartOfSpeech);
            if (index >= 0)
                cmbPartOfSpeech.SelectedIndex = index;

            // Update UI
            btnAdd.Text = "Update word";
            lblAddTitle.Text = "Edit word";
            btnAdd.BackColor = Color.FromArgb(220, 118, 51); // Orange color for update

            // Focus on first field
            txtWord.Focus();
            txtWord.SelectAll();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            // Clear fields and exit update mode
            ClearFields();
            txtWord.Focus();
        }

        private void ClearFields()
        {
            txtWord.Clear();
            txtMeaning.Clear();
            txtExample.Clear();
            cmbPartOfSpeech.SelectedIndex = 0; // Reset to first item (Noun)
            
            // Exit update mode
            _isUpdateMode = false;
            _selectedWordId = null;
            btnAdd.Text = "Add word";
            lblAddTitle.Text = "Add new word";
            btnAdd.BackColor = Color.FromArgb(25, 103, 210); // Blue color for add
        }
    }
}
