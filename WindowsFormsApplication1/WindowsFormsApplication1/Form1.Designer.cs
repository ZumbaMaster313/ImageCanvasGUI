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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TintBtn));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ContrastBtn = new System.Windows.Forms.Button();
            this.RotateBtn = new System.Windows.Forms.Button();
            this.Tint = new System.Windows.Forms.Button();
            this.CropBtn = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.rightHorizontal = new System.Windows.Forms.CheckBox();
            this.leftHorizontal = new System.Windows.Forms.CheckBox();
            this.contrastBar = new System.Windows.Forms.TrackBar();
            this.tintBar = new System.Windows.Forms.TrackBar();
            this.tintPicBox = new System.Windows.Forms.PictureBox();
            this.tintbar2 = new System.Windows.Forms.TrackBar();
            this.tintBar3 = new System.Windows.Forms.TrackBar();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.contrastBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tintBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tintPicBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tintbar2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tintBar3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.SystemColors.ControlText;
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            resources.ApplyResources(this.menuStrip, "menuStrip");
            this.menuStrip.Name = "menuStrip";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DoubleClickEnabled = true;
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem});
            this.fileToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control;
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            resources.ApplyResources(this.fileToolStripMenuItem, "fileToolStripMenuItem");
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            resources.ApplyResources(this.openToolStripMenuItem, "openToolStripMenuItem");
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            resources.ApplyResources(this.saveToolStripMenuItem, "saveToolStripMenuItem");
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // ContrastBtn
            // 
            this.ContrastBtn.BackColor = System.Drawing.SystemColors.Control;
            resources.ApplyResources(this.ContrastBtn, "ContrastBtn");
            this.ContrastBtn.Name = "ContrastBtn";
            this.ContrastBtn.UseVisualStyleBackColor = false;
            this.ContrastBtn.Click += new System.EventHandler(this.ContrastBtn_Click);
            // 
            // RotateBtn
            // 
            resources.ApplyResources(this.RotateBtn, "RotateBtn");
            this.RotateBtn.Name = "RotateBtn";
            this.RotateBtn.UseVisualStyleBackColor = true;
            this.RotateBtn.Click += new System.EventHandler(this.RotateBtn_Click);
            // 
            // Tint
            // 
            resources.ApplyResources(this.Tint, "Tint");
            this.Tint.Name = "Tint";
            this.Tint.UseVisualStyleBackColor = true;
            this.Tint.Click += new System.EventHandler(this.Tint_Click);
            // 
            // CropBtn
            // 
            resources.ApplyResources(this.CropBtn, "CropBtn");
            this.CropBtn.Name = "CropBtn";
            this.CropBtn.UseVisualStyleBackColor = true;
            this.CropBtn.Click += new System.EventHandler(this.CropBtn_Click);
            // 
            // rightHorizontal
            // 
            resources.ApplyResources(this.rightHorizontal, "rightHorizontal");
            this.rightHorizontal.ForeColor = System.Drawing.Color.White;
            this.rightHorizontal.Name = "rightHorizontal";
            this.rightHorizontal.UseVisualStyleBackColor = true;
            // 
            // leftHorizontal
            // 
            resources.ApplyResources(this.leftHorizontal, "leftHorizontal");
            this.leftHorizontal.ForeColor = System.Drawing.Color.White;
            this.leftHorizontal.Name = "leftHorizontal";
            this.leftHorizontal.UseVisualStyleBackColor = true;
            // 
            // contrastBar
            // 
            resources.ApplyResources(this.contrastBar, "contrastBar");
            this.contrastBar.Maximum = 30;
            this.contrastBar.Minimum = 10;
            this.contrastBar.Name = "contrastBar";
            this.contrastBar.Value = 10;
            // 
            // tintBar
            // 
            resources.ApplyResources(this.tintBar, "tintBar");
            this.tintBar.Maximum = 255;
            this.tintBar.Name = "tintBar";
            this.tintBar.Value = 10;
            this.tintBar.Scroll += new System.EventHandler(this.tintBar_Scroll);
            // 
            // tintPicBox
            // 
            this.tintPicBox.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.tintPicBox, "tintPicBox");
            this.tintPicBox.Name = "tintPicBox";
            this.tintPicBox.TabStop = false;
            // 
            // tintbar2
            // 
            resources.ApplyResources(this.tintbar2, "tintbar2");
            this.tintbar2.Maximum = 255;
            this.tintbar2.Name = "tintbar2";
            this.tintbar2.Value = 10;
            this.tintbar2.Scroll += new System.EventHandler(this.tintbar2_Scroll);
            // 
            // tintBar3
            // 
            resources.ApplyResources(this.tintBar3, "tintBar3");
            this.tintBar3.Maximum = 255;
            this.tintBar3.Name = "tintBar3";
            this.tintBar3.Value = 10;
            // 
            // pictureBox
            // 
            this.pictureBox.BackColor = System.Drawing.Color.Black;
            resources.ApplyResources(this.pictureBox, "pictureBox");
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.TabStop = false;
            // 
            // TintBtn
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Controls.Add(this.tintBar3);
            this.Controls.Add(this.tintbar2);
            this.Controls.Add(this.tintPicBox);
            this.Controls.Add(this.tintBar);
            this.Controls.Add(this.contrastBar);
            this.Controls.Add(this.leftHorizontal);
            this.Controls.Add(this.rightHorizontal);
            this.Controls.Add(this.CropBtn);
            this.Controls.Add(this.Tint);
            this.Controls.Add(this.RotateBtn);
            this.Controls.Add(this.ContrastBtn);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.menuStrip);
            this.ForeColor = System.Drawing.Color.Black;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "TintBtn";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.contrastBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tintBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tintPicBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tintbar2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tintBar3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.Button ContrastBtn;
        private System.Windows.Forms.Button RotateBtn;
        private System.Windows.Forms.Button Tint;
        private System.Windows.Forms.Button CropBtn;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.CheckBox rightHorizontal;
        private System.Windows.Forms.CheckBox leftHorizontal;
        private System.Windows.Forms.TrackBar contrastBar;
        private System.Windows.Forms.TrackBar tintBar;
        private System.Windows.Forms.PictureBox tintPicBox;
        private System.Windows.Forms.TrackBar tintbar2;
        private System.Windows.Forms.TrackBar tintBar3;
        private System.Windows.Forms.PictureBox pictureBox;
    }
}

