using NEXUS.Properties;
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
    public partial class History : Form
    {
        private string Filter;
        int UserID;
        public History(int userID)
        {
            InitializeComponent();
            this.UserID = userID;
        }

        private void cmbxFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbxFilter.SelectedItem != null)
            {
                Filter = cmbxFilter.SelectedItem.ToString();
                displayTools(Filter);
            }
        }

        private void displayTools(string tool)
        {
            if (tool == "Date")
            {
                tbxJeepCode.Visible = false;
                dtDate.Visible = true;
                pbIcon.Visible = true;
                pbIcon.Image = Resources._115762_calendar_date_event_month_icon;
            }
            else
            {
                dtDate.Visible = false;
                pbIcon.Visible = true;
                tbxJeepCode.Visible = true;
                pbIcon.Image = Resources.jeepcode;
            }
        }

        private void tbxJeepCode_Click(object sender, EventArgs e)
        {
            tbxJeepCode.Text = "";
            tbxJeepCode.ForeColor = Color.Black;
        }

        private void rateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Rate rate = new Rate();
            Scan scan = new Scan(UserID);

            scan.ShowOverlay(rate, null);
            scan.FormClosed += (s, args) => this.Show();
        }
    }
}
