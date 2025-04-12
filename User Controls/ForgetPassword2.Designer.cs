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
            btnLogin = new ReaLTaiizor.Controls.CyberButton();
            pnlUsername = new Panel();
            textBox1 = new TextBox();
            panel1 = new Panel();
            textBox2 = new TextBox();
            panel2 = new Panel();
            textBox3 = new TextBox();
            panel3 = new Panel();
            textBox4 = new TextBox();
            panel4 = new Panel();
            textBox5 = new TextBox();
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
            btnLogin.Location = new Point(33, 290);
            btnLogin.Name = "btnLogin";
            btnLogin.PenWidth = 15;
            btnLogin.Rounding = true;
            btnLogin.RoundingInt = 70;
            btnLogin.Size = new Size(311, 44);
            btnLogin.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            btnLogin.TabIndex = 49;
            btnLogin.Tag = "Cyber";
            btnLogin.TextButton = "Verify Code";
            btnLogin.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            btnLogin.Timer_Effect_1 = 5;
            btnLogin.Timer_RGB = 300;
            // 
            // pnlUsername
            // 
            pnlUsername.BackColor = Color.FromArgb(176, 233, 255);
            pnlUsername.BackgroundImageLayout = ImageLayout.None;
            pnlUsername.Controls.Add(textBox1);
            pnlUsername.Location = new Point(31, 196);
            pnlUsername.Name = "pnlUsername";
            pnlUsername.Size = new Size(55, 55);
            pnlUsername.TabIndex = 48;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(176, 233, 255);
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Inter", 25F, FontStyle.Bold);
            textBox1.ForeColor = Color.FromArgb(24, 60, 114);
            textBox1.Location = new Point(4, 4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(47, 41);
            textBox1.TabIndex = 10;
            textBox1.TabStop = false;
            textBox1.Text = "5";
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(176, 233, 255);
            panel1.BackgroundImageLayout = ImageLayout.None;
            panel1.Controls.Add(textBox2);
            panel1.Location = new Point(97, 196);
            panel1.Name = "panel1";
            panel1.Size = new Size(55, 55);
            panel1.TabIndex = 49;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.FromArgb(176, 233, 255);
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Font = new Font("Inter", 25F, FontStyle.Bold);
            textBox2.ForeColor = Color.FromArgb(24, 60, 114);
            textBox2.Location = new Point(4, 4);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(47, 41);
            textBox2.TabIndex = 11;
            textBox2.TabStop = false;
            textBox2.Text = "5";
            textBox2.TextAlign = HorizontalAlignment.Center;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(176, 233, 255);
            panel2.BackgroundImageLayout = ImageLayout.None;
            panel2.Controls.Add(textBox3);
            panel2.Location = new Point(161, 196);
            panel2.Name = "panel2";
            panel2.Size = new Size(55, 55);
            panel2.TabIndex = 49;
            // 
            // textBox3
            // 
            textBox3.BackColor = Color.FromArgb(176, 233, 255);
            textBox3.BorderStyle = BorderStyle.None;
            textBox3.Font = new Font("Inter", 25F, FontStyle.Bold);
            textBox3.ForeColor = Color.FromArgb(24, 60, 114);
            textBox3.Location = new Point(4, 4);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(47, 41);
            textBox3.TabIndex = 11;
            textBox3.TabStop = false;
            textBox3.Text = "5";
            textBox3.TextAlign = HorizontalAlignment.Center;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(176, 233, 255);
            panel3.BackgroundImageLayout = ImageLayout.None;
            panel3.Controls.Add(textBox4);
            panel3.Location = new Point(227, 196);
            panel3.Name = "panel3";
            panel3.Size = new Size(55, 55);
            panel3.TabIndex = 49;
            // 
            // textBox4
            // 
            textBox4.BackColor = Color.FromArgb(176, 233, 255);
            textBox4.BorderStyle = BorderStyle.None;
            textBox4.Font = new Font("Inter", 25F, FontStyle.Bold);
            textBox4.ForeColor = Color.FromArgb(24, 60, 114);
            textBox4.Location = new Point(4, 4);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(47, 41);
            textBox4.TabIndex = 11;
            textBox4.TabStop = false;
            textBox4.Text = "5";
            textBox4.TextAlign = HorizontalAlignment.Center;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(176, 233, 255);
            panel4.BackgroundImageLayout = ImageLayout.None;
            panel4.Controls.Add(textBox5);
            panel4.Location = new Point(292, 196);
            panel4.Name = "panel4";
            panel4.Size = new Size(55, 55);
            panel4.TabIndex = 49;
            // 
            // textBox5
            // 
            textBox5.BackColor = Color.FromArgb(176, 233, 255);
            textBox5.BorderStyle = BorderStyle.None;
            textBox5.Font = new Font("Inter", 25F, FontStyle.Bold);
            textBox5.ForeColor = Color.FromArgb(24, 60, 114);
            textBox5.Location = new Point(4, 4);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(47, 41);
            textBox5.TabIndex = 11;
            textBox5.TabStop = false;
            textBox5.Text = "5";
            textBox5.TextAlign = HorizontalAlignment.Center;
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
            Controls.Add(btnLogin);
            Controls.Add(pnlUsername);
            Name = "ForgetPassword2";
            Size = new Size(397, 458);
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
        private ReaLTaiizor.Controls.CyberButton btnLogin;
        private Panel pnlUsername;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
    }
}
