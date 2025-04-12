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
        public ForgetPasssword3()
        {
            InitializeComponent();
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
    }
}
