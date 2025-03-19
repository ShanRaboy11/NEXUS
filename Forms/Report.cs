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
        public Report()
        {
            InitializeComponent();
        }

        private void btnAttach_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";
                openFileDialog.Title = "Select an Image";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Display the selected image in the PictureBox
                    //pbAttachedImage.Image = Image.FromFile(openFileDialog.FileName);

                    // Display the filename in the label or textbox
                    lblFileName.Text = Path.GetFileName(openFileDialog.FileName);
                    lblFileName.Font = new Font(lblFileName.Font, FontStyle.Underline);
                }
            }
        }

        private void btnSubmitReport_Click(object sender, EventArgs e)
        {
            DialogBox dialogBox = new DialogBox();
            if (dtIncidentDate == null || cmbxNature == null ||
                string.IsNullOrEmpty(tbxLocation.Text) || string.IsNullOrEmpty(rtbxIncidentDescription.Text))
            {
                dialogBox.ShowIcon("blank");
                dialogBox.Show();
            }
            else
            {
                dialogBox.ShowIcon("report");
                if (dialogBox.ShowDialog() == DialogResult.OK)
                {
                    dtIncidentDate.Value = DateTime.Now;
                    lblFileName.Text = string.Empty;
                    tbxLocation.Text = string.Empty;
                    rtbxIncidentDescription.Text = string.Empty;
                    cmbxNature.SelectedIndex = -1;
                }
            }
        }
    }
}
