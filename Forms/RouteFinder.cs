using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NEXUS.Forms
{
    public partial class RouteFinder : Form
    {
        private string currentJeepCode;
        public RouteFinder()
        {
            InitializeComponent();
        }

        private void cmbxJeepCodes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbxJeepCodes.SelectedIndex != null)
            {
                currentJeepCode = cmbxJeepCodes.SelectedIndex.ToString();
                JeepCodeDestinations(currentJeepCode);
            }
        }

        private void JeepCodeDestinations(string jeepCode)
        {


        }
    }
}
