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
    public partial class Rate : Form
    {
        public Rate()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pbSafety1_Click(object sender, EventArgs e)
        {
            pbSafety1.Image = Resources.rate_hover2;
            pbSafety2.Image = Resources.rate_normal;
            pbSafety3.Image = Resources.rate_normal;
            pbSafety4.Image = Resources.rate_normal;
            pbSafety5.Image = Resources.rate_normal;
            lblSafety.Visible = true;
            lblSafety.Text = "Very Unsafe";
            lblSafety.ForeColor = Color.Red;
        }

        private void pbSafety2_Click(object sender, EventArgs e)
        {
            pbSafety1.Image = Resources.rate_hover2;
            pbSafety2.Image = Resources.rate_hover2;
            pbSafety3.Image = Resources.rate_normal;
            pbSafety4.Image = Resources.rate_normal;
            pbSafety5.Image = Resources.rate_normal;
            lblSafety.Visible = true;
            lblSafety.Text = "Unsafe";
            lblSafety.ForeColor = Color.OrangeRed;
        }

        private void pbSafety3_Click(object sender, EventArgs e)
        {
            pbSafety1.Image = Resources.rate_hover2;
            pbSafety2.Image = Resources.rate_hover2;
            pbSafety3.Image = Resources.rate_hover2;
            pbSafety4.Image = Resources.rate_normal;
            pbSafety5.Image = Resources.rate_normal;
            lblSafety.Visible = true;
            lblSafety.Text = "Neutral";
            lblSafety.ForeColor = Color.DarkGreen;
        }

        private void pbSafety4_Click(object sender, EventArgs e)
        {
            pbSafety1.Image = Resources.rate_hover2;
            pbSafety2.Image = Resources.rate_hover2;
            pbSafety3.Image = Resources.rate_hover2;
            pbSafety4.Image = Resources.rate_hover2;
            pbSafety5.Image = Resources.rate_normal;
            lblSafety.Visible = true;
            lblSafety.Text = "Mostly Safe";
            lblSafety.ForeColor = Color.Green;
        }

        private void pbSafety5_Click(object sender, EventArgs e)
        {
            pbSafety1.Image = Resources.rate_hover2;
            pbSafety2.Image = Resources.rate_hover2;
            pbSafety3.Image = Resources.rate_hover2;
            pbSafety4.Image = Resources.rate_hover2;
            pbSafety5.Image = Resources.rate_hover2;
            lblSafety.Visible = true;
            lblSafety.Text = "Extremely Safe";
            lblSafety.ForeColor = Color.Blue;
        }

        private void pbSmoothness1_Click(object sender, EventArgs e)
        {
            pbSmoothness1.Image = Resources.rate_hover2;
            pbSmoothness2.Image = Resources.rate_normal;
            pbSmoothness3.Image = Resources.rate_normal;
            pbSmoothness4.Image = Resources.rate_normal;
            pbSmoothness5.Image = Resources.rate_normal;
            lblSafety.Visible = true;
            lblSafety.Text = "Very Rough";
            lblSafety.ForeColor = Color.Red;
        }

        private void pbSmoothness2_Click(object sender, EventArgs e)
        {
            pbSmoothness1.Image = Resources.rate_hover2;
            pbSmoothness2.Image = Resources.rate_hover2;
            pbSmoothness3.Image = Resources.rate_normal;
            pbSmoothness4.Image = Resources.rate_normal;
            pbSmoothness5.Image = Resources.rate_normal;
            lblSafety.Visible = true;
            lblSafety.Text = "Rough";
            lblSafety.ForeColor = Color.OrangeRed;
        }

        private void pbSmoothness3_Click(object sender, EventArgs e)
        {
            pbSmoothness1.Image = Resources.rate_hover2;
            pbSmoothness2.Image = Resources.rate_hover2;
            pbSmoothness3.Image = Resources.rate_hover2;
            pbSmoothness4.Image = Resources.rate_normal;
            pbSmoothness5.Image = Resources.rate_normal;
            lblSafety.Visible = true;
            lblSafety.Text = "Average";
            lblSafety.ForeColor = Color.DarkGreen;
        }

        private void pbSmoothness4_Click(object sender, EventArgs e)
        {
            pbSmoothness1.Image = Resources.rate_hover2;
            pbSmoothness2.Image = Resources.rate_hover2;
            pbSmoothness3.Image = Resources.rate_hover2;
            pbSmoothness4.Image = Resources.rate_hover2;
            pbSmoothness5.Image = Resources.rate_normal;
            lblSafety.Visible = true;
            lblSafety.Text = "Mostly Smooth";
            lblSafety.ForeColor = Color.Green;
        }

        private void pbSmoothness5_Click(object sender, EventArgs e)
        {
            pbSmoothness1.Image = Resources.rate_hover2;
            pbSmoothness2.Image = Resources.rate_hover2;
            pbSmoothness3.Image = Resources.rate_hover2;
            pbSmoothness4.Image = Resources.rate_hover2;
            pbSmoothness5.Image = Resources.rate_hover2;
            lblSafety.Visible = true;
            lblSafety.Text = "Very Smooth";
            lblSafety.ForeColor = Color.Blue;
        }

        private void pbSpeed1_Click(object sender, EventArgs e)
        {
            pbSpeed1.Image = Resources.rate_hover2;
            pbSpeed2.Image = Resources.rate_normal;
            pbSpeed3.Image = Resources.rate_normal;
            pbSpeed4.Image = Resources.rate_normal;
            pbSpeed5.Image = Resources.rate_normal;
            lblSafety.Visible = true;
        }

        private void pbSpeed2_Click(object sender, EventArgs e)
        {
            pbSpeed1.Image = Resources.rate_hover2;
            pbSpeed2.Image = Resources.rate_hover2;
            pbSpeed3.Image = Resources.rate_normal;
            pbSpeed4.Image = Resources.rate_normal;
            pbSpeed5.Image = Resources.rate_normal;
            lblSafety.Visible = true;
        }

        private void pbSpeed3_Click(object sender, EventArgs e)
        {
            pbSpeed1.Image = Resources.rate_hover2;
            pbSpeed2.Image = Resources.rate_hover2;
            pbSpeed3.Image = Resources.rate_hover2;
            pbSpeed4.Image = Resources.rate_normal;
            pbSpeed5.Image = Resources.rate_normal;
            lblSafety.Visible = true;
        }

        private void pbSpeed4_Click(object sender, EventArgs e)
        {
            pbSpeed1.Image = Resources.rate_hover2;
            pbSpeed2.Image = Resources.rate_hover2;
            pbSpeed3.Image = Resources.rate_hover2;
            pbSpeed4.Image = Resources.rate_hover2;
            pbSpeed5.Image = Resources.rate_normal;
            lblSafety.Visible = true;
        }

        private void pbSpeed5_Click(object sender, EventArgs e)
        {
            pbSpeed1.Image = Resources.rate_hover2;
            pbSpeed2.Image = Resources.rate_hover2;
            pbSpeed3.Image = Resources.rate_hover2;
            pbSpeed4.Image = Resources.rate_hover2;
            pbSpeed5.Image = Resources.rate_hover2;
            lblSafety.Visible = true;
        }
    }
}
