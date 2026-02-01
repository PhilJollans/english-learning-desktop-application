#nullable disable
namespace EngApp.UI
{
    partial class MainForm
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
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.menuItemWords = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemFlashcards = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemPractice = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemIrregularVerbs = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemAnalytics = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemHangman = new System.Windows.Forms.ToolStripMenuItem();
            this.contentPanel = new System.Windows.Forms.Panel();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.menuStrip.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemWords,
            this.menuItemFlashcards,
            this.menuItemPractice,
            this.menuItemIrregularVerbs,
            this.menuItemAnalytics,
            this.menuItemHangman});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(8, 4, 0, 4);
            this.menuStrip.Size = new System.Drawing.Size(1000, 32);
            this.menuStrip.TabIndex = 0;
            // 
            // menuItemWords
            // 
            this.menuItemWords.Name = "menuItemWords";
            this.menuItemWords.Size = new System.Drawing.Size(57, 24);
            this.menuItemWords.Text = "Word";
            this.menuItemWords.Click += new System.EventHandler(this.MenuItemWords_Click);
            // 
            // menuItemFlashcards
            // 
            this.menuItemFlashcards.Name = "menuItemFlashcards";
            this.menuItemFlashcards.Size = new System.Drawing.Size(83, 24);
            this.menuItemFlashcards.Text = "Flashcard";
            this.menuItemFlashcards.Click += new System.EventHandler(this.MenuItemFlashcards_Click);
            // 
            // menuItemPractice
            // 
            this.menuItemPractice.Name = "menuItemPractice";
            this.menuItemPractice.Size = new System.Drawing.Size(73, 24);
            this.menuItemPractice.Text = "Practice";
            this.menuItemPractice.Click += new System.EventHandler(this.MenuItemPractice_Click);
            // 
            // menuItemIrregularVerbs
            // 
            this.menuItemIrregularVerbs.Name = "menuItemIrregularVerbs";
            this.menuItemIrregularVerbs.Size = new System.Drawing.Size(119, 24);
            this.menuItemIrregularVerbs.Text = "Irregular Verbs";
            this.menuItemIrregularVerbs.Click += new System.EventHandler(this.MenuItemIrregularVerbs_Click);
            // 
            // menuItemAnalytics
            // 
            this.menuItemAnalytics.Name = "menuItemAnalytics";
            this.menuItemAnalytics.Size = new System.Drawing.Size(81, 24);
            this.menuItemAnalytics.Text = "Analytics";
            this.menuItemAnalytics.Click += new System.EventHandler(this.MenuItemAnalytics_Click);
            // 
            // menuItemHangman
            // 
            this.menuItemHangman.Name = "menuItemHangman";
            this.menuItemHangman.Size = new System.Drawing.Size(115, 24);
            this.menuItemHangman.Text = "Adam Asmaca";
            this.menuItemHangman.Click += new System.EventHandler(this.MenuItemHangman_Click);
            // 
            // contentPanel
            // 
            this.contentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contentPanel.Location = new System.Drawing.Point(0, 32);
            this.contentPanel.Name = "contentPanel";
            this.contentPanel.Size = new System.Drawing.Size(1000, 668);
            this.contentPanel.TabIndex = 1;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 700);
            this.Controls.Add(this.contentPanel);
            this.Controls.Add(this.menuStrip);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.MainMenuStrip = this.menuStrip;
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EngApp - English Learning Application";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem menuItemWords;
        private System.Windows.Forms.ToolStripMenuItem menuItemFlashcards;
        private System.Windows.Forms.ToolStripMenuItem menuItemPractice;
        private System.Windows.Forms.ToolStripMenuItem menuItemIrregularVerbs;
        private System.Windows.Forms.ToolStripMenuItem menuItemAnalytics;
        private System.Windows.Forms.ToolStripMenuItem menuItemHangman;
        private System.Windows.Forms.Panel contentPanel;
    }
}
