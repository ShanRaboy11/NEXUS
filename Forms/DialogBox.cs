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
            if(message == "successful")
            {
                return;
            }
            else if (message == "fail")
            {
                pbDialogIcon.Image = Resources.Animation___1739888041200;
                lblMessage.Text = "Incorrect username or password.";
            }
            else
            {
                pbDialogIcon.Image = Resources.Animation___1739888639577;
                lblMessage.Text = "Fill in all required fields.";
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard();
            dashboard.Show();

            this.DialogResult = DialogResult.OK; 
            this.Close();
        }
    }
}
