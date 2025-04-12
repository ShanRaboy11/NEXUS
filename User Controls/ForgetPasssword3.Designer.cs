namespace NEXUS.User_Controls
{
    partial class ForgetPasssword3
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            richTextBox1 = new RichTextBox();
            richTextBox5 = new RichTextBox();
            label1 = new Label();
            lblUserFName = new Label();
            btnLogin = new ReaLTaiizor.Controls.CyberButton();
            pnlUsername = new Panel();
            pbPrivacy1 = new PictureBox();
            tbxNewPassword = new TextBox();
            panel1 = new Panel();
            pbPrivacy2 = new PictureBox();
            tbxConfirmPassword = new TextBox();
            pnlUsername.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbPrivacy1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbPrivacy2).BeginInit();
            SuspendLayout();
            // 
            // richTextBox1
            // 
            richTextBox1.BackColor = Color.FromArgb(230, 249, 255);
            richTextBox1.BorderStyle = BorderStyle.None;
            richTextBox1.Font = new Font("Inter", 11F);
            richTextBox1.Location = new Point(107, 140);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.ReadOnly = true;
            richTextBox1.Size = new Size(170, 23);
            richTextBox1.TabIndex = 53;
            richTextBox1.Text = "set your new password";
            // 
            // richTextBox5
            // 
            richTextBox5.BackColor = Color.FromArgb(230, 249, 255);
            richTextBox5.BorderStyle = BorderStyle.None;
            richTextBox5.Font = new Font("Inter", 11F);
            richTextBox5.Location = new Point(81, 119);
            richTextBox5.Name = "richTextBox5";
            richTextBox5.ReadOnly = true;
            richTextBox5.Size = new Size(231, 24);
            richTextBox5.TabIndex = 52;
            richTextBox5.Text = "Your identity has been verified!";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Inter ExtraBold", 18F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(24, 60, 114);
            label1.Location = new Point(116, 73);
            label1.Name = "label1";
            label1.Size = new Size(154, 35);
            label1.TabIndex = 51;
            label1.Text = "PASSWORD";
            // 
            // lblUserFName
            // 
            lblUserFName.AutoSize = true;
            lblUserFName.Font = new Font("Inter ExtraBold", 18F, FontStyle.Bold);
            lblUserFName.ForeColor = Color.FromArgb(24, 60, 114);
            lblUserFName.Location = new Point(137, 43);
            lblUserFName.Name = "lblUserFName";
            lblUserFName.Size = new Size(111, 35);
            lblUserFName.TabIndex = 50;
            lblUserFName.Text = "UPDATE";
            // 
            // btnLogin
            // 
            btnLogin.Alpha = 20;
            btnLogin.BackColor = Color.Transparent;
            btnLogin.Background = true;
            btnLogin.Background_WidthPen = 4F;
            btnLogin.BackgroundPen = true;
            btnLogin.ColorBackground = Color.FromArgb(24, 60, 114);
            btnLogin.ColorBackground_1 = Color.FromArgb(24, 60, 114);
            btnLogin.ColorBackground_2 = Color.FromArgb(24, 60, 114);
            btnLogin.ColorBackground_Pen = Color.FromArgb(128, 223, 255);
            btnLogin.ColorLighting = Color.FromArgb(24, 60, 114);
            btnLogin.ColorPen_1 = Color.FromArgb(24, 60, 114);
            btnLogin.ColorPen_2 = Color.FromArgb(24, 60, 114);
            btnLogin.Cursor = Cursors.Hand;
            btnLogin.CyberButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            btnLogin.Effect_1 = true;
            btnLogin.Effect_1_ColorBackground = Color.FromArgb(29, 200, 238);
            btnLogin.Effect_1_Transparency = 25;
            btnLogin.Effect_2 = true;
            btnLogin.Effect_2_ColorBackground = Color.White;
            btnLogin.Effect_2_Transparency = 20;
            btnLogin.Font = new Font("Inter", 12.25F);
            btnLogin.ForeColor = Color.FromArgb(245, 245, 245);
            btnLogin.Lighting = false;
            btnLogin.LinearGradient_Background = false;
            btnLogin.LinearGradientPen = false;
            btnLogin.Location = new Point(37, 331);
            btnLogin.Name = "btnLogin";
            btnLogin.PenWidth = 15;
            btnLogin.Rounding = true;
            btnLogin.RoundingInt = 70;
            btnLogin.Size = new Size(311, 44);
            btnLogin.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            btnLogin.TabIndex = 49;
            btnLogin.Tag = "Cyber";
            btnLogin.TextButton = "Update";
            btnLogin.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            btnLogin.Timer_Effect_1 = 5;
            btnLogin.Timer_RGB = 300;
            // 
            // pnlUsername
            // 
            pnlUsername.BackColor = Color.FromArgb(176, 233, 255);
            pnlUsername.BackgroundImageLayout = ImageLayout.None;
            pnlUsername.Controls.Add(pbPrivacy1);
            pnlUsername.Controls.Add(tbxNewPassword);
            pnlUsername.Location = new Point(38, 200);
            pnlUsername.Name = "pnlUsername";
            pnlUsername.Size = new Size(311, 48);
            pnlUsername.TabIndex = 48;
            // 
            // pbPrivacy1
            // 
            pbPrivacy1.Cursor = Cursors.Hand;
            pbPrivacy1.Image = Properties.Resources._3844443_disable_eye_inactive_see_show_icon;
            pbPrivacy1.Location = new Point(271, 14);
            pbPrivacy1.Name = "pbPrivacy1";
            pbPrivacy1.Size = new Size(33, 21);
            pbPrivacy1.SizeMode = PictureBoxSizeMode.CenterImage;
            pbPrivacy1.TabIndex = 10;
            pbPrivacy1.TabStop = false;
            pbPrivacy1.Click += pbPrivacy1_Click;
            // 
            // tbxNewPassword
            // 
            tbxNewPassword.BackColor = Color.FromArgb(176, 233, 255);
            tbxNewPassword.BorderStyle = BorderStyle.None;
            tbxNewPassword.Font = new Font("Inter", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbxNewPassword.ForeColor = Color.FromArgb(24, 60, 114);
            tbxNewPassword.Location = new Point(17, 14);
            tbxNewPassword.Name = "tbxNewPassword";
            tbxNewPassword.Size = new Size(257, 20);
            tbxNewPassword.TabIndex = 9;
            tbxNewPassword.TabStop = false;
            tbxNewPassword.Text = "New Password";
            tbxNewPassword.Click += tbxNewPassword_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(176, 233, 255);
            panel1.BackgroundImageLayout = ImageLayout.None;
            panel1.Controls.Add(pbPrivacy2);
            panel1.Controls.Add(tbxConfirmPassword);
            panel1.Location = new Point(39, 262);
            panel1.Name = "panel1";
            panel1.Size = new Size(311, 48);
            panel1.TabIndex = 54;
            // 
            // pbPrivacy2
            // 
            pbPrivacy2.Cursor = Cursors.Hand;
            pbPrivacy2.Image = Properties.Resources._3844443_disable_eye_inactive_see_show_icon;
            pbPrivacy2.Location = new Point(270, 14);
            pbPrivacy2.Name = "pbPrivacy2";
            pbPrivacy2.Size = new Size(33, 21);
            pbPrivacy2.SizeMode = PictureBoxSizeMode.CenterImage;
            pbPrivacy2.TabIndex = 10;
            pbPrivacy2.TabStop = false;
            // 
            // tbxConfirmPassword
            // 
            tbxConfirmPassword.BackColor = Color.FromArgb(176, 233, 255);
            tbxConfirmPassword.BorderStyle = BorderStyle.None;
            tbxConfirmPassword.Font = new Font("Inter", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbxConfirmPassword.ForeColor = Color.FromArgb(24, 60, 114);
            tbxConfirmPassword.Location = new Point(17, 14);
            tbxConfirmPassword.Name = "tbxConfirmPassword";
            tbxConfirmPassword.Size = new Size(256, 20);
            tbxConfirmPassword.TabIndex = 9;
            tbxConfirmPassword.TabStop = false;
            tbxConfirmPassword.Text = "Confirm Password";
            // 
            // ForgetPasssword3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(230, 249, 255);
            Controls.Add(panel1);
            Controls.Add(richTextBox1);
            Controls.Add(richTextBox5);
            Controls.Add(label1);
            Controls.Add(lblUserFName);
            Controls.Add(btnLogin);
            Controls.Add(pnlUsername);
            Name = "ForgetPasssword3";
            Size = new Size(397, 458);
            pnlUsername.ResumeLayout(false);
            pnlUsername.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbPrivacy1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbPrivacy2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox richTextBox1;
        private RichTextBox richTextBox5;
        private Label label1;
        private Label lblUserFName;
        private ReaLTaiizor.Controls.CyberButton btnLogin;
        private Panel pnlUsername;
        private TextBox tbxNewPassword;
        private Panel panel1;
        private TextBox tbxConfirmPassword;
        private PictureBox pbPrivacy1;
        private PictureBox pbPrivacy2;
    }
}
