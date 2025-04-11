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
            btnLogout = new FontAwesome.Sharp.IconButton();
            btnHistory = new FontAwesome.Sharp.IconButton();
            pbAbout = new PictureBox();
            btnReport = new FontAwesome.Sharp.IconButton();
            btnHome = new FontAwesome.Sharp.IconButton();
            btnScan = new FontAwesome.Sharp.IconButton();
            btnRoute = new FontAwesome.Sharp.IconButton();
            SidebarTransition = new System.Windows.Forms.Timer(components);
            pnlDesktop = new Panel();
            pnlTop = new Panel();
            spaceSeparatorHorizontal1 = new ReaLTaiizor.Controls.SpaceSeparatorHorizontal();
            label15 = new Label();
            pbWheelPoints = new PictureBox();
            lblUserFName = new Label();
            label1 = new Label();
            lblPoints1 = new Label();
            panel3 = new Panel();
            pbTransLogo = new PictureBox();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            lblFare = new Label();
            label10 = new Label();
            lblTo = new Label();
            lblFrom = new Label();
            cyberButton4 = new ReaLTaiizor.Controls.CyberButton();
            lblTripDate = new Label();
            lblTripTime = new Label();
            lblPlate = new Label();
            lblRoute = new Label();
            cyberButton3 = new ReaLTaiizor.Controls.CyberButton();
            label4 = new Label();
            label5 = new Label();
            btnCashIn = new ReaLTaiizor.Controls.CyberButton();
            lblBalance = new Label();
            label2 = new Label();
            label3 = new Label();
            pbProfilePicture = new PictureBox();
            pbProfile = new PictureBox();
            pictureBox5 = new PictureBox();
            cyberButton2 = new ReaLTaiizor.Controls.CyberButton();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            pnlSidebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbAbout).BeginInit();
            pnlDesktop.SuspendLayout();
            pnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbWheelPoints).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbTransLogo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbProfilePicture).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbProfile).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
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
            pnlSidebar.Controls.Add(btnLogout);
            pnlSidebar.Controls.Add(btnHistory);
            pnlSidebar.Controls.Add(pbAbout);
            pnlSidebar.Controls.Add(btnReport);
            pnlSidebar.Controls.Add(btnHome);
            pnlSidebar.Controls.Add(btnScan);
            pnlSidebar.Controls.Add(btnRoute);
            pnlSidebar.Dock = DockStyle.Left;
            pnlSidebar.Location = new Point(0, 28);
            pnlSidebar.Name = "pnlSidebar";
            pnlSidebar.Size = new Size(88, 879);
            pnlSidebar.TabIndex = 18;
            pnlSidebar.Click += pnlSidebar_Click;
            // 
            // btnLogout
            // 
            btnLogout.FlatAppearance.BorderSize = 0;
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.Font = new Font("Inter", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLogout.IconChar = FontAwesome.Sharp.IconChar.ArrowAltCircleLeft;
            btnLogout.IconColor = Color.Black;
            btnLogout.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnLogout.ImageAlign = ContentAlignment.MiddleLeft;
            btnLogout.Location = new Point(0, 811);
            btnLogout.Name = "btnLogout";
            btnLogout.Padding = new Padding(15, 0, 0, 0);
            btnLogout.Size = new Size(185, 43);
            btnLogout.TabIndex = 39;
            btnLogout.Text = "      Logout";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            btnLogout.MouseLeave += btnLogout_MouseLeave;
            btnLogout.MouseHover += btnLogout_MouseHover;
            // 
            // btnHistory
            // 
            btnHistory.FlatAppearance.BorderSize = 0;
            btnHistory.FlatStyle = FlatStyle.Flat;
            btnHistory.Font = new Font("Inter", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnHistory.IconChar = FontAwesome.Sharp.IconChar.ClockRotateLeft;
            btnHistory.IconColor = Color.Black;
            btnHistory.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnHistory.ImageAlign = ContentAlignment.MiddleLeft;
            btnHistory.Location = new Point(0, 570);
            btnHistory.Name = "btnHistory";
            btnHistory.Padding = new Padding(15, 0, 0, 0);
            btnHistory.Size = new Size(185, 43);
            btnHistory.TabIndex = 38;
            btnHistory.Text = "       History";
            btnHistory.UseVisualStyleBackColor = true;
            btnHistory.Click += btnHistory_Click;
            btnHistory.MouseLeave += btnHistory_MouseLeave;
            btnHistory.MouseHover += btnHistory_MouseHover;
            // 
            // pbAbout
            // 
            pbAbout.Cursor = Cursors.Hand;
            pbAbout.Image = Properties.Resources.Removal_915;
            pbAbout.Location = new Point(12, 25);
            pbAbout.Name = "pbAbout";
            pbAbout.Size = new Size(58, 60);
            pbAbout.SizeMode = PictureBoxSizeMode.Zoom;
            pbAbout.TabIndex = 6;
            pbAbout.TabStop = false;
            pbAbout.Click += pbAbout_Click;
            // 
            // btnReport
            // 
            btnReport.FlatAppearance.BorderSize = 0;
            btnReport.FlatStyle = FlatStyle.Flat;
            btnReport.Font = new Font("Inter", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnReport.IconChar = FontAwesome.Sharp.IconChar.Flag;
            btnReport.IconColor = Color.Black;
            btnReport.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnReport.ImageAlign = ContentAlignment.MiddleLeft;
            btnReport.Location = new Point(0, 470);
            btnReport.Name = "btnReport";
            btnReport.Padding = new Padding(15, 0, 0, 0);
            btnReport.Size = new Size(185, 43);
            btnReport.TabIndex = 36;
            btnReport.Text = "      Report";
            btnReport.UseVisualStyleBackColor = true;
            btnReport.Click += btnReport_Click;
            btnReport.MouseLeave += btnReport_MouseLeave;
            btnReport.MouseHover += btnReport_MouseHover;
            // 
            // btnHome
            // 
            btnHome.FlatAppearance.BorderSize = 0;
            btnHome.FlatStyle = FlatStyle.Flat;
            btnHome.Font = new Font("Inter", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnHome.IconChar = FontAwesome.Sharp.IconChar.House;
            btnHome.IconColor = Color.Black;
            btnHome.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnHome.ImageAlign = ContentAlignment.MiddleLeft;
            btnHome.Location = new Point(0, 170);
            btnHome.Name = "btnHome";
            btnHome.Padding = new Padding(15, 0, 0, 0);
            btnHome.Size = new Size(185, 43);
            btnHome.TabIndex = 33;
            btnHome.Text = "     Home";
            btnHome.UseVisualStyleBackColor = true;
            btnHome.Click += btnHome_Click;
            btnHome.MouseLeave += btnHome_MouseLeave;
            btnHome.MouseHover += btnHome_MouseHover;
            // 
            // btnScan
            // 
            btnScan.FlatAppearance.BorderSize = 0;
            btnScan.FlatStyle = FlatStyle.Flat;
            btnScan.Font = new Font("Inter", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnScan.IconChar = FontAwesome.Sharp.IconChar.Qrcode;
            btnScan.IconColor = Color.Black;
            btnScan.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnScan.ImageAlign = ContentAlignment.MiddleLeft;
            btnScan.Location = new Point(0, 370);
            btnScan.Name = "btnScan";
            btnScan.Padding = new Padding(15, 0, 0, 0);
            btnScan.Size = new Size(185, 43);
            btnScan.TabIndex = 35;
            btnScan.Text = "    Scan";
            btnScan.UseVisualStyleBackColor = true;
            btnScan.Click += btnScan_Click;
            btnScan.MouseLeave += btnScanHover_MouseLeave;
            btnScan.MouseHover += btnScanHover_MouseHover;
            // 
            // btnRoute
            // 
            btnRoute.FlatAppearance.BorderSize = 0;
            btnRoute.FlatStyle = FlatStyle.Flat;
            btnRoute.Font = new Font("Inter", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRoute.IconChar = FontAwesome.Sharp.IconChar.Route;
            btnRoute.IconColor = Color.Black;
            btnRoute.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnRoute.ImageAlign = ContentAlignment.MiddleLeft;
            btnRoute.Location = new Point(0, 270);
            btnRoute.Name = "btnRoute";
            btnRoute.Padding = new Padding(15, 0, 0, 0);
            btnRoute.Size = new Size(185, 43);
            btnRoute.TabIndex = 34;
            btnRoute.Text = "     Route";
            btnRoute.UseVisualStyleBackColor = true;
            btnRoute.Click += btnRoute_Click;
            btnRoute.MouseLeave += btnRouteHover_MouseLeave;
            btnRoute.MouseHover += btnRouteHover_MouseHover;
            // 
            // SidebarTransition
            // 
            SidebarTransition.Interval = 10;
            SidebarTransition.Tick += SidebarTransition_Tick;
            // 
            // pnlDesktop
            // 
            pnlDesktop.Controls.Add(pnlTop);
            pnlDesktop.Controls.Add(panel3);
            pnlDesktop.Dock = DockStyle.Fill;
            pnlDesktop.Location = new Point(88, 28);
            pnlDesktop.Name = "pnlDesktop";
            pnlDesktop.Size = new Size(1312, 879);
            pnlDesktop.TabIndex = 19;
            // 
            // pnlTop
            // 
            pnlTop.Controls.Add(spaceSeparatorHorizontal1);
            pnlTop.Controls.Add(label15);
            pnlTop.Controls.Add(pbWheelPoints);
            pnlTop.Controls.Add(lblUserFName);
            pnlTop.Controls.Add(label1);
            pnlTop.Controls.Add(lblPoints1);
            pnlTop.Dock = DockStyle.Top;
            pnlTop.Location = new Point(0, 0);
            pnlTop.Name = "pnlTop";
            pnlTop.Size = new Size(988, 145);
            pnlTop.TabIndex = 0;
            // 
            // spaceSeparatorHorizontal1
            // 
            spaceSeparatorHorizontal1.Customization = "Kioq/yoqKv8jIyP/Kioq/w==";
            spaceSeparatorHorizontal1.Font = new Font("Verdana", 8F);
            spaceSeparatorHorizontal1.Image = null;
            spaceSeparatorHorizontal1.Location = new Point(638, 122);
            spaceSeparatorHorizontal1.Name = "spaceSeparatorHorizontal1";
            spaceSeparatorHorizontal1.NoRounding = false;
            spaceSeparatorHorizontal1.Size = new Size(375, 4);
            spaceSeparatorHorizontal1.TabIndex = 33;
            spaceSeparatorHorizontal1.Text = "spaceSeparatorHorizontal1";
            spaceSeparatorHorizontal1.Transparent = false;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.BackColor = Color.FromArgb(230, 249, 255);
            label15.Font = new Font("Inter", 21F, FontStyle.Bold);
            label15.ForeColor = Color.FromArgb(38, 36, 68);
            label15.Location = new Point(671, 66);
            label15.Name = "label15";
            label15.Size = new Size(141, 40);
            label15.TabIndex = 55;
            label15.Text = "You have";
            // 
            // pbWheelPoints
            // 
            pbWheelPoints.Cursor = Cursors.Hand;
            pbWheelPoints.Image = (Image)resources.GetObject("pbWheelPoints.Image");
            pbWheelPoints.Location = new Point(896, 55);
            pbWheelPoints.Name = "pbWheelPoints";
            pbWheelPoints.Size = new Size(66, 58);
            pbWheelPoints.SizeMode = PictureBoxSizeMode.Zoom;
            pbWheelPoints.TabIndex = 40;
            pbWheelPoints.TabStop = false;
            pbWheelPoints.Click += pbWheelPoints_Click;
            // 
            // lblUserFName
            // 
            lblUserFName.AutoSize = true;
            lblUserFName.Font = new Font("Inter ExtraBold", 23F, FontStyle.Bold);
            lblUserFName.ForeColor = Color.FromArgb(24, 60, 114);
            lblUserFName.Location = new Point(103, 21);
            lblUserFName.Name = "lblUserFName";
            lblUserFName.Size = new Size(141, 44);
            lblUserFName.TabIndex = 33;
            lblUserFName.Text = "Angelo!";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Inter SemiBold", 23F, FontStyle.Bold);
            label1.ForeColor = SystemColors.ControlDarkDark;
            label1.Location = new Point(16, 22);
            label1.Name = "label1";
            label1.Size = new Size(95, 44);
            label1.TabIndex = 32;
            label1.Text = "Hello";
            // 
            // lblPoints1
            // 
            lblPoints1.BackColor = Color.FromArgb(230, 249, 255);
            lblPoints1.Font = new Font("Inter", 31F, FontStyle.Bold);
            lblPoints1.ForeColor = Color.FromArgb(38, 36, 68);
            lblPoints1.Location = new Point(804, 54);
            lblPoints1.Name = "lblPoints1";
            lblPoints1.Size = new Size(108, 61);
            lblPoints1.TabIndex = 55;
            lblPoints1.Text = "0";
            lblPoints1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(pbTransLogo);
            panel3.Controls.Add(iconButton1);
            panel3.Controls.Add(lblFare);
            panel3.Controls.Add(label10);
            panel3.Controls.Add(lblTo);
            panel3.Controls.Add(lblFrom);
            panel3.Controls.Add(cyberButton4);
            panel3.Controls.Add(lblTripDate);
            panel3.Controls.Add(lblTripTime);
            panel3.Controls.Add(lblPlate);
            panel3.Controls.Add(lblRoute);
            panel3.Controls.Add(cyberButton3);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(btnCashIn);
            panel3.Controls.Add(lblBalance);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(pbProfilePicture);
            panel3.Controls.Add(pbProfile);
            panel3.Controls.Add(pictureBox5);
            panel3.Controls.Add(cyberButton2);
            panel3.Dock = DockStyle.Right;
            panel3.Location = new Point(988, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(324, 879);
            panel3.TabIndex = 32;
            // 
            // pbTransLogo
            // 
            pbTransLogo.Image = (Image)resources.GetObject("pbTransLogo.Image");
            pbTransLogo.Location = new Point(52, 720);
            pbTransLogo.Name = "pbTransLogo";
            pbTransLogo.Size = new Size(227, 129);
            pbTransLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            pbTransLogo.TabIndex = 54;
            pbTransLogo.TabStop = false;
            pbTransLogo.Visible = false;
            // 
            // iconButton1
            // 
            iconButton1.BackColor = Color.FromArgb(38, 36, 68);
            iconButton1.FlatStyle = FlatStyle.Flat;
            iconButton1.Font = new Font("Microsoft Sans Serif", 8.25F);
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.ArrowDown;
            iconButton1.IconColor = Color.White;
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton1.IconSize = 36;
            iconButton1.Location = new Point(149, 764);
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new Size(32, 36);
            iconButton1.TabIndex = 53;
            iconButton1.UseVisualStyleBackColor = false;
            // 
            // lblFare
            // 
            lblFare.AutoSize = true;
            lblFare.BackColor = Color.FromArgb(153, 229, 255);
            lblFare.Font = new Font("Inter", 18F, FontStyle.Bold);
            lblFare.ForeColor = Color.FromArgb(24, 60, 114);
            lblFare.Location = new Point(177, 632);
            lblFare.Name = "lblFare";
            lblFare.Size = new Size(107, 35);
            lblFare.TabIndex = 52;
            lblFare.Text = "₱ 20.00";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.FromArgb(153, 229, 255);
            label10.Font = new Font("Inter", 18F, FontStyle.Bold);
            label10.ForeColor = Color.FromArgb(24, 60, 114);
            label10.Location = new Point(47, 631);
            label10.Name = "label10";
            label10.Size = new Size(133, 35);
            label10.TabIndex = 50;
            label10.Text = "Payment :";
            // 
            // lblTo
            // 
            lblTo.BackColor = Color.FromArgb(38, 36, 68);
            lblTo.Font = new Font("Inter", 19F, FontStyle.Bold);
            lblTo.ForeColor = Color.White;
            lblTo.Location = new Point(48, 807);
            lblTo.Name = "lblTo";
            lblTo.RightToLeft = RightToLeft.No;
            lblTo.Size = new Size(237, 37);
            lblTo.TabIndex = 49;
            lblTo.Text = "CIT-U";
            lblTo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblFrom
            // 
            lblFrom.BackColor = Color.FromArgb(38, 36, 68);
            lblFrom.Font = new Font("Inter", 19F, FontStyle.Bold);
            lblFrom.ForeColor = Color.White;
            lblFrom.Location = new Point(50, 714);
            lblFrom.Name = "lblFrom";
            lblFrom.Size = new Size(234, 37);
            lblFrom.TabIndex = 47;
            lblFrom.Text = "Basak";
            lblFrom.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // cyberButton4
            // 
            cyberButton4.Alpha = 20;
            cyberButton4.BackColor = Color.Transparent;
            cyberButton4.Background = true;
            cyberButton4.Background_WidthPen = 4F;
            cyberButton4.BackgroundPen = true;
            cyberButton4.ColorBackground = Color.FromArgb(38, 36, 68);
            cyberButton4.ColorBackground_1 = Color.FromArgb(38, 36, 68);
            cyberButton4.ColorBackground_2 = Color.FromArgb(41, 63, 86);
            cyberButton4.ColorBackground_Pen = Color.FromArgb(153, 229, 255);
            cyberButton4.ColorLighting = Color.FromArgb(153, 229, 255);
            cyberButton4.ColorPen_1 = Color.FromArgb(37, 52, 68);
            cyberButton4.ColorPen_2 = Color.FromArgb(41, 63, 86);
            cyberButton4.CyberButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            cyberButton4.Effect_1 = true;
            cyberButton4.Effect_1_ColorBackground = Color.FromArgb(29, 200, 238);
            cyberButton4.Effect_1_Transparency = 25;
            cyberButton4.Effect_2 = true;
            cyberButton4.Effect_2_ColorBackground = Color.White;
            cyberButton4.Effect_2_Transparency = 20;
            cyberButton4.Enabled = false;
            cyberButton4.Font = new Font("Inter", 12F);
            cyberButton4.ForeColor = Color.FromArgb(38, 36, 68);
            cyberButton4.Lighting = false;
            cyberButton4.LinearGradient_Background = false;
            cyberButton4.LinearGradientPen = false;
            cyberButton4.Location = new Point(20, 702);
            cyberButton4.Name = "cyberButton4";
            cyberButton4.PenWidth = 15;
            cyberButton4.Rounding = true;
            cyberButton4.RoundingInt = 70;
            cyberButton4.Size = new Size(292, 160);
            cyberButton4.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            cyberButton4.TabIndex = 46;
            cyberButton4.Tag = "Cyber";
            cyberButton4.TextButton = "";
            cyberButton4.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            cyberButton4.Timer_Effect_1 = 5;
            cyberButton4.Timer_RGB = 300;
            // 
            // lblTripDate
            // 
            lblTripDate.BackColor = Color.FromArgb(153, 229, 255);
            lblTripDate.Font = new Font("Inter", 18F, FontStyle.Bold);
            lblTripDate.ForeColor = Color.FromArgb(24, 60, 114);
            lblTripDate.Location = new Point(52, 508);
            lblTripDate.Name = "lblTripDate";
            lblTripDate.Size = new Size(228, 51);
            lblTripDate.TabIndex = 45;
            lblTripDate.Text = "March 13, 2025";
            lblTripDate.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblTripTime
            // 
            lblTripTime.BackColor = Color.FromArgb(153, 229, 255);
            lblTripTime.Font = new Font("Inter", 18F, FontStyle.Bold);
            lblTripTime.ForeColor = Color.FromArgb(24, 60, 114);
            lblTripTime.Location = new Point(178, 591);
            lblTripTime.Name = "lblTripTime";
            lblTripTime.Size = new Size(131, 35);
            lblTripTime.TabIndex = 44;
            lblTripTime.Text = "8:34 AM";
            lblTripTime.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblPlate
            // 
            lblPlate.BackColor = Color.FromArgb(153, 229, 255);
            lblPlate.Font = new Font("Inter", 18F, FontStyle.Bold);
            lblPlate.ForeColor = Color.FromArgb(24, 60, 114);
            lblPlate.Location = new Point(178, 555);
            lblPlate.Name = "lblPlate";
            lblPlate.Size = new Size(128, 35);
            lblPlate.TabIndex = 43;
            lblPlate.Text = "481HOF";
            lblPlate.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblRoute
            // 
            lblRoute.BackColor = Color.FromArgb(153, 229, 255);
            lblRoute.Font = new Font("Inter", 50F, FontStyle.Bold);
            lblRoute.ForeColor = Color.FromArgb(24, 60, 114);
            lblRoute.Location = new Point(25, 541);
            lblRoute.Margin = new Padding(0);
            lblRoute.Name = "lblRoute";
            lblRoute.Size = new Size(189, 96);
            lblRoute.TabIndex = 42;
            lblRoute.Text = "09C";
            lblRoute.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // cyberButton3
            // 
            cyberButton3.Alpha = 20;
            cyberButton3.BackColor = Color.Transparent;
            cyberButton3.Background = true;
            cyberButton3.Background_WidthPen = 4F;
            cyberButton3.BackgroundPen = true;
            cyberButton3.ColorBackground = Color.FromArgb(153, 229, 255);
            cyberButton3.ColorBackground_1 = Color.FromArgb(38, 36, 68);
            cyberButton3.ColorBackground_2 = Color.FromArgb(41, 63, 86);
            cyberButton3.ColorBackground_Pen = Color.FromArgb(153, 229, 255);
            cyberButton3.ColorLighting = Color.FromArgb(153, 229, 255);
            cyberButton3.ColorPen_1 = Color.FromArgb(37, 52, 68);
            cyberButton3.ColorPen_2 = Color.FromArgb(41, 63, 86);
            cyberButton3.CyberButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            cyberButton3.Effect_1 = true;
            cyberButton3.Effect_1_ColorBackground = Color.FromArgb(29, 200, 238);
            cyberButton3.Effect_1_Transparency = 25;
            cyberButton3.Effect_2 = true;
            cyberButton3.Effect_2_ColorBackground = Color.White;
            cyberButton3.Effect_2_Transparency = 20;
            cyberButton3.Enabled = false;
            cyberButton3.Font = new Font("Inter", 12F);
            cyberButton3.ForeColor = Color.FromArgb(38, 36, 68);
            cyberButton3.Lighting = false;
            cyberButton3.LinearGradient_Background = false;
            cyberButton3.LinearGradientPen = false;
            cyberButton3.Location = new Point(19, 494);
            cyberButton3.Name = "cyberButton3";
            cyberButton3.PenWidth = 15;
            cyberButton3.Rounding = true;
            cyberButton3.RoundingInt = 70;
            cyberButton3.Size = new Size(292, 193);
            cyberButton3.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            cyberButton3.TabIndex = 41;
            cyberButton3.Tag = "Cyber";
            cyberButton3.TextButton = "";
            cyberButton3.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            cyberButton3.Timer_Effect_1 = 5;
            cyberButton3.Timer_RGB = 300;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Inter ExtraBold", 21F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(24, 60, 114);
            label4.Location = new Point(15, 433);
            label4.Name = "label4";
            label4.Size = new Size(104, 40);
            label4.TabIndex = 40;
            label4.Text = "Latest";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Inter SemiBold", 21F, FontStyle.Bold);
            label5.ForeColor = SystemColors.ControlDarkDark;
            label5.Location = new Point(113, 433);
            label5.Name = "label5";
            label5.Size = new Size(175, 40);
            label5.TabIndex = 39;
            label5.Text = "Transaction";
            // 
            // btnCashIn
            // 
            btnCashIn.Alpha = 20;
            btnCashIn.BackColor = Color.Transparent;
            btnCashIn.Background = true;
            btnCashIn.Background_WidthPen = 4F;
            btnCashIn.BackgroundPen = true;
            btnCashIn.ColorBackground = Color.FromArgb(153, 229, 255);
            btnCashIn.ColorBackground_1 = Color.FromArgb(153, 229, 255);
            btnCashIn.ColorBackground_2 = Color.FromArgb(41, 63, 86);
            btnCashIn.ColorBackground_Pen = Color.FromArgb(153, 229, 255);
            btnCashIn.ColorLighting = Color.FromArgb(153, 229, 255);
            btnCashIn.ColorPen_1 = Color.FromArgb(37, 52, 68);
            btnCashIn.ColorPen_2 = Color.FromArgb(41, 63, 86);
            btnCashIn.Cursor = Cursors.Hand;
            btnCashIn.CyberButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            btnCashIn.Effect_1 = true;
            btnCashIn.Effect_1_ColorBackground = Color.FromArgb(29, 200, 238);
            btnCashIn.Effect_1_Transparency = 25;
            btnCashIn.Effect_2 = true;
            btnCashIn.Effect_2_ColorBackground = Color.White;
            btnCashIn.Effect_2_Transparency = 20;
            btnCashIn.Font = new Font("Inter", 12F);
            btnCashIn.ForeColor = Color.FromArgb(38, 36, 68);
            btnCashIn.Lighting = false;
            btnCashIn.LinearGradient_Background = false;
            btnCashIn.LinearGradientPen = false;
            btnCashIn.Location = new Point(183, 339);
            btnCashIn.Name = "btnCashIn";
            btnCashIn.PenWidth = 15;
            btnCashIn.Rounding = true;
            btnCashIn.RoundingInt = 70;
            btnCashIn.Size = new Size(117, 43);
            btnCashIn.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            btnCashIn.TabIndex = 37;
            btnCashIn.Tag = "Cyber";
            btnCashIn.TextButton = "+ Cash in";
            btnCashIn.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            btnCashIn.Timer_Effect_1 = 5;
            btnCashIn.Timer_RGB = 300;
            btnCashIn.Click += btnCashIn_Click;
            // 
            // lblBalance
            // 
            lblBalance.BackColor = Color.FromArgb(38, 36, 68);
            lblBalance.Font = new Font("Inter", 32F, FontStyle.Bold);
            lblBalance.ForeColor = Color.White;
            lblBalance.Location = new Point(37, 254);
            lblBalance.Name = "lblBalance";
            lblBalance.Size = new Size(251, 62);
            lblBalance.TabIndex = 0;
            lblBalance.Text = "₱  0.00";
            lblBalance.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Inter ExtraBold", 21F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(24, 60, 114);
            label2.Location = new Point(7, 178);
            label2.Name = "label2";
            label2.Size = new Size(126, 40);
            label2.TabIndex = 35;
            label2.Text = "Current";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Inter SemiBold", 21F, FontStyle.Bold);
            label3.ForeColor = SystemColors.ControlDarkDark;
            label3.Location = new Point(127, 178);
            label3.Name = "label3";
            label3.Size = new Size(124, 40);
            label3.TabIndex = 34;
            label3.Text = "Balance";
            // 
            // pbProfilePicture
            // 
            pbProfilePicture.BackColor = Color.FromArgb(38, 36, 68);
            pbProfilePicture.Image = (Image)resources.GetObject("pbProfilePicture.Image");
            pbProfilePicture.Location = new Point(37, 25);
            pbProfilePicture.Name = "pbProfilePicture";
            pbProfilePicture.Size = new Size(58, 60);
            pbProfilePicture.SizeMode = PictureBoxSizeMode.Zoom;
            pbProfilePicture.TabIndex = 31;
            pbProfilePicture.TabStop = false;
            // 
            // pbProfile
            // 
            pbProfile.BackColor = Color.FromArgb(38, 36, 68);
            pbProfile.Cursor = Cursors.Hand;
            pbProfile.Image = (Image)resources.GetObject("pbProfile.Image");
            pbProfile.Location = new Point(256, 29);
            pbProfile.Name = "pbProfile";
            pbProfile.Size = new Size(48, 50);
            pbProfile.SizeMode = PictureBoxSizeMode.CenterImage;
            pbProfile.TabIndex = 33;
            pbProfile.TabStop = false;
            pbProfile.Click += pbProfile_Click;
            // 
            // pictureBox5
            // 
            pictureBox5.BackColor = Color.White;
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(-15, 0);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(341, 145);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 0;
            pictureBox5.TabStop = false;
            // 
            // cyberButton2
            // 
            cyberButton2.Alpha = 20;
            cyberButton2.BackColor = Color.Transparent;
            cyberButton2.Background = true;
            cyberButton2.Background_WidthPen = 4F;
            cyberButton2.BackgroundPen = true;
            cyberButton2.ColorBackground = Color.FromArgb(38, 36, 68);
            cyberButton2.ColorBackground_1 = Color.FromArgb(38, 36, 68);
            cyberButton2.ColorBackground_2 = Color.FromArgb(41, 63, 86);
            cyberButton2.ColorBackground_Pen = Color.FromArgb(153, 229, 255);
            cyberButton2.ColorLighting = Color.FromArgb(153, 229, 255);
            cyberButton2.ColorPen_1 = Color.FromArgb(37, 52, 68);
            cyberButton2.ColorPen_2 = Color.FromArgb(41, 63, 86);
            cyberButton2.CyberButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            cyberButton2.Effect_1 = true;
            cyberButton2.Effect_1_ColorBackground = Color.FromArgb(29, 200, 238);
            cyberButton2.Effect_1_Transparency = 25;
            cyberButton2.Effect_2 = true;
            cyberButton2.Effect_2_ColorBackground = Color.White;
            cyberButton2.Effect_2_Transparency = 20;
            cyberButton2.Enabled = false;
            cyberButton2.Font = new Font("Inter", 12F);
            cyberButton2.ForeColor = Color.FromArgb(38, 36, 68);
            cyberButton2.Lighting = false;
            cyberButton2.LinearGradient_Background = false;
            cyberButton2.LinearGradientPen = false;
            cyberButton2.Location = new Point(15, 239);
            cyberButton2.Name = "cyberButton2";
            cyberButton2.PenWidth = 15;
            cyberButton2.Rounding = true;
            cyberButton2.RoundingInt = 70;
            cyberButton2.Size = new Size(292, 93);
            cyberButton2.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            cyberButton2.TabIndex = 38;
            cyberButton2.Tag = "Cyber";
            cyberButton2.TextButton = "";
            cyberButton2.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            cyberButton2.Timer_Effect_1 = 5;
            cyberButton2.Timer_RGB = 300;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(230, 249, 255);
            ClientSize = new Size(1400, 907);
            Controls.Add(pnlDesktop);
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
            pnlDesktop.ResumeLayout(false);
            pnlTop.ResumeLayout(false);
            pnlTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbWheelPoints).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbTransLogo).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbProfilePicture).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbProfile).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
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
        private Panel pnlDesktop;
        private Panel pnlTop;
        private PictureBox pictureBox5;
        private Panel panel3;
        private Label label1;
        private PictureBox pbProfilePicture;
        private PictureBox pbProfile;
        private FontAwesome.Sharp.IconButton btnHome;
        private FontAwesome.Sharp.IconButton btnRoute;
        private FontAwesome.Sharp.IconButton btnReport;
        private FontAwesome.Sharp.IconButton btnScan;
        private FontAwesome.Sharp.IconButton btnLogout;
        private FontAwesome.Sharp.IconButton btnHistory;
        private Label lblUserFName;
        private Label label2;
        private Label label3;
        private ReaLTaiizor.Controls.CyberButton btnCashIn;
        private ReaLTaiizor.Controls.CyberButton cyberButton2;
        private ReaLTaiizor.Controls.CyberButton cyberButton3;
        private Label label4;
        private Label label5;
        private Label lblTripDate;
        private Label lblTripTime;
        private Label lblPlate;
        private Label lblRoute;
        private Label label10;
        private Label lblTo;
        private Label lblFrom;
        private ReaLTaiizor.Controls.CyberButton cyberButton4;
        private Label lblFare;
        private PictureBox pbWheelPoints;
        private Label label15;
        private ReaLTaiizor.Controls.SpaceSeparatorHorizontal spaceSeparatorHorizontal1;
        public Label lblBalance;
        private FontAwesome.Sharp.IconButton iconButton1;
        private PictureBox pbTransLogo;
        private Label lblPoints1;
    }
}