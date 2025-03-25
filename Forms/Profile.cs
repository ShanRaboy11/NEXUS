using NEXUS.Classes;
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
    public partial class Profile : Form
    {
        public Profile(string currentUser, string userType)
        {
            InitializeComponent();
            DisplayInfo(currentUser, userType);
        }

        private void DisplayInfo(string userName, string type)
        {
            UserInformation userInformation = Cryptography.GetUserInfo(userName, type);

            if(userInformation is Passenger passenger)
            {
                lblUserName.Text = passenger.Name;
                lblClassification.Text = passenger.Classification;
                lblGender.Text = passenger.Gender;
                lblUserType.Text = passenger.UserType;
                lblEmail.Text = passenger.Email;
                lblUser.Text = passenger.Username;
                //lblPassword.Text = passenger.
                lblBirthday.Text = passenger.Birthday;
                lblTokens.Text = passenger.Points.ToString();
            }
            else if(userInformation is Driver driver)
            {
                lblUserName.Text = driver.Name;
                lblClassification.Text = driver.PlateNumber;
                lblGender.Text = driver.Gender;
                lblUserType.Text = driver.UserType;
                lblEmail.Text = driver.Email;
                lblUser.Text = driver.Username;
                //lblPassword.Text = passenger.
                lblBirthday.Text = driver.Birthday;
                lblTokens.Text = "₱ " + driver.WalletAmount.ToString("F2");
            }
        }

        private void pbCloseee_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
