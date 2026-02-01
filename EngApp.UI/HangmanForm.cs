using EngApp.Business.Interfaces;
using EngApp.Business.Services;
using EngApp.Core.Entities;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace EngApp.UI
{
    public partial class HangmanForm : Form
    {
        private readonly IWordService _wordService;
        private Word? _currentWord;
        private HashSet<char> _guessedLetters;
        private HashSet<int> _askedWordIds;
        private int _wrongGuesses;
        private bool _isGameOver;
        private const int MaxWrongGuesses = 6;

        public HangmanForm()
        {
            InitializeComponent();
            _wordService = new WordService(); // Simple dependency resolution
            _guessedLetters = new HashSet<char>();
            _askedWordIds = new HashSet<int>();
        }

        private void HangmanForm_Load(object sender, EventArgs e)
        {
            SetupKeyboard();
            StartNewGame();
        }

        private void SetupKeyboard()
        {
            flpKeyboard.Controls.Clear();
            // A-Z
            for (char c = 'A'; c <= 'Z'; c++)
            {
                AddKeyboardButton(c);
            }
        }

        private void AddKeyboardButton(char letter)
        {
            var btn = new Button
            {
                Text = letter.ToString(),
                Width = 40,
                Height = 40,
                Margin = new Padding(3),
                Tag = letter
            };
            btn.Click += KeyboardButton_Click;
            flpKeyboard.Controls.Add(btn);
        }

        private void KeyboardButton_Click(object? sender, EventArgs e)
        {
            if (sender is Button btn && btn.Tag is char letter)
            {
                btn.Enabled = false;
                ProcessGuess(letter);
            }
        }

        private void StartNewGame()
        {
            // Reset game state
            _guessedLetters.Clear();
            _wrongGuesses = 0;
            _isGameOver = false;
            lblStatus.Text = "";
            lblStatus.ForeColor = Color.Black;
            pnlHangman.Invalidate(); // Redraw (clear) hangman

            // Enable all keyboard buttons
            foreach (Control control in flpKeyboard.Controls)
            {
                if (control is Button btn)
                    btn.Enabled = true;
            }

            // Fetch new word using prioritized selection
            var prioritizedWords = _wordService.GetPrioritizedWords(_askedWordIds.ToList());
            
            if (prioritizedWords.Any())
            {
                _currentWord = prioritizedWords.First();
                _askedWordIds.Add(_currentWord.Id);
                lblHint.Text = $"İpucu: {_currentWord.Meaning} ({_currentWord.PartOfSpeech})";
                UpdateWordDisplay();
            }
            else
            {
                // All words have been asked, reset and start over
                if (_askedWordIds.Count > 0)
                {
                    MessageBox.Show("Tüm kelimeleri tamamladın! Tekrar başlıyoruz.", "Tebrikler", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _askedWordIds.Clear();
                    StartNewGame(); // Recursive call to restart
                    return;
                }
                else
                {
                    MessageBox.Show("Sözlüğünde hiç kelime yok! Önce kelime eklemelisin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    this.Close();
                }
            }
        }

        private void ProcessGuess(char letter)
        {
            if (_currentWord == null) return;
            
            letter = char.ToUpperInvariant(letter);
            _guessedLetters.Add(letter);

            string upperWord = _currentWord.Text.ToUpperInvariant();
            
            if (upperWord.Contains(letter))
            {
                // Correct guess
                UpdateWordDisplay();
                CheckWinCondition();
            }
            else
            {
                // Wrong guess
                _wrongGuesses++;
                pnlHangman.Invalidate(); // Trigger repaint
                CheckLoseCondition();
            }
        }

        private void UpdateWordDisplay()
        {
            if (_currentWord == null) return;

            string display = "";
            string upperWord = _currentWord.Text.ToUpperInvariant();

            foreach (char c in upperWord)
            {
                if (!char.IsLetter(c)) 
                {
                    display += c + " "; // Show non-letter characters (spaces, hyphens)
                }
                else if (_guessedLetters.Contains(c))
                {
                    display += c + " ";
                }
                else
                {
                    display += "_ ";
                }
            }

            lblWordDisplay.Text = display.Trim();
        }

        private void CheckWinCondition()
        {
            if (_currentWord == null) return;
            string upperWord = _currentWord.Text.ToUpperInvariant();
            
            bool won = true;
            foreach (char c in upperWord)
            {
                if (char.IsLetter(c) && !_guessedLetters.Contains(c))
                {
                    won = false;
                    break;
                }
            }

            if (won)
            {
                _isGameOver = true;
                lblStatus.Text = "Tebrikler! Kazandın! 🎉 (Enter: Yeni oyun)";
                lblStatus.ForeColor = Color.Green;
                DisableKeyboard();
            }
        }

        private void CheckLoseCondition()
        {
            if (_wrongGuesses >= MaxWrongGuesses)
            {
                _isGameOver = true;
                lblStatus.Text = $"Kaybettin! Doğru kelime: {_currentWord?.Text} (Enter: Yeni oyun)";
                lblStatus.ForeColor = Color.Red;
                DisableKeyboard();
                _guessedLetters.UnionWith(_currentWord?.Text.ToUpperInvariant().ToCharArray() ?? Array.Empty<char>()); // Reveal all
                UpdateWordDisplay();
            }
        }

        private void DisableKeyboard()
        {
            foreach (Control control in flpKeyboard.Controls)
            {
                control.Enabled = false;
            }
        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            StartNewGame();
        }

        private void pnlHangman_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Pen pen = new Pen(Color.Black, 3);
            
            // Base
            g.DrawLine(pen, 20, 230, 180, 230);
            g.DrawLine(pen, 100, 230, 100, 20);
            g.DrawLine(pen, 100, 20, 150, 20);
            g.DrawLine(pen, 150, 20, 150, 50);

            if (_wrongGuesses >= 1) g.DrawEllipse(pen, 130, 50, 40, 40); // Head
            if (_wrongGuesses >= 2) g.DrawLine(pen, 150, 90, 150, 170);   // Body
            if (_wrongGuesses >= 3) g.DrawLine(pen, 150, 110, 120, 140);  // Left Arm
            if (_wrongGuesses >= 4) g.DrawLine(pen, 150, 110, 180, 140);  // Right Arm
            if (_wrongGuesses >= 5) g.DrawLine(pen, 150, 170, 120, 210);  // Left Leg
            if (_wrongGuesses >= 6) g.DrawLine(pen, 150, 170, 180, 210);  // Right Leg
        }

        private void HangmanForm_KeyPress(object? sender, KeyPressEventArgs e)
        {
            // Check if Enter key is pressed and game is over
            if (e.KeyChar == (char)Keys.Enter || e.KeyChar == (char)Keys.Return)
            {
                if (_isGameOver)
                {
                    StartNewGame();
                }
                return;
            }

            // Convert to uppercase using invariant culture
            char letter = char.ToUpperInvariant(e.KeyChar);

            // Check if it's a valid letter (A-Z)
            if (letter >= 'A' && letter <= 'Z')
            {
                // Don't allow input if game is over
                if (_isGameOver)
                    return;

                // Check if already guessed
                if (_guessedLetters.Contains(letter))
                {
                    return; // Already guessed, ignore
                }

                // Find and disable the corresponding keyboard button
                foreach (Control control in flpKeyboard.Controls)
                {
                    if (control is Button btn && btn.Tag is char btnLetter && btnLetter == letter)
                    {
                        btn.Enabled = false;
                        break;
                    }
                }

                // Process the guess
                ProcessGuess(letter);
            }
        }
    }
}
