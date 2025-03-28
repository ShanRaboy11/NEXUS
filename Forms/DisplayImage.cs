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
        Scan scan = new Scan(null);
        public DisplayImage(Image image,string message)
        {
            InitializeComponent();
            pbImageUploaded.Image = image;
            if (message == "report")
            {
                scan.ShowOverlay(this, null);       
            }
            else
            {
                this.Show();
            }
            
        }

        private void pbClose1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
