namespace WindowsFormsApplication1
{
    partial class TintBtn
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
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.ContrastBtn = new System.Windows.Forms.Button();
            this.RotateBtn = new System.Windows.Forms.Button();
            this.Tint = new System.Windows.Forms.Button();
            this.CropBtn = new System.Windows.Forms.Button();
            this.menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.SystemColors.ControlText;
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(969, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DoubleClickEnabled = true;
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem});
            this.fileToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control;
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(229, 67);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(617, 399);
            this.pictureBox.TabIndex = 1;
            this.pictureBox.TabStop = false;
            // 
            // ContrastBtn
            // 
            this.ContrastBtn.BackColor = System.Drawing.SystemColors.Control;
            this.ContrastBtn.Location = new System.Drawing.Point(13, 67);
            this.ContrastBtn.Name = "ContrastBtn";
            this.ContrastBtn.Size = new System.Drawing.Size(194, 23);
            this.ContrastBtn.TabIndex = 2;
            this.ContrastBtn.Text = "Contrast";
            this.ContrastBtn.UseVisualStyleBackColor = false;
            this.ContrastBtn.Click += new System.EventHandler(this.ContrastBtn_Click);
            // 
            // RotateBtn
            // 
            this.RotateBtn.Location = new System.Drawing.Point(12, 124);
            this.RotateBtn.Name = "RotateBtn";
            this.RotateBtn.Size = new System.Drawing.Size(194, 23);
            this.RotateBtn.TabIndex = 3;
            this.RotateBtn.Text = "Rotate Horizontal";
            this.RotateBtn.UseVisualStyleBackColor = true;
            this.RotateBtn.Click += new System.EventHandler(this.RotateBtn_Click);
            // 
            // Tint
            // 
            this.Tint.Location = new System.Drawing.Point(12, 181);
            this.Tint.Name = "Tint";
            this.Tint.Size = new System.Drawing.Size(194, 23);
            this.Tint.TabIndex = 4;
            this.Tint.Text = "Tint/Color Change";
            this.Tint.UseVisualStyleBackColor = true;
            this.Tint.Click += new System.EventHandler(this.Tint_Click);
            // 
            // CropBtn
            // 
            this.CropBtn.Location = new System.Drawing.Point(12, 240);
            this.CropBtn.Name = "CropBtn";
            this.CropBtn.Size = new System.Drawing.Size(194, 23);
            this.CropBtn.TabIndex = 5;
            this.CropBtn.Text = "Crop";
            this.CropBtn.UseVisualStyleBackColor = true;
            this.CropBtn.Click += new System.EventHandler(this.CropBtn_Click);
            // 
            // TintBtn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(969, 517);
            this.Controls.Add(this.CropBtn);
            this.Controls.Add(this.Tint);
            this.Controls.Add(this.RotateBtn);
            this.Controls.Add(this.ContrastBtn);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "TintBtn";
            this.Text = "Tint";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Button ContrastBtn;
        private System.Windows.Forms.Button RotateBtn;
        private System.Windows.Forms.Button Tint;
        private System.Windows.Forms.Button CropBtn;
    }
}

