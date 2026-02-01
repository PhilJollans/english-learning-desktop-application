using EngApp.Business.Interfaces;
using EngApp.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Drawing;
using System.Threading.Tasks;

namespace EngApp.UI
{
    public partial class PracticeForm : Form
    {
        private readonly IWordService _wordService;
        private List<PracticeQuestion> _sessionQuestions = new();
        private int _currentQuestionIndex;
        private int _score;
        private const int TotalQuestions = 10;
        private bool _answeringAllowed;

        public PracticeForm(IWordService wordService)
        {
            InitializeComponent();
            _wordService = wordService;
            
            // Set up initial state
            ShowPanel(pnlStart);
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            StartNewSession();
        }

        private void StartNewSession()
        {
            _score = 0;
            _currentQuestionIndex = 0;
            _sessionQuestions = GenerateSessionQuestions();
            
            if (_sessionQuestions.Count == 0)
            {
                MessageBox.Show("Not enough words to practice! Add more words first.", "Practice", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            ShowPanel(pnlQuestion);
            LoadQuestion(_currentQuestionIndex);
        }

        private List<PracticeQuestion> GenerateSessionQuestions()
        {
            var questions = new List<PracticeQuestion>();
            var words = _wordService.GetRandomWords(TotalQuestions);

            foreach (var word in words)
            {
                // Randomly decide question type (Word->Meaning or Meaning->Word)
                bool isReverse = Random.Shared.Next(2) == 0;
                
                var question = new PracticeQuestion
                {
                    TargetWord = word,
                    IsReverse = isReverse,
                    Options = new List<string>()
                };

                // Add correct answer
                string answer = isReverse ? word.Text : word.Meaning;
                question.CorrectAnswer = answer;
                question.Options.Add(answer);

                // Add distractors
                var distractors = _wordService.GetDistractors(word.Id, 3);
                // If reverse (Meaning -> select Word), we need random other Words as options, not Meanings.
                // However, WordService.GetDistractors currently returns Meanings.
                // For simplicity in this iteration, if Reverse, we might need a different Distractor method
                // OR we just use Meaning->Meaning (Synonyms?) No, standard is Word->Meaning.
                
                // Let's stick to standard Word -> Meaning for now to be safe, 
                // OR implement "GetRandomWords" to extract Texts for the reverse case.
                
                if (isReverse)
                {
                   // For reverse (Show Meaning, Select Word)
                   // We need 3 random other word Texts
                   var otherWords = _wordService.GetRandomWords(4).Where(w => w.Id != word.Id).Take(3);
                   foreach(var other in otherWords) question.Options.Add(other.Text);
                   
                   // Fallback if not enough words
                   while(question.Options.Count < 4) question.Options.Add("???");
                }
                else
                {
                    // Standard (Show Word, Select Meaning)
                    foreach(var d in distractors) question.Options.Add(d);
                    while(question.Options.Count < 4) question.Options.Add("???");
                }

                // Shuffle options
                question.Options = question.Options.OrderBy(x => Random.Shared.Next()).ToList();
                questions.Add(question);
            }

            return questions;
        }

        private void LoadQuestion(int index)
        {
            if (index >= _sessionQuestions.Count)
            {
                FinishSession();
                return;
            }

            _answeringAllowed = true;
            var q = _sessionQuestions[index];
            
            lblProgress.Text = $"{index + 1} / {_sessionQuestions.Count}";
            
            // Set Question Text
            if (q.IsReverse)
            {
                lblQuestionText.Text = $"Which word means:\n'{q.TargetWord.Meaning}' ({q.TargetWord.PartOfSpeech})?";
            }
            else
            {
                lblQuestionText.Text = $"What is the meaning of:\n'{q.TargetWord.Text}' ({q.TargetWord.PartOfSpeech})?";
            }

            // Set Options
            var buttons = new Button[] { btnOption1, btnOption2, btnOption3, btnOption4 };
            for (int i = 0; i < 4; i++)
            {
                buttons[i].Text = q.Options.Count > i ? q.Options[i] : "";
                buttons[i].Tag = q.Options.Count > i ? q.Options[i] : null;
                ResetButtonStyle(buttons[i]);
            }
        }

        private async void Option_Click(object sender, EventArgs e)
        {
            if (!_answeringAllowed) return;
            
            var btn = sender as Button;
            if (btn == null || btn.Tag == null) return;

            _answeringAllowed = false; // Prevent double clicking

            string selectedAnswer = btn.Tag.ToString()!;
            var currentQ = _sessionQuestions[_currentQuestionIndex];
            bool isCorrect = selectedAnswer == currentQ.CorrectAnswer;

            if (isCorrect)
            {
                btn.BackColor = Color.LightGreen;
                btn.FlatAppearance.BorderColor = Color.Green;
                _score++;
                
                // Update stats
                _wordService.MarkCorrect(currentQ.TargetWord.Id); 
            }
            else
            {
                btn.BackColor = Color.LightCoral;
                btn.FlatAppearance.BorderColor = Color.Red;
                // Highlight correct answer
                HighlightCorrectAnswer(currentQ.CorrectAnswer);
                
                _wordService.MarkWrong(currentQ.TargetWord.Id);
            }

            // Wait a moment before next question
            await Task.Delay(1500);
            
            _currentQuestionIndex++;
            LoadQuestion(_currentQuestionIndex);
        }

        private void HighlightCorrectAnswer(string correctAnswer)
        {
            var buttons = new Button[] { btnOption1, btnOption2, btnOption3, btnOption4 };
            foreach (var btn in buttons)
            {
                if (btn.Tag != null && btn.Tag.ToString() == correctAnswer)
                {
                    btn.BackColor = Color.LightGreen;
                    btn.FlatAppearance.BorderColor = Color.Green;
                    break;
                }
            }
        }

        private void FinishSession()
        {
            ShowPanel(pnlResult);
            lblFinalScore.Text = $"{_score} / {_sessionQuestions.Count}";
            
            if (_score == _sessionQuestions.Count) 
                lblResultTitle.Text = "Perfect!";
            else if (_score > _sessionQuestions.Count / 2) 
                lblResultTitle.Text = "Good Job!";
            else 
                lblResultTitle.Text = "Keep Practicing!";
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            // Close this form (which is inside a panel) ? 
            // Or just go back to Start Panel?
            // If we are in a MainForm panel, "closing" might mean just clearing the view or showing empty state.
            // For now, let's go back to Start Panel of practice.
            ShowPanel(pnlStart);
        }

        private void ShowPanel(Panel panel)
        {
            pnlStart.Visible = panel == pnlStart;
            pnlQuestion.Visible = panel == pnlQuestion;
            pnlResult.Visible = panel == pnlResult;
        }

        private void ResetButtonStyle(Button btn)
        {
            btn.BackColor = Color.White;
            btn.ForeColor = Color.Black;
            btn.FlatAppearance.BorderColor = Color.Silver;
        }

        private class PracticeQuestion
        {
            public Word TargetWord { get; set; } = null!;
            public bool IsReverse { get; set; } // True = Show Meaning, Ask Word
            public string CorrectAnswer { get; set; } = null!;
            public List<string> Options { get; set; } = null!;
        }
    }
}
