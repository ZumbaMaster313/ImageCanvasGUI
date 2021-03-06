﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ImageProcessor;
using ImageProcessor.Imaging;
using System.IO;
using System.Drawing.Imaging;
using WindowsFormsApplication1;



namespace WindowsFormsApplication1
{
    public partial class TintBtn : Form
    {
        ImageFactory imageFactory;

        public TintBtn()
        {
            InitializeComponent();
        }
        

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.InitialDirectory = "c:\\";
            openFileDialog1.Filter = "jpg files (*.jpg)|*.jpg|All files (*.*)|*.*";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                var path = openFileDialog1.FileName;
                imageFactory = new ImageFactory();
                Bitmap image = new Bitmap(path);

                pictureBox.Width = image.Width;
                pictureBox.Height = image.Height;
                pictureBox.Image = image;
                imageFactory.Load(image);
                imageFactory.Load(pictureBox.Image);
            }             
            
        }

        private void ContrastBtn_Click(object sender, EventArgs e)
        {
            imageFactory.Contrast(contrastBar.Value);
            pictureBox.Image = imageFactory.Image;
        }

        private void RotateBtn_Click(object sender, EventArgs e)
        {

            if (rightHorizontal.Checked == true)
            {
                imageFactory.Rotate(90);
                pictureBox.Image = imageFactory.Image;
            }
            else if (leftHorizontal.Checked == true)
            {
                imageFactory.Rotate(-90);
                pictureBox.Image = imageFactory.Image;
            }
        }


        private void Tint_Click(object sender, EventArgs e)
        {

            Color myColor = Color.FromArgb(tintBar.Value, tintbar2.Value, tintBar3.Value);

            string hex = "#" + myColor.R.ToString("X2") + myColor.G.ToString("X2") + myColor.B.ToString("X2");

            imageFactory.Tint(ColorTranslator.FromHtml(hex));
            pictureBox.Image = imageFactory.Image;
        }

        private void CropBtn_Click(object sender, EventArgs e)
        {
            CropDialog cropDialog = new WindowsFormsApplication1.CropDialog();
            cropDialog.SetImageFactory(imageFactory);
            cropDialog.Show();
            cropDialog.FormClosed += new FormClosedEventHandler(Form_Closed);

        }

        void Form_Closed(object sender, FormClosedEventArgs e)
        {
            CropDialog frm = (CropDialog)sender;
            pictureBox.Width = imageFactory.Image.Width;
            pictureBox.Height = imageFactory.Image.Height;
            pictureBox.Image = imageFactory.Image;
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {

            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.InitialDirectory = "c:\\";

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                imageFactory.Save(saveFileDialog1.FileName);
            }
        }

        private void tintBar_Scroll(object sender, EventArgs e)
        {
            Color myColor = Color.FromArgb(tintBar.Value, tintbar2.Value, tintBar3.Value);

            string hex = "#" + myColor.R.ToString("X2") + myColor.G.ToString("X2") + myColor.B.ToString("X2");

            tintPicBox.BackColor = ColorTranslator.FromHtml(hex);
        }

        private void tintbar2_Scroll(object sender, EventArgs e)
        {
            Color myColor = Color.FromArgb(tintBar.Value, tintbar2.Value, tintBar3.Value);

            string hex = "#" + myColor.R.ToString("X2") + myColor.G.ToString("X2") + myColor.B.ToString("X2");

            tintPicBox.BackColor = ColorTranslator.FromHtml(hex);
        }

        private void tintBar3_Scroll(object sender, EventArgs e)
        {
            Color myColor = Color.FromArgb(tintBar.Value, tintbar2.Value, tintBar3.Value);

            string hex = "#" + myColor.R.ToString("X2") + myColor.G.ToString("X2") + myColor.B.ToString("X2");

            tintPicBox.BackColor = ColorTranslator.FromHtml(hex);
        }
        private void brightnessToolStripMenuItem_Click(object sender, EventArgs e)
        {
            brightnessFrm bFrm = new WindowsFormsApplication1.brightnessFrm();
            bFrm.SetImgFactory(imageFactory);
            bFrm.Show();
            bFrm.FormClosed += new FormClosedEventHandler(brightnessFrmClosed);
        }
        void brightnessFrmClosed(object sender, FormClosedEventArgs e)
        {
            brightnessFrm bForm = (brightnessFrm)sender;
            pictureBox.Image = imageFactory.Image;
        }
       private void entropyCropToolStripMenuItem_Click(object sender, EventArgs e)
        {
            imageFactory.EntropyCrop(128);
            pictureBox.Image = imageFactory.Image;
        }

        private void hueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            imageFactory.Hue(180, true);
            pictureBox.Image = imageFactory.Image;
        }

        private void resetImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            imageFactory.Reset();
            pictureBox.Image = imageFactory.Image;
        }

        private void emptyImageBoxToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            pictureBox.Image = null;
        }

        private void filtersToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            filterForm filterForm = new WindowsFormsApplication1.filterForm();
            filterForm.sImageFactorty(imageFactory);
            filterForm.Show();
            filterForm.FormClosed += new FormClosedEventHandler(filterFormClosed);
        }
        void filterFormClosed(object sender, FormClosedEventArgs e)
        {
            filterForm filterFrm = (filterForm)sender;
            pictureBox.Image = imageFactory.Image;
        }
        private void blurToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            imageFactory.GaussianBlur(10);
            pictureBox.Image = imageFactory.Image;
        }
    }
}
    

