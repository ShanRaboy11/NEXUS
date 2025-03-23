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
            this.Size = new System.Drawing.Size(504, 495);
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

            if ((!rbtnStudent.Checked && !rbtnSenior.Checked && !rbtnRegular.Checked) ||
                (!rbtnDriver.Checked && !rbtnPassenger.Checked))
            {

                dialogBox.ShowIcon("blank");
                logInForm.overlayForm(this, dialogBox);
                return;
            }
            else
            {
                string fullName = userData.FName + " " + userData.LName;
                string birthday = cmbxMonth.Text + cmbxDay.Text + cmbxYear;
                if (rbtnPassenger.Checked)
                {
                    Passenger newPassenger = new Passenger
                    (
                        fullName, userData.Email, userData.UserName, userData.Password, 
                        userData.Gender, rbtnPassenger.Text, birthday, 
                        (rbtnStudent.Checked ? rbtnStudent.Text : rbtnSenior.Checked ? rbtnSenior.Text : rbtnRegular.Checked ? rbtnRegular.Text : "None"), 
                        lblFileName.Text
                    );
                }
                else if(rbtnDriver.Checked)
                {
                    Driver newDriver = new Driver
                    (
                        fullName, userData.Email, userData.UserName, userData.Password,
                        userData.Gender, rbtnDriver.Text, birthday, tbxPlateNumber.Text,
                        lblFileName.Text
                    );
                }

                dialogBox.ShowIcon("register");
                logInForm.overlayForm(this, dialogBox);
                logInForm.Show();
                this.Close();
            }
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

        private void btnAttach_Click(object sender, EventArgs e)
        {
            lblFileName.Text = "";
            lblFileName.ForeColor = Color.Black;
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";
                openFileDialog.Title = "Select an Image";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    attachedImage1 = Image.FromFile(openFileDialog.FileName);

                    lblFileName.Text = Path.GetFileName(openFileDialog.FileName);
                    lblFileName.Font = new Font(lblFileName.Font, FontStyle.Underline);
                }
            }
        }

        private void lblFileName_Click(object sender, EventArgs e)
        {
            if (attachedImage1 != null)
            {
                DisplayImage displayImage = new DisplayImage(attachedImage1, "register");
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

        private void rbtnPassenger_CheckedChanged(object sender, EventArgs e)
        {
            label6.Visible = false;
            tbxPlateNumber.Visible = false;
            pnlPlate.Visible = false;
            label4.Visible = true;
            pnlClassification.Visible = true;
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
    }
}
