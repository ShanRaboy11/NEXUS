using Microsoft.Win32;
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
using NEXUS.Classes;
using System.Windows.Documents;

namespace NEXUS.Forms
{
    public partial class LogInForm : Form
    {
        private bool isPasswordVisible = false;
        private bool isClicked1 = false, isClicked2 = false;

        public LogInForm()
        {
            InitializeComponent();
            btnLogin.ColorBackground_Pen = Color.FromArgb(24, 60, 114);
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void Login_MouseDown(object sender, MouseEventArgs e)
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

        private void pbPrivacy_Click(object sender, EventArgs e)
        {
            isPasswordVisible = !isPasswordVisible;

            if (tbxEnterPassword.Text == "Password")
            {
                tbxEnterPassword.Text = "";
            }

            if (isPasswordVisible)
            {
                pbPrivacy.Image = Resources.show_eye;
                tbxEnterPassword.UseSystemPasswordChar = false;
                tbxEnterPassword.TabStop = false;
                tbxEnterPassword.Font = new Font("Inter", 12, FontStyle.Regular);
            }
            else
            {
                pbPrivacy.Image = Resources._3844443_disable_eye_inactive_see_show_icon;
                tbxEnterPassword.UseSystemPasswordChar = true;
                tbxEnterPassword.Font = new Font("Inter", 9, FontStyle.Regular);
            }
        }

        private void EnterUsername(object sender, EventArgs e)
        {
            if (isClicked1) return;

            isClicked1 = true;
            tbxEnterUsername.Text = "";
        }

        private void EnterPassword(object sender, EventArgs e)
        {
            if (isClicked2) return;

            isClicked2 = true;
            tbxEnterPassword.Text = "";
            tbxEnterPassword.UseSystemPasswordChar = true;
            tbxEnterPassword.Font = new Font("Inter", 9, FontStyle.Regular);
        }

        private void CopyText(object sender, EventArgs e)
        {
            if (tbxEnterUsername.SelectedText.Length > 0)
            {
                Clipboard.SetText(tbxEnterUsername.SelectedText);
            }
        }

        private void CutText(object sender, EventArgs e)
        {
            if (tbxEnterUsername.SelectedText.Length > 0)
            {
                Clipboard.SetText(tbxEnterUsername.SelectedText);
                tbxEnterUsername.SelectedText = "";
            }
        }

        private void PasteText(object sender, EventArgs e)
        {
            if (Clipboard.ContainsText())
            {
                int selectionStart = tbxEnterUsername.SelectionStart;
                tbxEnterUsername.Text = tbxEnterUsername.Text.Insert(selectionStart, Clipboard.GetText());
                tbxEnterUsername.SelectionStart = selectionStart + Clipboard.GetText().Length;
            }
        }

        private void SelectAllText(object sender, EventArgs e)
        {
            tbxEnterUsername.SelectAll();
        }

        private void tbxPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                btnLogin_Click(sender, EventArgs.Empty);
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            Register register = new Register();
            register.Show();
            this.Close();
        }

        private void pbLogo_Click(object sender, EventArgs e)
        {
            About about = new About();

            about.FormClosed += (s, args) => this.Show();
            about.Owner = this;
            about.Show();
            this.Hide();
        }

        public void overlayForm(Form newForm, Form dialog)
        {
            var overlay = new Form();

            overlay.StartPosition = FormStartPosition.CenterScreen;
            overlay.FormBorderStyle = FormBorderStyle.None;
            overlay.Opacity = 0.5d;
            overlay.BackColor = Color.Black;
            overlay.Size = newForm.Size;
            overlay.Location = this.Location;
            overlay.ShowInTaskbar = false;

            overlay.Show();
            newForm.FormClosed += (s, args) => overlay.Close();
            newForm.Show();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                overlay.Close();
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            DialogBox dialogBox = new DialogBox();

            string username = tbxEnterUsername.Text;
            string password = tbxEnterPassword.Text;
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password) ||
                tbxEnterPassword.Text == "Username" || tbxEnterPassword.Text == "Password")
            {
                dialogBox.ShowIcon("blank");
                overlayForm(this, dialogBox);
                return;
            }

            if (username == "admin")
            {
                if (Cryptography.VerifyAdminPassword(password))
                {
                    dialogBox.ShowIcon("login");
                    overlayForm(this, dialogBox);
                    AdminDashboard adminDashboard = new AdminDashboard();
                    adminDashboard.Show();
                    this.Close();
                }
                else
                {
                    dialogBox.ShowIcon("fail");
                    overlayForm(this, dialogBox);
                    return;
                }
            }
            else
            {
                UserInformation user = Cryptography.VerifyPassword(username, password);

                if (user == null)
                {
                    dialogBox.ShowIcon("fail");
                    overlayForm(this, dialogBox);
                    return;
                }

                if (user is Passenger passenger)
                {
                    dialogBox.ShowIcon("login");
                    overlayForm(this, dialogBox);
                    Dashboard dashboard = new Dashboard(passenger);
                    dashboard.Show();
                    this.Close();
                }
                else if (user is Driver driver)
                {
                    dialogBox.ShowIcon("login");
                    overlayForm(this, dialogBox);
                    DriverDashboard driverDashboard = new DriverDashboard(driver);
                    driverDashboard.Show();
                    this.Close();
                }

                if (chkRememberMe.Checked)
                {
                    Properties.Settings.Default.SavedUser = username;
                    Properties.Settings.Default.SavedPass = password;
                    Properties.Settings.Default.RememberMe = true;
                }
                else
                {
                    // Clear saved credentials if "Remember Me" is unchecked
                    Properties.Settings.Default.SavedUser = string.Empty;
                    Properties.Settings.Default.SavedPass = string.Empty;
                    Properties.Settings.Default.RememberMe = false;
                }

                // Always save settings to persist the RememberMe state
                Properties.Settings.Default.Save();
            }
        }

        private void LogInForm_Load(object sender, EventArgs e)
        {
            Properties.Settings.Default.Reload();
            // Check if "Remember Me" is enabled and populate fields accordingly
            if (Properties.Settings.Default.RememberMe)
            {
                tbxEnterUsername.Text = Properties.Settings.Default.SavedUser;
                tbxEnterPassword.Text = Properties.Settings.Default.SavedPass;
                tbxEnterPassword.UseSystemPasswordChar = true;  // Set password visibility
                chkRememberMe.Checked = true;  // Keep the checkbox checked
            }
            else
            {
                tbxEnterUsername.Text = "Username";
                tbxEnterPassword.Text = "Password";
                chkRememberMe.Checked = false;  // Uncheck the box if "Remember Me" is false
            }
        }

    }
}