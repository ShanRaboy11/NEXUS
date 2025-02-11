namespace NEXUS.Forms
{
    partial class LogInForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pbLogo = new PictureBox();
            pnlUsername = new Panel();
            lblUsername = new Label();
            btnLogIn = new ReaLTaiizor.Controls.CyberButton();
            lblForgetPass = new Label();
            checkBox1 = new CheckBox();
            pnlPassword = new Panel();
            lblPassword = new Label();
            lblRemember = new Label();
            btnRegister = new ReaLTaiizor.Controls.CyberButton();
            panel1 = new Panel();
            cyberButton3 = new ReaLTaiizor.Controls.CyberButton();
            btnMaximize = new ReaLTaiizor.Controls.CyberButton();
            cyberButton1 = new ReaLTaiizor.Controls.CyberButton();
            ((System.ComponentModel.ISupportInitialize)pbLogo).BeginInit();
            pnlUsername.SuspendLayout();
            pnlPassword.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pbLogo
            // 
            pbLogo.Image = Properties.Resources.Removal_915;
            pbLogo.Location = new Point(148, 60);
            pbLogo.Name = "pbLogo";
            pbLogo.Size = new Size(87, 87);
            pbLogo.SizeMode = PictureBoxSizeMode.Zoom;
            pbLogo.TabIndex = 0;
            pbLogo.TabStop = false;
            // 
            // pnlUsername
            // 
            pnlUsername.BackColor = Color.FromArgb(176, 233, 255);
            pnlUsername.BackgroundImageLayout = ImageLayout.None;
            pnlUsername.Controls.Add(lblUsername);
            pnlUsername.Location = new Point(38, 170);
            pnlUsername.Name = "pnlUsername";
            pnlUsername.Size = new Size(311, 48);
            pnlUsername.TabIndex = 2;
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Font = new Font("Inter", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblUsername.ForeColor = Color.FromArgb(24, 60, 114);
            lblUsername.Location = new Point(32, 11);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(86, 23);
            lblUsername.TabIndex = 6;
            lblUsername.Text = "Username";
            // 
            // btnLogIn
            // 
            btnLogIn.Alpha = 20;
            btnLogIn.BackColor = Color.Transparent;
            btnLogIn.Background = true;
            btnLogIn.Background_WidthPen = 4F;
            btnLogIn.BackgroundPen = true;
            btnLogIn.ColorBackground = Color.FromArgb(24, 60, 114);
            btnLogIn.ColorBackground_1 = Color.FromArgb(24, 60, 114);
            btnLogIn.ColorBackground_2 = Color.FromArgb(24, 60, 114);
            btnLogIn.ColorBackground_Pen = Color.FromArgb(128, 223, 255);
            btnLogIn.ColorLighting = Color.FromArgb(24, 60, 114);
            btnLogIn.ColorPen_1 = Color.FromArgb(24, 60, 114);
            btnLogIn.ColorPen_2 = Color.FromArgb(24, 60, 114);
            btnLogIn.CyberButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            btnLogIn.Effect_1 = true;
            btnLogIn.Effect_1_ColorBackground = Color.FromArgb(29, 200, 238);
            btnLogIn.Effect_1_Transparency = 25;
            btnLogIn.Effect_2 = true;
            btnLogIn.Effect_2_ColorBackground = Color.White;
            btnLogIn.Effect_2_Transparency = 20;
            btnLogIn.Font = new Font("Inter", 12.25F);
            btnLogIn.ForeColor = Color.FromArgb(245, 245, 245);
            btnLogIn.Lighting = false;
            btnLogIn.LinearGradient_Background = false;
            btnLogIn.LinearGradientPen = false;
            btnLogIn.Location = new Point(38, 291);
            btnLogIn.Name = "btnLogIn";
            btnLogIn.PenWidth = 15;
            btnLogIn.Rounding = true;
            btnLogIn.RoundingInt = 70;
            btnLogIn.Size = new Size(311, 44);
            btnLogIn.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            btnLogIn.TabIndex = 4;
            btnLogIn.Tag = "Cyber";
            btnLogIn.TextButton = "Log in";
            btnLogIn.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            btnLogIn.Timer_Effect_1 = 5;
            btnLogIn.Timer_RGB = 300;
            // 
            // lblForgetPass
            // 
            lblForgetPass.AutoSize = true;
            lblForgetPass.Font = new Font("Inter", 10.25F);
            lblForgetPass.ForeColor = Color.FromArgb(84, 84, 84);
            lblForgetPass.Location = new Point(222, 339);
            lblForgetPass.Name = "lblForgetPass";
            lblForgetPass.RightToLeft = RightToLeft.No;
            lblForgetPass.Size = new Size(127, 21);
            lblForgetPass.TabIndex = 8;
            lblForgetPass.Text = "Forget Password?";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(47, 344);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(15, 14);
            checkBox1.TabIndex = 9;
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // pnlPassword
            // 
            pnlPassword.BackColor = Color.FromArgb(176, 233, 255);
            pnlPassword.BackgroundImageLayout = ImageLayout.None;
            pnlPassword.Controls.Add(lblPassword);
            pnlPassword.Location = new Point(38, 232);
            pnlPassword.Name = "pnlPassword";
            pnlPassword.Size = new Size(309, 48);
            pnlPassword.TabIndex = 7;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Inter", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPassword.ForeColor = Color.FromArgb(24, 60, 114);
            lblPassword.Location = new Point(32, 11);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(84, 23);
            lblPassword.TabIndex = 6;
            lblPassword.Text = "Password";
            // 
            // lblRemember
            // 
            lblRemember.AutoSize = true;
            lblRemember.Font = new Font("Inter", 10.25F);
            lblRemember.ForeColor = Color.FromArgb(84, 84, 84);
            lblRemember.Location = new Point(63, 339);
            lblRemember.Name = "lblRemember";
            lblRemember.RightToLeft = RightToLeft.No;
            lblRemember.Size = new Size(105, 21);
            lblRemember.TabIndex = 10;
            lblRemember.Text = "Remember me";
            // 
            // btnRegister
            // 
            btnRegister.Alpha = 20;
            btnRegister.BackColor = Color.Transparent;
            btnRegister.Background = true;
            btnRegister.Background_WidthPen = 4F;
            btnRegister.BackgroundPen = true;
            btnRegister.ColorBackground = Color.White;
            btnRegister.ColorBackground_1 = Color.White;
            btnRegister.ColorBackground_2 = Color.White;
            btnRegister.ColorBackground_Pen = Color.FromArgb(128, 223, 255);
            btnRegister.ColorLighting = Color.White;
            btnRegister.ColorPen_1 = Color.White;
            btnRegister.ColorPen_2 = Color.White;
            btnRegister.CyberButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            btnRegister.Effect_1 = true;
            btnRegister.Effect_1_ColorBackground = Color.FromArgb(29, 200, 238);
            btnRegister.Effect_1_Transparency = 25;
            btnRegister.Effect_2 = true;
            btnRegister.Effect_2_ColorBackground = Color.White;
            btnRegister.Effect_2_Transparency = 20;
            btnRegister.Font = new Font("Inter", 12.25F);
            btnRegister.ForeColor = Color.FromArgb(24, 60, 114);
            btnRegister.Lighting = false;
            btnRegister.LinearGradient_Background = false;
            btnRegister.LinearGradientPen = false;
            btnRegister.Location = new Point(78, 406);
            btnRegister.Name = "btnRegister";
            btnRegister.PenWidth = 15;
            btnRegister.Rounding = true;
            btnRegister.RoundingInt = 70;
            btnRegister.Size = new Size(227, 48);
            btnRegister.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            btnRegister.TabIndex = 11;
            btnRegister.Tag = "Cyber";
            btnRegister.TextButton = "Register";
            btnRegister.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            btnRegister.Timer_Effect_1 = 5;
            btnRegister.Timer_RGB = 300;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(153, 229, 255);
            panel1.Controls.Add(cyberButton3);
            panel1.Controls.Add(btnMaximize);
            panel1.Controls.Add(cyberButton1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(397, 34);
            panel1.TabIndex = 12;
            panel1.MouseDown += Login_MouseDown;
            // 
            // cyberButton3
            // 
            cyberButton3.Alpha = 20;
            cyberButton3.BackColor = Color.Transparent;
            cyberButton3.Background = true;
            cyberButton3.Background_WidthPen = 4F;
            cyberButton3.BackgroundPen = true;
            cyberButton3.ColorBackground = Color.White;
            cyberButton3.ColorBackground_1 = Color.White;
            cyberButton3.ColorBackground_2 = Color.White;
            cyberButton3.ColorBackground_Pen = Color.FromArgb(128, 223, 255);
            cyberButton3.ColorLighting = Color.White;
            cyberButton3.ColorPen_1 = Color.FromArgb(37, 52, 68);
            cyberButton3.ColorPen_2 = Color.FromArgb(41, 63, 86);
            cyberButton3.CyberButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            cyberButton3.Effect_1 = true;
            cyberButton3.Effect_1_ColorBackground = Color.FromArgb(29, 200, 238);
            cyberButton3.Effect_1_Transparency = 25;
            cyberButton3.Effect_2 = true;
            cyberButton3.Effect_2_ColorBackground = Color.FromArgb(29, 200, 238);
            cyberButton3.Effect_2_Transparency = 20;
            cyberButton3.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cyberButton3.ForeColor = Color.FromArgb(0, 229, 255);
            cyberButton3.Lighting = false;
            cyberButton3.LinearGradient_Background = false;
            cyberButton3.LinearGradientPen = false;
            cyberButton3.Location = new Point(304, 1);
            cyberButton3.Name = "cyberButton3";
            cyberButton3.PenWidth = 15;
            cyberButton3.Rounding = true;
            cyberButton3.RoundingInt = 70;
            cyberButton3.Size = new Size(30, 30);
            cyberButton3.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            cyberButton3.TabIndex = 8;
            cyberButton3.Tag = "Cyber";
            cyberButton3.TextButton = "_";
            cyberButton3.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            cyberButton3.Timer_Effect_1 = 5;
            cyberButton3.Timer_RGB = 300;
            // 
            // btnMaximize
            // 
            btnMaximize.Alpha = 20;
            btnMaximize.BackColor = Color.Transparent;
            btnMaximize.Background = true;
            btnMaximize.Background_WidthPen = 4F;
            btnMaximize.BackgroundPen = true;
            btnMaximize.ColorBackground = Color.White;
            btnMaximize.ColorBackground_1 = Color.White;
            btnMaximize.ColorBackground_2 = Color.White;
            btnMaximize.ColorBackground_Pen = Color.FromArgb(128, 223, 255);
            btnMaximize.ColorLighting = Color.White;
            btnMaximize.ColorPen_1 = Color.FromArgb(37, 52, 68);
            btnMaximize.ColorPen_2 = Color.FromArgb(41, 63, 86);
            btnMaximize.CyberButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            btnMaximize.Effect_1 = true;
            btnMaximize.Effect_1_ColorBackground = Color.FromArgb(29, 200, 238);
            btnMaximize.Effect_1_Transparency = 25;
            btnMaximize.Effect_2 = true;
            btnMaximize.Effect_2_ColorBackground = Color.White;
            btnMaximize.Effect_2_Transparency = 20;
            btnMaximize.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMaximize.ForeColor = Color.FromArgb(0, 229, 255);
            btnMaximize.Lighting = false;
            btnMaximize.LinearGradient_Background = false;
            btnMaximize.LinearGradientPen = false;
            btnMaximize.Location = new Point(335, 1);
            btnMaximize.Name = "btnMaximize";
            btnMaximize.PenWidth = 15;
            btnMaximize.Rounding = true;
            btnMaximize.RoundingInt = 70;
            btnMaximize.Size = new Size(30, 30);
            btnMaximize.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            btnMaximize.TabIndex = 7;
            btnMaximize.Tag = "Cyber";
            btnMaximize.TextButton = "⛶";
            btnMaximize.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            btnMaximize.Timer_Effect_1 = 5;
            btnMaximize.Timer_RGB = 300;
            // 
            // cyberButton1
            // 
            cyberButton1.Alpha = 20;
            cyberButton1.BackColor = Color.Transparent;
            cyberButton1.Background = true;
            cyberButton1.Background_WidthPen = 4F;
            cyberButton1.BackgroundPen = true;
            cyberButton1.ColorBackground = Color.White;
            cyberButton1.ColorBackground_1 = Color.White;
            cyberButton1.ColorBackground_2 = Color.White;
            cyberButton1.ColorBackground_Pen = Color.FromArgb(128, 223, 255);
            cyberButton1.ColorLighting = Color.White;
            cyberButton1.ColorPen_1 = Color.FromArgb(37, 52, 68);
            cyberButton1.ColorPen_2 = Color.FromArgb(41, 63, 86);
            cyberButton1.CyberButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            cyberButton1.Effect_1 = true;
            cyberButton1.Effect_1_ColorBackground = Color.FromArgb(29, 200, 238);
            cyberButton1.Effect_1_Transparency = 25;
            cyberButton1.Effect_2 = true;
            cyberButton1.Effect_2_ColorBackground = Color.White;
            cyberButton1.Effect_2_Transparency = 20;
            cyberButton1.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cyberButton1.ForeColor = Color.FromArgb(0, 229, 255);
            cyberButton1.Lighting = false;
            cyberButton1.LinearGradient_Background = false;
            cyberButton1.LinearGradientPen = false;
            cyberButton1.Location = new Point(366, 1);
            cyberButton1.Name = "cyberButton1";
            cyberButton1.PenWidth = 15;
            cyberButton1.Rounding = true;
            cyberButton1.RoundingInt = 70;
            cyberButton1.Size = new Size(30, 30);
            cyberButton1.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            cyberButton1.TabIndex = 6;
            cyberButton1.Tag = "Cyber";
            cyberButton1.TextButton = "x";
            cyberButton1.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            cyberButton1.Timer_Effect_1 = 5;
            cyberButton1.Timer_RGB = 300;
            // 
            // LogInForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(230, 249, 255);
            ClientSize = new Size(397, 486);
            Controls.Add(panel1);
            Controls.Add(btnRegister);
            Controls.Add(lblRemember);
            Controls.Add(pnlPassword);
            Controls.Add(checkBox1);
            Controls.Add(lblForgetPass);
            Controls.Add(btnLogIn);
            Controls.Add(pnlUsername);
            Controls.Add(pbLogo);
            FormBorderStyle = FormBorderStyle.None;
            Name = "LogInForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LogInForm";
            MouseDown += Login_MouseDown;
            ((System.ComponentModel.ISupportInitialize)pbLogo).EndInit();
            pnlUsername.ResumeLayout(false);
            pnlUsername.PerformLayout();
            pnlPassword.ResumeLayout(false);
            pnlPassword.PerformLayout();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pbLogo;
        private Panel pnlUsername;
        private ReaLTaiizor.Controls.CyberButton btnLogIn;
        private Label lblUsername;
        private Label lblForgetPass;
        private CheckBox checkBox1;
        private Panel pnlPassword;
        private Label lblPassword;
        private Label lblRemember;
        private ReaLTaiizor.Controls.CyberButton btnRegister;
        private Panel panel1;
        private ReaLTaiizor.Controls.CyberButton cyberButton3;
        private ReaLTaiizor.Controls.CyberButton btnMaximize;
        private ReaLTaiizor.Controls.CyberButton cyberButton1;
    }
}