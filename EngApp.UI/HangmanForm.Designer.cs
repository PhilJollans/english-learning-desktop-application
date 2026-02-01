
namespace EngApp.UI
{
    partial class HangmanForm
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
            this.lblWordDisplay = new System.Windows.Forms.Label();
            this.lblHint = new System.Windows.Forms.Label();
            this.pnlHangman = new System.Windows.Forms.Panel();
            this.flpKeyboard = new System.Windows.Forms.FlowLayoutPanel();
            this.lblStatus = new System.Windows.Forms.Label();
            this.btnRestart = new System.Windows.Forms.Button();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.pnlTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblWordDisplay
            // 
            this.lblWordDisplay.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblWordDisplay.Font = new System.Drawing.Font("Consolas", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblWordDisplay.Location = new System.Drawing.Point(0, 50);
            this.lblWordDisplay.Name = "lblWordDisplay";
            this.lblWordDisplay.Size = new System.Drawing.Size(800, 60);
            this.lblWordDisplay.TabIndex = 0;
            this.lblWordDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblHint
            // 
            this.lblHint.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblHint.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lblHint.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblHint.Location = new System.Drawing.Point(0, 0);
            this.lblHint.Name = "lblHint";
            this.lblHint.Size = new System.Drawing.Size(800, 50);
            this.lblHint.TabIndex = 1;
            this.lblHint.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlHangman
            // 
            this.pnlHangman.BackColor = System.Drawing.Color.White;
            this.pnlHangman.Location = new System.Drawing.Point(50, 130);
            this.pnlHangman.Name = "pnlHangman";
            this.pnlHangman.Size = new System.Drawing.Size(200, 250);
            this.pnlHangman.TabIndex = 2;
            this.pnlHangman.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlHangman_Paint);
            // 
            // flpKeyboard
            // 
            this.flpKeyboard.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flpKeyboard.Location = new System.Drawing.Point(280, 130);
            this.flpKeyboard.Name = "flpKeyboard";
            this.flpKeyboard.Size = new System.Drawing.Size(490, 250);
            this.flpKeyboard.TabIndex = 3;
            // 
            // lblStatus
            // 
            this.lblStatus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblStatus.Location = new System.Drawing.Point(12, 400);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(600, 40);
            this.lblStatus.TabIndex = 4;
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnRestart
            // 
            this.btnRestart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRestart.Location = new System.Drawing.Point(638, 400);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(150, 40);
            this.btnRestart.TabIndex = 5;
            this.btnRestart.Text = "Yeni Oyun";
            this.btnRestart.UseVisualStyleBackColor = true;
            this.btnRestart.Click += new System.EventHandler(this.btnRestart_Click);
            // 
            // pnlTop
            // 
            this.pnlTop.Controls.Add(this.lblWordDisplay);
            this.pnlTop.Controls.Add(this.lblHint);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(800, 110);
            this.pnlTop.TabIndex = 6;
            // 
            // HangmanForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnRestart);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.flpKeyboard);
            this.Controls.Add(this.pnlHangman);
            this.Controls.Add(this.pnlTop);
            this.KeyPreview = true;
            this.Name = "HangmanForm";
            this.Text = "Adam Asmaca";
            this.Load += new System.EventHandler(this.HangmanForm_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.HangmanForm_KeyPress);
            this.pnlTop.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblWordDisplay;
        private System.Windows.Forms.Label lblHint;
        private System.Windows.Forms.Panel pnlHangman;
        private System.Windows.Forms.FlowLayoutPanel flpKeyboard;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Button btnRestart;
        private System.Windows.Forms.Panel pnlTop;
    }
}
