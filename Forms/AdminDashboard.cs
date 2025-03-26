using NEXUS.Classes;
using NEXUS.User_Controls;
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
    public partial class AdminDashboard : Form
    {
        private FontAwesome.Sharp.IconButton selectedButton = null;
        private FontAwesome.Sharp.IconButton currentBtn;
        public AdminDashboard()
        {
            InitializeComponent();
            LoadHomeAdmin();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void AdminDashboard_MouseDown(object sender, MouseEventArgs e)
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
        private void LoadHomeAdmin()
        {
            HomeAdmin homeControl = new HomeAdmin();

            homeControl.Dock = DockStyle.Fill;
            pnlContainer.Controls.Clear();
            pnlContainer.Controls.Add(homeControl);
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            SelectButton(btnHome);
            LoadHomeAdmin();
        }

        private void pbAbout_Click(object sender, EventArgs e)
        {
            About about = new About();
            Scan scan = new Scan(passenger.Username);

            scan.ShowOverlay(about, null);
            about.FormClosed += (s, args) => this.Show();
            about.Owner = this;
        }

        private void btnPassengers_Click(object sender, EventArgs e)
        {
            SelectButton(btnPassengers);
        }

        private void btnDrivers_Click(object sender, EventArgs e)
        {
            SelectButton(btnDrivers);
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            SelectButton(btnReport);
        }

        private void btnTransactions_Click(object sender, EventArgs e)
        {
            SelectButton(btnTransactions);
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            LogInForm logInForm = new LogInForm();
            SelectButton(btnLogout);
            logInForm.Show();
            this.Close();
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
    }
}
