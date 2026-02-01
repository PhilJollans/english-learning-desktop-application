namespace EngApp.UI
{
    partial class WordForm
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            panelMain = new Panel();
            panelContent = new Panel();
            panelWordList = new Panel();
            dgvWords = new DataGridView();
            colId = new DataGridViewTextBoxColumn();
            colWord = new DataGridViewTextBoxColumn();
            colMeaning = new DataGridViewTextBoxColumn();
            colExample = new DataGridViewTextBoxColumn();
            colSpeak = new DataGridViewButtonColumn();
            colDelete = new DataGridViewButtonColumn();
            txtSearch = new TextBox();
            lblWordsTitle = new Label();
            panelAddWord = new Panel();
            btnCancel = new Button();
            btnAdd = new Button();
            txtExample = new TextBox();
            lblExample = new Label();
            txtMeaning = new TextBox();
            lblMeaning = new Label();
            cmbPartOfSpeech = new ComboBox();
            lblPartOfSpeech = new Label();
            txtWord = new TextBox();
            lblWord = new Label();
            lblAddTitle = new Label();
            panelMain.SuspendLayout();
            panelContent.SuspendLayout();
            panelWordList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvWords).BeginInit();
            panelAddWord.SuspendLayout();
            SuspendLayout();
            // 
            // panelMain
            // 
            panelMain.BackColor = Color.FromArgb(248, 249, 250);
            panelMain.Controls.Add(panelContent);
            panelMain.Dock = DockStyle.Fill;
            panelMain.Location = new Point(0, 0);
            panelMain.Name = "panelMain";
            panelMain.Padding = new Padding(32);
            panelMain.Size = new Size(1200, 800);
            panelMain.TabIndex = 0;
            // 
            // panelContent
            // 
            panelContent.Controls.Add(panelWordList);
            panelContent.Controls.Add(panelAddWord);
            panelContent.Dock = DockStyle.Fill;
            panelContent.Location = new Point(32, 32);
            panelContent.Name = "panelContent";
            panelContent.Size = new Size(1136, 736);
            panelContent.TabIndex = 0;
            // 
            // panelWordList
            // 
            panelWordList.BackColor = Color.White;
            panelWordList.Controls.Add(dgvWords);
            panelWordList.Controls.Add(txtSearch);
            panelWordList.Controls.Add(lblWordsTitle);
            panelWordList.Dock = DockStyle.Fill;
            panelWordList.Location = new Point(420, 0);
            panelWordList.Name = "panelWordList";
            panelWordList.Padding = new Padding(24);
            panelWordList.Size = new Size(716, 736);
            panelWordList.TabIndex = 1;
            // 
            // dgvWords
            // 
            dgvWords.AllowUserToAddRows = false;
            dgvWords.AllowUserToDeleteRows = false;
            dgvWords.AllowUserToResizeRows = false;
            dgvWords.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvWords.BackgroundColor = Color.White;
            dgvWords.BorderStyle = BorderStyle.None;
            dgvWords.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvWords.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.White;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(95, 99, 104);
            dataGridViewCellStyle1.SelectionBackColor = Color.White;
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(95, 99, 104);
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvWords.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvWords.ColumnHeadersHeight = 48;
            dgvWords.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvWords.Columns.AddRange(new DataGridViewColumn[] { colId, colWord, colMeaning, colExample, colSpeak, colDelete });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10F);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(32, 33, 36);
            dataGridViewCellStyle2.Padding = new Padding(8, 12, 8, 12);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(232, 240, 254);
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(25, 103, 210);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvWords.DefaultCellStyle = dataGridViewCellStyle2;
            dgvWords.Dock = DockStyle.Fill;
            dgvWords.EnableHeadersVisualStyles = false;
            dgvWords.GridColor = Color.FromArgb(218, 220, 224);
            dgvWords.Location = new Point(24, 115);
            dgvWords.MultiSelect = false;
            dgvWords.Name = "dgvWords";
            dgvWords.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvWords.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvWords.RowHeadersVisible = false;
            dgvWords.RowHeadersWidth = 51;
            dgvWords.RowTemplate.Height = 56;
            dgvWords.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvWords.Size = new Size(668, 597);
            dgvWords.TabIndex = 1;
            dgvWords.CellContentClick += DgvWords_CellContentClick;
            // 
            // colId
            // 
            colId.HeaderText = "Id";
            colId.MinimumWidth = 6;
            colId.Name = "colId";
            colId.ReadOnly = true;
            colId.Visible = false;
            // 
            // colWord
            // 
            colWord.FillWeight = 50F;
            colWord.HeaderText = "Word";
            colWord.MinimumWidth = 6;
            colWord.Name = "colWord";
            colWord.ReadOnly = true;
            // 
            // colMeaning
            // 
            colMeaning.FillWeight = 70F;
            colMeaning.HeaderText = "Meaning";
            colMeaning.MinimumWidth = 6;
            colMeaning.Name = "colMeaning";
            colMeaning.ReadOnly = true;
            // 
            // colExample
            // 
            colExample.HeaderText = "Example";
            colExample.MinimumWidth = 6;
            colExample.Name = "colExample";
            colExample.ReadOnly = true;
            // 
            // colSpeak
            // 
            colSpeak.FillWeight = 60F;
            colSpeak.HeaderText = "Listen";
            colSpeak.MinimumWidth = 6;
            colSpeak.Name = "colSpeak";
            colSpeak.ReadOnly = true;
            colSpeak.Text = "🔊 Listen";
            colSpeak.UseColumnTextForButtonValue = true;
            // 
            // colDelete
            // 
            colDelete.FillWeight = 60F;
            colDelete.HeaderText = "Delete";
            colDelete.MinimumWidth = 6;
            colDelete.Name = "colDelete";
            colDelete.ReadOnly = true;
            colDelete.Text = "🗑️ Delete";
            colDelete.UseColumnTextForButtonValue = true;
            // 
            // txtSearch
            // 
            txtSearch.BackColor = Color.White;
            txtSearch.BorderStyle = BorderStyle.FixedSingle;
            txtSearch.Dock = DockStyle.Top;
            txtSearch.Font = new Font("Segoe UI", 11F);
            txtSearch.ForeColor = Color.FromArgb(32, 33, 36);
            txtSearch.Location = new Point(24, 67);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "🔍 Search words...";
            txtSearch.Size = new Size(668, 32);
            txtSearch.TabIndex = 2;
            // 
            // lblWordsTitle
            // 
            lblWordsTitle.Dock = DockStyle.Top;
            lblWordsTitle.Font = new Font("Segoe UI", 16F);
            lblWordsTitle.ForeColor = Color.FromArgb(32, 33, 36);
            lblWordsTitle.Location = new Point(24, 24);
            lblWordsTitle.Name = "lblWordsTitle";
            lblWordsTitle.Size = new Size(668, 43);
            lblWordsTitle.TabIndex = 0;
            lblWordsTitle.Text = "My words";
            // 
            // panelAddWord
            // 
            panelAddWord.BackColor = Color.White;
            panelAddWord.Controls.Add(btnCancel);
            panelAddWord.Controls.Add(btnAdd);
            panelAddWord.Controls.Add(txtExample);
            panelAddWord.Controls.Add(lblExample);
            panelAddWord.Controls.Add(txtMeaning);
            panelAddWord.Controls.Add(lblMeaning);
            panelAddWord.Controls.Add(cmbPartOfSpeech);
            panelAddWord.Controls.Add(lblPartOfSpeech);
            panelAddWord.Controls.Add(txtWord);
            panelAddWord.Controls.Add(lblWord);
            panelAddWord.Controls.Add(lblAddTitle);
            panelAddWord.Dock = DockStyle.Left;
            panelAddWord.Location = new Point(0, 0);
            panelAddWord.Name = "panelAddWord";
            panelAddWord.Padding = new Padding(24);
            panelAddWord.Size = new Size(420, 736);
            panelAddWord.TabIndex = 0;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.FromArgb(224, 224, 224);
            btnCancel.Cursor = Cursors.Hand;
            btnCancel.FlatAppearance.BorderSize = 0;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Segoe UI", 10F);
            btnCancel.ForeColor = Color.FromArgb(95, 99, 104);
            btnCancel.Location = new Point(24, 627);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(372, 40);
            btnCancel.TabIndex = 10;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(25, 103, 210);
            btnAdd.Cursor = Cursors.Hand;
            btnAdd.FlatAppearance.BorderSize = 0;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(24, 571);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(372, 44);
            btnAdd.TabIndex = 9;
            btnAdd.Text = "Add word";
            btnAdd.UseVisualStyleBackColor = false;
            // 
            // txtExample
            // 
            txtExample.BackColor = Color.White;
            txtExample.BorderStyle = BorderStyle.FixedSingle;
            txtExample.Font = new Font("Segoe UI", 10.5F);
            txtExample.ForeColor = Color.FromArgb(32, 33, 36);
            txtExample.Location = new Point(24, 481);
            txtExample.Multiline = true;
            txtExample.Name = "txtExample";
            txtExample.PlaceholderText = "Example sentence (optional)";
            txtExample.Size = new Size(372, 72);
            txtExample.TabIndex = 8;
            // 
            // lblExample
            // 
            lblExample.AutoSize = true;
            lblExample.Font = new Font("Segoe UI", 10F);
            lblExample.ForeColor = Color.FromArgb(95, 99, 104);
            lblExample.Location = new Point(24, 453);
            lblExample.Name = "lblExample";
            lblExample.Size = new Size(124, 23);
            lblExample.TabIndex = 7;
            lblExample.Text = "Example usage";
            // 
            // txtMeaning
            // 
            txtMeaning.BackColor = Color.White;
            txtMeaning.BorderStyle = BorderStyle.FixedSingle;
            txtMeaning.Font = new Font("Segoe UI", 10.5F);
            txtMeaning.ForeColor = Color.FromArgb(32, 33, 36);
            txtMeaning.Location = new Point(24, 342);
            txtMeaning.Multiline = true;
            txtMeaning.Name = "txtMeaning";
            txtMeaning.PlaceholderText = "Turkish meaning";
            txtMeaning.Size = new Size(372, 88);
            txtMeaning.TabIndex = 6;
            // 
            // lblMeaning
            // 
            lblMeaning.AutoSize = true;
            lblMeaning.Font = new Font("Segoe UI", 10F);
            lblMeaning.ForeColor = Color.FromArgb(95, 99, 104);
            lblMeaning.Location = new Point(24, 314);
            lblMeaning.Name = "lblMeaning";
            lblMeaning.Size = new Size(77, 23);
            lblMeaning.TabIndex = 5;
            lblMeaning.Text = "Meaning";
            // 
            // cmbPartOfSpeech
            // 
            cmbPartOfSpeech.BackColor = Color.White;
            cmbPartOfSpeech.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPartOfSpeech.Font = new Font("Segoe UI", 10.5F);
            cmbPartOfSpeech.ForeColor = Color.FromArgb(32, 33, 36);
            cmbPartOfSpeech.FormattingEnabled = true;
            cmbPartOfSpeech.Location = new Point(24, 259);
            cmbPartOfSpeech.Name = "cmbPartOfSpeech";
            cmbPartOfSpeech.Size = new Size(372, 31);
            cmbPartOfSpeech.TabIndex = 4;
            // 
            // lblPartOfSpeech
            // 
            lblPartOfSpeech.AutoSize = true;
            lblPartOfSpeech.Font = new Font("Segoe UI", 10F);
            lblPartOfSpeech.ForeColor = Color.FromArgb(95, 99, 104);
            lblPartOfSpeech.Location = new Point(24, 231);
            lblPartOfSpeech.Name = "lblPartOfSpeech";
            lblPartOfSpeech.Size = new Size(91, 23);
            lblPartOfSpeech.TabIndex = 3;
            lblPartOfSpeech.Text = "Word Type";
            // 
            // txtWord
            // 
            txtWord.BackColor = Color.White;
            txtWord.BorderStyle = BorderStyle.FixedSingle;
            txtWord.Font = new Font("Segoe UI", 12F);
            txtWord.ForeColor = Color.FromArgb(32, 33, 36);
            txtWord.Location = new Point(24, 178);
            txtWord.Name = "txtWord";
            txtWord.PlaceholderText = "English word";
            txtWord.Size = new Size(372, 34);
            txtWord.TabIndex = 2;
            // 
            // lblWord
            // 
            lblWord.AutoSize = true;
            lblWord.Font = new Font("Segoe UI", 10F);
            lblWord.ForeColor = Color.FromArgb(95, 99, 104);
            lblWord.Location = new Point(24, 150);
            lblWord.Name = "lblWord";
            lblWord.Size = new Size(51, 23);
            lblWord.TabIndex = 1;
            lblWord.Text = "Word";
            // 
            // lblAddTitle
            // 
            lblAddTitle.Dock = DockStyle.Top;
            lblAddTitle.Font = new Font("Segoe UI", 20F);
            lblAddTitle.ForeColor = Color.FromArgb(32, 33, 36);
            lblAddTitle.Location = new Point(24, 24);
            lblAddTitle.Name = "lblAddTitle";
            lblAddTitle.Size = new Size(372, 100);
            lblAddTitle.TabIndex = 0;
            lblAddTitle.Text = "Add new word";
            lblAddTitle.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // WordForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1200, 800);
            Controls.Add(panelMain);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            Name = "WordForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EngApp - Words";
            panelMain.ResumeLayout(false);
            panelContent.ResumeLayout(false);
            panelWordList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvWords).EndInit();
            panelAddWord.ResumeLayout(false);
            panelAddWord.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panelMain;
        private Panel panelContent;
        private Panel panelAddWord;
        private Label lblAddTitle;
        private TextBox txtWord;
        private Label lblWord;
        private TextBox txtMeaning;
        private Label lblMeaning;
        private TextBox txtExample;
        private Label lblExample;
        private Button btnAdd;
        private Panel panelWordList;
        private Label lblWordsTitle;
        private DataGridView dgvWords;
        private DataGridViewTextBoxColumn colId;
        private DataGridViewTextBoxColumn colWord;
        private DataGridViewTextBoxColumn colMeaning;
        private DataGridViewTextBoxColumn colExample;
        private DataGridViewButtonColumn colSpeak;
        private DataGridViewButtonColumn colDelete;
        private Label lblPartOfSpeech;
        private ComboBox cmbPartOfSpeech;
        private Button btnCancel;
        private TextBox txtSearch;
    }
}