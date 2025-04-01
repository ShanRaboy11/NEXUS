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
    public partial class DisplayImage : Form
    {
        Scan scan = new Scan(0);

        // Modify constructor to accept byte[] instead of Image
        public DisplayImage(byte[] imageBytes, string message)
        {
            InitializeComponent();

            // Convert byte[] to Image
            if (imageBytes != null && imageBytes.Length > 0)
            {
                using (MemoryStream ms = new MemoryStream(imageBytes))
                {
                    pbImageUploaded.Image = Image.FromStream(ms);
                }
            }
            else
            {
                pbImageUploaded.Image = null;  // In case the byte array is null or empty
            }

            // Handle the message and display overlay if needed
            if (message == "report")
            {
                scan.ShowOverlay(this, null);
            }
            else
            {
                this.Show();
            }
        }

        private void pbClose1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private int Overlay(Form form)
        {
            AdminDashboard adminDashboard = new AdminDashboard();
            var overlayForm = new Form();
            overlayForm.StartPosition = FormStartPosition.CenterScreen;
            overlayForm.FormBorderStyle = FormBorderStyle.None;
            overlayForm.Opacity = 0.5d;
            overlayForm.BackColor = Color.Black;

            if (adminDashboard.maximized)
            {
                overlayForm.StartPosition = FormStartPosition.Manual;
                overlayForm.Bounds = Screen.FromControl(adminDashboard).WorkingArea;
                overlayForm.FormBorderStyle = FormBorderStyle.None;
                overlayForm.WindowState = FormWindowState.Normal;
                overlayForm.WindowState = FormWindowState.Maximized;
            }
            else
            {
                overlayForm.WindowState = FormWindowState.Normal;
            }

            overlayForm.Size = adminDashboard.Size;
            overlayForm.Location = this.Location;
            overlayForm.ShowInTaskbar = false;
            overlayForm.Show();

            if (form.ShowDialog() == DialogResult.OK)
            {
                form.Close();
                overlayForm.Close();
                return 1;
            }
            else
            {
                form.Close();
                overlayForm.Close();
                return 0;
            }
        }
    }
}
