using NEXUS.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NEXUS.Forms
{
    public partial class Dashboard : Form
    {
        bool sidebarExpand = false;
        public Dashboard()
        {
            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void Dashboard_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void Maximize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Maximized;
            else
                this.WindowState = FormWindowState.Normal;
        }

        private void Minimize(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Close(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pbAbout_Click(object sender, EventArgs e)
        {
            About about = new About();
            about.FormClosed += (s, args) => this.Show();
            about.Owner = this;
            about.Show();
            this.Hide();
        }

        private void btnScan_Click(object sender, EventArgs e)
        {
            QRScannerForm qRScannerForm = new QRScannerForm();
            qRScannerForm.FormClosed += (s, args) => this.Show();
            qRScannerForm.Owner = this;
            qRScannerForm.Show();
            this.Hide();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard();
            dashboard.Show();
            this.Close();
        }

        private void btnRoute_Click(object sender, EventArgs e)
        {

        }

        private void btnReport_Click(object sender, EventArgs e)
        {

        }

        private void btnRate_Click(object sender, EventArgs e)
        {

        }

        private void btnHistory_Click(object sender, EventArgs e)
        {

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {

        }

        private void SidebarTransition_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                pnlSidebar.Width -= 10;
                pbAbout.Location = new Point(15 + (pnlSidebar.Width - 88) * 40 / 90, 25);

                if (pnlSidebar.Width <= 88)
                {
                    SidebarTransition.Stop();
                    sidebarExpand = false;
                    pbAbout.Location = new Point(15, 25);
                }
            }
            else
            {
                pnlSidebar.Width += 10;
                pbAbout.Location = new Point(15 + (pnlSidebar.Width - 88) * 40 / 90, 25);

                if (pnlSidebar.Width >= 178)
                {
                    SidebarTransition.Stop();
                    sidebarExpand = true;
                    pbAbout.Location = new Point(55, 25);
                }
            }
        }


        private void pnlSidebar_Click(object sender, EventArgs e)
        {
            SidebarTransition.Start();
        }

        private void btnHome_MouseHover(object sender, EventArgs e)
        {
            btnHomeHover.Visible = true;
            btnHomeHover.Image = Resources.home_animation;
        }

        private void btnHome_MouseLeave(object sender, EventArgs e)
        {
            btnHomeHover.Visible = false;
        }
    }
}