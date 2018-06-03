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
using ImageProcessor.Imaging.Filters.EdgeDetection;

namespace WindowsFormsApplication1
{
    public partial class EdgeFilterFrm : Form
    {
        public ImageFactory imgFactory;
        public TintBtn tntBtn;
        public KayyaliEdgeFilter kk;
        public EdgeFilterFrm()
        {
            InitializeComponent();
        }

        private void chooseBtn_Click(object sender, EventArgs e)
        {
        }
    }
}
