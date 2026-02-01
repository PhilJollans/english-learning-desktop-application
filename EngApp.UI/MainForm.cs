#nullable disable
using System;
using System.Windows.Forms;

namespace EngApp.UI
{
    public partial class MainForm : Form
    {
        private Form _currentForm;

        public MainForm()
        {
            InitializeComponent();
            
            // Show WordForm by default
            ShowFormInPanel(new WordForm());
        }

        private void ShowFormInPanel(Form form)
        {
            // Remove current form if exists
            if (_currentForm != null)
            {
                // First remove from panel to prevent access issues
                contentPanel.Controls.Remove(_currentForm);
                
                try
                {
                    _currentForm.Close();
                    _currentForm.Dispose();
                }
                catch (ObjectDisposedException)
                {
                    // Form already disposed, safe to ignore
                }
                
                _currentForm = null;
            }

            // Set up the form to be displayed within the panel
            _currentForm = form;
            _currentForm.TopLevel = false;
            _currentForm.FormBorderStyle = FormBorderStyle.None;
            _currentForm.Dock = DockStyle.Fill;
            
            // Add form to panel and show it
            contentPanel.Controls.Clear();
            contentPanel.Controls.Add(_currentForm);
            _currentForm.Show();
        }

        private void MenuItemWords_Click(object sender, EventArgs e)
        {
            ShowFormInPanel(new WordForm());
        }

        private void MenuItemFlashcards_Click(object sender, EventArgs e)
        {
            ShowFormInPanel(new FlashcardForm());
        }

        private void MenuItemPractice_Click(object sender, EventArgs e)
        {
            ShowFormInPanel(new PracticeForm(new Business.Services.WordService()));
        }

        private void MenuItemAnalytics_Click(object sender, EventArgs e)
        {
            ShowFormInPanel(new AnalyticsForm());
        }

        private void MenuItemIrregularVerbs_Click(object sender, EventArgs e)
        {
            ShowFormInPanel(new IrregularVerbsForm());
        }

        private void MenuItemHangman_Click(object sender, EventArgs e)
        {
            ShowFormInPanel(new HangmanForm());
        }
    }
}

