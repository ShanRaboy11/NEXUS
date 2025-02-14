using NEXUS.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NEXUS.Forms
{
    public partial class LogInForm : Form
    {
        private bool isPasswordVisible = false;

        public LogInForm()
        {
            InitializeComponent();
            btnLogIn.ColorBackground_Pen = Color.FromArgb(24, 60, 114);
            //btnRegister.ColorBackground_Pen = Color.Black;
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void Login_MouseDown(object sender, MouseEventArgs e)
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

        private void pbPrivacy_Click(object sender, EventArgs e)
        {
            isPasswordVisible = !isPasswordVisible;

            if (isPasswordVisible)
            {
                pbPrivacy.Image = Resources.show_eye;
                tbxEnterPassword.UseSystemPasswordChar = false;
            }
            else
            {
                pbPrivacy.Image = Resources._3844443_disable_eye_inactive_see_show_icon; 
                tbxEnterPassword.UseSystemPasswordChar = true;
            }
        }

        private void EnterUsername(object sender, EventArgs e)
        {
            tbxEnterUsername.Text = "";
        }

        private void EnterPassword(object sender, EventArgs e)
        {
            tbxEnterPassword.Text = "";
            tbxEnterPassword.UseSystemPasswordChar = true;
        }

        private void CopyText(object sender, EventArgs e)
        {
            if (tbxEnterUsername.SelectedText.Length > 0)
            {
                Clipboard.SetText(tbxEnterUsername.SelectedText);
            }
        }

        private void CutText(object sender, EventArgs e)
        {
            if (tbxEnterUsername.SelectedText.Length > 0)
            {
                Clipboard.SetText(tbxEnterUsername.SelectedText);
                tbxEnterUsername.SelectedText = "";
            }
        }

        private void PasteText(object sender, EventArgs e)
        {
            if (Clipboard.ContainsText())
            {
                int selectionStart = tbxEnterUsername.SelectionStart;
                tbxEnterUsername.Text = tbxEnterUsername.Text.Insert(selectionStart, Clipboard.GetText());
                tbxEnterUsername.SelectionStart = selectionStart + Clipboard.GetText().Length;
            }
        }

        private void SelectAllText(object sender, EventArgs e)
        {
            tbxEnterUsername.SelectAll();
        }

        private void tbxPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                //btnLogin(this, EventArgs.Empty);
            }
        }
    }
}
