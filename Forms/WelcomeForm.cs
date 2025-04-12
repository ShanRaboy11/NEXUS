using NEXUS.Forms;
using System.Runtime.InteropServices;
using NEXUS.Classes;

namespace NEXUS
{
    public partial class WelcomeForm : Form
    {
        public WelcomeForm()
        {
            InitializeComponent();
            //Cryptography.AdminPassword("admin123");
            //Uncomment when using sizable
            //this.Text = string.Empty;
            //this.ControlBox = false;
            //this.DoubleBuffered = true;
            //this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void Welcome_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
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

        private void Close(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void AboutPage(object sender, EventArgs e)
        {
            About about = new About();
            about.FormClosed += (s, args) => this.Show();
            about.Owner = this;

            about.Show();
            this.Hide();
        }

        private void cyberButton2_Click(object sender, EventArgs e)
        {
            NEXUS.Forms.ProgressBar progressBar = new NEXUS.Forms.ProgressBar();

            progressBar.ProgressCompleted += () =>
            {
                LogInForm logInForm = new LogInForm();
                logInForm.Show();
            };
            progressBar.labelChange("NEXUS");
            progressBar.Show();
            this.Hide();          
        }
    }
}
