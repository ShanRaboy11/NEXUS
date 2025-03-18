using NEXUS.Properties;
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
            if (cmbxJeepCodes.SelectedItem != null)
            {
                currentJeepCode = cmbxJeepCodes.SelectedItem.ToString();
                JeepCodeDestinations(currentJeepCode);
            }
        }

        private void JeepCodeDestinations(string jeepCode)
        {
            switch (jeepCode)
            {
                case "01K":
                    pbJeepDestination.Image = Resources._01K;
                    break;
                case "01C":
                    pbJeepDestination.Image = Resources._01C;
                    break;
                case "02B":
                    pbJeepDestination.Image = Resources._02B;
                    break;
                case "03A":
                    pbJeepDestination.Image = Resources._03A;
                    break;
                    //03B
                default:
                    pbJeepDestination.Image = Resources._default;
                    break;
            }
        }
    }
}
