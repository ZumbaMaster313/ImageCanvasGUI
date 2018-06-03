namespace WindowsFormsApplication1
{
    partial class filterForm
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
            this.textBox = new System.Windows.Forms.Label();
            this.grayScale = new System.Windows.Forms.CheckBox();
            this.chooseBtn = new System.Windows.Forms.Button();
            this.comicFilter = new System.Windows.Forms.CheckBox();
            this.polaroidFilter = new System.Windows.Forms.CheckBox();
            this.hiSatchFilter = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // textBox
            // 
            this.textBox.AutoSize = true;
            this.textBox.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox.ForeColor = System.Drawing.Color.White;
            this.textBox.Location = new System.Drawing.Point(61, 35);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(123, 23);
            this.textBox.TabIndex = 5;
            this.textBox.Text = "Choose Filter ";
            this.textBox.UseMnemonic = false;
            // 
            // grayScale
            // 
            this.grayScale.AutoSize = true;
            this.grayScale.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grayScale.ForeColor = System.Drawing.Color.White;
            this.grayScale.Location = new System.Drawing.Point(31, 124);
            this.grayScale.Name = "grayScale";
            this.grayScale.Size = new System.Drawing.Size(88, 20);
            this.grayScale.TabIndex = 6;
            this.grayScale.Text = "Gray Scale";
            this.grayScale.UseVisualStyleBackColor = true;
            // 
            // chooseBtn
            // 
            this.chooseBtn.BackColor = System.Drawing.Color.DodgerBlue;
            this.chooseBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.chooseBtn.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.chooseBtn.ForeColor = System.Drawing.Color.Black;
            this.chooseBtn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.chooseBtn.Location = new System.Drawing.Point(31, 84);
            this.chooseBtn.Name = "chooseBtn";
            this.chooseBtn.Size = new System.Drawing.Size(194, 34);
            this.chooseBtn.TabIndex = 7;
            this.chooseBtn.Text = "Filter";
            this.chooseBtn.UseVisualStyleBackColor = false;
            this.chooseBtn.Click += new System.EventHandler(this.chooseBtn_Click);
            // 
            // comicFilter
            // 
            this.comicFilter.AutoSize = true;
            this.comicFilter.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comicFilter.ForeColor = System.Drawing.Color.White;
            this.comicFilter.Location = new System.Drawing.Point(125, 124);
            this.comicFilter.Name = "comicFilter";
            this.comicFilter.Size = new System.Drawing.Size(62, 20);
            this.comicFilter.TabIndex = 8;
            this.comicFilter.Text = "Comic";
            this.comicFilter.UseVisualStyleBackColor = true;
            // 
            // polaroidFilter
            // 
            this.polaroidFilter.AutoSize = true;
            this.polaroidFilter.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.polaroidFilter.ForeColor = System.Drawing.Color.White;
            this.polaroidFilter.Location = new System.Drawing.Point(31, 159);
            this.polaroidFilter.Name = "polaroidFilter";
            this.polaroidFilter.Size = new System.Drawing.Size(73, 20);
            this.polaroidFilter.TabIndex = 9;
            this.polaroidFilter.Text = "Polaroid";
            this.polaroidFilter.UseVisualStyleBackColor = true;
            // 
            // hiSatchFilter
            // 
            this.hiSatchFilter.AutoSize = true;
            this.hiSatchFilter.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hiSatchFilter.ForeColor = System.Drawing.Color.White;
            this.hiSatchFilter.Location = new System.Drawing.Point(125, 159);
            this.hiSatchFilter.Name = "hiSatchFilter";
            this.hiSatchFilter.Size = new System.Drawing.Size(70, 20);
            this.hiSatchFilter.TabIndex = 10;
            this.hiSatchFilter.Text = "HiSatch";
            this.hiSatchFilter.UseVisualStyleBackColor = true;
            // 
            // filterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(40)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(253, 216);
            this.Controls.Add(this.hiSatchFilter);
            this.Controls.Add(this.polaroidFilter);
            this.Controls.Add(this.comicFilter);
            this.Controls.Add(this.chooseBtn);
            this.Controls.Add(this.grayScale);
            this.Controls.Add(this.textBox);
            this.Name = "filterForm";
            this.Text = "Filters";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label textBox;
        private System.Windows.Forms.CheckBox grayScale;
        private System.Windows.Forms.Button chooseBtn;
        private System.Windows.Forms.CheckBox comicFilter;
        private System.Windows.Forms.CheckBox polaroidFilter;
        private System.Windows.Forms.CheckBox hiSatchFilter;
    }
}