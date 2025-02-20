using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace NEXUS.Forms
{
    public partial class ProgressBar : Form
    {
        public event Action ProgressCompleted;

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
            (
            int nleftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipse
            );
        public ProgressBar()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            progressBar1.Percentage = 0;
            timer1.Interval = 55; 
            timer1.Tick += timer1_Tick;
            timer1.Start();
        }

        public void labelChange(string label1)
        {
            if(label1 == "NEXUS")
            {
                return;
            }
            else if(label1 == "QR")
            {
                lblIdentifier.Text = "QR Code";
                lblLoading.Text = "Generating...";
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Percentage < 100)
            {
                progressBar1.Percentage += 1;
                progressBar1.Text = progressBar1.Percentage.ToString() + "%";
            }

            if (progressBar1.Percentage >= 100)
            {
                timer1.Stop();
                this.Hide();
                ProgressCompleted?.Invoke(); // Notify that progress is done
            }
        }
    }
}
