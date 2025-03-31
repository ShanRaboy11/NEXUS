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
        public DisplayImage(Image image,string message)
        {
            InitializeComponent();
            pbImageUploaded.Image = image;
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
                overlayForm.StartPosition = FormStartPosition.Manual; // Ensure manual positioning
                overlayForm.Bounds = Screen.FromControl(adminDashboard).WorkingArea; // Adjust to working area (excludes taskbar)
                overlayForm.FormBorderStyle = FormBorderStyle.None; // Remove borders if needed
                overlayForm.WindowState = FormWindowState.Normal; // Reset first to ensure proper resize
                overlayForm.WindowState = FormWindowState.Maximized; // Then maximize
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
