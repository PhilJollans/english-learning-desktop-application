#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Speech.Synthesis;
using System.Windows.Forms;
using EngApp.Business.Interfaces;
using EngApp.Business.Services;
using EngApp.Core.Entities;

namespace EngApp.UI
{
    public partial class FlashcardForm : Form
    {
        private readonly IWordService _wordService;
        private readonly SpeechSynthesizer _synthesizer;
        private List<Word> _words;
        private int _currentIndex;
        private int _correctCount;
        private int _wrongCount;

        public FlashcardForm()
        {
            InitializeComponent();

            // Initialize services
            _wordService = new WordService();
            _synthesizer = new SpeechSynthesizer();

            // Configure speech synthesizer
            _synthesizer.Rate = -1;
            _synthesizer.Volume = 100;

            // Initialize counters
            _currentIndex = 0;
            _correctCount = 0;
            _wrongCount = 0;

            // Load and shuffle words
            LoadWords();
        }

        // Public method to reload flashcards when form is shown again
        public void ReloadFlashcards()
        {
            // Reset counters
            _currentIndex = 0;
            _correctCount = 0;
            _wrongCount = 0;

            // Reload and shuffle words
            LoadWords();
        }



        private void LoadWords()
        {
            try
            {
                // Get all words from database
                var allWords = _wordService.GetAll();

                if (allWords == null || allWords.Count == 0)
                {
                    // Hide all panels
                    panelCard.Visible = false;
                    panelActions.Visible = false;
                    panelSummary.Visible = false;
                    
                    // Show a message label in the center
                    var lblNoWords = new Label
                    {
                        Text = "Henüz kelime eklenmemiş!\n\nLütfen önce 'Word' menüsünden kelime ekleyin.",
                        AutoSize = false,
                        TextAlign = System.Drawing.ContentAlignment.MiddleCenter,
                        Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular),
                        ForeColor = System.Drawing.Color.Gray,
                        Dock = DockStyle.Fill
                    };
                    panelMain.Controls.Add(lblNoWords);
                    lblNoWords.BringToFront();
                    return;
                }

                // Shuffle words for random order
                _words = allWords.OrderBy(x => Guid.NewGuid()).ToList();

                // Show first card
                ShowCurrentCard();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Kelimeler yüklenirken hata oluştu:\n{ex.Message}",
                    "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
                // Show error message within the form instead of closing
                panelCard.Visible = false;
                panelActions.Visible = false;
                panelSummary.Visible = false;
                
                var lblError = new Label
                {
                    Text = $"Hata oluştu:\n{ex.Message}",
                    AutoSize = false,
                    TextAlign = System.Drawing.ContentAlignment.MiddleCenter,
                    Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular),
                    ForeColor = System.Drawing.Color.Red,
                    Dock = DockStyle.Fill
                };
                panelMain.Controls.Add(lblError);
                lblError.BringToFront();
            }
        }

        private void ShowCurrentCard()
        {
            if (_currentIndex >= _words.Count)
            {
                ShowSummary();
                return;
            }

            var currentWord = _words[_currentIndex];

            // Update UI
            lblWord.Text = currentWord.Text;
            lblMeaning.Text = currentWord.Meaning;
            lblExample.Text = string.IsNullOrWhiteSpace(currentWord.MySentence) 
                ? "(No example sentence)" 
                : currentWord.MySentence;

            // Hide answer panel
            panelAnswer.Visible = false;
            btnShowAnswer.Visible = true;
            btnCorrect.Visible = false;
            btnWrong.Visible = false;

            // Update progress
            lblProgress.Text = $"{_currentIndex + 1} / {_words.Count} card";
            progressBar.Maximum = _words.Count;
            progressBar.Value = _currentIndex + 1;
        }

        private void BtnShowAnswer_Click(object sender, EventArgs e)
        {
            // Show answer panel
            panelAnswer.Visible = true;
            btnShowAnswer.Visible = false;
            btnCorrect.Visible = true;
            btnWrong.Visible = true;
        }

        private void BtnSpeak_Click(object sender, EventArgs e)
        {
            if (_currentIndex >= _words.Count)
                return;

            var currentWord = _words[_currentIndex];
            
            try
            {
                // Stop any current speech
                _synthesizer.SpeakAsyncCancelAll();
                
                // Speak the word asynchronously
                _synthesizer.SpeakAsync(currentWord.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Kelime seslendirilirken hata oluştu:\n{ex.Message}",
                    "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnCorrect_Click(object sender, EventArgs e)
        {
            if (_currentIndex >= _words.Count)
                return;

            try
            {
                // Update word statistics
                var currentWord = _words[_currentIndex];
                currentWord.CorrectCount++;
                currentWord.ReviewCount++;
                currentWord.LastReviewedDate = DateTime.Now;
                _wordService.Update(currentWord);

                // Update local counter
                _correctCount++;

                // Move to next card
                _currentIndex++;
                ShowCurrentCard();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Kelime güncellenirken hata oluştu:\n{ex.Message}",
                    "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnWrong_Click(object sender, EventArgs e)
        {
            if (_currentIndex >= _words.Count)
                return;

            try
            {
                // Update word statistics
                var currentWord = _words[_currentIndex];
                currentWord.WrongCount++;
                currentWord.ReviewCount++;
                currentWord.LastReviewedDate = DateTime.Now;
                _wordService.Update(currentWord);

                // Update local counter
                _wrongCount++;

                // Move to next card
                _currentIndex++;
                ShowCurrentCard();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Kelime güncellenirken hata oluştu:\n{ex.Message}",
                    "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ShowSummary()
        {
            // Hide card and actions
            panelCard.Visible = false;
            panelActions.Visible = false;

            // Calculate statistics
            int totalWords = _words.Count;
            double successRate = totalWords > 0 ? (_correctCount * 100.0 / totalWords) : 0;

            // Show summary
            lblSummaryStats.Text = $@"
Total words: {totalWords}

Correct: {_correctCount}
Incorrect: {_wrongCount}

Success rate: {successRate:F1}%

{GetMotivationalMessage(successRate)}
";

            panelSummary.Visible = true;
            panelSummary.BringToFront();

            // Center the summary panel
            panelSummary.Left = (panelMain.Width - panelSummary.Width) / 2;
            panelSummary.Top = (panelMain.Height - panelSummary.Height) / 2;
        }

        private string GetMotivationalMessage(double successRate)
        {
            if (successRate >= 90)
                return "Perfect! Great performance!";
            else if (successRate >= 75)
                return "Very good! Keep it up!";
            else if (successRate >= 60)
                return "Good! Practice a bit more!";
            else if (successRate >= 40)
                return "More practice needed!";
            else
                return "Don't give up! You'll improve with practice!";
        }

        private void BtnCloseSummary_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
