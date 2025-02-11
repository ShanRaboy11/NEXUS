namespace NEXUS
{
    partial class WelcomeForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WelcomeForm));
            panel1 = new Panel();
            cyberButton3 = new ReaLTaiizor.Controls.CyberButton();
            btnMaximize = new ReaLTaiizor.Controls.CyberButton();
            cyberButton1 = new ReaLTaiizor.Controls.CyberButton();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
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
            panel1.Size = new Size(485, 34);
            panel1.TabIndex = 0;
            panel1.MouseDown += Form1_MouseDown;
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
            cyberButton3.ColorBackground_Pen = Color.White;
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
            cyberButton3.Location = new Point(389, 1);
            cyberButton3.Name = "cyberButton3";
            cyberButton3.PenWidth = 15;
            cyberButton3.Rounding = true;
            cyberButton3.RoundingInt = 70;
            cyberButton3.Size = new Size(30, 30);
            cyberButton3.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            cyberButton3.TabIndex = 5;
            cyberButton3.Tag = "Cyber";
            cyberButton3.TextButton = "_";
            cyberButton3.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            cyberButton3.Timer_Effect_1 = 5;
            cyberButton3.Timer_RGB = 300;
            cyberButton3.Click += Minimize;
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
            btnMaximize.ColorBackground_Pen = Color.White;
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
            btnMaximize.Location = new Point(420, 1);
            btnMaximize.Name = "btnMaximize";
            btnMaximize.PenWidth = 15;
            btnMaximize.Rounding = true;
            btnMaximize.RoundingInt = 70;
            btnMaximize.Size = new Size(30, 30);
            btnMaximize.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            btnMaximize.TabIndex = 4;
            btnMaximize.Tag = "Cyber";
            btnMaximize.TextButton = "⛶";
            btnMaximize.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            btnMaximize.Timer_Effect_1 = 5;
            btnMaximize.Timer_RGB = 300;
            btnMaximize.Click += Maximize;
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
            cyberButton1.ColorBackground_Pen = Color.White;
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
            cyberButton1.Location = new Point(451, 1);
            cyberButton1.Name = "cyberButton1";
            cyberButton1.PenWidth = 15;
            cyberButton1.Rounding = true;
            cyberButton1.RoundingInt = 70;
            cyberButton1.Size = new Size(30, 30);
            cyberButton1.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            cyberButton1.TabIndex = 3;
            cyberButton1.Tag = "Cyber";
            cyberButton1.TextButton = "x";
            cyberButton1.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            cyberButton1.Timer_Effect_1 = 5;
            cyberButton1.Timer_RGB = 300;
            cyberButton1.Click += Close;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = Properties.Resources.NEXUS__1__removebg_preview__1_;
            pictureBox1.Location = new Point(0, 34);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(485, 448);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            pictureBox1.MouseDown += Form1_MouseDown;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Helvetica Neue", 17.9999981F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(166, 102);
            label1.Name = "label1";
            label1.Size = new Size(134, 27);
            label1.TabIndex = 2;
            label1.Text = "Welcome to";
            // 
            // WelcomeForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(230, 249, 255);
            ClientSize = new Size(485, 482);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "WelcomeForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Nexus";
            MouseDown += Form1_MouseDown;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label1;
        private ReaLTaiizor.Controls.CyberButton btnMaximize;
        private ReaLTaiizor.Controls.CyberButton cyberButton1;
        private ReaLTaiizor.Controls.CyberButton cyberButton3;
    }
}
