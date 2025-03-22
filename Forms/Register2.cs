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
        private Image attachedImage1;
        bool increase = false;
        public Register2()
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
            List<string> userInfo = new List<string>
             {
                cmbxMonth.Text,
                cmbxDay.Text,
                cmbxYear.Text,
                (rbtnStudent.Checked ? rbtnStudent.Text : rbtnSenior.Checked ? rbtnSenior.Text : rbtnRegular.Text)
             };
            dialogBox.ShowIcon("register");
            overlayForm(this, dialogBox);
            logInForm.Show();
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            LogInForm logInForm = new LogInForm();
            this.Close();
            logInForm.Show();
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
            if(!increase)
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

        public void overlayForm(Form newForm, Form dialog)
        {
            var overlay = new Form();

            overlay.FormBorderStyle = FormBorderStyle.None;
            overlay.Opacity = 0.5d;
            overlay.BackColor = Color.Black;
            overlay.Size = this.Size;
            overlay.Location = this.Location;
            overlay.ShowInTaskbar = false;

            overlay.Show();
            newForm.FormClosed += (s, args) => overlay.Close();
            newForm.Show();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                overlay.Close();
            }
        }

        private void lblFileName_Click(object sender, EventArgs e)
        {
            if (attachedImage1 != null)
            {
                DisplayImage displayImage = new DisplayImage(attachedImage1, "register");
            }
        }
    }
}
