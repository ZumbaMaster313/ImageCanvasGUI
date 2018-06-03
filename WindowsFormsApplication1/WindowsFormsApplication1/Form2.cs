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


namespace WindowsFormsApplication1
{
    public partial class CropDialog : Form
    {
        
        public ImageFactory imgFactory;
        public TintBtn tintBtn;
        public CropDialog()
        {
            InitializeComponent();
         
        }

        public void SetImageFactory(ImageFactory inImgFactgory)
        {
            imgFactory = inImgFactgory;
            WidthResTbox.Text = imgFactory.Image.Width.ToString();
            HeightResTbox.Text = imgFactory.Image.Height.ToString();
        }

        private void CropBtn_Click(object sender, EventArgs e)
        {

            int myImageWidth = imgFactory.Image.Width;
            int myImageHeight = imgFactory.Image.Height;

            int newIntValueW = Convert.ToInt32(WidthResTbox.Text);
            int newIntValueH = Convert.ToInt32(HeightResTbox.Text);
            Rectangle rec = new Rectangle(new Point(myImageWidth/2, myImageHeight/2), new Size(newIntValueW , newIntValueH));
            imgFactory.Crop(rec);
            Close();
        }

      
    }
}
