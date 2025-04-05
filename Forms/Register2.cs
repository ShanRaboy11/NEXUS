using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NEXUS.Classes;

namespace NEXUS.Forms
{
    public partial class Register2 : Form
    {
        private Image attachedImage1;
        bool increase = false;
        private UserRegistrationData userData;
        public Register2(UserRegistrationData data)
        {
            InitializeComponent();
            rbtnDriver.Parent = pnlRole;
            rbtnPassenger.Parent = pnlRole;
            panel10.Parent = pnlRole;
            rbtnStudent.Parent = pnlClassification;
            panel7.Parent = pnlClassification;
            rbtnSenior.Parent = pnlClassification;
            rbtnRegular.Parent = pnlClassification;
            rbtnRegular.BringToFront();
            rbtnRegular.Location = new Point(357, 16);
            this.Size = new System.Drawing.Size(524, 495);
            lblNote.Location = new System.Drawing.Point(41, 406);
            btnSignUp.Location = new System.Drawing.Point(152, 439);
            pnlPlate.Parent = this;
            pnlPlate.Location = new Point(30, 330);
            userData = data;
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            DialogBox dialogBox = new DialogBox();
            LogInForm logInForm = new LogInForm();

            if(!rbtnPassenger.Checked && !rbtnDriver.Checked)
            {
                dialogBox.ShowIcon("blank");
                logInForm.overlayForm(this, dialogBox);
                return;
            }
            else if(rbtnPassenger.Checked)
            {
                if((!rbtnStudent.Checked && !rbtnSenior.Checked && !rbtnRegular.Checked) || cmbxMonth.Text == "Month" ||
                    cmbxDay.Text == "Day" || cmbxYear.Text == "Year" || (lblFileName.Text == "Attach ID" && rbtnStudent.Checked && rbtnSenior.Checked))
                {
                    dialogBox.ShowIcon("blank");
                    logInForm.overlayForm(this, dialogBox);
                    return;
                }     
                else
                    SaveCredentials();
            }
            else if(rbtnDriver.Checked)
            {
                if(string.IsNullOrEmpty(tbxPlateNumber.Text) || cmbxMonth.Text == "Month" ||
                    cmbxDay.Text == "Day" || cmbxYear.Text == "Year" || lblFileName.Text == "Attach ID" || tbxJeep.Text == "")
                {
                    dialogBox.ShowIcon("blank");
                    logInForm.overlayForm(this, dialogBox);
                    return;
                }
                else
                    SaveCredentials();
            }
        }

        private void SaveCredentials()
        {
            DialogBox dialogBox = new DialogBox();
            LogInForm logInForm = new LogInForm();
            Passenger passenger = new Passenger(0, null, null, null, "i", null, null, null, null, null, null, 0.0, 0, null);
            Driver driver = new Driver(0, null, null, null, "i", null, null, null, null, null, null, 0.0, null, null, null, null);
            string fullName = userData.FName + " " + userData.LName;
            string birthday = cmbxMonth.Text + " " + cmbxDay.Text + ", " + cmbxYear.Text;
            byte[] userphoto = null;
            if (rbtnPassenger.Checked)
            {
                userphoto = passenger.DefaultProfilePicture(userData.Gender);
                Passenger newPassenger = new Passenger
                (
                    0, fullName, userData.Email, userData.UserName, userData.Password,
                    userData.Gender, rbtnPassenger.Text, birthday,
                    (rbtnStudent.Checked ? rbtnStudent.Text : rbtnSenior.Checked ? rbtnSenior.Text : rbtnRegular.Checked ? rbtnRegular.Text : "None"),
                    (rbtnStudent.Checked || rbtnSenior.Checked ? attachedImageBytes : rbtnRegular.Checked ? null : new byte[0]), 
                    userphoto, 0, 0.0, (rbtnStudent.Checked || rbtnSenior.Checked ? "Pending" : "Verified")
                );
                newPassenger.SaveToDatabase();
            }
            else if (rbtnDriver.Checked)
            {
                userphoto = driver.DefaultProfilePicture(userData.Gender);
                Driver newDriver = new Driver
                (
                    0, fullName, userData.Email, userData.UserName, userData.Password,
                    userData.Gender, rbtnDriver.Text, birthday, attachedImageBytes, tbxPlateNumber.Text, 
                    userphoto, 0, null, tbxRoute.SelectedItem.ToString(), tbxJeep.SelectedItem.ToString(), "Pending"
                );
                newDriver.SaveToDatabase();
            }

            dialogBox.ShowIcon("register");
            logInForm.overlayForm(this, dialogBox);
            logInForm.Show();
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            LogInForm logInForm = new LogInForm();
            this.Close();
            logInForm.Show();
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

        private void rbtnStudent_CheckedChanged(object sender, EventArgs e)
        {
            lblAttachment.Visible = true;
            lblFileName.Visible = true;
            pnlAttach.Visible = true;
            btnAttach.Visible = true;
            this.Size = new System.Drawing.Size(506, 590);
            lblNote.Location = new System.Drawing.Point(46, 500);
            btnSignUp.Location = new System.Drawing.Point(157, 533);
            btnBack.Location = new System.Drawing.Point(15, 534);
            if (!increase)
            {
                this.Location = new System.Drawing.Point(this.Location.X, this.Location.Y - 47);
                increase = true;
            }
        }

        private void rbtnSenior_CheckedChanged(object sender, EventArgs e)
        {
            lblAttachment.Visible = true;
            lblFileName.Visible = true;
            pnlAttach.Visible = true;
            btnAttach.Visible = true;
            this.Size = new System.Drawing.Size(506, 590);
            lblNote.Location = new System.Drawing.Point(46, 500);
            btnSignUp.Location = new System.Drawing.Point(157, 533);
            btnBack.Location = new System.Drawing.Point(15, 534);
            if (!increase)
            {
                this.Location = new System.Drawing.Point(this.Location.X, this.Location.Y - 47);
                increase = true;
            }
        }

        private void rbtnRegular_CheckedChanged(object sender, EventArgs e)
        {
            lblAttachment.Visible = false;
            lblFileName.Visible = false;
            pnlAttach.Visible = false;
            btnAttach.Visible = false;
            this.Size = new System.Drawing.Size(504, 495);
            lblNote.Location = new System.Drawing.Point(41, 406);
            btnSignUp.Location = new System.Drawing.Point(152, 439);
            btnBack.Location = new System.Drawing.Point(15, 440);
            if (increase)
            {
                this.Location = new System.Drawing.Point(this.Location.X, this.Location.Y + 47);
                increase = false;
            }
        }

        private Image attachedImage;
        private byte[] attachedImageBytes;
        private readonly Attachment attachmentHandler = new Attachment();

        private void btnAttach_Click(object sender, EventArgs e)
        {
            Passenger passenger = new Passenger(0, null, null, null, userData.Password, null, null, null, null, null, null, 0.0, 0, null);
            lblFileName.Text = "";
            lblFileName.ForeColor = Color.Black;
            lblFileName.Font = new Font(lblFileName.Font, FontStyle.Underline);

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    attachedImage = Image.FromFile(openFileDialog.FileName);
                    attachedImageBytes = attachmentHandler.ConvertImageToByteArray(attachedImage);

                    lblFileName.Text = Path.GetFileName(openFileDialog.FileName);
                    lblFileName.ForeColor = Color.Blue;
                    lblFileName.Cursor = Cursors.Hand;
                    lblFileName.Font = new Font(lblFileName.Font, FontStyle.Underline);

                    // Save to database
                    passenger.SaveImageToDatabase(attachedImageBytes, 0);
                }
            }
        }

        private void lblFileName_Click(object sender, EventArgs e)
        {
            if (attachedImage != null)
            {
                DisplayImage displayImage = new DisplayImage(attachedImageBytes, "register");
            }
        }


        private void btnBack_Click(object sender, EventArgs e)
        {
            Register register = new Register();
            register.Show();
            this.Close();
        }

        private void rbtnDriver_CheckedChanged(object sender, EventArgs e)
        {
            label6.Visible = true;
            lblAttachment.Text = "Driver's License";
            tbxPlateNumber.Visible = true;
            pnlPlate.BringToFront();
            tbxPlateNumber.BringToFront();
            pnlPlate.Visible = true;
            label4.Visible = false;
            pnlClassification.Visible = false;
            lblAttachment.Visible = true;
            lblFileName.Visible = true;
            pnlAttach.Visible = true;
            btnAttach.Visible = true;
            lblJeep.Visible = true;
            pnlJeep.Visible = true;
            tbxJeep.Visible = true;
            lblRoute.Visible = true;
            tbxRoute.Visible = true;
            panel1.Visible = true;
            this.Size = new System.Drawing.Size(526, 590);
            lblNote.Location = new System.Drawing.Point(46, 500);
            btnSignUp.Location = new System.Drawing.Point(157, 533);
            btnBack.Location = new System.Drawing.Point(15, 534);
            if (!increase)
            {
                this.Location = new System.Drawing.Point(this.Location.X, this.Location.Y - 47);
                increase = true;
            }
        }

        private void rbtnPassenger_CheckedChanged(object sender, EventArgs e)
        {
            lblAttachment.Text = "Attachment";
            tbxPlateNumber.Visible = false;
            pnlPlate.Visible = false;
            label4.Visible = true;
            pnlClassification.Visible = true;
            lblAttachment.Visible = false;
            lblFileName.Visible = false;
            pnlAttach.Visible = false;
            btnAttach.Visible = false;
            lblJeep.Visible = false;
            pnlJeep.Visible = false;
            tbxJeep.Visible = false;
            lblRoute.Visible = false;
            tbxRoute.Visible = false;
            panel1.Visible = false;
            this.Size = new System.Drawing.Size(524, 495);
            lblNote.Location = new System.Drawing.Point(41, 406);
            btnSignUp.Location = new System.Drawing.Point(152, 439);
            btnBack.Location = new System.Drawing.Point(15, 440);
            if (increase)
            {
                this.Location = new System.Drawing.Point(this.Location.X, this.Location.Y + 47);
                increase = false;
            }
        }
    }
}
