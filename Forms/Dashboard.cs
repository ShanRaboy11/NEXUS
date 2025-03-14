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
        private Form currentChildForm;
        public Dashboard()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
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
            OpenChildForm(qRScannerForm);
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            OpenChildForm(home);
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
            btnHome.ButtonImage = Resources.home;
        }

        private void btnHome_MouseLeave(object sender, EventArgs e)
        {
            btnHome.ButtonImage = Resources.home_normal;
        }

        private void btnRouteHover_MouseHover(object sender, EventArgs e)
        {
            btnRoute.ButtonImage = Resources.route_hover1;
        }

        private void btnRouteHover_MouseLeave(object sender, EventArgs e)
        {
            btnRoute.ButtonImage = Resources.route_normal;
        }

        private void btnScanHover_MouseHover(object sender, EventArgs e)
        {
            btnScan.ButtonImage = Resources.scan_hover;
        }

        private void btnScanHover_MouseLeave(object sender, EventArgs e)
        {
            btnScan.ButtonImage= Resources.scan_normal;
        }

        private void btnReport_MouseHover(object sender, EventArgs e)
        {
            btnReport.ButtonImage = Resources.report_hover2;
        }

        private void btnReport_MouseLeave(object sender, EventArgs e)
        {
            btnReport.ButtonImage = Resources.emergency__1_;
        }

        private void btnRate_MouseHover(object sender, EventArgs e)
        {
            btnRate.ButtonImage = Resources.rate_hover2;
        }

        private void btnRate_MouseLeave(object sender, EventArgs e)
        {
            btnRate.ButtonImage = Resources.rate_normal;
        }

        private void btnHistory_MouseHover(object sender, EventArgs e)
        {
            btnHistory.ButtonImage = Resources.history_hover;
        }

        private void btnHistory_MouseLeave(object sender, EventArgs e)
        {
            btnHistory.ButtonImage = Resources.history_normal;
        }

        private void btnLogout_MouseHover(object sender, EventArgs e)
        {
            btnLogout.ButtonImage = Resources.logout_hover1;
        }

        private void btnLogout_MouseLeave(object sender, EventArgs e)
        {
            btnLogout.ButtonImage= Resources.logout_normal;
        }

        private void OpenChildForm(Form childForm)
        {
            //currentChildForm = null;
            if (currentChildForm != null)
            {
                // Close and remove the current child form from the panel before adding a new one
                currentChildForm.Close();
                pnlDesktop.Controls.Remove(currentChildForm);
            }

            currentChildForm = childForm;
            childForm.TopLevel = false; // Ensure the form is not a top-level window
            childForm.Dock = DockStyle.Fill;

            pnlDesktop.Controls.Add(childForm);
            pnlDesktop.Tag = childForm;

            childForm.BringToFront();
            childForm.Show();
        }

    }
}