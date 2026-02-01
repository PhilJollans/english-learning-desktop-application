namespace EngApp.UI
{
    partial class FlashcardForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            if (disposing)
            {
                _synthesizer?.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panelMain = new Panel();
            panelSummary = new Panel();
            btnCloseSummary = new Button();
            lblSummaryStats = new Label();
            lblSummaryTitle = new Label();
            panelCard = new Panel();
            panelAnswer = new Panel();
            lblExample = new Label();
            lblMeaning = new Label();
            lblExampleTitle = new Label();
            lblMeaningTitle = new Label();
            lblWord = new Label();
            panelActions = new Panel();
            btnWrong = new Button();
            btnCorrect = new Button();
            btnSpeak = new Button();
            btnShowAnswer = new Button();
            panelProgress = new Panel();
            progressBar = new ProgressBar();
            lblProgress = new Label();
            panelMain.SuspendLayout();
            panelSummary.SuspendLayout();
            panelCard.SuspendLayout();
            panelAnswer.SuspendLayout();
            panelActions.SuspendLayout();
            panelProgress.SuspendLayout();
            SuspendLayout();
            // 
            // panelMain
            // 
            panelMain.BackColor = Color.FromArgb(248, 249, 250);
            panelMain.Controls.Add(panelCard);
            panelMain.Controls.Add(panelActions);
            panelMain.Controls.Add(panelProgress);
            panelMain.Dock = DockStyle.Fill;
            panelMain.Location = new Point(0, 0);
            panelMain.Name = "panelMain";
            panelMain.Padding = new Padding(48, 32, 48, 48);
            panelMain.Size = new Size(1200, 800);
            panelMain.TabIndex = 0;
            // 
            // panelSummary
            // 
            panelSummary.BackColor = Color.White;
            panelSummary.Controls.Add(btnCloseSummary);
            panelSummary.Controls.Add(lblSummaryStats);
            panelSummary.Controls.Add(lblSummaryTitle);
            panelSummary.Location = new Point(267, 48);
            panelSummary.Name = "panelSummary";
            panelSummary.Padding = new Padding(48);
            panelSummary.Size = new Size(600, 450);
            panelSummary.TabIndex = 3;
            panelSummary.Visible = false;
            // 
            // btnCloseSummary
            // 
            btnCloseSummary.BackColor = Color.FromArgb(25, 103, 210);
            btnCloseSummary.Cursor = Cursors.Hand;
            btnCloseSummary.FlatAppearance.BorderSize = 0;
            btnCloseSummary.FlatStyle = FlatStyle.Flat;
            btnCloseSummary.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnCloseSummary.ForeColor = Color.White;
            btnCloseSummary.Location = new Point(200, 360);
            btnCloseSummary.Name = "btnCloseSummary";
            btnCloseSummary.Size = new Size(200, 48);
            btnCloseSummary.TabIndex = 2;
            btnCloseSummary.Text = "Close";
            btnCloseSummary.UseVisualStyleBackColor = false;
            btnCloseSummary.Click += BtnCloseSummary_Click;
            // 
            // lblSummaryStats
            // 
            lblSummaryStats.Font = new Font("Segoe UI", 12F);
            lblSummaryStats.ForeColor = Color.FromArgb(95, 99, 104);
            lblSummaryStats.Location = new Point(45, 113);
            lblSummaryStats.Name = "lblSummaryStats";
            lblSummaryStats.Size = new Size(504, 200);
            lblSummaryStats.TabIndex = 1;
            lblSummaryStats.Text = "Statistics...";
            // 
            // lblSummaryTitle
            // 
            lblSummaryTitle.Dock = DockStyle.Top;
            lblSummaryTitle.Font = new Font("Segoe UI", 24F);
            lblSummaryTitle.ForeColor = Color.FromArgb(52, 168, 83);
            lblSummaryTitle.Location = new Point(48, 48);
            lblSummaryTitle.Name = "lblSummaryTitle";
            lblSummaryTitle.Size = new Size(504, 80);
            lblSummaryTitle.TabIndex = 0;
            lblSummaryTitle.Text = "Well done!";
            lblSummaryTitle.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panelCard
            // 
            panelCard.BackColor = Color.White;
            panelCard.Controls.Add(panelSummary);
            panelCard.Controls.Add(panelAnswer);
            panelCard.Controls.Add(lblWord);
            panelCard.Dock = DockStyle.Fill;
            panelCard.Location = new Point(48, 72);
            panelCard.Name = "panelCard";
            panelCard.Padding = new Padding(48);
            panelCard.Size = new Size(904, 437);
            panelCard.TabIndex = 2;
            // 
            // panelAnswer
            // 
            panelAnswer.Controls.Add(lblExample);
            panelAnswer.Controls.Add(lblMeaning);
            panelAnswer.Controls.Add(lblExampleTitle);
            panelAnswer.Controls.Add(lblMeaningTitle);
            panelAnswer.Dock = DockStyle.Fill;
            panelAnswer.Location = new Point(48, 148);
            panelAnswer.Name = "panelAnswer";
            panelAnswer.Size = new Size(808, 241);
            panelAnswer.TabIndex = 1;
            panelAnswer.Visible = false;
            // 
            // lblExample
            // 
            lblExample.Dock = DockStyle.Fill;
            lblExample.Font = new Font("Segoe UI", 11F, FontStyle.Italic);
            lblExample.ForeColor = Color.FromArgb(95, 99, 104);
            lblExample.Location = new Point(0, 141);
            lblExample.Name = "lblExample";
            lblExample.Padding = new Padding(0, 8, 0, 0);
            lblExample.Size = new Size(808, 80);
            lblExample.TabIndex = 3;
            lblExample.Text = "Example sentence here";
            // 
            // lblMeaning
            // 
            lblMeaning.Dock = DockStyle.Top;
            lblMeaning.Font = new Font("Segoe UI", 16F);
            lblMeaning.ForeColor = Color.FromArgb(32, 33, 36);
            lblMeaning.Location = new Point(0, 31);
            lblMeaning.Name = "lblMeaning";
            lblMeaning.Padding = new Padding(0, 8, 0, 0);
            lblMeaning.Size = new Size(808, 110);
            lblMeaning.TabIndex = 2;
            lblMeaning.Text = "Meaning here";
            // 
            // lblExampleTitle
            // 
            lblExampleTitle.Dock = DockStyle.Bottom;
            lblExampleTitle.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblExampleTitle.ForeColor = Color.FromArgb(95, 99, 104);
            lblExampleTitle.Location = new Point(0, 221);
            lblExampleTitle.Name = "lblExampleTitle";
            lblExampleTitle.Size = new Size(808, 20);
            lblExampleTitle.TabIndex = 1;
            lblExampleTitle.Text = "EXAMPLE";
            // 
            // lblMeaningTitle
            // 
            lblMeaningTitle.Dock = DockStyle.Top;
            lblMeaningTitle.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblMeaningTitle.ForeColor = Color.FromArgb(95, 99, 104);
            lblMeaningTitle.Location = new Point(0, 0);
            lblMeaningTitle.Name = "lblMeaningTitle";
            lblMeaningTitle.Padding = new Padding(0, 0, 0, 8);
            lblMeaningTitle.Size = new Size(808, 31);
            lblMeaningTitle.TabIndex = 0;
            lblMeaningTitle.Text = "MEANING";
            // 
            // lblWord
            // 
            lblWord.Dock = DockStyle.Top;
            lblWord.Font = new Font("Segoe UI", 36F);
            lblWord.ForeColor = Color.FromArgb(25, 103, 210);
            lblWord.Location = new Point(48, 48);
            lblWord.Name = "lblWord";
            lblWord.Size = new Size(808, 100);
            lblWord.TabIndex = 0;
            lblWord.Text = "Word";
            lblWord.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panelActions
            // 
            panelActions.Controls.Add(btnWrong);
            panelActions.Controls.Add(btnCorrect);
            panelActions.Controls.Add(btnSpeak);
            panelActions.Controls.Add(btnShowAnswer);
            panelActions.Dock = DockStyle.Bottom;
            panelActions.Location = new Point(48, 509);
            panelActions.Name = "panelActions";
            panelActions.Size = new Size(904, 100);
            panelActions.TabIndex = 1;
            // 
            // btnWrong
            // 
            btnWrong.BackColor = Color.FromArgb(217, 48, 37);
            btnWrong.Cursor = Cursors.Hand;
            btnWrong.FlatAppearance.BorderSize = 0;
            btnWrong.FlatStyle = FlatStyle.Flat;
            btnWrong.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnWrong.ForeColor = Color.White;
            btnWrong.Location = new Point(464, 25);
            btnWrong.Name = "btnWrong";
            btnWrong.Size = new Size(200, 48);
            btnWrong.TabIndex = 3;
            btnWrong.Text = "Don't know";
            btnWrong.UseVisualStyleBackColor = false;
            btnWrong.Visible = false;
            btnWrong.Click += BtnWrong_Click;
            // 
            // btnCorrect
            // 
            btnCorrect.BackColor = Color.FromArgb(52, 168, 83);
            btnCorrect.Cursor = Cursors.Hand;
            btnCorrect.FlatAppearance.BorderSize = 0;
            btnCorrect.FlatStyle = FlatStyle.Flat;
            btnCorrect.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnCorrect.ForeColor = Color.White;
            btnCorrect.Location = new Point(688, 25);
            btnCorrect.Name = "btnCorrect";
            btnCorrect.Size = new Size(200, 48);
            btnCorrect.TabIndex = 2;
            btnCorrect.Text = "I know";
            btnCorrect.UseVisualStyleBackColor = false;
            btnCorrect.Visible = false;
            btnCorrect.Click += BtnCorrect_Click;
            // 
            // btnSpeak
            // 
            btnSpeak.BackColor = Color.White;
            btnSpeak.Cursor = Cursors.Hand;
            btnSpeak.FlatAppearance.BorderColor = Color.FromArgb(218, 220, 224);
            btnSpeak.FlatStyle = FlatStyle.Flat;
            btnSpeak.Font = new Font("Segoe UI", 11F);
            btnSpeak.ForeColor = Color.FromArgb(95, 99, 104);
            btnSpeak.Location = new Point(16, 25);
            btnSpeak.Name = "btnSpeak";
            btnSpeak.Size = new Size(160, 48);
            btnSpeak.TabIndex = 1;
            btnSpeak.Text = "🔊 Listen";
            btnSpeak.UseVisualStyleBackColor = false;
            btnSpeak.Click += BtnSpeak_Click;
            // 
            // btnShowAnswer
            // 
            btnShowAnswer.BackColor = Color.FromArgb(25, 103, 210);
            btnShowAnswer.Cursor = Cursors.Hand;
            btnShowAnswer.FlatAppearance.BorderSize = 0;
            btnShowAnswer.FlatStyle = FlatStyle.Flat;
            btnShowAnswer.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnShowAnswer.ForeColor = Color.White;
            btnShowAnswer.Location = new Point(352, 25);
            btnShowAnswer.Name = "btnShowAnswer";
            btnShowAnswer.Size = new Size(200, 48);
            btnShowAnswer.TabIndex = 0;
            btnShowAnswer.Text = "Show answer";
            btnShowAnswer.UseVisualStyleBackColor = false;
            btnShowAnswer.Click += BtnShowAnswer_Click;
            // 
            // panelProgress
            // 
            panelProgress.Controls.Add(progressBar);
            panelProgress.Controls.Add(lblProgress);
            panelProgress.Dock = DockStyle.Top;
            panelProgress.Location = new Point(48, 32);
            panelProgress.Name = "panelProgress";
            panelProgress.Size = new Size(904, 40);
            panelProgress.TabIndex = 0;
            // 
            // progressBar
            // 
            progressBar.Dock = DockStyle.Bottom;
            progressBar.Location = new Point(0, 28);
            progressBar.Name = "progressBar";
            progressBar.Size = new Size(904, 12);
            progressBar.TabIndex = 0;
            // 
            // lblProgress
            // 
            lblProgress.AutoSize = true;
            lblProgress.Font = new Font("Segoe UI", 10F);
            lblProgress.ForeColor = Color.FromArgb(95, 99, 104);
            lblProgress.Location = new Point(0, 0);
            lblProgress.Name = "lblProgress";
            lblProgress.Size = new Size(92, 23);
            lblProgress.TabIndex = 1;
            lblProgress.Text = "1 / 10 card";
            // 
            // FlashcardForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1200, 800);
            Controls.Add(panelMain);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            Name = "FlashcardForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EngApp - Flashcards";
            panelMain.ResumeLayout(false);
            panelSummary.ResumeLayout(false);
            panelCard.ResumeLayout(false);
            panelAnswer.ResumeLayout(false);
            panelActions.ResumeLayout(false);
            panelProgress.ResumeLayout(false);
            panelProgress.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelMain;
        private Panel panelProgress;
        private Label lblProgress;
        private ProgressBar progressBar;
        private Panel panelCard;
        private Label lblWord;
        private Panel panelActions;
        private Button btnShowAnswer;
        private Button btnSpeak;
        private Button btnCorrect;
        private Button btnWrong;
        private Panel panelAnswer;
        private Label lblMeaningTitle;
        private Label lblExampleTitle;
        private Label lblMeaning;
        private Label lblExample;
        private Panel panelSummary;
        private Label lblSummaryTitle;
        private Label lblSummaryStats;
        private Button btnCloseSummary;
    }
}
