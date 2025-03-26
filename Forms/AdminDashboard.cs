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
    public partial class AdminDashboard : Form
    {
        public AdminDashboard()
        {
            InitializeComponent();
            LoadHomeAdmin();
        }

        private void LoadHomeAdmin()
        {
            HomeAdmin homeControl = new HomeAdmin();

            homeControl.Dock = DockStyle.Fill;
            pnlContainer.Controls.Clear();
            pnlContainer.Controls.Add(homeControl);
        }

        // Example: Reload HomeAdmin when clicking a button
        private void btnHome_Click(object sender, EventArgs e)
        {
            LoadHomeAdmin();
        }
    }
}
