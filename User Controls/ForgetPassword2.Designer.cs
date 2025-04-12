namespace NEXUS.User_Controls
{
    partial class ForgetPassword2
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
            richTextBox5 = new RichTextBox();
            lblUserFName = new Label();
            btnVerify = new ReaLTaiizor.Controls.CyberButton();
            pnlUsername = new Panel();
            tbxCode1 = new TextBox();
            panel1 = new Panel();
            tbxCode2 = new TextBox();
            panel2 = new Panel();
            tbxCode3 = new TextBox();
            panel3 = new Panel();
            tbxCode4 = new TextBox();
            panel4 = new Panel();
            tbxCode5 = new TextBox();
            pnlUsername.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // richTextBox5
            // 
            richTextBox5.BackColor = Color.FromArgb(230, 249, 255);
            richTextBox5.BorderStyle = BorderStyle.None;
            richTextBox5.Font = new Font("Inter", 11F);
            richTextBox5.Location = new Point(25, 100);
            richTextBox5.Name = "richTextBox5";
            richTextBox5.ReadOnly = true;
            richTextBox5.Size = new Size(346, 54);
            richTextBox5.TabIndex = 52;
            richTextBox5.Text = "We’ve sent a 5-digit code to help you reset your password. Please eneter it below to continue.";
            // 
            // lblUserFName
            // 
            lblUserFName.AutoSize = true;
            lblUserFName.Font = new Font("Inter ExtraBold", 18F, FontStyle.Bold);
            lblUserFName.ForeColor = Color.FromArgb(24, 60, 114);
            lblUserFName.Location = new Point(19, 51);
            lblUserFName.Name = "lblUserFName";
            lblUserFName.Size = new Size(257, 35);
            lblUserFName.TabIndex = 50;
            lblUserFName.Text = "CHECK YOUR INBOX";
            // 
            // btnVerify
            // 
            btnVerify.Alpha = 20;
            btnVerify.BackColor = Color.Transparent;
            btnVerify.Background = true;
            btnVerify.Background_WidthPen = 4F;
            btnVerify.BackgroundPen = true;
            btnVerify.ColorBackground = Color.FromArgb(24, 60, 114);
            btnVerify.ColorBackground_1 = Color.FromArgb(24, 60, 114);
            btnVerify.ColorBackground_2 = Color.FromArgb(24, 60, 114);
            btnVerify.ColorBackground_Pen = Color.FromArgb(128, 223, 255);
            btnVerify.ColorLighting = Color.FromArgb(24, 60, 114);
            btnVerify.ColorPen_1 = Color.FromArgb(24, 60, 114);
            btnVerify.ColorPen_2 = Color.FromArgb(24, 60, 114);
            btnVerify.Cursor = Cursors.Hand;
            btnVerify.CyberButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            btnVerify.Effect_1 = true;
            btnVerify.Effect_1_ColorBackground = Color.FromArgb(29, 200, 238);
            btnVerify.Effect_1_Transparency = 25;
            btnVerify.Effect_2 = true;
            btnVerify.Effect_2_ColorBackground = Color.White;
            btnVerify.Effect_2_Transparency = 20;
            btnVerify.Font = new Font("Inter", 12.25F);
            btnVerify.ForeColor = Color.FromArgb(245, 245, 245);
            btnVerify.Lighting = false;
            btnVerify.LinearGradient_Background = false;
            btnVerify.LinearGradientPen = false;
            btnVerify.Location = new Point(33, 290);
            btnVerify.Name = "btnVerify";
            btnVerify.PenWidth = 15;
            btnVerify.Rounding = true;
            btnVerify.RoundingInt = 70;
            btnVerify.Size = new Size(311, 44);
            btnVerify.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            btnVerify.TabIndex = 49;
            btnVerify.Tag = "Cyber";
            btnVerify.TextButton = "Verify Code";
            btnVerify.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            btnVerify.Timer_Effect_1 = 5;
            btnVerify.Timer_RGB = 300;
            btnVerify.Click += btnVerifyCode_Click;
            // 
            // pnlUsername
            // 
            pnlUsername.BackColor = Color.FromArgb(176, 233, 255);
            pnlUsername.BackgroundImageLayout = ImageLayout.None;
            pnlUsername.Controls.Add(tbxCode1);
            pnlUsername.Location = new Point(31, 196);
            pnlUsername.Name = "pnlUsername";
            pnlUsername.Size = new Size(55, 55);
            pnlUsername.TabIndex = 48;
            // 
            // tbxCode1
            // 
            tbxCode1.BackColor = Color.FromArgb(176, 233, 255);
            tbxCode1.BorderStyle = BorderStyle.None;
            tbxCode1.Font = new Font("Inter", 25F, FontStyle.Bold);
            tbxCode1.ForeColor = Color.FromArgb(24, 60, 114);
            tbxCode1.Location = new Point(4, 4);
            tbxCode1.Name = "tbxCode1";
            tbxCode1.Size = new Size(47, 41);
            tbxCode1.TabIndex = 10;
            tbxCode1.TabStop = false;
            tbxCode1.TextAlign = HorizontalAlignment.Center;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(176, 233, 255);
            panel1.BackgroundImageLayout = ImageLayout.None;
            panel1.Controls.Add(tbxCode2);
            panel1.Location = new Point(97, 196);
            panel1.Name = "panel1";
            panel1.Size = new Size(55, 55);
            panel1.TabIndex = 49;
            // 
            // tbxCode2
            // 
            tbxCode2.BackColor = Color.FromArgb(176, 233, 255);
            tbxCode2.BorderStyle = BorderStyle.None;
            tbxCode2.Font = new Font("Inter", 25F, FontStyle.Bold);
            tbxCode2.ForeColor = Color.FromArgb(24, 60, 114);
            tbxCode2.Location = new Point(4, 4);
            tbxCode2.Name = "tbxCode2";
            tbxCode2.Size = new Size(47, 41);
            tbxCode2.TabIndex = 11;
            tbxCode2.TabStop = false;
            tbxCode2.TextAlign = HorizontalAlignment.Center;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(176, 233, 255);
            panel2.BackgroundImageLayout = ImageLayout.None;
            panel2.Controls.Add(tbxCode3);
            panel2.Location = new Point(161, 196);
            panel2.Name = "panel2";
            panel2.Size = new Size(55, 55);
            panel2.TabIndex = 49;
            // 
            // tbxCode3
            // 
            tbxCode3.BackColor = Color.FromArgb(176, 233, 255);
            tbxCode3.BorderStyle = BorderStyle.None;
            tbxCode3.Font = new Font("Inter", 25F, FontStyle.Bold);
            tbxCode3.ForeColor = Color.FromArgb(24, 60, 114);
            tbxCode3.Location = new Point(4, 4);
            tbxCode3.Name = "tbxCode3";
            tbxCode3.Size = new Size(47, 41);
            tbxCode3.TabIndex = 11;
            tbxCode3.TabStop = false;
            tbxCode3.TextAlign = HorizontalAlignment.Center;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(176, 233, 255);
            panel3.BackgroundImageLayout = ImageLayout.None;
            panel3.Controls.Add(tbxCode4);
            panel3.Location = new Point(227, 196);
            panel3.Name = "panel3";
            panel3.Size = new Size(55, 55);
            panel3.TabIndex = 49;
            // 
            // tbxCode4
            // 
            tbxCode4.BackColor = Color.FromArgb(176, 233, 255);
            tbxCode4.BorderStyle = BorderStyle.None;
            tbxCode4.Font = new Font("Inter", 25F, FontStyle.Bold);
            tbxCode4.ForeColor = Color.FromArgb(24, 60, 114);
            tbxCode4.Location = new Point(4, 4);
            tbxCode4.Name = "tbxCode4";
            tbxCode4.Size = new Size(47, 41);
            tbxCode4.TabIndex = 11;
            tbxCode4.TabStop = false;
            tbxCode4.TextAlign = HorizontalAlignment.Center;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(176, 233, 255);
            panel4.BackgroundImageLayout = ImageLayout.None;
            panel4.Controls.Add(tbxCode5);
            panel4.Location = new Point(292, 196);
            panel4.Name = "panel4";
            panel4.Size = new Size(55, 55);
            panel4.TabIndex = 49;
            // 
            // tbxCode5
            // 
            tbxCode5.BackColor = Color.FromArgb(176, 233, 255);
            tbxCode5.BorderStyle = BorderStyle.None;
            tbxCode5.Font = new Font("Inter", 25F, FontStyle.Bold);
            tbxCode5.ForeColor = Color.FromArgb(24, 60, 114);
            tbxCode5.Location = new Point(4, 4);
            tbxCode5.Name = "tbxCode5";
            tbxCode5.Size = new Size(47, 41);
            tbxCode5.TabIndex = 11;
            tbxCode5.TabStop = false;
            tbxCode5.TextAlign = HorizontalAlignment.Center;
            // 
            // ForgetPassword2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(230, 249, 255);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(richTextBox5);
            Controls.Add(lblUserFName);
            Controls.Add(btnVerify);
            Controls.Add(pnlUsername);
            Name = "ForgetPassword2";
            Size = new Size(397, 458);
            Load += ForgetPassword2_Load;
            pnlUsername.ResumeLayout(false);
            pnlUsername.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox richTextBox5;
        private Label lblUserFName;
        private ReaLTaiizor.Controls.CyberButton btnVerify;
        private Panel pnlUsername;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private TextBox tbxCode1;
        private TextBox tbxCode2;
        private TextBox tbxCode3;
        private TextBox tbxCode4;
        private TextBox tbxCode5;
    }
}
