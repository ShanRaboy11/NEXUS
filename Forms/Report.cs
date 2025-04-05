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
        public Report(int userID)
        {
            InitializeComponent();
            this.UserID = userID;
            
        }


        private void btnAttach_Click(object sender, EventArgs e)
        {
            Passenger passenger = new Passenger(0, null, null, null, "i", null, null, null, null, null, null, 0.0, 0, null);
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

        private void btnSubmitReport_Click(object sender, EventArgs e)
        {
            DialogBox dialogBox = new DialogBox();
            Scan scan = new Scan(UserID);

            if (dtIncidentDate == null || cmbxNature == null ||
                string.IsNullOrEmpty(tbxLocation.Text) || string.IsNullOrEmpty(rtbxIncidentDescription.Text))
            {
                dialogBox.ShowIcon("blank");
                scan.ShowOverlay(this,dialogBox);
            }
            else
            {
                dialogBox.ShowIcon("report");
                scan.ShowOverlay(this,dialogBox);
                //IncidentReport incidentReport = new IncidentReport(UserID, )
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
