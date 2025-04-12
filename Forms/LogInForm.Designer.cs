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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogInForm));
            pbLogo = new PictureBox();
            pnlUsername = new Panel();
            contextShortcuts = new ContextMenuStrip(components);
            copyToolStripMenuItem = new ToolStripMenuItem();
            cutToolStripMenuItem = new ToolStripMenuItem();
            pasteToolStripMenuItem = new ToolStripMenuItem();
            selectAllToolStripMenuItem = new ToolStripMenuItem();
            tbxEnterUsername = new TextBox();
            btnLogin = new ReaLTaiizor.Controls.CyberButton();
            lblForgetPass = new Label();
            chkRememberMe = new CheckBox();
            pnlPassword = new Panel();
            tbxEnterPassword = new TextBox();
            pbPrivacy = new PictureBox();
            lblRemember = new Label();
            btnRegister = new ReaLTaiizor.Controls.CyberButton();
            panel2 = new Panel();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pbLogo).BeginInit();
            pnlUsername.SuspendLayout();
            contextShortcuts.SuspendLayout();
            pnlPassword.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbPrivacy).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pbLogo
            // 
            pbLogo.Cursor = Cursors.Hand;
            pbLogo.Image = Properties.Resources.Removal_915;
            pbLogo.Location = new Point(153, 57);
            pbLogo.Name = "pbLogo";
            pbLogo.Size = new Size(90, 90);
            pbLogo.SizeMode = PictureBoxSizeMode.Zoom;
            pbLogo.TabIndex = 0;
            pbLogo.TabStop = false;
            pbLogo.Click += pbLogo_Click;
            // 
            // pnlUsername
            // 
            pnlUsername.BackColor = Color.FromArgb(176, 233, 255);
            pnlUsername.BackgroundImageLayout = ImageLayout.None;
            pnlUsername.ContextMenuStrip = contextShortcuts;
            pnlUsername.Controls.Add(tbxEnterUsername);
            pnlUsername.Location = new Point(43, 170);
            pnlUsername.Name = "pnlUsername";
            pnlUsername.Size = new Size(311, 48);
            pnlUsername.TabIndex = 2;
            pnlUsername.Click += EnterUsername;
            // 
            // contextShortcuts
            // 
            contextShortcuts.Font = new Font("Inter", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            contextShortcuts.Items.AddRange(new ToolStripItem[] { copyToolStripMenuItem, cutToolStripMenuItem, pasteToolStripMenuItem, selectAllToolStripMenuItem });
            contextShortcuts.Name = "contextShortcuts";
            contextShortcuts.Size = new Size(132, 92);
            // 
            // copyToolStripMenuItem
            // 
            copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            copyToolStripMenuItem.Size = new Size(131, 22);
            copyToolStripMenuItem.Text = "Copy";
            copyToolStripMenuItem.Click += CopyText;
            // 
            // cutToolStripMenuItem
            // 
            cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            cutToolStripMenuItem.Size = new Size(131, 22);
            cutToolStripMenuItem.Text = "Cut";
            cutToolStripMenuItem.Click += CutText;
            // 
            // pasteToolStripMenuItem
            // 
            pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            pasteToolStripMenuItem.Size = new Size(131, 22);
            pasteToolStripMenuItem.Text = "Paste";
            pasteToolStripMenuItem.Click += PasteText;
            // 
            // selectAllToolStripMenuItem
            // 
            selectAllToolStripMenuItem.Name = "selectAllToolStripMenuItem";
            selectAllToolStripMenuItem.Size = new Size(131, 22);
            selectAllToolStripMenuItem.Text = "Select all";
            selectAllToolStripMenuItem.Click += SelectAllText;
            // 
            // tbxEnterUsername
            // 
            tbxEnterUsername.BackColor = Color.FromArgb(176, 233, 255);
            tbxEnterUsername.BorderStyle = BorderStyle.None;
            tbxEnterUsername.ContextMenuStrip = contextShortcuts;
            tbxEnterUsername.Font = new Font("Inter", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbxEnterUsername.ForeColor = Color.FromArgb(24, 60, 114);
            tbxEnterUsername.Location = new Point(30, 14);
            tbxEnterUsername.Name = "tbxEnterUsername";
            tbxEnterUsername.Size = new Size(237, 20);
            tbxEnterUsername.TabIndex = 9;
            tbxEnterUsername.TabStop = false;
            tbxEnterUsername.Text = "Username";
            tbxEnterUsername.Click += EnterUsername;
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
            btnLogin.Location = new Point(43, 291);
            btnLogin.Name = "btnLogin";
            btnLogin.PenWidth = 15;
            btnLogin.Rounding = true;
            btnLogin.RoundingInt = 70;
            btnLogin.Size = new Size(311, 44);
            btnLogin.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            btnLogin.TabIndex = 4;
            btnLogin.Tag = "Cyber";
            btnLogin.TextButton = "Log in";
            btnLogin.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            btnLogin.Timer_Effect_1 = 5;
            btnLogin.Timer_RGB = 300;
            btnLogin.Click += btnLogin_Click;
            // 
            // lblForgetPass
            // 
            lblForgetPass.AutoSize = true;
            lblForgetPass.Cursor = Cursors.Hand;
            lblForgetPass.Font = new Font("Inter", 10.25F);
            lblForgetPass.ForeColor = Color.FromArgb(84, 84, 84);
            lblForgetPass.Location = new Point(227, 339);
            lblForgetPass.Name = "lblForgetPass";
            lblForgetPass.RightToLeft = RightToLeft.No;
            lblForgetPass.Size = new Size(127, 21);
            lblForgetPass.TabIndex = 8;
            lblForgetPass.Text = "Forget Password?";
            lblForgetPass.Click += lblForgetPass_Click;
            // 
            // chkRememberMe
            // 
            chkRememberMe.AutoSize = true;
            chkRememberMe.Cursor = Cursors.Hand;
            chkRememberMe.Location = new Point(52, 344);
            chkRememberMe.Name = "chkRememberMe";
            chkRememberMe.Size = new Size(15, 14);
            chkRememberMe.TabIndex = 9;
            chkRememberMe.UseVisualStyleBackColor = true;
            // 
            // pnlPassword
            // 
            pnlPassword.BackColor = Color.FromArgb(176, 233, 255);
            pnlPassword.BackgroundImageLayout = ImageLayout.None;
            pnlPassword.Controls.Add(tbxEnterPassword);
            pnlPassword.Controls.Add(pbPrivacy);
            pnlPassword.Location = new Point(43, 232);
            pnlPassword.Name = "pnlPassword";
            pnlPassword.Size = new Size(309, 48);
            pnlPassword.TabIndex = 7;
            pnlPassword.Enter += EnterPassword;
            // 
            // tbxEnterPassword
            // 
            tbxEnterPassword.BackColor = Color.FromArgb(176, 233, 255);
            tbxEnterPassword.BorderStyle = BorderStyle.None;
            tbxEnterPassword.Font = new Font("Inter", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbxEnterPassword.ForeColor = Color.FromArgb(24, 60, 114);
            tbxEnterPassword.Location = new Point(32, 14);
            tbxEnterPassword.Name = "tbxEnterPassword";
            tbxEnterPassword.Size = new Size(227, 20);
            tbxEnterPassword.TabIndex = 8;
            tbxEnterPassword.TabStop = false;
            tbxEnterPassword.Text = "Password";
            tbxEnterPassword.Click += EnterPassword;
            tbxEnterPassword.KeyDown += tbxPassword_KeyDown;
            // 
            // pbPrivacy
            // 
            pbPrivacy.Cursor = Cursors.Hand;
            pbPrivacy.Image = Properties.Resources._3844443_disable_eye_inactive_see_show_icon;
            pbPrivacy.Location = new Point(265, 14);
            pbPrivacy.Name = "pbPrivacy";
            pbPrivacy.Size = new Size(33, 21);
            pbPrivacy.SizeMode = PictureBoxSizeMode.CenterImage;
            pbPrivacy.TabIndex = 7;
            pbPrivacy.TabStop = false;
            pbPrivacy.Click += pbPrivacy_Click;
            // 
            // lblRemember
            // 
            lblRemember.AutoSize = true;
            lblRemember.Cursor = Cursors.Hand;
            lblRemember.Font = new Font("Inter", 10.25F);
            lblRemember.ForeColor = Color.FromArgb(84, 84, 84);
            lblRemember.Location = new Point(68, 339);
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
            btnRegister.Cursor = Cursors.Hand;
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
            btnRegister.Location = new Point(83, 406);
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
            btnRegister.Click += btnRegister_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(153, 229, 255);
            panel2.Controls.Add(pictureBox3);
            panel2.Controls.Add(pictureBox2);
            panel2.Controls.Add(pictureBox1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(397, 28);
            panel2.TabIndex = 13;
            panel2.MouseDown += Login_MouseDown;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(344, 7);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(14, 14);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 2;
            pictureBox3.TabStop = false;
            pictureBox3.Click += Maximize;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(313, 5);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(19, 19);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            pictureBox2.Click += Minimize;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(371, 5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(18, 18);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += Close;
            // 
            // LogInForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(230, 249, 255);
            ClientSize = new Size(397, 486);
            Controls.Add(panel2);
            Controls.Add(btnRegister);
            Controls.Add(lblRemember);
            Controls.Add(pnlPassword);
            Controls.Add(chkRememberMe);
            Controls.Add(lblForgetPass);
            Controls.Add(btnLogin);
            Controls.Add(pnlUsername);
            Controls.Add(pbLogo);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "LogInForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LogInForm";
            Load += LogInForm_Load;
            MouseDown += Login_MouseDown;
            ((System.ComponentModel.ISupportInitialize)pbLogo).EndInit();
            pnlUsername.ResumeLayout(false);
            pnlUsername.PerformLayout();
            contextShortcuts.ResumeLayout(false);
            pnlPassword.ResumeLayout(false);
            pnlPassword.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbPrivacy).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pbLogo;
        private Panel pnlUsername;
        private ReaLTaiizor.Controls.CyberButton btnLogin;
        private Label lblUsername;
        private Label lblForgetPass;
        private CheckBox chkRememberMe;
        private Panel pnlPassword;
        private Label lblPassword;
        private Label lblRemember;
        private ReaLTaiizor.Controls.CyberButton btnRegister;
        private PictureBox pbPrivacy;
        private TextBox tbxEnterUsername;
        private TextBox tbxEnterPassword;
        private ContextMenuStrip contextShortcuts;
        private ToolStripMenuItem copyToolStripMenuItem;
        private ToolStripMenuItem cutToolStripMenuItem;
        private ToolStripMenuItem pasteToolStripMenuItem;
        private ToolStripMenuItem selectAllToolStripMenuItem;
        private Panel panel2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
    }
}