#nullable disable
namespace EngApp.UI
{
    partial class AnalyticsForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            panelMain = new Panel();
            listsPanel = new Panel();
            panelMostDifficult = new Panel();
            dgvMostDifficult = new DataGridView();
            lblMostDifficultTitle = new Label();
            panelMostStudied = new Panel();
            dgvMostStudied = new DataGridView();
            lblMostStudiedTitle = new Label();
            statsPanel = new Panel();
            cardSuccessRate = new Panel();
            progressSuccess = new ProgressBar();
            lblSuccessRate = new Label();
            lblSuccessRateTitle = new Label();
            cardTotalReviews = new Panel();
            lblTotalReviews = new Label();
            lblTotalReviewsTitle = new Label();
            cardWeekWords = new Panel();
            lblWeekWords = new Label();
            lblWeekWordsTitle = new Label();
            cardTodayWords = new Panel();
            lblTodayWords = new Label();
            lblTodayWordsTitle = new Label();
            cardTotalWords = new Panel();
            lblTotalWords = new Label();
            lblTotalWordsTitle = new Label();
            titleLabel = new Label();
            panelMain.SuspendLayout();
            listsPanel.SuspendLayout();
            panelMostDifficult.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMostDifficult).BeginInit();
            panelMostStudied.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMostStudied).BeginInit();
            statsPanel.SuspendLayout();
            cardSuccessRate.SuspendLayout();
            cardTotalReviews.SuspendLayout();
            cardWeekWords.SuspendLayout();
            cardTodayWords.SuspendLayout();
            cardTotalWords.SuspendLayout();
            SuspendLayout();
            // 
            // panelMain
            // 
            panelMain.AutoScroll = true;
            panelMain.BackColor = Color.FromArgb(248, 249, 250);
            panelMain.Controls.Add(listsPanel);
            panelMain.Controls.Add(statsPanel);
            panelMain.Controls.Add(titleLabel);
            panelMain.Dock = DockStyle.Fill;
            panelMain.Location = new Point(0, 0);
            panelMain.Margin = new Padding(4);
            panelMain.Name = "panelMain";
            panelMain.Padding = new Padding(40);
            panelMain.Size = new Size(1250, 875);
            panelMain.TabIndex = 0;
            // 
            // listsPanel
            // 
            listsPanel.Controls.Add(panelMostDifficult);
            listsPanel.Controls.Add(panelMostStudied);
            listsPanel.Dock = DockStyle.Top;
            listsPanel.Location = new Point(40, 327);
            listsPanel.Margin = new Padding(0, 25, 0, 0);
            listsPanel.Name = "listsPanel";
            listsPanel.Size = new Size(1170, 475);
            listsPanel.TabIndex = 3;
            // 
            // panelMostDifficult
            // 
            panelMostDifficult.BackColor = Color.White;
            panelMostDifficult.Controls.Add(dgvMostDifficult);
            panelMostDifficult.Controls.Add(lblMostDifficultTitle);
            panelMostDifficult.Location = new Point(588, 0);
            panelMostDifficult.Margin = new Padding(4);
            panelMostDifficult.Name = "panelMostDifficult";
            panelMostDifficult.Padding = new Padding(30);
            panelMostDifficult.Size = new Size(582, 475);
            panelMostDifficult.TabIndex = 1;
            // 
            // dgvMostDifficult
            // 
            dgvMostDifficult.AllowUserToAddRows = false;
            dgvMostDifficult.AllowUserToDeleteRows = false;
            dgvMostDifficult.AllowUserToResizeRows = false;
            dgvMostDifficult.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvMostDifficult.BackgroundColor = Color.White;
            dgvMostDifficult.BorderStyle = BorderStyle.None;
            dgvMostDifficult.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMostDifficult.Dock = DockStyle.Fill;
            dgvMostDifficult.Location = new Point(30, 68);
            dgvMostDifficult.Margin = new Padding(4);
            dgvMostDifficult.MultiSelect = false;
            dgvMostDifficult.Name = "dgvMostDifficult";
            dgvMostDifficult.ReadOnly = true;
            dgvMostDifficult.RowHeadersVisible = false;
            dgvMostDifficult.RowHeadersWidth = 51;
            dgvMostDifficult.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvMostDifficult.Size = new Size(522, 377);
            dgvMostDifficult.TabIndex = 1;
            // 
            // lblMostDifficultTitle
            // 
            lblMostDifficultTitle.Dock = DockStyle.Top;
            lblMostDifficultTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblMostDifficultTitle.ForeColor = Color.FromArgb(32, 33, 36);
            lblMostDifficultTitle.Location = new Point(30, 30);
            lblMostDifficultTitle.Margin = new Padding(4, 0, 4, 0);
            lblMostDifficultTitle.Name = "lblMostDifficultTitle";
            lblMostDifficultTitle.Size = new Size(522, 38);
            lblMostDifficultTitle.TabIndex = 0;
            lblMostDifficultTitle.Text = "💪 Most Difficult Words";
            // 
            // panelMostStudied
            // 
            panelMostStudied.BackColor = Color.White;
            panelMostStudied.Controls.Add(dgvMostStudied);
            panelMostStudied.Controls.Add(lblMostStudiedTitle);
            panelMostStudied.Location = new Point(0, 0);
            panelMostStudied.Margin = new Padding(4);
            panelMostStudied.Name = "panelMostStudied";
            panelMostStudied.Padding = new Padding(30);
            panelMostStudied.Size = new Size(562, 475);
            panelMostStudied.TabIndex = 0;
            // 
            // dgvMostStudied
            // 
            dgvMostStudied.AllowUserToAddRows = false;
            dgvMostStudied.AllowUserToDeleteRows = false;
            dgvMostStudied.AllowUserToResizeRows = false;
            dgvMostStudied.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvMostStudied.BackgroundColor = Color.White;
            dgvMostStudied.BorderStyle = BorderStyle.None;
            dgvMostStudied.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMostStudied.Dock = DockStyle.Fill;
            dgvMostStudied.Location = new Point(30, 68);
            dgvMostStudied.Margin = new Padding(4);
            dgvMostStudied.MultiSelect = false;
            dgvMostStudied.Name = "dgvMostStudied";
            dgvMostStudied.ReadOnly = true;
            dgvMostStudied.RowHeadersVisible = false;
            dgvMostStudied.RowHeadersWidth = 51;
            dgvMostStudied.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvMostStudied.Size = new Size(502, 377);
            dgvMostStudied.TabIndex = 1;
            // 
            // lblMostStudiedTitle
            // 
            lblMostStudiedTitle.Dock = DockStyle.Top;
            lblMostStudiedTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblMostStudiedTitle.ForeColor = Color.FromArgb(32, 33, 36);
            lblMostStudiedTitle.Location = new Point(30, 30);
            lblMostStudiedTitle.Margin = new Padding(4, 0, 4, 0);
            lblMostStudiedTitle.Name = "lblMostStudiedTitle";
            lblMostStudiedTitle.Size = new Size(502, 38);
            lblMostStudiedTitle.TabIndex = 0;
            lblMostStudiedTitle.Text = "📚 Most Studied Words";
            // 
            // statsPanel
            // 
            statsPanel.Controls.Add(cardSuccessRate);
            statsPanel.Controls.Add(cardTotalReviews);
            statsPanel.Controls.Add(cardWeekWords);
            statsPanel.Controls.Add(cardTodayWords);
            statsPanel.Controls.Add(cardTotalWords);
            statsPanel.Dock = DockStyle.Top;
            statsPanel.Location = new Point(40, 102);
            statsPanel.Margin = new Padding(4);
            statsPanel.Name = "statsPanel";
            statsPanel.Size = new Size(1170, 225);
            statsPanel.TabIndex = 1;
            // 
            // cardSuccessRate
            // 
            cardSuccessRate.BackColor = Color.White;
            cardSuccessRate.Controls.Add(progressSuccess);
            cardSuccessRate.Controls.Add(lblSuccessRate);
            cardSuccessRate.Controls.Add(lblSuccessRateTitle);
            cardSuccessRate.Location = new Point(925, 0);
            cardSuccessRate.Margin = new Padding(4);
            cardSuccessRate.Name = "cardSuccessRate";
            cardSuccessRate.Padding = new Padding(25);
            cardSuccessRate.Size = new Size(245, 200);
            cardSuccessRate.TabIndex = 4;
            // 
            // progressSuccess
            // 
            progressSuccess.Dock = DockStyle.Bottom;
            progressSuccess.ForeColor = Color.FromArgb(46, 125, 50);
            progressSuccess.Location = new Point(25, 80);
            progressSuccess.Margin = new Padding(4);
            progressSuccess.Name = "progressSuccess";
            progressSuccess.Size = new Size(195, 15);
            progressSuccess.Style = ProgressBarStyle.Continuous;
            progressSuccess.TabIndex = 2;
            // 
            // lblSuccessRate
            // 
            lblSuccessRate.Dock = DockStyle.Bottom;
            lblSuccessRate.Font = new Font("Segoe UI", 36F, FontStyle.Bold);
            lblSuccessRate.ForeColor = Color.FromArgb(46, 125, 50);
            lblSuccessRate.Location = new Point(25, 95);
            lblSuccessRate.Margin = new Padding(4, 0, 4, 0);
            lblSuccessRate.Name = "lblSuccessRate";
            lblSuccessRate.Size = new Size(195, 80);
            lblSuccessRate.TabIndex = 1;
            lblSuccessRate.Text = "0%";
            lblSuccessRate.TextAlign = ContentAlignment.BottomLeft;
            // 
            // lblSuccessRateTitle
            // 
            lblSuccessRateTitle.Dock = DockStyle.Top;
            lblSuccessRateTitle.Font = new Font("Segoe UI", 11F);
            lblSuccessRateTitle.ForeColor = Color.FromArgb(95, 99, 104);
            lblSuccessRateTitle.Location = new Point(25, 25);
            lblSuccessRateTitle.Margin = new Padding(4, 0, 4, 0);
            lblSuccessRateTitle.Name = "lblSuccessRateTitle";
            lblSuccessRateTitle.Size = new Size(195, 50);
            lblSuccessRateTitle.TabIndex = 0;
            // 
            // cardTotalReviews
            // 
            cardTotalReviews.BackColor = Color.White;
            cardTotalReviews.Controls.Add(lblTotalReviews);
            cardTotalReviews.Controls.Add(lblTotalReviewsTitle);
            cardTotalReviews.Location = new Point(925, 0);
            cardTotalReviews.Margin = new Padding(4);
            cardTotalReviews.Name = "cardTotalReviews";
            cardTotalReviews.Padding = new Padding(25);
            cardTotalReviews.Size = new Size(245, 94);
            cardTotalReviews.TabIndex = 3;
            // 
            // lblTotalReviews
            // 
            lblTotalReviews.Dock = DockStyle.Bottom;
            lblTotalReviews.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblTotalReviews.ForeColor = Color.FromArgb(251, 140, 0);
            lblTotalReviews.Location = new Point(25, 29);
            lblTotalReviews.Margin = new Padding(4, 0, 4, 0);
            lblTotalReviews.Name = "lblTotalReviews";
            lblTotalReviews.Size = new Size(195, 40);
            lblTotalReviews.TabIndex = 1;
            lblTotalReviews.Text = "0";
            lblTotalReviews.TextAlign = ContentAlignment.BottomLeft;
            // 
            // lblTotalReviewsTitle
            // 
            lblTotalReviewsTitle.Dock = DockStyle.Top;
            lblTotalReviewsTitle.Font = new Font("Segoe UI", 10F);
            lblTotalReviewsTitle.ForeColor = Color.FromArgb(95, 99, 104);
            lblTotalReviewsTitle.Location = new Point(25, 25);
            lblTotalReviewsTitle.Margin = new Padding(4, 0, 4, 0);
            lblTotalReviewsTitle.Name = "lblTotalReviewsTitle";
            lblTotalReviewsTitle.Size = new Size(195, 24);
            lblTotalReviewsTitle.TabIndex = 0;
            lblTotalReviewsTitle.Text = "Total Studies";
            // 
            // cardWeekWords
            // 
            cardWeekWords.BackColor = Color.White;
            cardWeekWords.Controls.Add(lblWeekWords);
            cardWeekWords.Controls.Add(lblWeekWordsTitle);
            cardWeekWords.Location = new Point(650, 0);
            cardWeekWords.Margin = new Padding(4);
            cardWeekWords.Name = "cardWeekWords";
            cardWeekWords.Padding = new Padding(25);
            cardWeekWords.Size = new Size(250, 200);
            cardWeekWords.TabIndex = 2;
            // 
            // lblWeekWords
            // 
            lblWeekWords.Dock = DockStyle.Bottom;
            lblWeekWords.Font = new Font("Segoe UI", 36F, FontStyle.Bold);
            lblWeekWords.ForeColor = Color.FromArgb(156, 39, 176);
            lblWeekWords.Location = new Point(25, 95);
            lblWeekWords.Margin = new Padding(4, 0, 4, 0);
            lblWeekWords.Name = "lblWeekWords";
            lblWeekWords.Size = new Size(200, 80);
            lblWeekWords.TabIndex = 1;
            lblWeekWords.Text = "0";
            lblWeekWords.TextAlign = ContentAlignment.BottomLeft;
            // 
            // lblWeekWordsTitle
            // 
            lblWeekWordsTitle.Dock = DockStyle.Top;
            lblWeekWordsTitle.Font = new Font("Segoe UI", 11F);
            lblWeekWordsTitle.ForeColor = Color.FromArgb(95, 99, 104);
            lblWeekWordsTitle.Location = new Point(25, 25);
            lblWeekWordsTitle.Margin = new Padding(4, 0, 4, 0);
            lblWeekWordsTitle.Name = "lblWeekWordsTitle";
            lblWeekWordsTitle.Size = new Size(200, 50);
            lblWeekWordsTitle.TabIndex = 0;
            lblWeekWordsTitle.Text = "This Week";
            // 
            // cardTodayWords
            // 
            cardTodayWords.BackColor = Color.White;
            cardTodayWords.Controls.Add(lblTodayWords);
            cardTodayWords.Controls.Add(lblTodayWordsTitle);
            cardTodayWords.Location = new Point(375, 0);
            cardTodayWords.Margin = new Padding(4);
            cardTodayWords.Name = "cardTodayWords";
            cardTodayWords.Padding = new Padding(25);
            cardTodayWords.Size = new Size(250, 200);
            cardTodayWords.TabIndex = 1;
            // 
            // lblTodayWords
            // 
            lblTodayWords.Dock = DockStyle.Bottom;
            lblTodayWords.Font = new Font("Segoe UI", 36F, FontStyle.Bold);
            lblTodayWords.ForeColor = Color.FromArgb(46, 125, 50);
            lblTodayWords.Location = new Point(25, 95);
            lblTodayWords.Margin = new Padding(4, 0, 4, 0);
            lblTodayWords.Name = "lblTodayWords";
            lblTodayWords.Size = new Size(200, 80);
            lblTodayWords.TabIndex = 1;
            lblTodayWords.Text = "0";
            lblTodayWords.TextAlign = ContentAlignment.BottomLeft;
            // 
            // lblTodayWordsTitle
            // 
            lblTodayWordsTitle.Dock = DockStyle.Top;
            lblTodayWordsTitle.Font = new Font("Segoe UI", 11F);
            lblTodayWordsTitle.ForeColor = Color.FromArgb(95, 99, 104);
            lblTodayWordsTitle.Location = new Point(25, 25);
            lblTodayWordsTitle.Margin = new Padding(4, 0, 4, 0);
            lblTodayWordsTitle.Name = "lblTodayWordsTitle";
            lblTodayWordsTitle.Size = new Size(200, 50);
            lblTodayWordsTitle.TabIndex = 0;
            lblTodayWordsTitle.Text = "Added Today";
            // 
            // cardTotalWords
            // 
            cardTotalWords.BackColor = Color.White;
            cardTotalWords.Controls.Add(lblTotalWords);
            cardTotalWords.Controls.Add(lblTotalWordsTitle);
            cardTotalWords.Location = new Point(0, 0);
            cardTotalWords.Margin = new Padding(4);
            cardTotalWords.Name = "cardTotalWords";
            cardTotalWords.Padding = new Padding(30);
            cardTotalWords.Size = new Size(350, 200);
            cardTotalWords.TabIndex = 0;
            // 
            // lblTotalWords
            // 
            lblTotalWords.Dock = DockStyle.Bottom;
            lblTotalWords.Font = new Font("Segoe UI", 42F, FontStyle.Bold);
            lblTotalWords.ForeColor = Color.FromArgb(25, 103, 210);
            lblTotalWords.Location = new Point(30, 75);
            lblTotalWords.Margin = new Padding(4, 0, 4, 0);
            lblTotalWords.Name = "lblTotalWords";
            lblTotalWords.Size = new Size(290, 95);
            lblTotalWords.TabIndex = 1;
            lblTotalWords.Text = "0";
            lblTotalWords.TextAlign = ContentAlignment.BottomLeft;
            // 
            // lblTotalWordsTitle
            // 
            lblTotalWordsTitle.Dock = DockStyle.Top;
            lblTotalWordsTitle.Font = new Font("Segoe UI", 12F);
            lblTotalWordsTitle.ForeColor = Color.FromArgb(95, 99, 104);
            lblTotalWordsTitle.Location = new Point(30, 30);
            lblTotalWordsTitle.Margin = new Padding(4, 0, 4, 0);
            lblTotalWordsTitle.Name = "lblTotalWordsTitle";
            lblTotalWordsTitle.Size = new Size(290, 29);
            lblTotalWordsTitle.TabIndex = 0;
            lblTotalWordsTitle.Text = "Total Words";
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Dock = DockStyle.Top;
            titleLabel.Font = new Font("Segoe UI", 28F, FontStyle.Bold);
            titleLabel.ForeColor = Color.FromArgb(32, 33, 36);
            titleLabel.Location = new Point(40, 40);
            titleLabel.Margin = new Padding(0, 0, 0, 30);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(226, 62);
            titleLabel.TabIndex = 0;
            titleLabel.Text = "Analytics";
            // 
            // AnalyticsForm
            // 
            AutoScaleDimensions = new SizeF(120F, 120F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(1250, 875);
            Controls.Add(panelMain);
            Font = new Font("Segoe UI", 9F);
            Margin = new Padding(4);
            Name = "AnalyticsForm";
            Text = "Analytics";
            panelMain.ResumeLayout(false);
            panelMain.PerformLayout();
            listsPanel.ResumeLayout(false);
            panelMostDifficult.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvMostDifficult).EndInit();
            panelMostStudied.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvMostStudied).EndInit();
            statsPanel.ResumeLayout(false);
            cardSuccessRate.ResumeLayout(false);
            cardTotalReviews.ResumeLayout(false);
            cardWeekWords.ResumeLayout(false);
            cardTodayWords.ResumeLayout(false);
            cardTotalWords.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Panel statsPanel;
        private System.Windows.Forms.Panel cardTotalWords;
        private System.Windows.Forms.Label lblTotalWords;
        private System.Windows.Forms.Label lblTotalWordsTitle;
        private System.Windows.Forms.Panel cardTodayWords;
        private System.Windows.Forms.Label lblTodayWords;
        private System.Windows.Forms.Label lblTodayWordsTitle;
        private System.Windows.Forms.Panel cardWeekWords;
        private System.Windows.Forms.Label lblWeekWords;
        private System.Windows.Forms.Label lblWeekWordsTitle;
        private System.Windows.Forms.Panel cardTotalReviews;
        private System.Windows.Forms.Label lblTotalReviews;
        private System.Windows.Forms.Label lblTotalReviewsTitle;
        private System.Windows.Forms.Panel cardSuccessRate;
        private System.Windows.Forms.ProgressBar progressSuccess;
        private System.Windows.Forms.Label lblSuccessRate;
        private System.Windows.Forms.Label lblSuccessRateTitle;
        private System.Windows.Forms.Panel listsPanel;
        private System.Windows.Forms.Panel panelMostStudied;
        private System.Windows.Forms.DataGridView dgvMostStudied;
        private System.Windows.Forms.Label lblMostStudiedTitle;
        private System.Windows.Forms.Panel panelMostDifficult;
        private System.Windows.Forms.DataGridView dgvMostDifficult;
        private System.Windows.Forms.Label lblMostDifficultTitle;
    }
}
