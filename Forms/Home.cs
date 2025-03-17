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
    public partial class Home : Form
    {
        Dashboard dashboard = new Dashboard();
        public Home()
        {
            InitializeComponent();
        }

        private void pbMap_Click(object sender, EventArgs e)
        {
            Map map = new Map();
            dashboard.OpenChildForm(map);
        }
    }
}
