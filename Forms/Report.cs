using NEXUS.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Windows.Forms;

namespace NEXUS.Forms
{
    public partial class Report : Form
    {
        private Image attachedImage;
        private byte[] attachedImageBytes;
        private readonly Attachment attachmentHandler = new Attachment();
        private int UserID;
        private string UserType;
        public Report(int userID, string userType)
        {
            InitializeComponent();
            this.UserID = userID;
            this.UserType = userType;           
        }


        private void btnAttach_Click(object sender, EventArgs e)
        {
            lblFileName.Text = "";
            lblFileName.ForeColor = Color.Black;
            lblFileName.Font = new Font(lblFileName.Font, FontStyle.Underline);

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    attachedImage = Image.FromFile(openFileDialog.FileName);
                    this.attachedImageBytes = attachmentHandler.ConvertImageToByteArray(attachedImage);

                    lblFileName.Text = Path.GetFileName(openFileDialog.FileName);
                    lblFileName.ForeColor = Color.Blue;
                    lblFileName.Cursor = Cursors.Hand;
                    lblFileName.Font = new Font(lblFileName.Font, FontStyle.Underline);
                }
            }
        }

        private void btnSubmitReport_Click(object sender, EventArgs e)
        {
            DialogBox dialogBox = new DialogBox();
            Scan scan = new Scan(UserID);
            int latestTripID = Trip.GetLatestTripIDForUser(UserID);

            if (latestTripID == null)
            {
                MessageBox.Show("No trip found for this user. Cannot submit report.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (dtIncidentDate == null || cmbxNature == null ||
                string.IsNullOrEmpty(tbxLocation.Text) || string.IsNullOrEmpty(rtbxIncidentDescription.Text))
            {
                dialogBox.ShowIcon("blank");
                scan.ShowOverlay(this,dialogBox);
                return;
            }
            else
            {
                dialogBox.ShowIcon("report");
                scan.ShowOverlay(this,dialogBox);
                if(this.UserType == "Passenger")
                {
                    IncidentReport incidentReport = new IncidentReport(UserID, latestTripID, dtIncidentDate.Value, tbxLocation.Text, cmbxNature.SelectedItem.ToString(), rtbxIncidentDescription.Text, attachedImageBytes, "Pending");
                    incidentReport.SaveToDatabase();
                }
                else
                {
                    int DriverTripID = Trip.GetLatestTripIDForDriver(UserID);
                    IncidentReport incidentReport = new IncidentReport(UserID, DriverTripID, dtIncidentDate.Value, tbxLocation.Text, cmbxNature.SelectedItem.ToString(), rtbxIncidentDescription.Text, attachedImageBytes, "Pending");
                    incidentReport.SaveToDatabase();
                }
            }
            dtIncidentDate.Value = DateTime.Now;
            lblFileName.Text = string.Empty;
            tbxLocation.Text = string.Empty;
            rtbxIncidentDescription.Text = string.Empty;
            cmbxNature.SelectedIndex = -1;
        }

        private void lblFileName_Click(object sender, EventArgs e)
        {
            if (attachedImage != null)
            {
                DisplayImage displayImage = new DisplayImage(attachedImageBytes, "report");
            }
        }
    }
}
