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
    public partial class Register2 : Form
    {
        public Register2()
        {
            InitializeComponent();
            rbtnDriver.Parent = pnlRole;
            rbtnPassenger.Parent = pnlRole;
            panel10.Parent = pnlRole;
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            DialogBox dialogBox = new DialogBox();
            LogInForm logInForm = new LogInForm();

            if ((!rbtnFemale.Checked && !rbtnMale.Checked && !rbtnNotSay.Checked) ||
                (!rbtnDriver.Checked && !rbtnPassenger.Checked))
                {

                dialogBox.ShowIcon("blank");
                logInForm.overlayForm(this, dialogBox);
                return;
                }
            List<string> userInfo = new List<string>
             {
                cmbxMonth.Text,
                cmbxDay.Text,
                cmbxYear.Text,
                (rbtnFemale.Checked ? rbtnFemale.Text : rbtnMale.Checked ? rbtnMale.Text : rbtnNotSay.Text)
             };
            dialogBox.ShowIcon("register");
            logInForm.overlayForm(this, dialogBox);
            logInForm.Show();
            this.Close();
        }
    }
}
