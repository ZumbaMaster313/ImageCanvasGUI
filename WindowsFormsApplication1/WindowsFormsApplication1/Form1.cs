using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ImageProcessor;
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
            imageFactory.Contrast(10);
            pictureBox.Image = imageFactory.Image;
        }

        private void RotateBtn_Click(object sender, EventArgs e)
        {
            imageFactory.Rotate(90);
            pictureBox.Image = imageFactory.Image;
        }

        private void Tint_Click(object sender, EventArgs e)
        {
            imageFactory.Tint(Color.RoyalBlue);
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
    }
}
    

