namespace NEXUS.User_Controls
{
    partial class ForgetPassword1
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
            pnlUsername = new Panel();
            tbxEmailRevoery = new TextBox();
            pbLogo = new PictureBox();
            btnLogin = new ReaLTaiizor.Controls.CyberButton();
            lblUserFName = new Label();
            label1 = new Label();
            richTextBox5 = new RichTextBox();
            richTextBox1 = new RichTextBox();
            pnlUsername.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbLogo).BeginInit();
            SuspendLayout();
            // 
            // pnlUsername
            // 
            pnlUsername.BackColor = Color.FromArgb(176, 233, 255);
            pnlUsername.BackgroundImageLayout = ImageLayout.None;
            pnlUsername.Controls.Add(tbxEmailRevoery);
            pnlUsername.Location = new Point(34, 278);
            pnlUsername.Name = "pnlUsername";
            pnlUsername.Size = new Size(311, 48);
            pnlUsername.TabIndex = 4;
            // 
            // tbxEmailRevoery
            // 
            tbxEmailRevoery.BackColor = Color.FromArgb(176, 233, 255);
            tbxEmailRevoery.BorderStyle = BorderStyle.None;
            tbxEmailRevoery.Font = new Font("Inter", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbxEmailRevoery.ForeColor = Color.FromArgb(24, 60, 114);
            tbxEmailRevoery.Location = new Point(17, 14);
            tbxEmailRevoery.Name = "tbxEmailRevoery";
            tbxEmailRevoery.Size = new Size(275, 20);
            tbxEmailRevoery.TabIndex = 9;
            tbxEmailRevoery.TabStop = false;
            tbxEmailRevoery.Text = "Email";
            // 
            // pbLogo
            // 
            pbLogo.Cursor = Cursors.Hand;
            pbLogo.Image = Properties.Resources.Removal_915;
            pbLogo.Location = new Point(144, 24);
            pbLogo.Name = "pbLogo";
            pbLogo.Size = new Size(90, 90);
            pbLogo.SizeMode = PictureBoxSizeMode.Zoom;
            pbLogo.TabIndex = 3;
            pbLogo.TabStop = false;
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
            btnLogin.ColorBackground_Pen = Color.FromArgb(153, 229, 255);
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
            btnLogin.Location = new Point(33, 346);
            btnLogin.Name = "btnLogin";
            btnLogin.PenWidth = 15;
            btnLogin.Rounding = true;
            btnLogin.RoundingInt = 70;
            btnLogin.Size = new Size(311, 44);
            btnLogin.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            btnLogin.TabIndex = 10;
            btnLogin.Tag = "Cyber";
            btnLogin.TextButton = "Send Code";
            btnLogin.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            btnLogin.Timer_Effect_1 = 5;
            btnLogin.Timer_RGB = 300;
            // 
            // lblUserFName
            // 
            lblUserFName.AutoSize = true;
            lblUserFName.Font = new Font("Inter ExtraBold", 18F, FontStyle.Bold);
            lblUserFName.ForeColor = Color.FromArgb(24, 60, 114);
            lblUserFName.Location = new Point(130, 125);
            lblUserFName.Name = "lblUserFName";
            lblUserFName.Size = new Size(116, 35);
            lblUserFName.TabIndex = 34;
            lblUserFName.Text = "FORGOT";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Inter ExtraBold", 18F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(24, 60, 114);
            label1.Location = new Point(110, 155);
            label1.Name = "label1";
            label1.Size = new Size(154, 35);
            label1.TabIndex = 35;
            label1.Text = "PASSWORD";
            // 
            // richTextBox5
            // 
            richTextBox5.BackColor = Color.FromArgb(230, 249, 255);
            richTextBox5.BorderStyle = BorderStyle.None;
            richTextBox5.Font = new Font("Inter", 11F);
            richTextBox5.Location = new Point(33, 195);
            richTextBox5.Name = "richTextBox5";
            richTextBox5.ReadOnly = true;
            richTextBox5.Size = new Size(335, 24);
            richTextBox5.TabIndex = 46;
            richTextBox5.Text = "Provide your account's email for which you";
            // 
            // richTextBox1
            // 
            richTextBox1.BackColor = Color.FromArgb(230, 249, 255);
            richTextBox1.BorderStyle = BorderStyle.None;
            richTextBox1.Font = new Font("Inter", 11F);
            richTextBox1.Location = new Point(82, 216);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.ReadOnly = true;
            richTextBox1.Size = new Size(227, 23);
            richTextBox1.TabIndex = 47;
            richTextBox1.Text = " want to reset your password";
            // 
            // ForgetPassword1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(230, 249, 255);
            Controls.Add(richTextBox1);
            Controls.Add(richTextBox5);
            Controls.Add(label1);
            Controls.Add(lblUserFName);
            Controls.Add(btnLogin);
            Controls.Add(pnlUsername);
            Controls.Add(pbLogo);
            Name = "ForgetPassword1";
            Size = new Size(397, 458);
            pnlUsername.ResumeLayout(false);
            pnlUsername.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlUsername;
        private TextBox tbxEmailRevoery;
        private PictureBox pbLogo;
        private ReaLTaiizor.Controls.CyberButton btnLogin;
        private Label lblUserFName;
        private Label label1;
        private RichTextBox richTextBox5;
        private RichTextBox richTextBox1;
    }
}
