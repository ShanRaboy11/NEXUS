namespace NEXUS.Forms
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            panel2 = new Panel();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            pnlSidebar = new Panel();
            parrotButton7 = new ReaLTaiizor.Controls.ParrotButton();
            parrotButton6 = new ReaLTaiizor.Controls.ParrotButton();
            parrotButton5 = new ReaLTaiizor.Controls.ParrotButton();
            parrotButton4 = new ReaLTaiizor.Controls.ParrotButton();
            parrotButton3 = new ReaLTaiizor.Controls.ParrotButton();
            parrotButton2 = new ReaLTaiizor.Controls.ParrotButton();
            parrotButton1 = new ReaLTaiizor.Controls.ParrotButton();
            pbAbout = new PictureBox();
            SidebarTransition = new System.Windows.Forms.Timer(components);
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            pnlSidebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbAbout).BeginInit();
            SuspendLayout();
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
            panel2.Size = new Size(1400, 28);
            panel2.TabIndex = 17;
            panel2.MouseDown += Dashboard_MouseDown;
            // 
            // pictureBox3
            // 
            pictureBox3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(1342, 6);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(14, 14);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 2;
            pictureBox3.TabStop = false;
            pictureBox3.Click += Maximize;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(1311, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(19, 19);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            pictureBox2.Click += Minimize;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(1369, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(18, 18);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += Close;
            // 
            // pnlSidebar
            // 
            pnlSidebar.BackColor = Color.White;
            pnlSidebar.Controls.Add(parrotButton7);
            pnlSidebar.Controls.Add(parrotButton6);
            pnlSidebar.Controls.Add(parrotButton5);
            pnlSidebar.Controls.Add(parrotButton4);
            pnlSidebar.Controls.Add(parrotButton3);
            pnlSidebar.Controls.Add(parrotButton2);
            pnlSidebar.Controls.Add(parrotButton1);
            pnlSidebar.Controls.Add(pbAbout);
            pnlSidebar.Dock = DockStyle.Left;
            pnlSidebar.Location = new Point(0, 28);
            pnlSidebar.Name = "pnlSidebar";
            pnlSidebar.Size = new Size(88, 879);
            pnlSidebar.TabIndex = 18;
            pnlSidebar.Click += pnlSidebar_Click;
            // 
            // parrotButton7
            // 
            parrotButton7.BackgroundColor = Color.FromArgb(255, 255, 255);
            parrotButton7.ButtonImage = Properties.Resources.scan_normall;
            parrotButton7.ButtonStyle = ReaLTaiizor.Controls.ParrotButton.Style.MaterialRounded;
            parrotButton7.ButtonText = "Scan";
            parrotButton7.ClickBackColor = Color.FromArgb(230, 249, 255);
            parrotButton7.ClickTextColor = Color.DodgerBlue;
            parrotButton7.CornerRadius = 8;
            parrotButton7.Font = new Font("Inter", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            parrotButton7.Horizontal_Alignment = StringAlignment.Center;
            parrotButton7.HoverBackgroundColor = Color.FromArgb(230, 249, 255);
            parrotButton7.HoverTextColor = Color.DodgerBlue;
            parrotButton7.ImagePosition = ReaLTaiizor.Controls.ParrotButton.ImgPosition.Left;
            parrotButton7.Location = new Point(24, 325);
            parrotButton7.Name = "parrotButton7";
            parrotButton7.Size = new Size(150, 33);
            parrotButton7.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            parrotButton7.TabIndex = 30;
            parrotButton7.TextColor = Color.FromArgb(24, 60, 114);
            parrotButton7.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            parrotButton7.Vertical_Alignment = StringAlignment.Center;
            parrotButton7.Click += btnScan_Click;
            // 
            // parrotButton6
            // 
            parrotButton6.BackgroundColor = Color.FromArgb(255, 255, 255);
            parrotButton6.ButtonImage = Properties.Resources.route_normal;
            parrotButton6.ButtonStyle = ReaLTaiizor.Controls.ParrotButton.Style.MaterialRounded;
            parrotButton6.ButtonText = "Route";
            parrotButton6.ClickBackColor = Color.FromArgb(230, 249, 255);
            parrotButton6.ClickTextColor = Color.DodgerBlue;
            parrotButton6.CornerRadius = 8;
            parrotButton6.Font = new Font("Inter", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            parrotButton6.Horizontal_Alignment = StringAlignment.Center;
            parrotButton6.HoverBackgroundColor = Color.FromArgb(230, 249, 255);
            parrotButton6.HoverTextColor = Color.DodgerBlue;
            parrotButton6.ImagePosition = ReaLTaiizor.Controls.ParrotButton.ImgPosition.Left;
            parrotButton6.Location = new Point(24, 250);
            parrotButton6.Name = "parrotButton6";
            parrotButton6.Size = new Size(150, 33);
            parrotButton6.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            parrotButton6.TabIndex = 29;
            parrotButton6.TextColor = Color.FromArgb(24, 60, 114);
            parrotButton6.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            parrotButton6.Vertical_Alignment = StringAlignment.Center;
            parrotButton6.Click += btnRoute_Click;
            // 
            // parrotButton5
            // 
            parrotButton5.BackgroundColor = Color.FromArgb(255, 255, 255);
            parrotButton5.ButtonImage = Properties.Resources.home_normal;
            parrotButton5.ButtonStyle = ReaLTaiizor.Controls.ParrotButton.Style.MaterialRounded;
            parrotButton5.ButtonText = "Home";
            parrotButton5.ClickBackColor = Color.FromArgb(230, 249, 255);
            parrotButton5.ClickTextColor = Color.DodgerBlue;
            parrotButton5.CornerRadius = 8;
            parrotButton5.Font = new Font("Inter", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            parrotButton5.Horizontal_Alignment = StringAlignment.Center;
            parrotButton5.HoverBackgroundColor = Color.FromArgb(230, 249, 255);
            parrotButton5.HoverTextColor = Color.DodgerBlue;
            parrotButton5.ImagePosition = ReaLTaiizor.Controls.ParrotButton.ImgPosition.Left;
            parrotButton5.Location = new Point(24, 175);
            parrotButton5.Name = "parrotButton5";
            parrotButton5.Size = new Size(150, 33);
            parrotButton5.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            parrotButton5.TabIndex = 28;
            parrotButton5.TextColor = Color.FromArgb(24, 60, 114);
            parrotButton5.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            parrotButton5.Vertical_Alignment = StringAlignment.Center;
            parrotButton5.Click += btnHome_Click;
            // 
            // parrotButton4
            // 
            parrotButton4.BackgroundColor = Color.FromArgb(255, 255, 255);
            parrotButton4.ButtonImage = Properties.Resources.emergency__1_;
            parrotButton4.ButtonStyle = ReaLTaiizor.Controls.ParrotButton.Style.MaterialRounded;
            parrotButton4.ButtonText = "Report";
            parrotButton4.ClickBackColor = Color.FromArgb(230, 249, 255);
            parrotButton4.ClickTextColor = Color.DodgerBlue;
            parrotButton4.CornerRadius = 8;
            parrotButton4.Font = new Font("Inter", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            parrotButton4.Horizontal_Alignment = StringAlignment.Center;
            parrotButton4.HoverBackgroundColor = Color.FromArgb(230, 249, 255);
            parrotButton4.HoverTextColor = Color.DodgerBlue;
            parrotButton4.ImagePosition = ReaLTaiizor.Controls.ParrotButton.ImgPosition.Left;
            parrotButton4.Location = new Point(24, 400);
            parrotButton4.Name = "parrotButton4";
            parrotButton4.Size = new Size(150, 33);
            parrotButton4.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            parrotButton4.TabIndex = 27;
            parrotButton4.TextColor = Color.FromArgb(24, 60, 114);
            parrotButton4.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            parrotButton4.Vertical_Alignment = StringAlignment.Center;
            parrotButton4.Click += btnReport_Click;
            // 
            // parrotButton3
            // 
            parrotButton3.BackgroundColor = Color.FromArgb(255, 255, 255);
            parrotButton3.ButtonImage = Properties.Resources.rate_normal;
            parrotButton3.ButtonStyle = ReaLTaiizor.Controls.ParrotButton.Style.MaterialRounded;
            parrotButton3.ButtonText = "Rate";
            parrotButton3.ClickBackColor = Color.FromArgb(230, 249, 255);
            parrotButton3.ClickTextColor = Color.DodgerBlue;
            parrotButton3.CornerRadius = 8;
            parrotButton3.Font = new Font("Inter", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            parrotButton3.Horizontal_Alignment = StringAlignment.Center;
            parrotButton3.HoverBackgroundColor = Color.FromArgb(230, 249, 255);
            parrotButton3.HoverTextColor = Color.DodgerBlue;
            parrotButton3.ImagePosition = ReaLTaiizor.Controls.ParrotButton.ImgPosition.Left;
            parrotButton3.Location = new Point(24, 475);
            parrotButton3.Name = "parrotButton3";
            parrotButton3.Size = new Size(150, 33);
            parrotButton3.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            parrotButton3.TabIndex = 26;
            parrotButton3.TextColor = Color.FromArgb(24, 60, 114);
            parrotButton3.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            parrotButton3.Vertical_Alignment = StringAlignment.Center;
            parrotButton3.Click += btnRate_Click;
            // 
            // parrotButton2
            // 
            parrotButton2.BackgroundColor = Color.FromArgb(255, 255, 255);
            parrotButton2.ButtonImage = Properties.Resources.history_normal;
            parrotButton2.ButtonStyle = ReaLTaiizor.Controls.ParrotButton.Style.MaterialRounded;
            parrotButton2.ButtonText = "History";
            parrotButton2.ClickBackColor = Color.FromArgb(153, 229, 255);
            parrotButton2.ClickTextColor = Color.DodgerBlue;
            parrotButton2.CornerRadius = 8;
            parrotButton2.Font = new Font("Inter", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            parrotButton2.Horizontal_Alignment = StringAlignment.Center;
            parrotButton2.HoverBackgroundColor = Color.FromArgb(230, 249, 255);
            parrotButton2.HoverTextColor = Color.DodgerBlue;
            parrotButton2.ImagePosition = ReaLTaiizor.Controls.ParrotButton.ImgPosition.Left;
            parrotButton2.Location = new Point(24, 550);
            parrotButton2.Name = "parrotButton2";
            parrotButton2.Size = new Size(150, 33);
            parrotButton2.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            parrotButton2.TabIndex = 25;
            parrotButton2.TextColor = Color.FromArgb(24, 60, 114);
            parrotButton2.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            parrotButton2.Vertical_Alignment = StringAlignment.Center;
            parrotButton2.Click += btnHistory_Click;
            // 
            // parrotButton1
            // 
            parrotButton1.BackgroundColor = Color.FromArgb(255, 255, 255);
            parrotButton1.ButtonImage = Properties.Resources.logout_normal;
            parrotButton1.ButtonStyle = ReaLTaiizor.Controls.ParrotButton.Style.MaterialRounded;
            parrotButton1.ButtonText = "Logout";
            parrotButton1.ClickBackColor = Color.FromArgb(230, 249, 255);
            parrotButton1.ClickTextColor = Color.DodgerBlue;
            parrotButton1.CornerRadius = 8;
            parrotButton1.Font = new Font("Inter", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            parrotButton1.Horizontal_Alignment = StringAlignment.Center;
            parrotButton1.HoverBackgroundColor = Color.FromArgb(230, 249, 255);
            parrotButton1.HoverTextColor = Color.DodgerBlue;
            parrotButton1.ImagePosition = ReaLTaiizor.Controls.ParrotButton.ImgPosition.Left;
            parrotButton1.Location = new Point(25, 811);
            parrotButton1.Name = "parrotButton1";
            parrotButton1.Size = new Size(150, 33);
            parrotButton1.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            parrotButton1.TabIndex = 19;
            parrotButton1.TextColor = Color.FromArgb(24, 60, 114);
            parrotButton1.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            parrotButton1.Vertical_Alignment = StringAlignment.Center;
            parrotButton1.Click += btnLogout_Click;
            // 
            // pbAbout
            // 
            pbAbout.Cursor = Cursors.Hand;
            pbAbout.Image = Properties.Resources.Removal_915;
            pbAbout.Location = new Point(15, 25);
            pbAbout.Name = "pbAbout";
            pbAbout.Size = new Size(58, 60);
            pbAbout.SizeMode = PictureBoxSizeMode.Zoom;
            pbAbout.TabIndex = 6;
            pbAbout.TabStop = false;
            pbAbout.Click += pbAbout_Click;
            // 
            // SidebarTransition
            // 
            SidebarTransition.Interval = 10;
            SidebarTransition.Tick += SidebarTransition_Tick;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(230, 249, 255);
            ClientSize = new Size(1400, 907);
            Controls.Add(pnlSidebar);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Dashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Dashboard";
            MouseDown += Dashboard_MouseDown;
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            pnlSidebar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbAbout).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Panel pnlSidebar;
        private PictureBox pbAbout;
        private System.Windows.Forms.Timer SidebarTransition;
        private ReaLTaiizor.Controls.ParrotButton parrotButton1;
        private ReaLTaiizor.Controls.ParrotButton parrotButton2;
        private ReaLTaiizor.Controls.ParrotButton parrotButton6;
        private ReaLTaiizor.Controls.ParrotButton parrotButton5;
        private ReaLTaiizor.Controls.ParrotButton parrotButton4;
        private ReaLTaiizor.Controls.ParrotButton parrotButton3;
        private ReaLTaiizor.Controls.ParrotButton parrotButton7;
    }
}