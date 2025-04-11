using NEXUS.User_Controls;
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
    public partial class Information : Form
    {
        private FontAwesome.Sharp.IconButton selectedButton = null;
        private FontAwesome.Sharp.IconButton currentBtn;
        public Information()
        {
            InitializeComponent();
            btnPUV_Click(btnPUV, EventArgs.Empty);
        }

        private void SelectButton(FontAwesome.Sharp.IconButton button)
        {
            if (selectedButton != null)
            {
                selectedButton.BackColor = Color.White;
                selectedButton.ForeColor = Color.Black;
                selectedButton.Font = new(selectedButton.Font.FontFamily, 11, selectedButton.Font.Style);
            }

            selectedButton = button;
            selectedButton.BackColor = Color.FromArgb(0, 229, 255);
            selectedButton.ForeColor = Color.FromArgb(24, 60, 114);
            selectedButton.Font = new(selectedButton.Font.FontFamily, 12, selectedButton.Font.Style);
        }

        private void pbClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPUV_Click(object sender, EventArgs e)
        {
            PUV pUV = new PUV();

            pUV.Dock = DockStyle.Fill;
            pnlBG.Controls.Clear();
            pnlBG.Controls.Add(pUV);
            SelectButton(btnPUV);
        }

        private void btnPassengers_Click(object sender, EventArgs e)
        {
            PassengerInfo passengerInfo = new PassengerInfo();

            passengerInfo.Dock = DockStyle.Fill;
            pnlBG.Controls.Clear();
            pnlBG.Controls.Add(passengerInfo);
            SelectButton(btnPassengers);
        }

        private void btnDrivers_Click(object sender, EventArgs e)
        {
            DriverInfo driverInfo = new DriverInfo();

            driverInfo.Dock = DockStyle.Fill;
            pnlBG.Controls.Clear();
            pnlBG.Controls.Add(driverInfo);
            SelectButton(btnDrivers);
        }

        private void btnFare_Click(object sender, EventArgs e)
        {
            FareMatrix fareMatrix = new FareMatrix();

            fareMatrix.Dock = DockStyle.Fill;
            pnlBG.Controls.Clear();
            pnlBG.Controls.Add(fareMatrix);
            SelectButton(btnFare);
        }

        private void btnLTFRB_Click(object sender, EventArgs e)
        {
            LTFRB lTFRB = new LTFRB();

            lTFRB.Dock = DockStyle.Fill;
            pnlBG.Controls.Clear();
            pnlBG.Controls.Add(lTFRB);
            SelectButton(btnLTFRB);
        }
    }
}
