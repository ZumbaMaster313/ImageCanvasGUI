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
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editImageboxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.brightnessToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filtersToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.imageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.emptyImageBoxToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.entropyCropToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.blurToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ContrastBtn = new System.Windows.Forms.Button();
            this.RotateBtn = new System.Windows.Forms.Button();
            this.Tint = new System.Windows.Forms.Button();
            this.CropBtn = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.rightHorizontal = new System.Windows.Forms.CheckBox();
            this.leftHorizontal = new System.Windows.Forms.CheckBox();
            this.contrastBar = new System.Windows.Forms.TrackBar();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.tintPicBox = new System.Windows.Forms.PictureBox();
            this.tintBar = new System.Windows.Forms.TrackBar();
            this.tintbar2 = new System.Windows.Forms.TrackBar();
            this.tintBar3 = new System.Windows.Forms.TrackBar();
            this.menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.contrastBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tintPicBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tintBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tintbar2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tintBar3)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.SystemColors.ControlText;
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.filterToolStripMenuItem,
            this.imageToolStripMenuItem});
            resources.ApplyResources(this.menuStrip, "menuStrip");
            this.menuStrip.Name = "menuStrip";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DoubleClickEnabled = true;
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem});
            resources.ApplyResources(this.fileToolStripMenuItem, "fileToolStripMenuItem");
            this.fileToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control;
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
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
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.resetImageToolStripMenuItem,
            this.editImageboxToolStripMenuItem});
            this.editToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            resources.ApplyResources(this.editToolStripMenuItem, "editToolStripMenuItem");
            // 
            // resetImageToolStripMenuItem
            // 
            this.resetImageToolStripMenuItem.Name = "resetImageToolStripMenuItem";
            resources.ApplyResources(this.resetImageToolStripMenuItem, "resetImageToolStripMenuItem");
            this.resetImageToolStripMenuItem.Click += new System.EventHandler(this.resetImageToolStripMenuItem_Click);
            // 
            // editImageboxToolStripMenuItem
            // 
            this.editImageboxToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.brightnessToolStripMenuItem});
            this.editImageboxToolStripMenuItem.Name = "editImageboxToolStripMenuItem";
            resources.ApplyResources(this.editImageboxToolStripMenuItem, "editImageboxToolStripMenuItem");
            // 
            // brightnessToolStripMenuItem
            // 
            this.brightnessToolStripMenuItem.Name = "brightnessToolStripMenuItem";
            resources.ApplyResources(this.brightnessToolStripMenuItem, "brightnessToolStripMenuItem");
            this.brightnessToolStripMenuItem.Click += new System.EventHandler(this.brightnessToolStripMenuItem_Click);
            // 
            // filterToolStripMenuItem
            // 
            this.filterToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.filtersToolStripMenuItem1});
            this.filterToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.filterToolStripMenuItem.Name = "filterToolStripMenuItem";
            resources.ApplyResources(this.filterToolStripMenuItem, "filterToolStripMenuItem");
            // 
            // filtersToolStripMenuItem1
            // 
            this.filtersToolStripMenuItem1.Name = "filtersToolStripMenuItem1";
            resources.ApplyResources(this.filtersToolStripMenuItem1, "filtersToolStripMenuItem1");
            this.filtersToolStripMenuItem1.Click += new System.EventHandler(this.filtersToolStripMenuItem1_Click);
            // 
            // imageToolStripMenuItem
            // 
            this.imageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.emptyImageBoxToolStripMenuItem1,
            this.entropyCropToolStripMenuItem,
            this.hueToolStripMenuItem,
            this.blurToolStripMenuItem1});
            this.imageToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.imageToolStripMenuItem.Name = "imageToolStripMenuItem";
            resources.ApplyResources(this.imageToolStripMenuItem, "imageToolStripMenuItem");
            // 
            // emptyImageBoxToolStripMenuItem1
            // 
            this.emptyImageBoxToolStripMenuItem1.Name = "emptyImageBoxToolStripMenuItem1";
            resources.ApplyResources(this.emptyImageBoxToolStripMenuItem1, "emptyImageBoxToolStripMenuItem1");
            this.emptyImageBoxToolStripMenuItem1.Click += new System.EventHandler(this.emptyImageBoxToolStripMenuItem1_Click);
            // 
            // entropyCropToolStripMenuItem
            // 
            this.entropyCropToolStripMenuItem.Name = "entropyCropToolStripMenuItem";
            resources.ApplyResources(this.entropyCropToolStripMenuItem, "entropyCropToolStripMenuItem");
            this.entropyCropToolStripMenuItem.Click += new System.EventHandler(this.entropyCropToolStripMenuItem_Click);
            // 
            // hueToolStripMenuItem
            // 
            this.hueToolStripMenuItem.Name = "hueToolStripMenuItem";
            resources.ApplyResources(this.hueToolStripMenuItem, "hueToolStripMenuItem");
            this.hueToolStripMenuItem.Click += new System.EventHandler(this.hueToolStripMenuItem_Click);
            // 
            // blurToolStripMenuItem1
            // 
            this.blurToolStripMenuItem1.Name = "blurToolStripMenuItem1";
            resources.ApplyResources(this.blurToolStripMenuItem1, "blurToolStripMenuItem1");
            this.blurToolStripMenuItem1.Click += new System.EventHandler(this.blurToolStripMenuItem1_Click);
            // 
            // ContrastBtn
            // 
            this.ContrastBtn.BackColor = System.Drawing.Color.DodgerBlue;
            resources.ApplyResources(this.ContrastBtn, "ContrastBtn");
            this.ContrastBtn.ForeColor = System.Drawing.Color.Black;
            this.ContrastBtn.Name = "ContrastBtn";
            this.ContrastBtn.UseVisualStyleBackColor = false;
            this.ContrastBtn.Click += new System.EventHandler(this.ContrastBtn_Click);
            // 
            // RotateBtn
            // 
            this.RotateBtn.BackColor = System.Drawing.Color.DodgerBlue;
            resources.ApplyResources(this.RotateBtn, "RotateBtn");
            this.RotateBtn.ForeColor = System.Drawing.Color.Black;
            this.RotateBtn.Name = "RotateBtn";
            this.RotateBtn.UseVisualStyleBackColor = false;
            this.RotateBtn.Click += new System.EventHandler(this.RotateBtn_Click);
            // 
            // Tint
            // 
            this.Tint.BackColor = System.Drawing.Color.DodgerBlue;
            resources.ApplyResources(this.Tint, "Tint");
            this.Tint.ForeColor = System.Drawing.Color.Black;
            this.Tint.Name = "Tint";
            this.Tint.UseVisualStyleBackColor = false;
            this.Tint.Click += new System.EventHandler(this.Tint_Click);
            // 
            // CropBtn
            // 
            this.CropBtn.BackColor = System.Drawing.Color.DodgerBlue;
            resources.ApplyResources(this.CropBtn, "CropBtn");
            this.CropBtn.ForeColor = System.Drawing.Color.Black;
            this.CropBtn.Name = "CropBtn";
            this.CropBtn.UseVisualStyleBackColor = false;
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
            // pictureBox
            // 
            this.pictureBox.BackColor = System.Drawing.Color.Black;
            this.pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            resources.ApplyResources(this.pictureBox, "pictureBox");
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.TabStop = false;
            // 
            // tintPicBox
            // 
            this.tintPicBox.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.tintPicBox, "tintPicBox");
            this.tintPicBox.Name = "tintPicBox";
            this.tintPicBox.TabStop = false;
            // 
            // tintBar
            // 
            resources.ApplyResources(this.tintBar, "tintBar");
            this.tintBar.Maximum = 255;
            this.tintBar.Name = "tintBar";
            this.tintBar.Value = 10;
            this.tintBar.Scroll += new System.EventHandler(this.tintBar_Scroll);
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
            // TintBtn
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(40)))), ((int)(((byte)(48)))));
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "TintBtn";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.contrastBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tintPicBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tintBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tintbar2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tintBar3)).EndInit();
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
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editImageboxToolStripMenuItem;
        private System.Windows.Forms.PictureBox tintPicBox;
        private System.Windows.Forms.TrackBar tintBar;
        private System.Windows.Forms.TrackBar tintbar2;
        private System.Windows.Forms.TrackBar tintBar3;
        private System.Windows.Forms.ToolStripMenuItem brightnessToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem filterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem filtersToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem imageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem emptyImageBoxToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem entropyCropToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resetImageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem blurToolStripMenuItem1;
    }
}

