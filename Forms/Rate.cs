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
            lblSmoothness.Visible = true;
            lblSmoothness.Text = "Very Rough";
            lblSmoothness.ForeColor = Color.Red;
        }

        private void pbSmoothness2_Click(object sender, EventArgs e)
        {
            pbSmoothness1.Image = Resources.rate_hover2;
            pbSmoothness2.Image = Resources.rate_hover2;
            pbSmoothness3.Image = Resources.rate_normal;
            pbSmoothness4.Image = Resources.rate_normal;
            pbSmoothness5.Image = Resources.rate_normal;
            lblSmoothness.Visible = true;
            lblSmoothness.Text = "Rough";
            lblSmoothness.ForeColor = Color.OrangeRed;
        }

        private void pbSmoothness3_Click(object sender, EventArgs e)
        {
            pbSmoothness1.Image = Resources.rate_hover2;
            pbSmoothness2.Image = Resources.rate_hover2;
            pbSmoothness3.Image = Resources.rate_hover2;
            pbSmoothness4.Image = Resources.rate_normal;
            pbSmoothness5.Image = Resources.rate_normal;
            lblSmoothness.Visible = true;
            lblSmoothness.Text = "Average";
            lblSmoothness.ForeColor = Color.DarkGreen;
        }

        private void pbSmoothness4_Click(object sender, EventArgs e)
        {
            pbSmoothness1.Image = Resources.rate_hover2;
            pbSmoothness2.Image = Resources.rate_hover2;
            pbSmoothness3.Image = Resources.rate_hover2;
            pbSmoothness4.Image = Resources.rate_hover2;
            pbSmoothness5.Image = Resources.rate_normal;
            lblSmoothness.Visible = true;
            lblSmoothness.Text = "Mostly Smooth";
            lblSmoothness.ForeColor = Color.Green;
        }

        private void pbSmoothness5_Click(object sender, EventArgs e)
        {
            pbSmoothness1.Image = Resources.rate_hover2;
            pbSmoothness2.Image = Resources.rate_hover2;
            pbSmoothness3.Image = Resources.rate_hover2;
            pbSmoothness4.Image = Resources.rate_hover2;
            pbSmoothness5.Image = Resources.rate_hover2;
            lblSmoothness.Visible = true;
            lblSmoothness.Text = "Very Smooth";
            lblSmoothness.ForeColor = Color.Blue;
        }

        private void pbSpeed1_Click(object sender, EventArgs e)
        {
            pbSpeed1.Image = Resources.rate_hover2;
            pbSpeed2.Image = Resources.rate_normal;
            pbSpeed3.Image = Resources.rate_normal;
            pbSpeed4.Image = Resources.rate_normal;
            pbSpeed5.Image = Resources.rate_normal;
            lblSpeed.Visible = true;
            lblSpeed.Text = "Dangerous";
            lblSpeed.ForeColor = Color.Red;
        }

        private void pbSpeed2_Click(object sender, EventArgs e)
        {
            pbSpeed1.Image = Resources.rate_hover2;
            pbSpeed2.Image = Resources.rate_hover2;
            pbSpeed3.Image = Resources.rate_normal;
            pbSpeed4.Image = Resources.rate_normal;
            pbSpeed5.Image = Resources.rate_normal;
            lblSpeed.Visible = true;
            lblSpeed.Text = "Too Fast";
            lblSpeed.ForeColor = Color.OrangeRed;
        }

        private void pbSpeed3_Click(object sender, EventArgs e)
        {
            pbSpeed1.Image = Resources.rate_hover2;
            pbSpeed2.Image = Resources.rate_hover2;
            pbSpeed3.Image = Resources.rate_hover2;
            pbSpeed4.Image = Resources.rate_normal;
            pbSpeed5.Image = Resources.rate_normal;
            lblSpeed.Visible = true;
            lblSpeed.Text = "Average";
            lblSpeed.ForeColor = Color.DarkGreen;
        }

        private void pbSpeed4_Click(object sender, EventArgs e)
        {
            pbSpeed1.Image = Resources.rate_hover2;
            pbSpeed2.Image = Resources.rate_hover2;
            pbSpeed3.Image = Resources.rate_hover2;
            pbSpeed4.Image = Resources.rate_hover2;
            pbSpeed5.Image = Resources.rate_normal;
            lblSpeed.Visible = true;
            lblSpeed.Text = "Slightly Fast or Slow";
            lblSpeed.ForeColor = Color.Green;
        }

        private void pbSpeed5_Click(object sender, EventArgs e)
        {
            pbSpeed1.Image = Resources.rate_hover2;
            pbSpeed2.Image = Resources.rate_hover2;
            pbSpeed3.Image = Resources.rate_hover2;
            pbSpeed4.Image = Resources.rate_hover2;
            pbSpeed5.Image = Resources.rate_hover2;
            lblSpeed.Visible = true;
            lblSpeed.Text = "Perfect";
            lblSpeed.ForeColor = Color.Blue;
        }

        private void pbComfortability1_Click(object sender, EventArgs e)
        {
            pbComfortability1.Image = Resources.rate_hover2;
            pbComfortability2.Image = Resources.rate_normal;
            pbComfortability3.Image = Resources.rate_normal;
            pbComfortability4.Image = Resources.rate_normal;
            pbComfortability5.Image = Resources.rate_normal;
            lblComfortability.Visible = true;
            lblComfortability.Text = "Very Uncomfortable";
            lblComfortability.ForeColor = Color.Red;
        }

        private void pbComfortability2_Click(object sender, EventArgs e)
        {
            pbComfortability1.Image = Resources.rate_hover2;
            pbComfortability2.Image = Resources.rate_hover2;
            pbComfortability3.Image = Resources.rate_normal;
            pbComfortability4.Image = Resources.rate_normal;
            pbComfortability5.Image = Resources.rate_normal;
            lblComfortability.Visible = true;
            lblComfortability.Text = "Uncomfortable";
            lblComfortability.ForeColor = Color.OrangeRed;
        }

        private void pbComfortability3_Click(object sender, EventArgs e)
        {
            pbComfortability1.Image = Resources.rate_hover2;
            pbComfortability2.Image = Resources.rate_hover2;
            pbComfortability3.Image = Resources.rate_hover2;
            pbComfortability4.Image = Resources.rate_normal;
            pbComfortability5.Image = Resources.rate_normal;
            lblComfortability.Visible = true;
            lblComfortability.Text = "Neutral";
            lblComfortability.ForeColor = Color.DarkGreen;
        }

        private void pbComfortability4_Click(object sender, EventArgs e)
        {
            pbComfortability1.Image = Resources.rate_hover2;
            pbComfortability2.Image = Resources.rate_hover2;
            pbComfortability3.Image = Resources.rate_hover2;
            pbComfortability4.Image = Resources.rate_hover2;
            pbComfortability5.Image = Resources.rate_normal;
            lblComfortability.Visible = true;
            lblComfortability.Text = "Comfortable";
            lblComfortability.ForeColor = Color.Green;
        }

        private void pbComfortability5_Click(object sender, EventArgs e)
        {
            pbComfortability1.Image = Resources.rate_hover2;
            pbComfortability2.Image = Resources.rate_hover2;
            pbComfortability3.Image = Resources.rate_hover2;
            pbComfortability4.Image = Resources.rate_hover2;
            pbComfortability5.Image = Resources.rate_hover2;
            lblComfortability.Visible = true;
            lblComfortability.Text = "Very Comfortable";
            lblComfortability.ForeColor = Color.Blue;
        }

        private void pbCleanliness1_Click(object sender, EventArgs e)
        {
            pbCleanliness1.Image = Resources.rate_hover2;
            pbCleanliness2.Image = Resources.rate_normal;
            pbCleanliness3.Image = Resources.rate_normal;
            pbCleanliness4.Image = Resources.rate_normal;
            pbCleanliness5.Image = Resources.rate_normal;
            lblCleanliness.Visible = true;
            lblCleanliness.Text = "Very Dirty";
            lblCleanliness.ForeColor = Color.Red;
        }

        private void pbCleanliness2_Click(object sender, EventArgs e)
        {
            pbCleanliness1.Image = Resources.rate_hover2;
            pbCleanliness2.Image = Resources.rate_hover2;
            pbCleanliness3.Image = Resources.rate_normal;
            pbCleanliness4.Image = Resources.rate_normal;
            pbCleanliness5.Image = Resources.rate_normal;
            lblCleanliness.Visible = true;
            lblCleanliness.Text = "Dirty";
            lblCleanliness.ForeColor = Color.OrangeRed;
        }

        private void pbCleanliness3_Click(object sender, EventArgs e)
        {
            pbCleanliness1.Image = Resources.rate_hover2;
            pbCleanliness2.Image = Resources.rate_hover2;
            pbCleanliness3.Image = Resources.rate_hover2;
            pbCleanliness4.Image = Resources.rate_normal;
            pbCleanliness5.Image = Resources.rate_normal;
            lblCleanliness.Visible = true;
            lblCleanliness.Text = "Acceptable";
            lblCleanliness.ForeColor = Color.DarkGreen;
        }

        private void pbCleanliness4_Click(object sender, EventArgs e)
        {
            pbCleanliness1.Image = Resources.rate_hover2;
            pbCleanliness2.Image = Resources.rate_hover2;
            pbCleanliness3.Image = Resources.rate_hover2;
            pbCleanliness4.Image = Resources.rate_hover2;
            pbCleanliness5.Image = Resources.rate_normal;
            lblCleanliness.Visible = true;
            lblCleanliness.Text = "Comfortable";
            lblCleanliness.ForeColor = Color.Green;
        }

        private void pbCleanliness5_Click(object sender, EventArgs e)
        {
            pbCleanliness1.Image = Resources.rate_hover2;
            pbCleanliness2.Image = Resources.rate_hover2;
            pbCleanliness3.Image = Resources.rate_hover2;
            pbCleanliness4.Image = Resources.rate_hover2;
            pbCleanliness5.Image = Resources.rate_hover2;
            lblCleanliness.Visible = true;
            lblCleanliness.Text = "Very Clean";
            lblCleanliness.ForeColor = Color.Blue;
        }

        private void pbSatisfaction1_Click(object sender, EventArgs e)
        {
            pbSatisfaction1.Image = Resources.rate_hover2;
            pbSatisfaction2.Image = Resources.rate_normal;
            pbSatisfaction3.Image = Resources.rate_normal;
            pbSatisfaction4.Image = Resources.rate_normal;
            pbSatisfaction5.Image = Resources.rate_normal;
            lblSatisfaction.Visible = true;
            lblSatisfaction.Text = "Very Dissatisfied";
            lblSatisfaction.ForeColor = Color.Red;
        }

        private void pbSatisfaction2_Click(object sender, EventArgs e)
        {
            pbSatisfaction1.Image = Resources.rate_hover2;
            pbSatisfaction2.Image = Resources.rate_hover2;
            pbSatisfaction3.Image = Resources.rate_normal;
            pbSatisfaction4.Image = Resources.rate_normal;
            pbSatisfaction5.Image = Resources.rate_normal;
            lblSatisfaction.Visible = true;
            lblSatisfaction.Text = "Dissatisfied";
            lblSatisfaction.ForeColor = Color.OrangeRed;
        }

        private void pbSatisfaction3_Click(object sender, EventArgs e)
        {
            pbSatisfaction1.Image = Resources.rate_hover2;
            pbSatisfaction2.Image = Resources.rate_hover2;
            pbSatisfaction3.Image = Resources.rate_hover2;
            pbSatisfaction4.Image = Resources.rate_normal;
            pbSatisfaction5.Image = Resources.rate_normal;
            lblSatisfaction.Visible = true;
            lblSatisfaction.Text = "Neutral";
            lblSatisfaction.ForeColor = Color.DarkGreen;
        }

        private void pbSatisfaction4_Click(object sender, EventArgs e)
        {
            pbSatisfaction1.Image = Resources.rate_hover2;
            pbSatisfaction2.Image = Resources.rate_hover2;
            pbSatisfaction3.Image = Resources.rate_hover2;
            pbSatisfaction4.Image = Resources.rate_hover2;
            pbSatisfaction5.Image = Resources.rate_normal;
            lblSatisfaction.Visible = true;
            lblSatisfaction.Text = "Satisfied";
            lblSatisfaction.ForeColor = Color.Green;
        }
        private void pbSatisfaction5_Click(object sender, EventArgs e)
        {
            pbSatisfaction1.Image = Resources.rate_hover2;
            pbSatisfaction2.Image = Resources.rate_hover2;
            pbSatisfaction3.Image = Resources.rate_hover2;
            pbSatisfaction4.Image = Resources.rate_hover2;
            pbSatisfaction5.Image = Resources.rate_hover2;
            lblSatisfaction.Visible = true;
            lblSatisfaction.Text = "Very Satisfied";
            lblSatisfaction.ForeColor = Color.Blue;
        }
    }
}
