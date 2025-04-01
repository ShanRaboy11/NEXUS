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
    public partial class Message : Form
    {
        public Message(string message)
        {
            InitializeComponent();
            display(message);
        }

        private void display(string message)
        {

            if (message == "question")
            {
                pbDialogIcon.Image = Resources.Animation___1743240515087;
                lblMessage.Text = "Are you sure you want to delete this record?";
                btnOK.TextButton = "Confirm";
            }
            else if (message == "select")
            {
                pbDialogIcon.Image = Resources.Animation___1739888639577;
                lblMessage.Text = "Please select a record to delete.";
                btnOK.TextButton = "OK";
            }
            else if (message == "cash in")
            {
                pbDialogIcon.Image = Resources.Animation___1739885779319;
                lblMessage.Text = "Your deposit has been successfully processed.";
                btnOK.TextButton = "OK";
            }
            else if (message == "wait")
            {
                pbDialogIcon.Image = Resources.Animation___1739888639577;
                lblMessage.Location = new Point(12, 125);
                lblMessage.Font = new Font(lblMessage.Font.FontFamily, 11.5f);
                lblMesage1.Visible = true;
                lblMessage.Text = "Your account is currently being verified.";
                btnOK.TextButton = "OK";
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Yes;
            this.Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
