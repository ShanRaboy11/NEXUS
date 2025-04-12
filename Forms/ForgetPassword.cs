using NEXUS.User_Controls;
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
    public partial class ForgetPassword : Form
    {
        public ForgetPassword()
        {
            InitializeComponent();
            Display();
        }

        private void Display()
        {
            pnlContainer.Controls.Clear();

            ForgetPassword1 forgetPassword1 = new ForgetPassword1(pnlContainer)
            {
                Dock = DockStyle.Fill
            };

            pnlContainer.Controls.Add(forgetPassword1);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
