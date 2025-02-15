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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WelcomeForm));
            pbNexus = new PictureBox();
            contextMenuStrip1 = new ContextMenuStrip(components);
            aboutToolStripMenuItem = new ToolStripMenuItem();
            closeToolStripMenuItem = new ToolStripMenuItem();
            minimizeToolStripMenuItem = new ToolStripMenuItem();
            maximizeToolStripMenuItem = new ToolStripMenuItem();
            label1 = new Label();
            btnEnter = new ReaLTaiizor.Controls.CyberButton();
            panel2 = new Panel();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pbNexus).BeginInit();
            contextMenuStrip1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pbNexus
            // 
            pbNexus.ContextMenuStrip = contextMenuStrip1;
            pbNexus.Cursor = Cursors.Hand;
            pbNexus.Image = Properties.Resources.NEXUS__1__removebg_preview__1_;
            pbNexus.Location = new Point(0, 2);
            pbNexus.Name = "pbNexus";
            pbNexus.Size = new Size(485, 482);
            pbNexus.SizeMode = PictureBoxSizeMode.Zoom;
            pbNexus.TabIndex = 1;
            pbNexus.TabStop = false;
            pbNexus.MouseDown += Welcome_MouseDown;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Font = new Font("Inter", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { aboutToolStripMenuItem, closeToolStripMenuItem, minimizeToolStripMenuItem, maximizeToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(135, 92);
            // 
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.Size = new Size(134, 22);
            aboutToolStripMenuItem.Text = "About";
            aboutToolStripMenuItem.Click += AboutPage;
            // 
            // closeToolStripMenuItem
            // 
            closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            closeToolStripMenuItem.Size = new Size(134, 22);
            closeToolStripMenuItem.Text = "Close";
            // 
            // minimizeToolStripMenuItem
            // 
            minimizeToolStripMenuItem.Name = "minimizeToolStripMenuItem";
            minimizeToolStripMenuItem.Size = new Size(134, 22);
            minimizeToolStripMenuItem.Text = "Minimize";
            // 
            // maximizeToolStripMenuItem
            // 
            maximizeToolStripMenuItem.Name = "maximizeToolStripMenuItem";
            maximizeToolStripMenuItem.Size = new Size(134, 22);
            maximizeToolStripMenuItem.Text = "Maximize";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Inter SemiBold", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.ForeColor = Color.FromArgb(24, 60, 114);
            label1.Location = new Point(151, 63);
            label1.Name = "label1";
            label1.Size = new Size(152, 35);
            label1.TabIndex = 2;
            label1.Text = "Welcome to";
            // 
            // btnEnter
            // 
            btnEnter.Alpha = 20;
            btnEnter.BackColor = Color.Transparent;
            btnEnter.Background = true;
            btnEnter.Background_WidthPen = 4F;
            btnEnter.BackgroundPen = true;
            btnEnter.ColorBackground = Color.FromArgb(128, 223, 255);
            btnEnter.ColorBackground_1 = Color.FromArgb(128, 223, 255);
            btnEnter.ColorBackground_2 = Color.FromArgb(128, 223, 255);
            btnEnter.ColorBackground_Pen = Color.FromArgb(128, 223, 255);
            btnEnter.ColorLighting = Color.FromArgb(128, 223, 255);
            btnEnter.ColorPen_1 = Color.FromArgb(128, 223, 255);
            btnEnter.ColorPen_2 = Color.FromArgb(128, 223, 255);
            btnEnter.Cursor = Cursors.Hand;
            btnEnter.CyberButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            btnEnter.Effect_1 = true;
            btnEnter.Effect_1_ColorBackground = Color.FromArgb(29, 200, 238);
            btnEnter.Effect_1_Transparency = 25;
            btnEnter.Effect_2 = true;
            btnEnter.Effect_2_ColorBackground = Color.White;
            btnEnter.Effect_2_Transparency = 20;
            btnEnter.Font = new Font("Inter Medium", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEnter.ForeColor = Color.FromArgb(24, 60, 114);
            btnEnter.Lighting = false;
            btnEnter.LinearGradient_Background = false;
            btnEnter.LinearGradientPen = false;
            btnEnter.Location = new Point(153, 401);
            btnEnter.Name = "btnEnter";
            btnEnter.PenWidth = 15;
            btnEnter.Rounding = true;
            btnEnter.RoundingInt = 70;
            btnEnter.Size = new Size(165, 47);
            btnEnter.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            btnEnter.TabIndex = 5;
            btnEnter.Tag = "Cyber";
            btnEnter.TextButton = "Enter";
            btnEnter.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            btnEnter.Timer_Effect_1 = 5;
            btnEnter.Timer_RGB = 300;
            btnEnter.Click += cyberButton2_Click;
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
            panel2.Size = new Size(485, 28);
            panel2.TabIndex = 14;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(428, 7);
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
            pictureBox2.Location = new Point(397, 5);
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
            pictureBox1.Location = new Point(455, 5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(18, 18);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += Close;
            // 
            // WelcomeForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(230, 249, 255);
            ClientSize = new Size(485, 482);
            Controls.Add(panel2);
            Controls.Add(btnEnter);
            Controls.Add(label1);
            Controls.Add(pbNexus);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "WelcomeForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Nexus";
            MouseDown += Welcome_MouseDown;
            ((System.ComponentModel.ISupportInitialize)pbNexus).EndInit();
            contextMenuStrip1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pbNexus;
        private Label label1;
        private ReaLTaiizor.Controls.CyberButton btnEnter;
        private Panel panel2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private ToolStripMenuItem closeToolStripMenuItem;
        private ToolStripMenuItem minimizeToolStripMenuItem;
        private ToolStripMenuItem maximizeToolStripMenuItem;
    }
}
