using NEXUS.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NEXUS.User_Controls
{
    public partial class ForgetPassword2 : UserControl
    {
        private string resetCode;
        Panel pnlContainer;
        public ForgetPassword2(Panel pnlcontainer, string resetcode)
        {
            InitializeComponent();
            pnlContainer = pnlcontainer;
            resetCode = resetcode;
        }

        private void tbxCode_TextChanged(object sender, EventArgs e)
        {
            TextBox currentBox = sender as TextBox;

            if (currentBox.Text.Length == 1)
            {
                if (currentBox == tbxCode1) tbxCode2.Focus();
                else if (currentBox == tbxCode2) tbxCode3.Focus();
                else if (currentBox == tbxCode3) tbxCode4.Focus();
                else if (currentBox == tbxCode4) tbxCode5.Focus();
            }
        }

        private void tbxCode_KeyDown(object sender, KeyEventArgs e)
        {
            TextBox currentBox = sender as TextBox;

            if (e.KeyCode == Keys.Back && string.IsNullOrEmpty(currentBox.Text))
            {
                if (currentBox == tbxCode5) tbxCode4.Focus();
                else if (currentBox == tbxCode4) tbxCode3.Focus();
                else if (currentBox == tbxCode3) tbxCode2.Focus();
                else if (currentBox == tbxCode2) tbxCode1.Focus();
            }
        }

        private void ForgetPassword2_Load(object sender, EventArgs e)
        {
            TextBox[] boxes = { tbxCode1, tbxCode2, tbxCode3, tbxCode4, tbxCode5 };

            foreach (TextBox tb in boxes)
            {
                tb.MaxLength = 1;
                tb.TextChanged += tbxCode_TextChanged;
                tb.KeyDown += tbxCode_KeyDown;
            }

            tbxCode1.Focus();
        }


        private void btnVerifyCode_Click(object sender, EventArgs e)
        {
            string enteredCode = tbxCode1.Text + tbxCode2.Text + tbxCode3.Text + tbxCode4.Text + tbxCode5.Text;
            DialogBox dialogBox = new DialogBox();
            if (enteredCode.Length < 5)
            {
                dialogBox.ShowIcon("blank");
                dialogBox.ShowDialog();
                return;
            }

            if (enteredCode == resetCode) 
            {
                pnlContainer.Controls.Clear();

                ForgetPasssword3 forgetPassword3 = new ForgetPasssword3()
                {
                    Dock = DockStyle.Fill
                };

                pnlContainer.Controls.Add(forgetPassword3);
            }
            else
            {
                dialogBox.ShowIcon("invalid code");
                dialogBox.ShowDialog();
            }
        }

    }
}
