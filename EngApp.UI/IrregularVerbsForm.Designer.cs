namespace EngApp.UI
{
    partial class IrregularVerbsForm
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
            panelMain = new Panel();
            dgvVerbs = new DataGridView();
            panelSearch = new Panel();
            txtSearch = new TextBox();
            lblSearchIcon = new Label();
            panelHeader = new Panel();
            lblTotalVerbs = new Label();
            lblDescription = new Label();
            lblTitle = new Label();
            panelMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvVerbs).BeginInit();
            panelSearch.SuspendLayout();
            panelHeader.SuspendLayout();
            SuspendLayout();
            // 
            // panelMain
            // 
            panelMain.BackColor = Color.FromArgb(248, 249, 250);
            panelMain.Controls.Add(dgvVerbs);
            panelMain.Controls.Add(panelSearch);
            panelMain.Controls.Add(panelHeader);
            panelMain.Dock = DockStyle.Fill;
            panelMain.Location = new Point(0, 0);
            panelMain.Name = "panelMain";
            panelMain.Padding = new Padding(48, 32, 48, 48);
            panelMain.Size = new Size(1200, 800);
            panelMain.TabIndex = 0;
            // 
            // dgvVerbs
            // 
            dgvVerbs.AllowUserToAddRows = false;
            dgvVerbs.AllowUserToDeleteRows = false;
            dgvVerbs.BackgroundColor = Color.White;
            dgvVerbs.BorderStyle = BorderStyle.None;
            dgvVerbs.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvVerbs.Dock = DockStyle.Fill;
            dgvVerbs.Location = new Point(48, 192);
            dgvVerbs.Name = "dgvVerbs";
            dgvVerbs.ReadOnly = true;
            dgvVerbs.RowHeadersWidth = 51;
            dgvVerbs.Size = new Size(1104, 560);
            dgvVerbs.TabIndex = 2;
            // 
            // panelSearch
            // 
            panelSearch.BackColor = Color.White;
            panelSearch.Controls.Add(txtSearch);
            panelSearch.Controls.Add(lblSearchIcon);
            panelSearch.Dock = DockStyle.Top;
            panelSearch.Location = new Point(48, 128);
            panelSearch.Name = "panelSearch";
            panelSearch.Padding = new Padding(16, 12, 16, 12);
            panelSearch.Size = new Size(1104, 64);
            panelSearch.TabIndex = 1;
            // 
            // txtSearch
            // 
            txtSearch.BorderStyle = BorderStyle.None;
            txtSearch.Dock = DockStyle.Fill;
            txtSearch.Font = new Font("Segoe UI", 12F);
            txtSearch.ForeColor = Color.FromArgb(32, 33, 36);
            txtSearch.Location = new Point(64, 12);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Search verbs...";
            txtSearch.Size = new Size(1024, 27);
            txtSearch.TabIndex = 1;
            txtSearch.TextChanged += TxtSearch_TextChanged;
            // 
            // lblSearchIcon
            // 
            lblSearchIcon.Dock = DockStyle.Left;
            lblSearchIcon.Font = new Font("Segoe UI", 14F);
            lblSearchIcon.ForeColor = Color.FromArgb(95, 99, 104);
            lblSearchIcon.Location = new Point(16, 12);
            lblSearchIcon.Name = "lblSearchIcon";
            lblSearchIcon.Size = new Size(48, 40);
            lblSearchIcon.TabIndex = 0;
            lblSearchIcon.Text = "🔍";
            lblSearchIcon.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panelHeader
            // 
            panelHeader.Controls.Add(lblTotalVerbs);
            panelHeader.Controls.Add(lblDescription);
            panelHeader.Controls.Add(lblTitle);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(48, 32);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(1104, 96);
            panelHeader.TabIndex = 0;
            // 
            // lblTotalVerbs
            // 
            lblTotalVerbs.Dock = DockStyle.Top;
            lblTotalVerbs.Font = new Font("Segoe UI", 10F);
            lblTotalVerbs.ForeColor = Color.FromArgb(95, 99, 104);
            lblTotalVerbs.Location = new Point(0, 65);
            lblTotalVerbs.Name = "lblTotalVerbs";
            lblTotalVerbs.Size = new Size(1104, 25);
            lblTotalVerbs.TabIndex = 2;
            lblTotalVerbs.Text = "Total: 103 irregular verbs";
            // 
            // lblDescription
            // 
            lblDescription.Dock = DockStyle.Top;
            lblDescription.Font = new Font("Segoe UI", 10F);
            lblDescription.ForeColor = Color.FromArgb(95, 99, 104);
            lblDescription.Location = new Point(0, 40);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(1104, 25);
            lblDescription.TabIndex = 1;
            lblDescription.Text = "Common irregular English verbs with their forms";
            // 
            // lblTitle
            // 
            lblTitle.Dock = DockStyle.Top;
            lblTitle.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(25, 103, 210);
            lblTitle.Location = new Point(0, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(1104, 40);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Irregular Verbs Reference";
            // 
            // IrregularVerbsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1200, 800);
            Controls.Add(panelMain);
            FormBorderStyle = FormBorderStyle.None;
            Name = "IrregularVerbsForm";
            Text = "EngApp - Irregular Verbs";
            panelMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvVerbs).EndInit();
            panelSearch.ResumeLayout(false);
            panelSearch.ResumeLayout(false);
            panelSearch.PerformLayout();
            panelHeader.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelMain;
        private Panel panelHeader;
        private Label lblTitle;
        private Label lblDescription;
        private Panel panelSearch;
        private TextBox txtSearch;
        private Label lblSearchIcon;
        private DataGridView dgvVerbs;
        private Label lblTotalVerbs;
    }
}
