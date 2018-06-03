namespace WindowsFormsApplication1
{
    partial class brightnessFrm
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
            this.chooseBtn = new System.Windows.Forms.Button();
            this.txtBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBox
            // 
            this.textBox.AutoSize = true;
            this.textBox.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox.ForeColor = System.Drawing.Color.White;
            this.textBox.Location = new System.Drawing.Point(47, 31);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(187, 23);
            this.textBox.TabIndex = 6;
            this.textBox.Text = "Customize Brightness";
            this.textBox.UseMnemonic = false;
            // 
            // chooseBtn
            // 
            this.chooseBtn.BackColor = System.Drawing.Color.DodgerBlue;
            this.chooseBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.chooseBtn.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.chooseBtn.ForeColor = System.Drawing.Color.Black;
            this.chooseBtn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.chooseBtn.Location = new System.Drawing.Point(40, 81);
            this.chooseBtn.Name = "chooseBtn";
            this.chooseBtn.Size = new System.Drawing.Size(194, 34);
            this.chooseBtn.TabIndex = 8;
            this.chooseBtn.Text = "Confirm Brightness";
            this.chooseBtn.UseVisualStyleBackColor = false;
            this.chooseBtn.Click += new System.EventHandler(this.chooseBtn_Click);
            // 
            // txtBox
            // 
            this.txtBox.BackColor = System.Drawing.SystemColors.Desktop;
            this.txtBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBox.ForeColor = System.Drawing.SystemColors.Window;
            this.txtBox.Location = new System.Drawing.Point(73, 132);
            this.txtBox.Name = "txtBox";
            this.txtBox.Size = new System.Drawing.Size(115, 20);
            this.txtBox.TabIndex = 9;
            // 
            // brightnessFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(40)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(280, 181);
            this.Controls.Add(this.txtBox);
            this.Controls.Add(this.chooseBtn);
            this.Controls.Add(this.textBox);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "brightnessFrm";
            this.Text = "brightnessFrm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label textBox;
        private System.Windows.Forms.Button chooseBtn;
        private System.Windows.Forms.TextBox txtBox;
    }
}