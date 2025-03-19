using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NEXUS.Forms
{
    public partial class DisplayImage : Form
    {
        Scan scan = new Scan();
        public DisplayImage(Image image)
        {
            InitializeComponent();
            scan.ShowOverlay(this);
            pbImageUploaded.Image = image;
        }

        private void pbClose1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
