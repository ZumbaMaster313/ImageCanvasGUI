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
using ImageProcessor.Imaging;
using ImageProcessor.Imaging.Filters.Photo;

namespace WindowsFormsApplication1
{
    public partial class filterForm : Form
    {
        public ImageFactory imgFactory;
        public TintBtn tintBtn;
        public filterForm()
        {
            InitializeComponent();
        }
        public void sImageFactorty(ImageFactory inImageFactry)
        {
            imgFactory = inImageFactry;
            
        }
        private void chooseBtn_Click(object sender, EventArgs e)
        {
            if (grayScale.Checked == true)
            {
                imgFactory.Filter(MatrixFilters.GreyScale);
                Close();
            }
            else if(comicFilter.Checked == true)
            {
                imgFactory.Filter(MatrixFilters.Comic);
                Close();
            }
            else if (polaroidFilter.Checked == true)
            {
                imgFactory.Filter(MatrixFilters.Polaroid);
                Close();
            }
            else if(hiSatchFilter.Checked == true)
            {
                imgFactory.Filter(MatrixFilters.HiSatch);
                Close();
            }
        }
    }
}
