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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace NEXUS.Forms
{
    public partial class Profile : Form
    {
        UserInformation userInformation;
        bool edit = false;
        public Profile(string currentUser, string userType)
        {
            InitializeComponent();
            this.userInformation = Cryptography.GetUserInfo(currentUser, userType);
            DisplayInfo();
        }

        private void DisplayInfo()
        {

            if (userInformation is Passenger passenger)
            {
                using (MemoryStream ms = new MemoryStream(passenger.ProfilePicture))
                {
                    pbProfilePicture.Image = Image.FromStream(ms);
                }
                lblUserName.Text = passenger.Name;
                lblClassification.Text = passenger.Classification;
                lblGender.Text = passenger.Gender;
                lblUserType.Text = passenger.UserType;
                lblEmail.Text = passenger.Email;
                lblUser.Text = passenger.Username;
                lblBirthday.Text = passenger.Birthday;
                lblTokens.Text = passenger.Points.ToString("F1");
                lblStatus.Text = passenger.Status;
                if (passenger.Classification != "Regular")
                {
                    btnAttachment.Visible = true;
                }
            }
            else if (userInformation is Driver driver)
            {
                using (MemoryStream ms = new MemoryStream(driver.ProfilePicture))
                {
                    pbProfilePicture.Image = Image.FromStream(ms);
                }
                lblUserName.Text = driver.Name;
                lblClassification.Text = driver.PlateNumber;
                lblGender.Text = driver.Gender;
                lblUserType.Text = driver.UserType;
                lblEmail.Text = driver.Email;
                lblUser.Text = driver.Username;
                lblBirthday.Text = driver.Birthday;
                lblTokens.Text = driver.Route;
                label3.Text = "Route";
                lblStatus.Text = driver.Status;
                btnAttachment.Visible = true;
            }
        }

        private void pbCloseee_Click(object sender, EventArgs e)
        {
            Form parentForm = this.FindForm();
            if (userInformation.UserType == "Passenger")
            {
                parentForm.FormClosed += (s, args) =>
                {
                    Dashboard existingDashboard = Application.OpenForms.OfType<Dashboard>().FirstOrDefault();
                    if (existingDashboard != null)
                    {
                        existingDashboard.UpdateProfilePicture(userInformation.UserID);
                    }
                };
            }
            else
            {
                parentForm.FormClosed += (s, args) =>
                {
                    DriverDashboard existingDashboard = Application.OpenForms.OfType<DriverDashboard>().FirstOrDefault();
                    if (existingDashboard != null)
                    {
                        existingDashboard.UpdateProfilePicture(userInformation.UserID);
                    }
                };
            }
            this.Close();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void btnEditProfile_Click(object sender, EventArgs e)
        {
            if (!edit)
            {
                pbChangePic.Visible = true;
                edit = true;
                btnEditProfile.TextButton = "Save Changes";
                DatabaseManagement.UpdateAccountUsername(userInformation.UserID, lblUser.Text);
            }
            else
            {
                pbChangePic.Visible = false;
                edit = false;
                btnEditProfile.TextButton = "Edit Profile";
                this.userInformation = Cryptography.GetUserInfo(userInformation.Username, userInformation.UserType);
                DisplayInfo();
            }
        }

        private void btnAttachment_Click(object sender, EventArgs e)
        {
            if (edit && userInformation.Status != "Verified")
            {
                using (OpenFileDialog openFileDialog = new OpenFileDialog())
                {
                    openFileDialog.Title = "Select an image";
                    openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";

                    if (openFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        Image selectedImage = Image.FromFile(openFileDialog.FileName);
                        Attachment attachment = new Attachment();
                        byte[] imageBytes = attachment.ConvertImageToByteArray(selectedImage);

                        DatabaseManagement.UpdateAccountAttachment(userInformation.UserID, imageBytes);

                    }
                }
                DatabaseManagement.ResubmitValidID(userInformation.UserID);
            }
            else
            {
                if (userInformation.Attachment != null)
                {
                    Scan scan = new Scan(userInformation.UserID);
                    DisplayImage displayImage = new DisplayImage(userInformation.Attachment, null);
                    scan.ShowOverlay(displayImage, null);
                }
            }
        }

        private void lblUser_Click(object sender, EventArgs e)
        {
            if (edit)
            {
                lblUser.Text = "";
            }
        }

        private void pbChangePic_Click(object sender, EventArgs e)
        {
            if (edit)
            {
                using (OpenFileDialog openFileDialog = new OpenFileDialog())
                {
                    openFileDialog.Title = "Select an image";
                    openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";

                    if (openFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        Image selectedImage = Image.FromFile(openFileDialog.FileName);

                        pbProfilePicture.Image = selectedImage;

                        Attachment attachment = new Attachment();
                        byte[] imageBytes = attachment.ConvertImageToByteArray(selectedImage);

                        DatabaseManagement.UpdateAccountProfilePic(userInformation.UserID, imageBytes);
                    }
                }
            }
        }

    }
}
