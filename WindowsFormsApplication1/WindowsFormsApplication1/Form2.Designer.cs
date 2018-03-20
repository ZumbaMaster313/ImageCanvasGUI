namespace WindowsFormsApplication1
{
    partial class CropDialog
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
            this.WidthResTbox = new System.Windows.Forms.TextBox();
            this.HeightResTbox = new System.Windows.Forms.TextBox();
            this.CropBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // WidthResTbox
            // 
            this.WidthResTbox.Location = new System.Drawing.Point(32, 28);
            this.WidthResTbox.Name = "WidthResTbox";
            this.WidthResTbox.Size = new System.Drawing.Size(100, 20);
            this.WidthResTbox.TabIndex = 0;

            // 
            // HeightResTbox
            // 
            this.HeightResTbox.Location = new System.Drawing.Point(32, 54);
            this.HeightResTbox.Name = "HeightResTbox";
            this.HeightResTbox.Size = new System.Drawing.Size(100, 20);
            this.HeightResTbox.TabIndex = 1;
            // 
            // CropBtn
            // 
            this.CropBtn.Location = new System.Drawing.Point(32, 99);
            this.CropBtn.Name = "CropBtn";
            this.CropBtn.Size = new System.Drawing.Size(75, 23);
            this.CropBtn.TabIndex = 2;
            this.CropBtn.Text = "Crop!";
            this.CropBtn.UseVisualStyleBackColor = true;
            this.CropBtn.Click += new System.EventHandler(this.CropBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "resulution";

            // 
            // CropDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(267, 277);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CropBtn);
            this.Controls.Add(this.HeightResTbox);
            this.Controls.Add(this.WidthResTbox);
            this.Name = "CropDialog";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox WidthResTbox;
        private System.Windows.Forms.TextBox HeightResTbox;
        private System.Windows.Forms.Button CropBtn;
        private System.Windows.Forms.Label label1;
    }
}