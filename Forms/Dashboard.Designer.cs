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
            btnRateHover = new PictureBox();
            btnHistoryHover = new PictureBox();
            btnLogoutHover = new PictureBox();
            btnReportHover = new PictureBox();
            btnScanHover = new PictureBox();
            btnRouteHover = new PictureBox();
            btnHomeHover = new PictureBox();
            btnScan = new ReaLTaiizor.Controls.ParrotButton();
            btnRoute = new ReaLTaiizor.Controls.ParrotButton();
            btnHome = new ReaLTaiizor.Controls.ParrotButton();
            btnReport = new ReaLTaiizor.Controls.ParrotButton();
            btnRate = new ReaLTaiizor.Controls.ParrotButton();
            btnHistory = new ReaLTaiizor.Controls.ParrotButton();
            btnLogout = new ReaLTaiizor.Controls.ParrotButton();
            pbAbout = new PictureBox();
            SidebarTransition = new System.Windows.Forms.Timer(components);
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            pnlSidebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnRateHover).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnHistoryHover).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnLogoutHover).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnReportHover).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnScanHover).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnRouteHover).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnHomeHover).BeginInit();
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
            pnlSidebar.Controls.Add(btnRateHover);
            pnlSidebar.Controls.Add(btnHistoryHover);
            pnlSidebar.Controls.Add(btnLogoutHover);
            pnlSidebar.Controls.Add(btnReportHover);
            pnlSidebar.Controls.Add(btnScanHover);
            pnlSidebar.Controls.Add(btnRouteHover);
            pnlSidebar.Controls.Add(btnHomeHover);
            pnlSidebar.Controls.Add(btnScan);
            pnlSidebar.Controls.Add(btnRoute);
            pnlSidebar.Controls.Add(btnHome);
            pnlSidebar.Controls.Add(btnReport);
            pnlSidebar.Controls.Add(btnRate);
            pnlSidebar.Controls.Add(btnHistory);
            pnlSidebar.Controls.Add(btnLogout);
            pnlSidebar.Controls.Add(pbAbout);
            pnlSidebar.Dock = DockStyle.Left;
            pnlSidebar.Location = new Point(0, 28);
            pnlSidebar.Name = "pnlSidebar";
            pnlSidebar.Size = new Size(88, 879);
            pnlSidebar.TabIndex = 18;
            pnlSidebar.Click += pnlSidebar_Click;
            // 
            // btnRateHover
            // 
            btnRateHover.BackColor = Color.FromArgb(230, 249, 255);
            btnRateHover.Image = Properties.Resources.rate_hover1;
            btnRateHover.Location = new Point(25, 475);
            btnRateHover.Name = "btnRateHover";
            btnRateHover.Size = new Size(35, 35);
            btnRateHover.SizeMode = PictureBoxSizeMode.Zoom;
            btnRateHover.TabIndex = 36;
            btnRateHover.TabStop = false;
            btnRateHover.Visible = false;
            // 
            // btnHistoryHover
            // 
            btnHistoryHover.BackColor = Color.FromArgb(230, 249, 255);
            btnHistoryHover.Image = Properties.Resources.history_hover1;
            btnHistoryHover.Location = new Point(25, 550);
            btnHistoryHover.Name = "btnHistoryHover";
            btnHistoryHover.Size = new Size(35, 35);
            btnHistoryHover.SizeMode = PictureBoxSizeMode.Zoom;
            btnHistoryHover.TabIndex = 35;
            btnHistoryHover.TabStop = false;
            btnHistoryHover.Visible = false;
            // 
            // btnLogoutHover
            // 
            btnLogoutHover.BackColor = Color.FromArgb(230, 249, 255);
            btnLogoutHover.Image = Properties.Resources.logout_hover;
            btnLogoutHover.Location = new Point(25, 811);
            btnLogoutHover.Name = "btnLogoutHover";
            btnLogoutHover.Size = new Size(35, 35);
            btnLogoutHover.SizeMode = PictureBoxSizeMode.Zoom;
            btnLogoutHover.TabIndex = 34;
            btnLogoutHover.TabStop = false;
            btnLogoutHover.Visible = false;
            // 
            // btnReportHover
            // 
            btnReportHover.BackColor = Color.FromArgb(230, 249, 255);
            btnReportHover.Image = Properties.Resources.report_hover1;
            btnReportHover.Location = new Point(25, 400);
            btnReportHover.Name = "btnReportHover";
            btnReportHover.Size = new Size(35, 35);
            btnReportHover.SizeMode = PictureBoxSizeMode.Zoom;
            btnReportHover.TabIndex = 33;
            btnReportHover.TabStop = false;
            btnReportHover.Visible = false;
            // 
            // btnScanHover
            // 
            btnScanHover.BackColor = Color.FromArgb(230, 249, 255);
            btnScanHover.Image = Properties.Resources.scan_hover1;
            btnScanHover.Location = new Point(25, 325);
            btnScanHover.Name = "btnScanHover";
            btnScanHover.Size = new Size(35, 35);
            btnScanHover.SizeMode = PictureBoxSizeMode.CenterImage;
            btnScanHover.TabIndex = 32;
            btnScanHover.TabStop = false;
            btnScanHover.Visible = false;
            btnScanHover.MouseLeave += btnScanHover_MouseLeave;
            btnScanHover.MouseHover += btnScanHover_MouseHover;
            // 
            // btnRouteHover
            // 
            btnRouteHover.BackColor = Color.FromArgb(230, 249, 255);
            btnRouteHover.Image = (Image)resources.GetObject("btnRouteHover.Image");
            btnRouteHover.Location = new Point(25, 250);
            btnRouteHover.Name = "btnRouteHover";
            btnRouteHover.Size = new Size(35, 35);
            btnRouteHover.SizeMode = PictureBoxSizeMode.Zoom;
            btnRouteHover.TabIndex = 31;
            btnRouteHover.TabStop = false;
            btnRouteHover.Visible = false;
            btnRouteHover.MouseLeave += btnRouteHover_MouseLeave;
            btnRouteHover.MouseHover += btnRouteHover_MouseHover;
            // 
            // btnHomeHover
            // 
            btnHomeHover.BackColor = Color.FromArgb(230, 249, 255);
            btnHomeHover.Location = new Point(25, 175);
            btnHomeHover.Name = "btnHomeHover";
            btnHomeHover.Size = new Size(35, 35);
            btnHomeHover.SizeMode = PictureBoxSizeMode.Zoom;
            btnHomeHover.TabIndex = 19;
            btnHomeHover.TabStop = false;
            btnHomeHover.Visible = false;
            // 
            // btnScan
            // 
            btnScan.BackgroundColor = Color.FromArgb(255, 255, 255);
            btnScan.ButtonImage = Properties.Resources.scan_normall;
            btnScan.ButtonStyle = ReaLTaiizor.Controls.ParrotButton.Style.MaterialRounded;
            btnScan.ButtonText = "Scan";
            btnScan.ClickBackColor = Color.FromArgb(230, 249, 255);
            btnScan.ClickTextColor = Color.DodgerBlue;
            btnScan.CornerRadius = 8;
            btnScan.Font = new Font("Inter", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnScan.Horizontal_Alignment = StringAlignment.Center;
            btnScan.HoverBackgroundColor = Color.FromArgb(230, 249, 255);
            btnScan.HoverTextColor = Color.DodgerBlue;
            btnScan.ImagePosition = ReaLTaiizor.Controls.ParrotButton.ImgPosition.Left;
            btnScan.Location = new Point(24, 325);
            btnScan.Name = "btnScan";
            btnScan.Size = new Size(150, 33);
            btnScan.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            btnScan.TabIndex = 30;
            btnScan.TextColor = Color.FromArgb(24, 60, 114);
            btnScan.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            btnScan.Vertical_Alignment = StringAlignment.Center;
            btnScan.Click += btnScan_Click;
            // 
            // btnRoute
            // 
            btnRoute.BackgroundColor = Color.FromArgb(255, 255, 255);
            btnRoute.ButtonImage = Properties.Resources.route_normal;
            btnRoute.ButtonStyle = ReaLTaiizor.Controls.ParrotButton.Style.MaterialRounded;
            btnRoute.ButtonText = "Route";
            btnRoute.ClickBackColor = Color.FromArgb(230, 249, 255);
            btnRoute.ClickTextColor = Color.DodgerBlue;
            btnRoute.CornerRadius = 8;
            btnRoute.Font = new Font("Inter", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRoute.Horizontal_Alignment = StringAlignment.Center;
            btnRoute.HoverBackgroundColor = Color.FromArgb(230, 249, 255);
            btnRoute.HoverTextColor = Color.DodgerBlue;
            btnRoute.ImagePosition = ReaLTaiizor.Controls.ParrotButton.ImgPosition.Left;
            btnRoute.Location = new Point(24, 250);
            btnRoute.Name = "btnRoute";
            btnRoute.Size = new Size(150, 33);
            btnRoute.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            btnRoute.TabIndex = 29;
            btnRoute.TextColor = Color.FromArgb(24, 60, 114);
            btnRoute.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            btnRoute.Vertical_Alignment = StringAlignment.Center;
            btnRoute.Click += btnRoute_Click;
            // 
            // btnHome
            // 
            btnHome.BackgroundColor = Color.FromArgb(255, 255, 255);
            btnHome.ButtonImage = Properties.Resources.home_normal;
            btnHome.ButtonStyle = ReaLTaiizor.Controls.ParrotButton.Style.MaterialRounded;
            btnHome.ButtonText = "Home";
            btnHome.ClickBackColor = Color.FromArgb(230, 249, 255);
            btnHome.ClickTextColor = Color.DodgerBlue;
            btnHome.CornerRadius = 8;
            btnHome.Font = new Font("Inter", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnHome.Horizontal_Alignment = StringAlignment.Center;
            btnHome.HoverBackgroundColor = Color.FromArgb(230, 249, 255);
            btnHome.HoverTextColor = Color.DodgerBlue;
            btnHome.ImagePosition = ReaLTaiizor.Controls.ParrotButton.ImgPosition.Left;
            btnHome.Location = new Point(25, 175);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(149, 33);
            btnHome.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            btnHome.TabIndex = 28;
            btnHome.TextColor = Color.FromArgb(24, 60, 114);
            btnHome.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            btnHome.Vertical_Alignment = StringAlignment.Center;
            btnHome.Click += btnHome_Click;
            btnHome.MouseLeave += btnHome_MouseLeave;
            btnHome.MouseHover += btnHome_MouseHover;
            // 
            // btnReport
            // 
            btnReport.BackgroundColor = Color.FromArgb(255, 255, 255);
            btnReport.ButtonImage = Properties.Resources.emergency__1_;
            btnReport.ButtonStyle = ReaLTaiizor.Controls.ParrotButton.Style.MaterialRounded;
            btnReport.ButtonText = "Report";
            btnReport.ClickBackColor = Color.FromArgb(230, 249, 255);
            btnReport.ClickTextColor = Color.DodgerBlue;
            btnReport.CornerRadius = 8;
            btnReport.Font = new Font("Inter", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnReport.Horizontal_Alignment = StringAlignment.Center;
            btnReport.HoverBackgroundColor = Color.FromArgb(230, 249, 255);
            btnReport.HoverTextColor = Color.DodgerBlue;
            btnReport.ImagePosition = ReaLTaiizor.Controls.ParrotButton.ImgPosition.Left;
            btnReport.Location = new Point(24, 400);
            btnReport.Name = "btnReport";
            btnReport.Size = new Size(150, 33);
            btnReport.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            btnReport.TabIndex = 27;
            btnReport.TextColor = Color.FromArgb(24, 60, 114);
            btnReport.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            btnReport.Vertical_Alignment = StringAlignment.Center;
            btnReport.Click += btnReport_Click;
            // 
            // btnRate
            // 
            btnRate.BackgroundColor = Color.FromArgb(255, 255, 255);
            btnRate.ButtonImage = Properties.Resources.rate_normal;
            btnRate.ButtonStyle = ReaLTaiizor.Controls.ParrotButton.Style.MaterialRounded;
            btnRate.ButtonText = "Rate";
            btnRate.ClickBackColor = Color.FromArgb(230, 249, 255);
            btnRate.ClickTextColor = Color.DodgerBlue;
            btnRate.CornerRadius = 8;
            btnRate.Font = new Font("Inter", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRate.Horizontal_Alignment = StringAlignment.Center;
            btnRate.HoverBackgroundColor = Color.FromArgb(230, 249, 255);
            btnRate.HoverTextColor = Color.DodgerBlue;
            btnRate.ImagePosition = ReaLTaiizor.Controls.ParrotButton.ImgPosition.Left;
            btnRate.Location = new Point(24, 475);
            btnRate.Name = "btnRate";
            btnRate.Size = new Size(150, 33);
            btnRate.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            btnRate.TabIndex = 26;
            btnRate.TextColor = Color.FromArgb(24, 60, 114);
            btnRate.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            btnRate.Vertical_Alignment = StringAlignment.Center;
            btnRate.Click += btnRate_Click;
            // 
            // btnHistory
            // 
            btnHistory.BackgroundColor = Color.FromArgb(255, 255, 255);
            btnHistory.ButtonImage = Properties.Resources.history_normal;
            btnHistory.ButtonStyle = ReaLTaiizor.Controls.ParrotButton.Style.MaterialRounded;
            btnHistory.ButtonText = "History";
            btnHistory.ClickBackColor = Color.FromArgb(153, 229, 255);
            btnHistory.ClickTextColor = Color.DodgerBlue;
            btnHistory.CornerRadius = 8;
            btnHistory.Font = new Font("Inter", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnHistory.Horizontal_Alignment = StringAlignment.Center;
            btnHistory.HoverBackgroundColor = Color.FromArgb(230, 249, 255);
            btnHistory.HoverTextColor = Color.DodgerBlue;
            btnHistory.ImagePosition = ReaLTaiizor.Controls.ParrotButton.ImgPosition.Left;
            btnHistory.Location = new Point(24, 550);
            btnHistory.Name = "btnHistory";
            btnHistory.Size = new Size(150, 33);
            btnHistory.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            btnHistory.TabIndex = 25;
            btnHistory.TextColor = Color.FromArgb(24, 60, 114);
            btnHistory.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            btnHistory.Vertical_Alignment = StringAlignment.Center;
            btnHistory.Click += btnHistory_Click;
            // 
            // btnLogout
            // 
            btnLogout.BackgroundColor = Color.FromArgb(255, 255, 255);
            btnLogout.ButtonImage = Properties.Resources.logout_normal;
            btnLogout.ButtonStyle = ReaLTaiizor.Controls.ParrotButton.Style.MaterialRounded;
            btnLogout.ButtonText = "Logout";
            btnLogout.ClickBackColor = Color.FromArgb(230, 249, 255);
            btnLogout.ClickTextColor = Color.DodgerBlue;
            btnLogout.CornerRadius = 8;
            btnLogout.Font = new Font("Inter", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLogout.Horizontal_Alignment = StringAlignment.Center;
            btnLogout.HoverBackgroundColor = Color.FromArgb(230, 249, 255);
            btnLogout.HoverTextColor = Color.DodgerBlue;
            btnLogout.ImagePosition = ReaLTaiizor.Controls.ParrotButton.ImgPosition.Left;
            btnLogout.Location = new Point(25, 811);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(150, 33);
            btnLogout.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            btnLogout.TabIndex = 19;
            btnLogout.TextColor = Color.FromArgb(24, 60, 114);
            btnLogout.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            btnLogout.Vertical_Alignment = StringAlignment.Center;
            btnLogout.Click += btnLogout_Click;
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
            ((System.ComponentModel.ISupportInitialize)btnRateHover).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnHistoryHover).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnLogoutHover).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnReportHover).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnScanHover).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnRouteHover).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnHomeHover).EndInit();
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
        private ReaLTaiizor.Controls.ParrotButton btnLogout;
        private ReaLTaiizor.Controls.ParrotButton btnHistory;
        private ReaLTaiizor.Controls.ParrotButton btnRoute;
        private ReaLTaiizor.Controls.ParrotButton btnHome;
        private ReaLTaiizor.Controls.ParrotButton btnReport;
        private ReaLTaiizor.Controls.ParrotButton btnRate;
        private ReaLTaiizor.Controls.ParrotButton btnScan;
        private PictureBox btnHomeHover;
        private PictureBox btnRateHover;
        private PictureBox btnHistoryHover;
        private PictureBox btnLogoutHover;
        private PictureBox btnReportHover;
        private PictureBox btnScanHover;
        private PictureBox btnRouteHover;
    }
}