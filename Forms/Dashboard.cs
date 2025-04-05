using FontAwesome.Sharp;
using NEXUS.Classes;
using NEXUS.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
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
        Passenger passenger;
        bool sidebarExpand = false;
        private Form currentChildForm;
        private FontAwesome.Sharp.IconButton selectedButton = null;
        private FontAwesome.Sharp.IconButton currentBtn;
        public Dashboard(Passenger currentPassenger)
        {
            InitializeComponent();
            this.passenger = currentPassenger;
            this.DoubleBuffered = true;
            this.Load += (s, e) => btnHome_Click(btnHome, EventArgs.Empty);
            //btnHome_Click(btnHome, EventArgs.Empty);
            string currentName = currentPassenger.Name.Split(' ')[0] + "!";
            lblUserFName.Text = currentName;
            UpdateBalance(currentPassenger.UserID);
            //lblBalance.Text = "₱ " + currentPassenger.WalletAmount.ToString("F2");
            lblPoints.Text = currentPassenger.Points.ToString();
            using (MemoryStream ms = new MemoryStream(currentPassenger.ProfilePicture))
            {
                pbProfilePicture.Image = Image.FromStream(ms);
            }
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
            Scan scan = new Scan(passenger.UserID);

            scan.ShowOverlay(about, null);
            about.FormClosed += (s, args) => this.Show();
            about.Owner = this;
        }

        private void btnScan_Click(object sender, EventArgs e)
        {
            Scan scan = new Scan(passenger.UserID);
            OpenChildForm(scan);
            SelectButton(btnScan);
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            Home home = new Home(passenger);
            SelectButton(btnHome);
            OpenChildForm(home);
        }

        private void btnRoute_Click(object sender, EventArgs e)
        {
            RouteFinder route = new RouteFinder();
            SelectButton(btnRoute);
            OpenChildForm(route);
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            Report report = new Report(passenger.UserID);
            SelectButton(btnReport);
            OpenChildForm(report);
        }

        private void btnHistory_Click(object sender, EventArgs e)
        {
            History history = new History(passenger.UserID);
            SelectButton(btnHistory);
            OpenChildForm(history);
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

        private void btnHome_MouseHover(object sender, EventArgs e)
        {
            HighlightButton(btnHome);
        }

        private void btnHome_MouseLeave(object sender, EventArgs e)
        {
            ResetButton(btnHome);
        }

        private void btnRouteHover_MouseHover(object sender, EventArgs e)
        {
            HighlightButton(btnRoute);
        }

        private void btnRouteHover_MouseLeave(object sender, EventArgs e)
        {
            ResetButton(btnRoute);
        }

        private void btnScanHover_MouseHover(object sender, EventArgs e)
        {
            HighlightButton(btnScan);
        }

        private void btnScanHover_MouseLeave(object sender, EventArgs e)
        {
            ResetButton(btnScan);
        }

        private void btnReport_MouseHover(object sender, EventArgs e)
        {
            HighlightButton(btnReport);
        }

        private void btnReport_MouseLeave(object sender, EventArgs e)
        {
            ResetButton(btnReport);
        }

        private void btnHistory_MouseHover(object sender, EventArgs e)
        {
            HighlightButton(btnHistory);
        }

        private void btnHistory_MouseLeave(object sender, EventArgs e)
        {
            ResetButton(btnHistory);
        }

        private void btnLogout_MouseHover(object sender, EventArgs e)
        {
            HighlightButton(btnLogout);
        }

        private void btnLogout_MouseLeave(object sender, EventArgs e)
        {
            ResetButton(btnLogout);
        }

        public void OpenChildForm(Form childForm)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
                pnlDesktop.Controls.Remove(currentChildForm);
            }

            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.Dock = DockStyle.Fill;

            pnlDesktop.Controls.Add(childForm);
            pnlDesktop.Tag = childForm;

            childForm.BringToFront();
            childForm.Show();
            Application.DoEvents();
        }

        private void pbWheelPoints_Click(object sender, EventArgs e)
        {
            WheelTokens wheelTokens = new WheelTokens();
            Scan scan = new Scan(passenger.UserID);
            scan.ShowOverlay(wheelTokens, null);
            wheelTokens.FormClosed += (s, args) => this.Show();
            wheelTokens.Owner = this;
        }

        private void pbProfile_Click(object sender, EventArgs e)
        {
            Profile profile = new Profile(passenger.Username, passenger.UserType);
            Scan scan = new Scan(passenger.UserID);
            scan.ShowOverlay(profile, null);
        }

        private void btnCashIn_Click(object sender, EventArgs e)
        {
            CashIn cashIn = new CashIn(passenger.UserID, passenger.Name);
            Scan scan = new Scan(passenger.UserID);
            scan.ShowOverlay(cashIn, null);
        }

        public void UpdateBalance(int userID)
        {
            double passengerWallet = 0;
            using (OleDbConnection conn = DatabaseManagement.GetConnection())
            {
                conn.Open();
                string walletQuery = "SELECT Wallet FROM ACCOUNTS WHERE ID = ?";
                using (OleDbCommand cmd = new OleDbCommand(walletQuery, conn))
                {
                    cmd.Parameters.AddWithValue("?", userID);
                    object result = cmd.ExecuteScalar();
                    if (result != null)
                    {
                        passengerWallet = Convert.ToDouble(result);
                    }
                }
                lblBalance.Text = "₱ " + passengerWallet.ToString("F2");
            }
        }

        private void UpdateTransaction()
        {

        }
    }
}