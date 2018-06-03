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
    public partial class brightnessFrm : Form
    {
        public ImageFactory imgFactory;
        public TintBtn tBtn;
        public brightnessFrm()
        {
            InitializeComponent();
        }
        public void SetImgFactory(ImageFactory inImageFactory)
        {
            imgFactory = inImageFactory;
        }

        private void chooseBtn_Click(object sender, EventArgs e)
        {
            int percentage = Convert.ToInt32(txtBox.Text);
            imgFactory.Brightness(percentage);
            Close();

        }
    }
}
