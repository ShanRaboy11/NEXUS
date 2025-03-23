using NEXUS.Classes;
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
    public partial class DriverDashboard : Form
    {
        Driver driver;
        Form currentChildForm1;
        bool sidebarExpand = false;
        private FontAwesome.Sharp.IconButton selectedButton = null;
        private FontAwesome.Sharp.IconButton currentBtn;
        public DriverDashboard(Driver currentDriver)
        {
            InitializeComponent();
            this.driver = currentDriver;
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
            Scan scan = new Scan(driver.Username);

            scan.ShowOverlay(about, null);
            about.FormClosed += (s, args) => this.Show();
            about.Owner = this;
        }

        private void btnScan_Click(object sender, EventArgs e)
        {
            QRCodeGeneratorform qRCodeGeneratorform = new QRCodeGeneratorform();
            SelectButton(btnScan1);
            OpenChildForm(qRCodeGeneratorform);
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            Home home = new Home(driver);
            SelectButton(btnHome1);
            OpenChildForm(home);
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            Report report = new Report();
            SelectButton(btnReport1);
            OpenChildForm(report);
        }

        private void btnGraph_Click(object sender, EventArgs e)
        {
            Analytics analytics = new Analytics();
            SelectButton(btnGraph);
            OpenChildForm(analytics);
        }

        private void btnHistory_Click(object sender, EventArgs e)
        {
            DriverHistory driverHistory = new DriverHistory();
            SelectButton(btnHistory1);
            OpenChildForm(driverHistory);
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            LogInForm logInForm = new LogInForm();
            SelectButton(btnLogout1);
            logInForm.Show();
            this.Close();
        }

        private void SidebarTransition_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                pnlSidebar.Width -= 10;
                pbAbout1.Location = new Point(15 + (pnlSidebar.Width - 88) * 40 / 90, 25);

                if (pnlSidebar.Width <= 88)
                {
                    SidebarTransition.Stop();
                    sidebarExpand = false;
                    pbAbout1.Location = new Point(15, 25);
                }
            }
            else
            {
                pnlSidebar.Width += 10;
                pbAbout1.Location = new Point(15 + (pnlSidebar.Width - 88) * 40 / 90, 25);

                if (pnlSidebar.Width >= 178)
                {
                    SidebarTransition.Stop();
                    sidebarExpand = true;
                    pbAbout1.Location = new Point(55, 25);
                }
            }
        }


        private void pnlSidebar_Click(object sender, EventArgs e)
        {
            SidebarTransition.Start();
        }

        private void HighlightButton(FontAwesome.Sharp.IconButton button)
        {
            if (selectedButton != button)
            {
                button.BackColor = Color.FromArgb(38, 36, 68);
                button.IconColor = Color.FromArgb(0, 229, 255);
                button.ForeColor = Color.White;
                button.Size = new Size(190, 60);
            }
        }

        private void ResetButton(FontAwesome.Sharp.IconButton button)
        {
            if (selectedButton != button)
            {
                button.IconColor = Color.Black;
                button.BackColor = Color.White;
                button.ForeColor = Color.Black;
                button.Size = new Size(185, 43);
            }
        }

        private void SelectButton(FontAwesome.Sharp.IconButton button)
        {
            if (selectedButton != null)
            {
                selectedButton.IconColor = Color.Black;
                selectedButton.BackColor = Color.White;
                selectedButton.ForeColor = Color.Black;
                selectedButton.Size = new Size(180, 50);
            }

            selectedButton = button;
            button.BackColor = Color.FromArgb(38, 36, 68);
            button.IconColor = Color.FromArgb(0, 229, 255);
            button.ForeColor = Color.White;
            button.Size = new Size(190, 60);
        }

        private void btnHome1_MouseHover(object sender, EventArgs e)
        {
            HighlightButton(btnHome1);
        }

        private void btnHome1_MouseLeave(object sender, EventArgs e)
        {
            ResetButton(btnHome1);
        }

        private void btnScan1Hover_MouseHover(object sender, EventArgs e)
        {
            HighlightButton(btnScan1);
        }

        private void btnScanHover_MouseLeave(object sender, EventArgs e)
        {
            ResetButton(btnScan1);
        }

        private void btnReport1_MouseHover(object sender, EventArgs e)
        {
            HighlightButton(btnReport1);
        }

        private void btnReport1_MouseLeave(object sender, EventArgs e)
        {
            ResetButton(btnReport1);
        }

        private void btnHistory1_MouseHover(object sender, EventArgs e)
        {
            HighlightButton(btnHistory1);
        }

        private void btnHistory1_MouseLeave(object sender, EventArgs e)
        {
            ResetButton(btnHistory1);
        }

        private void btnLogout1_MouseHover(object sender, EventArgs e)
        {
            HighlightButton(btnLogout1);
        }

        private void btnLogout1_MouseLeave(object sender, EventArgs e)
        {
            ResetButton(btnLogout1);
        }

        public void OpenChildForm(Form childForm)
        {
            if (currentChildForm1 != null)
            {
                currentChildForm1.Close();
                pnlDesktop1.Controls.Remove(currentChildForm1);
            }

            currentChildForm1 = childForm;
            childForm.TopLevel = false;
            childForm.Dock = DockStyle.Fill;

            pnlDesktop1.Controls.Add(childForm);
            pnlDesktop1.Tag = childForm;

            childForm.BringToFront();
            childForm.Show();
            Application.DoEvents();
        }

        private void pbProfile1_Click(object sender, EventArgs e)
        {
            Profile profile = new Profile();
            Scan scan = new Scan(driver.Username);

            scan.ShowOverlay(profile, null);
        }
    }
}
