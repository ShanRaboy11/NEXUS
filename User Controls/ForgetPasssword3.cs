using NEXUS.Classes;
using NEXUS.Forms;
using NEXUS.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NEXUS.User_Controls
{
    public partial class ForgetPasssword3 : UserControl
    {
        bool isPasswordVisible = false, isPasswordVisible1 = false, isClicked = false, isClicked1 = false;
        string userEmail;
        public ForgetPasssword3(string email)
        {
            InitializeComponent();
            this.userEmail = email;
        }

        private void pbPrivacy1_Click(object sender, EventArgs e)
        {

            isPasswordVisible = !isPasswordVisible;

            if (tbxNewPassword.Text == "New Password")
            {
                tbxNewPassword.Text = "";
            }

            if (isPasswordVisible)
            {
                pbPrivacy1.Image = Resources.show_eye;
                tbxNewPassword.UseSystemPasswordChar = false;
                tbxNewPassword.TabStop = false;
                tbxNewPassword.Font = new Font("Inter", 12, FontStyle.Regular);
            }
            else
            {
                pbPrivacy1.Image = Resources._3844443_disable_eye_inactive_see_show_icon;
                tbxNewPassword.UseSystemPasswordChar = true;
                tbxNewPassword.Font = new Font("Inter", 9, FontStyle.Regular);
            }

        }

        private void tbxNewPassword_Click(object sender, EventArgs e)
        {
            if (isClicked) return;

            isClicked = true;
            tbxNewPassword.Text = "";
            tbxNewPassword.UseSystemPasswordChar = true;
            tbxNewPassword.Font = new Font("Inter", 9, FontStyle.Regular);
        }

        private void tbxConfirmPassword_Click(object sender, EventArgs e)
        {
            if (isClicked1) return;

            isClicked1 = true;
            tbxConfirmPassword.Text = "";
            tbxConfirmPassword.UseSystemPasswordChar = true;
            tbxConfirmPassword.Font = new Font("Inter", 9, FontStyle.Regular);
        }

        private void pbPrivacy2_Click(object sender, EventArgs e)
        {
            isPasswordVisible1 = !isPasswordVisible1;

            if (tbxConfirmPassword.Text == "Confirm Password")
            {
                tbxConfirmPassword.Text = "";
            }

            if (isPasswordVisible1)
            {
                pbPrivacy2.Image = Resources.show_eye;
                tbxConfirmPassword.UseSystemPasswordChar = false;
                tbxConfirmPassword.TabStop = false;
                tbxConfirmPassword.Font = new Font("Inter", 12, FontStyle.Regular);
            }
            else
            {
                pbPrivacy2.Image = Resources._3844443_disable_eye_inactive_see_show_icon;
                tbxConfirmPassword.UseSystemPasswordChar = true;
                tbxConfirmPassword.Font = new Font("Inter", 9, FontStyle.Regular);
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            DialogBox dialogBox = new DialogBox();
            if (tbxNewPassword.Text == tbxConfirmPassword.Text)
            {
                string newPassword = Cryptography.ToSHA256(tbxNewPassword.Text);
                DatabaseManagement.UpdatePassword(newPassword, userEmail);

                Form parentForm = this.FindForm();
                if (parentForm != null)
                {
                    dialogBox.ShowIcon("password updated");
                    if (dialogBox.ShowDialog() == DialogResult.OK)
                    {
                        dialogBox.Close();
                        parentForm.Close();
                    }
                }
            }
            else
            {
                dialogBox.ShowIcon("passwords mismatch");
                dialogBox.ShowDialog();
            }

        }
    }
}
