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
using NEXUS;

namespace NEXUS.Forms
{
    public partial class Register : Form
    {
        LogInForm logInForm = new LogInForm();
        private bool isPasswordVisible = false;
        public Register()
        {
            InitializeComponent();
            
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void Register_MouseDown(object sender, MouseEventArgs e)
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
            this.Close();
        }

        private void EnterFirstname(object sender, EventArgs e)
        {
            tbxNewFirstName.Text = "";
        }

        private void EnterLastname(object sender, EventArgs e)
        {
            tbxNewLastName.Text = "";
        }

        private void EnterUsername(object sender, EventArgs e)
        {
            tbxNewUserName.Text = "";
        }

        private void tbxEmail_Click(object sender, EventArgs e)
        {
            tbxEmail.Text = "";
        }

        private void EnterPassword(object sender, EventArgs e)
        {
            tbxNewPassword.Text = "";
            tbxNewPassword.UseSystemPasswordChar = true;
            tbxNewPassword.Font = new Font("Inter", 9, FontStyle.Regular);
        }

        private void pbPrivacy1_Click(object sender, EventArgs e)
        {
            isPasswordVisible = !isPasswordVisible;

            if (isPasswordVisible)
            {
                pbPrivacy1.Image = Resources.show_eye;
                tbxNewPassword.UseSystemPasswordChar = false;
                tbxNewPassword.Font = new Font("Inter", 12, FontStyle.Regular);
            }
            else
            {
                pbPrivacy1.Image = Resources._3844443_disable_eye_inactive_see_show_icon;
                tbxNewPassword.UseSystemPasswordChar = true;
                tbxNewPassword.Font = new Font("Inter", 9, FontStyle.Regular);
            }
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            DialogBox dialogBox = new DialogBox();
            Register2 register2 = new Register2();

            if (string.IsNullOrWhiteSpace(tbxNewFirstName.Text) ||
                string.IsNullOrWhiteSpace(tbxNewLastName.Text) ||
                string.IsNullOrWhiteSpace(tbxNewUserName.Text) ||
                string.IsNullOrWhiteSpace(tbxNewPassword.Text))
            {

                dialogBox.ShowIcon("blank");
                logInForm.overlayForm(this, dialogBox);
                return;
            }

            List<string> userInfo = new List<string>
             {
                tbxNewFirstName.Text,
                tbxNewLastName.Text,
                tbxNewUserName.Text,
                tbxNewPassword.Text,
                (rbtnFemale.Checked ? rbtnFemale.Text : rbtnMale.Checked ? rbtnMale.Text : rbtnNotSay.Text)
             };

            //add here for initializing the registered infos using userInfo[0];

            register2.Show();
            this.Close();
        }
    }
}