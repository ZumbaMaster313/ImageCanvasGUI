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
            this.WidthResTbox.Location = new System.Drawing.Point(32, 33);
            this.WidthResTbox.Name = "WidthResTbox";
            this.WidthResTbox.Size = new System.Drawing.Size(100, 20);
            this.WidthResTbox.TabIndex = 0;
            // 
            // HeightResTbox
            // 
            this.HeightResTbox.Location = new System.Drawing.Point(32, 59);
            this.HeightResTbox.Name = "HeightResTbox";
            this.HeightResTbox.Size = new System.Drawing.Size(100, 20);
            this.HeightResTbox.TabIndex = 1;
            // 
            // CropBtn
            // 
            this.CropBtn.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.CropBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CropBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.CropBtn.Location = new System.Drawing.Point(32, 98);
            this.CropBtn.Name = "CropBtn";
            this.CropBtn.Size = new System.Drawing.Size(75, 23);
            this.CropBtn.TabIndex = 2;
            this.CropBtn.Text = "Crop!";
            this.CropBtn.UseVisualStyleBackColor = false;
            this.CropBtn.Click += new System.EventHandler(this.CropBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(28, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "Resolution";
            this.label1.UseMnemonic = false;
            // 
            // CropDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(190, 187);
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