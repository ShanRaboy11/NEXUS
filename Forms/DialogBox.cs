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

namespace NEXUS.Forms
{
    public partial class DialogBox : Form
    {
        public DialogBox()
        {
            InitializeComponent();
        }

        private void Pausetimer_Tick(object sender, EventArgs e)
        {
            pbDialogIcon.Enabled = false;
            Pausetimer.Stop();
        }

        public void ShowIcon(string message)
        {
            if(message == "login")
            {
                return;
            }
            else if (message == "fail")
            {
                Pausetimer.Interval = 2000;
                pbDialogIcon.Size = new Size(146, 84);
                pbDialogIcon.Location = new Point(90, 15);
                pbDialogIcon.Image = Resources.Animation___1739888041200;
                lblMessage.Text = "Incorrect username or password.";
            }
            else if (message == "register")
            {
                lblMessage.Text = "Registered Successfully";
            }
            else if(message == "save")
            {
                lblMessage.Text = "Image Succssfully Saved";
            }
            else
            {
                Pausetimer.Enabled = false;
                pbDialogIcon.Image = Resources.Animation___1739888639577;
                lblMessage.Text = "Fill in all required fields.";
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK; 
            this.Close();
        }
    }
}
