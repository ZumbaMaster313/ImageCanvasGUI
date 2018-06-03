namespace WindowsFormsApplication1
{
    partial class EdgeFilterFrm
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
            this.chooseBtn = new System.Windows.Forms.Button();
            this.textBox = new System.Windows.Forms.Label();
            this.sobelFilter = new System.Windows.Forms.CheckBox();
            this.prewittFilter = new System.Windows.Forms.CheckBox();
            this.LaplacianFilter = new System.Windows.Forms.CheckBox();
            this.KayyaliFilter = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // chooseBtn
            // 
            this.chooseBtn.BackColor = System.Drawing.Color.DodgerBlue;
            this.chooseBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.chooseBtn.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.chooseBtn.ForeColor = System.Drawing.Color.Black;
            this.chooseBtn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.chooseBtn.Location = new System.Drawing.Point(42, 91);
            this.chooseBtn.Name = "chooseBtn";
            this.chooseBtn.Size = new System.Drawing.Size(207, 34);
            this.chooseBtn.TabIndex = 9;
            this.chooseBtn.Text = "Confirm Filter";
            this.chooseBtn.UseVisualStyleBackColor = false;
            this.chooseBtn.Click += new System.EventHandler(this.chooseBtn_Click);
            // 
            // textBox
            // 
            this.textBox.AutoSize = true;
            this.textBox.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox.ForeColor = System.Drawing.Color.White;
            this.textBox.Location = new System.Drawing.Point(86, 43);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(100, 23);
            this.textBox.TabIndex = 10;
            this.textBox.Text = "Edge Filter";
            this.textBox.UseMnemonic = false;
            // 
            // sobelFilter
            // 
            this.sobelFilter.AutoSize = true;
            this.sobelFilter.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sobelFilter.ForeColor = System.Drawing.Color.White;
            this.sobelFilter.Location = new System.Drawing.Point(142, 182);
            this.sobelFilter.Name = "sobelFilter";
            this.sobelFilter.Size = new System.Drawing.Size(62, 20);
            this.sobelFilter.TabIndex = 14;
            this.sobelFilter.Text = "Sobell";
            this.sobelFilter.UseVisualStyleBackColor = true;
            // 
            // prewittFilter
            // 
            this.prewittFilter.AutoSize = true;
            this.prewittFilter.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prewittFilter.ForeColor = System.Drawing.Color.White;
            this.prewittFilter.Location = new System.Drawing.Point(48, 182);
            this.prewittFilter.Name = "prewittFilter";
            this.prewittFilter.Size = new System.Drawing.Size(67, 20);
            this.prewittFilter.TabIndex = 13;
            this.prewittFilter.Text = "Prewitt";
            this.prewittFilter.UseVisualStyleBackColor = true;
            // 
            // LaplacianFilter
            // 
            this.LaplacianFilter.AutoSize = true;
            this.LaplacianFilter.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LaplacianFilter.ForeColor = System.Drawing.Color.White;
            this.LaplacianFilter.Location = new System.Drawing.Point(142, 147);
            this.LaplacianFilter.Name = "LaplacianFilter";
            this.LaplacianFilter.Size = new System.Drawing.Size(80, 20);
            this.LaplacianFilter.TabIndex = 12;
            this.LaplacianFilter.Text = "Laplacian";
            this.LaplacianFilter.UseVisualStyleBackColor = true;
            // 
            // KayyaliFilter
            // 
            this.KayyaliFilter.AutoSize = true;
            this.KayyaliFilter.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KayyaliFilter.ForeColor = System.Drawing.Color.White;
            this.KayyaliFilter.Location = new System.Drawing.Point(48, 147);
            this.KayyaliFilter.Name = "KayyaliFilter";
            this.KayyaliFilter.Size = new System.Drawing.Size(63, 20);
            this.KayyaliFilter.TabIndex = 11;
            this.KayyaliFilter.Text = "Kayalli";
            this.KayyaliFilter.UseVisualStyleBackColor = true;
            // 
            // EdgeFilterFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(40)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.sobelFilter);
            this.Controls.Add(this.prewittFilter);
            this.Controls.Add(this.LaplacianFilter);
            this.Controls.Add(this.KayyaliFilter);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.chooseBtn);
            this.Name = "EdgeFilterFrm";
            this.Text = "EdgeFilterFrm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button chooseBtn;
        private System.Windows.Forms.Label textBox;
        private System.Windows.Forms.CheckBox sobelFilter;
        private System.Windows.Forms.CheckBox prewittFilter;
        private System.Windows.Forms.CheckBox LaplacianFilter;
        private System.Windows.Forms.CheckBox KayyaliFilter;
    }
}