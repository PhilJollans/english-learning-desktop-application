
namespace EngApp.UI
{
    partial class PracticeForm
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
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlStart = new System.Windows.Forms.Panel();
            this.btnStart = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlQuestion = new System.Windows.Forms.Panel();
            this.lblProgress = new System.Windows.Forms.Label();
            this.lblQuestionText = new System.Windows.Forms.Label();
            this.tableLayoutPanelOptions = new System.Windows.Forms.TableLayoutPanel();
            this.btnOption1 = new System.Windows.Forms.Button();
            this.btnOption2 = new System.Windows.Forms.Button();
            this.btnOption3 = new System.Windows.Forms.Button();
            this.btnOption4 = new System.Windows.Forms.Button();
            this.pnlResult = new System.Windows.Forms.Panel();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnRestart = new System.Windows.Forms.Button();
            this.lblFinalScore = new System.Windows.Forms.Label();
            this.lblResultTitle = new System.Windows.Forms.Label();
            this.pnlStart.SuspendLayout();
            this.pnlQuestion.SuspendLayout();
            this.tableLayoutPanelOptions.SuspendLayout();
            this.pnlResult.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlStart
            // 
            this.pnlStart.Controls.Add(this.btnStart);
            this.pnlStart.Controls.Add(this.lblTitle);
            this.pnlStart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlStart.Location = new System.Drawing.Point(0, 0);
            this.pnlStart.Name = "pnlStart";
            this.pnlStart.Size = new System.Drawing.Size(800, 450);
            this.pnlStart.TabIndex = 0;
            // 
            // btnStart
            // 
            this.btnStart.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnStart.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnStart.FlatAppearance.BorderSize = 0;
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStart.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnStart.ForeColor = System.Drawing.Color.White;
            this.btnStart.Location = new System.Drawing.Point(300, 250);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(200, 60);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "Start Practice";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI Light", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.Location = new System.Drawing.Point(240, 150);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(320, 59);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Practice Session";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlQuestion
            // 
            this.pnlQuestion.Controls.Add(this.lblProgress);
            this.pnlQuestion.Controls.Add(this.lblQuestionText);
            this.pnlQuestion.Controls.Add(this.tableLayoutPanelOptions);
            this.pnlQuestion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlQuestion.Location = new System.Drawing.Point(0, 0);
            this.pnlQuestion.Name = "pnlQuestion";
            this.pnlQuestion.Size = new System.Drawing.Size(800, 450);
            this.pnlQuestion.TabIndex = 1;
            this.pnlQuestion.Visible = false;
            // 
            // lblProgress
            // 
            this.lblProgress.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblProgress.AutoSize = true;
            this.lblProgress.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblProgress.Location = new System.Drawing.Point(700, 20);
            this.lblProgress.Name = "lblProgress";
            this.lblProgress.Size = new System.Drawing.Size(56, 21);
            this.lblProgress.TabIndex = 2;
            this.lblProgress.Text = "1 / 10";
            // 
            // lblQuestionText
            // 
            this.lblQuestionText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblQuestionText.Font = new System.Drawing.Font("Segoe UI Semibold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblQuestionText.Location = new System.Drawing.Point(50, 60);
            this.lblQuestionText.Name = "lblQuestionText";
            this.lblQuestionText.Size = new System.Drawing.Size(700, 100);
            this.lblQuestionText.TabIndex = 1;
            this.lblQuestionText.Text = "Question Text Here";
            this.lblQuestionText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanelOptions
            // 
            this.tableLayoutPanelOptions.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanelOptions.ColumnCount = 2;
            this.tableLayoutPanelOptions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelOptions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelOptions.Controls.Add(this.btnOption1, 0, 0);
            this.tableLayoutPanelOptions.Controls.Add(this.btnOption2, 1, 0);
            this.tableLayoutPanelOptions.Controls.Add(this.btnOption3, 0, 1);
            this.tableLayoutPanelOptions.Controls.Add(this.btnOption4, 1, 1);
            this.tableLayoutPanelOptions.Location = new System.Drawing.Point(50, 180);
            this.tableLayoutPanelOptions.Name = "tableLayoutPanelOptions";
            this.tableLayoutPanelOptions.RowCount = 2;
            this.tableLayoutPanelOptions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelOptions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelOptions.Size = new System.Drawing.Size(700, 220);
            this.tableLayoutPanelOptions.TabIndex = 0;
            // 
            // btnOption1
            // 
            this.btnOption1.BackColor = System.Drawing.Color.White;
            this.btnOption1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnOption1.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnOption1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOption1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnOption1.Location = new System.Drawing.Point(10, 10);
            this.btnOption1.Margin = new System.Windows.Forms.Padding(10);
            this.btnOption1.Name = "btnOption1";
            this.btnOption1.Size = new System.Drawing.Size(330, 90);
            this.btnOption1.TabIndex = 0;
            this.btnOption1.Text = "Option 1";
            this.btnOption1.UseVisualStyleBackColor = false;
            this.btnOption1.Click += new System.EventHandler(this.Option_Click);
            // 
            // btnOption2
            // 
            this.btnOption2.BackColor = System.Drawing.Color.White;
            this.btnOption2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnOption2.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnOption2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOption2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnOption2.Location = new System.Drawing.Point(360, 10);
            this.btnOption2.Margin = new System.Windows.Forms.Padding(10);
            this.btnOption2.Name = "btnOption2";
            this.btnOption2.Size = new System.Drawing.Size(330, 90);
            this.btnOption2.TabIndex = 1;
            this.btnOption2.Text = "Option 2";
            this.btnOption2.UseVisualStyleBackColor = false;
            this.btnOption2.Click += new System.EventHandler(this.Option_Click);
            // 
            // btnOption3
            // 
            this.btnOption3.BackColor = System.Drawing.Color.White;
            this.btnOption3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnOption3.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnOption3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOption3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnOption3.Location = new System.Drawing.Point(10, 120);
            this.btnOption3.Margin = new System.Windows.Forms.Padding(10);
            this.btnOption3.Name = "btnOption3";
            this.btnOption3.Size = new System.Drawing.Size(330, 90);
            this.btnOption3.TabIndex = 2;
            this.btnOption3.Text = "Option 3";
            this.btnOption3.UseVisualStyleBackColor = false;
            this.btnOption3.Click += new System.EventHandler(this.Option_Click);
            // 
            // btnOption4
            // 
            this.btnOption4.BackColor = System.Drawing.Color.White;
            this.btnOption4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnOption4.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnOption4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOption4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnOption4.Location = new System.Drawing.Point(360, 120);
            this.btnOption4.Margin = new System.Windows.Forms.Padding(10);
            this.btnOption4.Name = "btnOption4";
            this.btnOption4.Size = new System.Drawing.Size(330, 90);
            this.btnOption4.TabIndex = 3;
            this.btnOption4.Text = "Option 4";
            this.btnOption4.UseVisualStyleBackColor = false;
            this.btnOption4.Click += new System.EventHandler(this.Option_Click);
            // 
            // pnlResult
            // 
            this.pnlResult.Controls.Add(this.btnHome);
            this.pnlResult.Controls.Add(this.btnRestart);
            this.pnlResult.Controls.Add(this.lblFinalScore);
            this.pnlResult.Controls.Add(this.lblResultTitle);
            this.pnlResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlResult.Location = new System.Drawing.Point(0, 0);
            this.pnlResult.Name = "pnlResult";
            this.pnlResult.Size = new System.Drawing.Size(800, 450);
            this.pnlResult.TabIndex = 2;
            this.pnlResult.Visible = false;
            // 
            // btnHome
            // 
            this.btnHome.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnHome.BackColor = System.Drawing.Color.Gray;
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnHome.ForeColor = System.Drawing.Color.White;
            this.btnHome.Location = new System.Drawing.Point(410, 280);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(150, 50);
            this.btnHome.TabIndex = 3;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnRestart
            // 
            this.btnRestart.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnRestart.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnRestart.FlatAppearance.BorderSize = 0;
            this.btnRestart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRestart.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnRestart.ForeColor = System.Drawing.Color.White;
            this.btnRestart.Location = new System.Drawing.Point(240, 280);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(150, 50);
            this.btnRestart.TabIndex = 2;
            this.btnRestart.Text = "Restart";
            this.btnRestart.UseVisualStyleBackColor = false;
            this.btnRestart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // lblFinalScore
            // 
            this.lblFinalScore.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblFinalScore.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblFinalScore.Location = new System.Drawing.Point(200, 180);
            this.lblFinalScore.Name = "lblFinalScore";
            this.lblFinalScore.Size = new System.Drawing.Size(400, 60);
            this.lblFinalScore.TabIndex = 1;
            this.lblFinalScore.Text = "8/10";
            this.lblFinalScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblResultTitle
            // 
            this.lblResultTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblResultTitle.AutoSize = true;
            this.lblResultTitle.Font = new System.Drawing.Font("Segoe UI Light", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblResultTitle.Location = new System.Drawing.Point(260, 100);
            this.lblResultTitle.Name = "lblResultTitle";
            this.lblResultTitle.Size = new System.Drawing.Size(280, 59);
            this.lblResultTitle.TabIndex = 0;
            this.lblResultTitle.Text = "Session Done!";
            this.lblResultTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PracticeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlResult);
            this.Controls.Add(this.pnlQuestion);
            this.Controls.Add(this.pnlStart);
            this.Name = "PracticeForm";
            this.Text = "Practice";
            this.pnlStart.ResumeLayout(false);
            this.pnlStart.PerformLayout();
            this.pnlQuestion.ResumeLayout(false);
            this.pnlQuestion.PerformLayout();
            this.tableLayoutPanelOptions.ResumeLayout(false);
            this.pnlResult.ResumeLayout(false);
            this.pnlResult.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlStart;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pnlQuestion;
        private System.Windows.Forms.Panel pnlResult;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelOptions;
        private System.Windows.Forms.Button btnOption1;
        private System.Windows.Forms.Button btnOption2;
        private System.Windows.Forms.Button btnOption3;
        private System.Windows.Forms.Button btnOption4;
        private System.Windows.Forms.Label lblQuestionText;
        private System.Windows.Forms.Label lblProgress;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnRestart;
        private System.Windows.Forms.Label lblFinalScore;
        private System.Windows.Forms.Label lblResultTitle;
    }
}
