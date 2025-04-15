namespace NEXUS.User_Controls
{
    partial class HomeAdmin
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
            components = new System.ComponentModel.Container();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel2 = new Panel();
            tableLayoutPanel2 = new TableLayoutPanel();
            panel6 = new Panel();
            lblNumDriver = new Label();
            lblNumPassenger = new Label();
            panel5 = new Panel();
            pvPieChart = new OxyPlot.WindowsForms.PlotView();
            cmsPie = new ContextMenuStrip(components);
            usersToolStripMenuItem = new ToolStripMenuItem();
            passengersToolStripMenuItem = new ToolStripMenuItem();
            driversToolStripMenuItem = new ToolStripMenuItem();
            tableLayoutPanel4 = new TableLayoutPanel();
            btnDrivers = new FontAwesome.Sharp.IconButton();
            btnPassengers = new FontAwesome.Sharp.IconButton();
            btnUsers = new FontAwesome.Sharp.IconButton();
            spaceSeparatorHorizontal4 = new ReaLTaiizor.Controls.SpaceSeparatorHorizontal();
            spaceSeparatorVertical1 = new ReaLTaiizor.Controls.SpaceSeparatorVertical();
            spaceSeparatorVertical2 = new ReaLTaiizor.Controls.SpaceSeparatorVertical();
            spaceSeparatorHorizontal3 = new ReaLTaiizor.Controls.SpaceSeparatorHorizontal();
            panel3 = new Panel();
            lblUsers = new Label();
            spaceSeparatorHorizontal1 = new ReaLTaiizor.Controls.SpaceSeparatorHorizontal();
            panel1 = new Panel();
            pvRevenueChart = new OxyPlot.WindowsForms.PlotView();
            cmsRevenue = new ContextMenuStrip(components);
            weeklyToolStripMenuItem = new ToolStripMenuItem();
            monthlyToolStripMenuItem = new ToolStripMenuItem();
            yearlyToolStripMenuItem = new ToolStripMenuItem();
            panel8 = new Panel();
            lblTotalRevenue = new Label();
            panel4 = new Panel();
            tableLayoutPanel5 = new TableLayoutPanel();
            btnAnnual = new FontAwesome.Sharp.IconButton();
            btnMonth = new FontAwesome.Sharp.IconButton();
            btnWeek = new FontAwesome.Sharp.IconButton();
            panel7 = new Panel();
            lblReport = new Label();
            spaceSeparatorHorizontal5 = new ReaLTaiizor.Controls.SpaceSeparatorHorizontal();
            spaceSeparatorVertical4 = new ReaLTaiizor.Controls.SpaceSeparatorVertical();
            spaceSeparatorHorizontal2 = new ReaLTaiizor.Controls.SpaceSeparatorHorizontal();
            spaceSeparatorVertical3 = new ReaLTaiizor.Controls.SpaceSeparatorVertical();
            pvDrivers = new OxyPlot.WindowsForms.PlotView();
            cmsDriver = new ContextMenuStrip(components);
            weeklyToolStripMenuItem1 = new ToolStripMenuItem();
            monthlyToolStripMenuItem1 = new ToolStripMenuItem();
            totalRevenueToolStripMenuItem = new ToolStripMenuItem();
            tableLayoutPanel3 = new TableLayoutPanel();
            panel11 = new Panel();
            lblReports = new Label();
            pictureBox1 = new PictureBox();
            panel9 = new Panel();
            tableLayoutPanel6 = new TableLayoutPanel();
            btnDTotal = new FontAwesome.Sharp.IconButton();
            btnDMionth = new FontAwesome.Sharp.IconButton();
            btnDriverWeek = new FontAwesome.Sharp.IconButton();
            panel10 = new Panel();
            lblTitle = new Label();
            panelRank = new Panel();
            dgvRank = new Krypton.Toolkit.KryptonDataGridView();
            tableLayoutPanel1.SuspendLayout();
            panel2.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            cmsPie.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            panel3.SuspendLayout();
            panel1.SuspendLayout();
            cmsRevenue.SuspendLayout();
            panel8.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            panel7.SuspendLayout();
            cmsDriver.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            panel11.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel9.SuspendLayout();
            tableLayoutPanel6.SuspendLayout();
            panel10.SuspendLayout();
            panelRank.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRank).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 5;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 1.90548778F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 37.7286568F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 2.21036577F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 57.0121956F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 1.44817078F));
            tableLayoutPanel1.Controls.Add(panel2, 1, 1);
            tableLayoutPanel1.Controls.Add(panel1, 3, 1);
            tableLayoutPanel1.Dock = DockStyle.Top;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 1.94174755F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 98.05825F));
            tableLayoutPanel1.Size = new Size(1312, 412);
            tableLayoutPanel1.TabIndex = 43;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(tableLayoutPanel2);
            panel2.Controls.Add(pvPieChart);
            panel2.Controls.Add(tableLayoutPanel4);
            panel2.Controls.Add(spaceSeparatorHorizontal4);
            panel2.Controls.Add(spaceSeparatorVertical1);
            panel2.Controls.Add(spaceSeparatorVertical2);
            panel2.Controls.Add(spaceSeparatorHorizontal3);
            panel2.Controls.Add(panel3);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(27, 11);
            panel2.Name = "panel2";
            panel2.Size = new Size(487, 398);
            panel2.TabIndex = 47;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 42.0289841F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 57.9710159F));
            tableLayoutPanel2.Controls.Add(panel6, 0, 1);
            tableLayoutPanel2.Controls.Add(lblNumDriver, 1, 0);
            tableLayoutPanel2.Controls.Add(lblNumPassenger, 1, 1);
            tableLayoutPanel2.Controls.Add(panel5, 0, 0);
            tableLayoutPanel2.Location = new Point(411, 338);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 3;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 8F));
            tableLayoutPanel2.Size = new Size(69, 56);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // panel6
            // 
            panel6.BackColor = Color.FromArgb(153, 229, 255);
            panel6.Dock = DockStyle.Fill;
            panel6.Location = new Point(3, 27);
            panel6.Name = "panel6";
            panel6.Size = new Size(23, 18);
            panel6.TabIndex = 65;
            // 
            // lblNumDriver
            // 
            lblNumDriver.Dock = DockStyle.Fill;
            lblNumDriver.Font = new Font("Inter Medium", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNumDriver.ForeColor = Color.FromArgb(24, 60, 114);
            lblNumDriver.Location = new Point(29, 0);
            lblNumDriver.Margin = new Padding(0);
            lblNumDriver.Name = "lblNumDriver";
            lblNumDriver.Size = new Size(40, 24);
            lblNumDriver.TabIndex = 62;
            lblNumDriver.Text = "15";
            lblNumDriver.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblNumPassenger
            // 
            lblNumPassenger.Dock = DockStyle.Fill;
            lblNumPassenger.Font = new Font("Inter Medium", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNumPassenger.ForeColor = Color.FromArgb(24, 60, 114);
            lblNumPassenger.Location = new Point(29, 24);
            lblNumPassenger.Margin = new Padding(0);
            lblNumPassenger.Name = "lblNumPassenger";
            lblNumPassenger.Size = new Size(40, 24);
            lblNumPassenger.TabIndex = 63;
            lblNumPassenger.Text = "18";
            lblNumPassenger.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(0, 229, 255);
            panel5.Dock = DockStyle.Fill;
            panel5.Location = new Point(3, 3);
            panel5.Name = "panel5";
            panel5.Size = new Size(23, 18);
            panel5.TabIndex = 64;
            // 
            // pvPieChart
            // 
            pvPieChart.BackColor = Color.White;
            pvPieChart.ContextMenuStrip = cmsPie;
            pvPieChart.Dock = DockStyle.Fill;
            pvPieChart.Location = new Point(4, 96);
            pvPieChart.Name = "pvPieChart";
            pvPieChart.PanCursor = Cursors.Hand;
            pvPieChart.Size = new Size(479, 298);
            pvPieChart.TabIndex = 46;
            pvPieChart.Text = "plotView1";
            pvPieChart.ZoomHorizontalCursor = Cursors.SizeWE;
            pvPieChart.ZoomRectangleCursor = Cursors.SizeNWSE;
            pvPieChart.ZoomVerticalCursor = Cursors.SizeNS;
            // 
            // cmsPie
            // 
            cmsPie.Font = new Font("Segoe UI", 9F);
            cmsPie.Items.AddRange(new ToolStripItem[] { usersToolStripMenuItem, passengersToolStripMenuItem, driversToolStripMenuItem });
            cmsPie.Name = "contextMenuStrip1";
            cmsPie.Size = new Size(162, 82);
            // 
            // usersToolStripMenuItem
            // 
            usersToolStripMenuItem.Font = new Font("Inter", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            usersToolStripMenuItem.Name = "usersToolStripMenuItem";
            usersToolStripMenuItem.Size = new Size(161, 26);
            usersToolStripMenuItem.Text = "Users";
            usersToolStripMenuItem.Click += usersToolStripMenuItem_Click;
            // 
            // passengersToolStripMenuItem
            // 
            passengersToolStripMenuItem.Font = new Font("Inter", 11.25F);
            passengersToolStripMenuItem.Name = "passengersToolStripMenuItem";
            passengersToolStripMenuItem.Size = new Size(161, 26);
            passengersToolStripMenuItem.Text = "Passengers";
            passengersToolStripMenuItem.Click += passengersToolStripMenuItem_Click;
            // 
            // driversToolStripMenuItem
            // 
            driversToolStripMenuItem.Font = new Font("Inter", 11.25F);
            driversToolStripMenuItem.Name = "driversToolStripMenuItem";
            driversToolStripMenuItem.Size = new Size(161, 26);
            driversToolStripMenuItem.Text = "Drivers";
            driversToolStripMenuItem.Click += driversToolStripMenuItem_Click;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 4;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 19.6876278F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 27.3486423F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 19.8329849F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.4029236F));
            tableLayoutPanel4.Controls.Add(btnDrivers, 0, 0);
            tableLayoutPanel4.Controls.Add(btnPassengers, 0, 0);
            tableLayoutPanel4.Controls.Add(btnUsers, 0, 0);
            tableLayoutPanel4.Dock = DockStyle.Top;
            tableLayoutPanel4.Location = new Point(4, 49);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 1;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.Size = new Size(479, 47);
            tableLayoutPanel4.TabIndex = 63;
            // 
            // btnDrivers
            // 
            btnDrivers.Dock = DockStyle.Fill;
            btnDrivers.FlatAppearance.BorderSize = 0;
            btnDrivers.FlatStyle = FlatStyle.Flat;
            btnDrivers.Font = new Font("Inter Medium", 13F, FontStyle.Bold);
            btnDrivers.ForeColor = Color.Black;
            btnDrivers.IconChar = FontAwesome.Sharp.IconChar.None;
            btnDrivers.IconColor = Color.Black;
            btnDrivers.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnDrivers.ImageAlign = ContentAlignment.MiddleLeft;
            btnDrivers.Location = new Point(227, 3);
            btnDrivers.Name = "btnDrivers";
            btnDrivers.Size = new Size(88, 41);
            btnDrivers.TabIndex = 37;
            btnDrivers.Text = "Drivers";
            btnDrivers.UseVisualStyleBackColor = true;
            btnDrivers.Click += driversToolStripMenuItem_Click;
            // 
            // btnPassengers
            // 
            btnPassengers.Dock = DockStyle.Fill;
            btnPassengers.FlatAppearance.BorderSize = 0;
            btnPassengers.FlatStyle = FlatStyle.Flat;
            btnPassengers.Font = new Font("Inter Medium", 13F, FontStyle.Bold);
            btnPassengers.ForeColor = Color.Black;
            btnPassengers.IconChar = FontAwesome.Sharp.IconChar.None;
            btnPassengers.IconColor = Color.Black;
            btnPassengers.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnPassengers.ImageAlign = ContentAlignment.MiddleLeft;
            btnPassengers.Location = new Point(97, 3);
            btnPassengers.Name = "btnPassengers";
            btnPassengers.Size = new Size(124, 41);
            btnPassengers.TabIndex = 36;
            btnPassengers.Text = "Passengers";
            btnPassengers.UseVisualStyleBackColor = true;
            btnPassengers.Click += passengersToolStripMenuItem_Click;
            // 
            // btnUsers
            // 
            btnUsers.Dock = DockStyle.Fill;
            btnUsers.FlatAppearance.BorderSize = 0;
            btnUsers.FlatStyle = FlatStyle.Flat;
            btnUsers.Font = new Font("Inter Medium", 13F, FontStyle.Bold);
            btnUsers.ForeColor = Color.Black;
            btnUsers.IconChar = FontAwesome.Sharp.IconChar.None;
            btnUsers.IconColor = Color.Black;
            btnUsers.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnUsers.ImageAlign = ContentAlignment.MiddleLeft;
            btnUsers.Location = new Point(3, 3);
            btnUsers.Name = "btnUsers";
            btnUsers.Size = new Size(88, 41);
            btnUsers.TabIndex = 35;
            btnUsers.Text = "Users";
            btnUsers.UseVisualStyleBackColor = true;
            btnUsers.Click += usersToolStripMenuItem_Click;
            // 
            // spaceSeparatorHorizontal4
            // 
            spaceSeparatorHorizontal4.Customization = "Kioq/yoqKv8jIyP/Kioq/w==";
            spaceSeparatorHorizontal4.Dock = DockStyle.Bottom;
            spaceSeparatorHorizontal4.Font = new Font("Verdana", 8F);
            spaceSeparatorHorizontal4.Image = null;
            spaceSeparatorHorizontal4.Location = new Point(4, 394);
            spaceSeparatorHorizontal4.Name = "spaceSeparatorHorizontal4";
            spaceSeparatorHorizontal4.NoRounding = false;
            spaceSeparatorHorizontal4.Size = new Size(479, 4);
            spaceSeparatorHorizontal4.TabIndex = 61;
            spaceSeparatorHorizontal4.Text = "spaceSeparatorHorizontal4";
            spaceSeparatorHorizontal4.Transparent = false;
            // 
            // spaceSeparatorVertical1
            // 
            spaceSeparatorVertical1.Customization = "Kioq/yoqKv8jIyP/Kioq/w==";
            spaceSeparatorVertical1.Dock = DockStyle.Right;
            spaceSeparatorVertical1.Font = new Font("Verdana", 8F);
            spaceSeparatorVertical1.Image = null;
            spaceSeparatorVertical1.Location = new Point(483, 49);
            spaceSeparatorVertical1.Name = "spaceSeparatorVertical1";
            spaceSeparatorVertical1.NoRounding = false;
            spaceSeparatorVertical1.Size = new Size(4, 349);
            spaceSeparatorVertical1.TabIndex = 57;
            spaceSeparatorVertical1.Text = "spaceSeparatorVertical1";
            spaceSeparatorVertical1.Transparent = false;
            // 
            // spaceSeparatorVertical2
            // 
            spaceSeparatorVertical2.Customization = "Kioq/yoqKv8jIyP/Kioq/w==";
            spaceSeparatorVertical2.Dock = DockStyle.Left;
            spaceSeparatorVertical2.Font = new Font("Verdana", 8F);
            spaceSeparatorVertical2.Image = null;
            spaceSeparatorVertical2.Location = new Point(0, 49);
            spaceSeparatorVertical2.Name = "spaceSeparatorVertical2";
            spaceSeparatorVertical2.NoRounding = false;
            spaceSeparatorVertical2.Size = new Size(4, 349);
            spaceSeparatorVertical2.TabIndex = 59;
            spaceSeparatorVertical2.Text = "spaceSeparatorVertical2";
            spaceSeparatorVertical2.Transparent = false;
            // 
            // spaceSeparatorHorizontal3
            // 
            spaceSeparatorHorizontal3.Customization = "Kioq/yoqKv8jIyP/Kioq/w==";
            spaceSeparatorHorizontal3.Dock = DockStyle.Top;
            spaceSeparatorHorizontal3.Font = new Font("Verdana", 8F);
            spaceSeparatorHorizontal3.Image = null;
            spaceSeparatorHorizontal3.Location = new Point(0, 45);
            spaceSeparatorHorizontal3.Name = "spaceSeparatorHorizontal3";
            spaceSeparatorHorizontal3.NoRounding = false;
            spaceSeparatorHorizontal3.Size = new Size(487, 4);
            spaceSeparatorHorizontal3.TabIndex = 58;
            spaceSeparatorHorizontal3.Text = "spaceSeparatorHorizontal3";
            spaceSeparatorHorizontal3.Transparent = false;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(38, 36, 68);
            panel3.Controls.Add(lblUsers);
            panel3.Controls.Add(spaceSeparatorHorizontal1);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(487, 45);
            panel3.TabIndex = 0;
            // 
            // lblUsers
            // 
            lblUsers.Dock = DockStyle.Top;
            lblUsers.Font = new Font("Inter", 20F, FontStyle.Bold);
            lblUsers.ForeColor = Color.White;
            lblUsers.Location = new Point(0, 4);
            lblUsers.Name = "lblUsers";
            lblUsers.Size = new Size(487, 34);
            lblUsers.TabIndex = 61;
            lblUsers.Text = "label2";
            lblUsers.TextAlign = ContentAlignment.TopCenter;
            // 
            // spaceSeparatorHorizontal1
            // 
            spaceSeparatorHorizontal1.Customization = "Kioq/yoqKv8jIyP/Kioq/w==";
            spaceSeparatorHorizontal1.Dock = DockStyle.Top;
            spaceSeparatorHorizontal1.Font = new Font("Verdana", 8F);
            spaceSeparatorHorizontal1.Image = null;
            spaceSeparatorHorizontal1.Location = new Point(0, 0);
            spaceSeparatorHorizontal1.Name = "spaceSeparatorHorizontal1";
            spaceSeparatorHorizontal1.NoRounding = false;
            spaceSeparatorHorizontal1.Size = new Size(487, 4);
            spaceSeparatorHorizontal1.TabIndex = 60;
            spaceSeparatorHorizontal1.Text = "spaceSeparatorHorizontal1";
            spaceSeparatorHorizontal1.Transparent = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(pvRevenueChart);
            panel1.Controls.Add(panel8);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(tableLayoutPanel5);
            panel1.Controls.Add(panel7);
            panel1.Controls.Add(spaceSeparatorVertical4);
            panel1.Controls.Add(spaceSeparatorHorizontal2);
            panel1.Controls.Add(spaceSeparatorVertical3);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(548, 11);
            panel1.Name = "panel1";
            panel1.Size = new Size(739, 398);
            panel1.TabIndex = 49;
            // 
            // pvRevenueChart
            // 
            pvRevenueChart.BackColor = Color.White;
            pvRevenueChart.ContextMenuStrip = cmsRevenue;
            pvRevenueChart.Dock = DockStyle.Fill;
            pvRevenueChart.Location = new Point(4, 129);
            pvRevenueChart.Margin = new Padding(0);
            pvRevenueChart.Name = "pvRevenueChart";
            pvRevenueChart.PanCursor = Cursors.Hand;
            pvRevenueChart.Size = new Size(731, 265);
            pvRevenueChart.TabIndex = 48;
            pvRevenueChart.Text = "plotView1";
            pvRevenueChart.ZoomHorizontalCursor = Cursors.SizeWE;
            pvRevenueChart.ZoomRectangleCursor = Cursors.SizeNWSE;
            pvRevenueChart.ZoomVerticalCursor = Cursors.SizeNS;
            // 
            // cmsRevenue
            // 
            cmsRevenue.Font = new Font("Segoe UI", 9F);
            cmsRevenue.Items.AddRange(new ToolStripItem[] { weeklyToolStripMenuItem, monthlyToolStripMenuItem, yearlyToolStripMenuItem });
            cmsRevenue.Name = "cmsRevenue";
            cmsRevenue.Size = new Size(136, 82);
            // 
            // weeklyToolStripMenuItem
            // 
            weeklyToolStripMenuItem.Font = new Font("Inter", 11.25F);
            weeklyToolStripMenuItem.Name = "weeklyToolStripMenuItem";
            weeklyToolStripMenuItem.Size = new Size(135, 26);
            weeklyToolStripMenuItem.Text = "Weekly";
            weeklyToolStripMenuItem.Click += weeklyToolStripMenuItem_Click;
            // 
            // monthlyToolStripMenuItem
            // 
            monthlyToolStripMenuItem.Font = new Font("Inter", 11.25F);
            monthlyToolStripMenuItem.Name = "monthlyToolStripMenuItem";
            monthlyToolStripMenuItem.Size = new Size(135, 26);
            monthlyToolStripMenuItem.Text = "Monthly";
            monthlyToolStripMenuItem.Click += monthlyToolStripMenuItem_Click;
            // 
            // yearlyToolStripMenuItem
            // 
            yearlyToolStripMenuItem.Font = new Font("Inter", 11.25F);
            yearlyToolStripMenuItem.Name = "yearlyToolStripMenuItem";
            yearlyToolStripMenuItem.Size = new Size(135, 26);
            yearlyToolStripMenuItem.Text = "Yearly";
            yearlyToolStripMenuItem.Click += yearlyToolStripMenuItem_Click;
            // 
            // panel8
            // 
            panel8.BackColor = Color.White;
            panel8.Controls.Add(lblTotalRevenue);
            panel8.Dock = DockStyle.Top;
            panel8.Location = new Point(4, 78);
            panel8.Name = "panel8";
            panel8.Size = new Size(731, 51);
            panel8.TabIndex = 65;
            // 
            // lblTotalRevenue
            // 
            lblTotalRevenue.Font = new Font("Inter", 30F, FontStyle.Bold);
            lblTotalRevenue.ForeColor = Color.FromArgb(38, 36, 68);
            lblTotalRevenue.Location = new Point(0, 0);
            lblTotalRevenue.Margin = new Padding(0);
            lblTotalRevenue.Name = "lblTotalRevenue";
            lblTotalRevenue.Size = new Size(731, 51);
            lblTotalRevenue.TabIndex = 61;
            lblTotalRevenue.Text = "label2";
            // 
            // panel4
            // 
            panel4.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            panel4.BackColor = Color.White;
            panel4.Location = new Point(89, 284);
            panel4.Name = "panel4";
            panel4.Size = new Size(69, 56);
            panel4.TabIndex = 62;
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.ColumnCount = 4;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 18.76886F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 18.7688637F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 18.7688637F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 43.6934166F));
            tableLayoutPanel5.Controls.Add(btnAnnual, 0, 0);
            tableLayoutPanel5.Controls.Add(btnMonth, 0, 0);
            tableLayoutPanel5.Controls.Add(btnWeek, 0, 0);
            tableLayoutPanel5.Dock = DockStyle.Top;
            tableLayoutPanel5.Location = new Point(4, 38);
            tableLayoutPanel5.Margin = new Padding(0);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 1;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel5.Size = new Size(731, 40);
            tableLayoutPanel5.TabIndex = 66;
            // 
            // btnAnnual
            // 
            btnAnnual.Dock = DockStyle.Fill;
            btnAnnual.FlatAppearance.BorderSize = 0;
            btnAnnual.FlatStyle = FlatStyle.Flat;
            btnAnnual.Font = new Font("Inter Medium", 13F, FontStyle.Bold);
            btnAnnual.ForeColor = Color.Black;
            btnAnnual.IconChar = FontAwesome.Sharp.IconChar.None;
            btnAnnual.IconColor = Color.Black;
            btnAnnual.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnAnnual.ImageAlign = ContentAlignment.MiddleLeft;
            btnAnnual.Location = new Point(277, 3);
            btnAnnual.Name = "btnAnnual";
            btnAnnual.Size = new Size(131, 34);
            btnAnnual.TabIndex = 37;
            btnAnnual.Text = "Annual";
            btnAnnual.TextAlign = ContentAlignment.TopCenter;
            btnAnnual.UseVisualStyleBackColor = true;
            btnAnnual.Click += yearlyToolStripMenuItem_Click;
            // 
            // btnMonth
            // 
            btnMonth.Dock = DockStyle.Fill;
            btnMonth.FlatAppearance.BorderSize = 0;
            btnMonth.FlatStyle = FlatStyle.Flat;
            btnMonth.Font = new Font("Inter Medium", 13F, FontStyle.Bold);
            btnMonth.ForeColor = Color.Black;
            btnMonth.IconChar = FontAwesome.Sharp.IconChar.None;
            btnMonth.IconColor = Color.Black;
            btnMonth.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnMonth.ImageAlign = ContentAlignment.MiddleLeft;
            btnMonth.Location = new Point(140, 3);
            btnMonth.Name = "btnMonth";
            btnMonth.Size = new Size(131, 34);
            btnMonth.TabIndex = 36;
            btnMonth.Text = "Month";
            btnMonth.TextAlign = ContentAlignment.TopCenter;
            btnMonth.UseVisualStyleBackColor = true;
            btnMonth.Click += monthlyToolStripMenuItem_Click;
            // 
            // btnWeek
            // 
            btnWeek.Dock = DockStyle.Fill;
            btnWeek.FlatAppearance.BorderSize = 0;
            btnWeek.FlatStyle = FlatStyle.Flat;
            btnWeek.Font = new Font("Inter Medium", 13F, FontStyle.Bold);
            btnWeek.ForeColor = Color.Black;
            btnWeek.IconChar = FontAwesome.Sharp.IconChar.None;
            btnWeek.IconColor = Color.Black;
            btnWeek.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnWeek.ImageAlign = ContentAlignment.MiddleLeft;
            btnWeek.Location = new Point(3, 3);
            btnWeek.Name = "btnWeek";
            btnWeek.Size = new Size(131, 34);
            btnWeek.TabIndex = 35;
            btnWeek.Text = "Week";
            btnWeek.TextAlign = ContentAlignment.TopCenter;
            btnWeek.UseVisualStyleBackColor = true;
            btnWeek.Click += weeklyToolStripMenuItem_Click;
            // 
            // panel7
            // 
            panel7.BackColor = Color.White;
            panel7.Controls.Add(lblReport);
            panel7.Controls.Add(spaceSeparatorHorizontal5);
            panel7.Dock = DockStyle.Top;
            panel7.Location = new Point(4, 0);
            panel7.Name = "panel7";
            panel7.Size = new Size(731, 38);
            panel7.TabIndex = 64;
            // 
            // lblReport
            // 
            lblReport.Dock = DockStyle.Fill;
            lblReport.Font = new Font("Inter Medium", 16.75F, FontStyle.Bold);
            lblReport.ForeColor = Color.FromArgb(38, 36, 68);
            lblReport.Location = new Point(0, 4);
            lblReport.Name = "lblReport";
            lblReport.Size = new Size(731, 34);
            lblReport.TabIndex = 61;
            lblReport.Text = "Weekly Report";
            // 
            // spaceSeparatorHorizontal5
            // 
            spaceSeparatorHorizontal5.Customization = "Kioq/yoqKv8jIyP/Kioq/w==";
            spaceSeparatorHorizontal5.Dock = DockStyle.Top;
            spaceSeparatorHorizontal5.Font = new Font("Verdana", 8F);
            spaceSeparatorHorizontal5.Image = null;
            spaceSeparatorHorizontal5.Location = new Point(0, 0);
            spaceSeparatorHorizontal5.Name = "spaceSeparatorHorizontal5";
            spaceSeparatorHorizontal5.NoRounding = false;
            spaceSeparatorHorizontal5.Size = new Size(731, 4);
            spaceSeparatorHorizontal5.TabIndex = 60;
            spaceSeparatorHorizontal5.Text = "spaceSeparatorHorizontal5";
            spaceSeparatorHorizontal5.Transparent = false;
            // 
            // spaceSeparatorVertical4
            // 
            spaceSeparatorVertical4.Customization = "Kioq/yoqKv8jIyP/Kioq/w==";
            spaceSeparatorVertical4.Dock = DockStyle.Left;
            spaceSeparatorVertical4.Font = new Font("Verdana", 8F);
            spaceSeparatorVertical4.Image = null;
            spaceSeparatorVertical4.Location = new Point(0, 0);
            spaceSeparatorVertical4.Name = "spaceSeparatorVertical4";
            spaceSeparatorVertical4.NoRounding = false;
            spaceSeparatorVertical4.Size = new Size(4, 394);
            spaceSeparatorVertical4.TabIndex = 63;
            spaceSeparatorVertical4.Text = "spaceSeparatorVertical4";
            spaceSeparatorVertical4.Transparent = false;
            // 
            // spaceSeparatorHorizontal2
            // 
            spaceSeparatorHorizontal2.Customization = "Kioq/yoqKv8jIyP/Kioq/w==";
            spaceSeparatorHorizontal2.Dock = DockStyle.Bottom;
            spaceSeparatorHorizontal2.Font = new Font("Verdana", 8F);
            spaceSeparatorHorizontal2.Image = null;
            spaceSeparatorHorizontal2.Location = new Point(0, 394);
            spaceSeparatorHorizontal2.Name = "spaceSeparatorHorizontal2";
            spaceSeparatorHorizontal2.NoRounding = false;
            spaceSeparatorHorizontal2.Size = new Size(735, 4);
            spaceSeparatorHorizontal2.TabIndex = 62;
            spaceSeparatorHorizontal2.Text = "spaceSeparatorHorizontal2";
            spaceSeparatorHorizontal2.Transparent = false;
            // 
            // spaceSeparatorVertical3
            // 
            spaceSeparatorVertical3.Customization = "Kioq/yoqKv8jIyP/Kioq/w==";
            spaceSeparatorVertical3.Dock = DockStyle.Right;
            spaceSeparatorVertical3.Font = new Font("Verdana", 8F);
            spaceSeparatorVertical3.Image = null;
            spaceSeparatorVertical3.Location = new Point(735, 0);
            spaceSeparatorVertical3.Name = "spaceSeparatorVertical3";
            spaceSeparatorVertical3.NoRounding = false;
            spaceSeparatorVertical3.Size = new Size(4, 398);
            spaceSeparatorVertical3.TabIndex = 58;
            spaceSeparatorVertical3.Text = "spaceSeparatorVertical3";
            spaceSeparatorVertical3.Transparent = false;
            // 
            // pvDrivers
            // 
            pvDrivers.ContextMenuStrip = cmsDriver;
            pvDrivers.Dock = DockStyle.Fill;
            pvDrivers.Location = new Point(0, 78);
            pvDrivers.Name = "pvDrivers";
            pvDrivers.PanCursor = Cursors.Hand;
            pvDrivers.Size = new Size(618, 232);
            pvDrivers.TabIndex = 50;
            pvDrivers.Text = "plotView1";
            pvDrivers.ZoomHorizontalCursor = Cursors.SizeWE;
            pvDrivers.ZoomRectangleCursor = Cursors.SizeNWSE;
            pvDrivers.ZoomVerticalCursor = Cursors.SizeNS;
            // 
            // cmsDriver
            // 
            cmsDriver.Items.AddRange(new ToolStripItem[] { weeklyToolStripMenuItem1, monthlyToolStripMenuItem1, totalRevenueToolStripMenuItem });
            cmsDriver.Name = "cmsDriver";
            cmsDriver.Size = new Size(180, 82);
            // 
            // weeklyToolStripMenuItem1
            // 
            weeklyToolStripMenuItem1.Font = new Font("Inter", 11.25F);
            weeklyToolStripMenuItem1.Name = "weeklyToolStripMenuItem1";
            weeklyToolStripMenuItem1.Size = new Size(179, 26);
            weeklyToolStripMenuItem1.Text = "Weekly";
            weeklyToolStripMenuItem1.Click += weeklyToolStripMenuItem1_Click;
            // 
            // monthlyToolStripMenuItem1
            // 
            monthlyToolStripMenuItem1.Font = new Font("Inter", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            monthlyToolStripMenuItem1.Name = "monthlyToolStripMenuItem1";
            monthlyToolStripMenuItem1.Size = new Size(179, 26);
            monthlyToolStripMenuItem1.Text = "Monthly";
            monthlyToolStripMenuItem1.Click += monthlyToolStripMenuItem1_Click;
            // 
            // totalRevenueToolStripMenuItem
            // 
            totalRevenueToolStripMenuItem.Font = new Font("Inter", 11.25F);
            totalRevenueToolStripMenuItem.Name = "totalRevenueToolStripMenuItem";
            totalRevenueToolStripMenuItem.Size = new Size(179, 26);
            totalRevenueToolStripMenuItem.Text = "Total Revenue";
            totalRevenueToolStripMenuItem.Click += totalRevenueToolStripMenuItem_Click;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 7;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 1.42155683F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 18.9547577F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 1.17004681F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 48.6739464F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 1.326053F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 28.471138F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 28F));
            tableLayoutPanel3.Controls.Add(panel11, 1, 1);
            tableLayoutPanel3.Controls.Add(panel9, 3, 1);
            tableLayoutPanel3.Controls.Add(panelRank, 5, 1);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(0, 412);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 3;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 5.633803F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 89.0140839F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 5.352113F));
            tableLayoutPanel3.Size = new Size(1312, 355);
            tableLayoutPanel3.TabIndex = 44;
            // 
            // panel11
            // 
            panel11.BackColor = Color.FromArgb(230, 249, 255);
            panel11.Controls.Add(lblReports);
            panel11.Controls.Add(pictureBox1);
            panel11.Dock = DockStyle.Fill;
            panel11.Location = new Point(21, 23);
            panel11.Name = "panel11";
            panel11.Size = new Size(237, 310);
            panel11.TabIndex = 52;
            // 
            // lblReports
            // 
            lblReports.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lblReports.BackColor = Color.FromArgb(0, 229, 255);
            lblReports.Font = new Font("Inter", 60F, FontStyle.Bold);
            lblReports.ForeColor = Color.FromArgb(38, 36, 68);
            lblReports.Image = Properties.Resources.bgReports1;
            lblReports.Location = new Point(7, 78);
            lblReports.Margin = new Padding(0);
            lblReports.Name = "lblReports";
            lblReports.Size = new Size(219, 118);
            lblReports.TabIndex = 43;
            lblReports.Text = "2";
            lblReports.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = Properties.Resources.Reports__1_;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(237, 310);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 44;
            pictureBox1.TabStop = false;
            // 
            // panel9
            // 
            panel9.BackColor = Color.FromArgb(38, 36, 68);
            panel9.Controls.Add(pvDrivers);
            panel9.Controls.Add(tableLayoutPanel6);
            panel9.Controls.Add(panel10);
            panel9.Dock = DockStyle.Fill;
            panel9.Location = new Point(279, 23);
            panel9.Name = "panel9";
            panel9.Size = new Size(618, 310);
            panel9.TabIndex = 51;
            // 
            // tableLayoutPanel6
            // 
            tableLayoutPanel6.ColumnCount = 4;
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20.1414833F));
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20.1414833F));
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 24.7572823F));
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 35.11327F));
            tableLayoutPanel6.Controls.Add(btnDTotal, 0, 0);
            tableLayoutPanel6.Controls.Add(btnDMionth, 0, 0);
            tableLayoutPanel6.Controls.Add(btnDriverWeek, 0, 0);
            tableLayoutPanel6.Dock = DockStyle.Top;
            tableLayoutPanel6.Location = new Point(0, 38);
            tableLayoutPanel6.Margin = new Padding(0);
            tableLayoutPanel6.Name = "tableLayoutPanel6";
            tableLayoutPanel6.RowCount = 1;
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel6.Size = new Size(618, 40);
            tableLayoutPanel6.TabIndex = 67;
            // 
            // btnDTotal
            // 
            btnDTotal.Dock = DockStyle.Fill;
            btnDTotal.FlatAppearance.BorderSize = 0;
            btnDTotal.FlatStyle = FlatStyle.Flat;
            btnDTotal.Font = new Font("Inter Medium", 13F, FontStyle.Bold);
            btnDTotal.ForeColor = Color.White;
            btnDTotal.IconChar = FontAwesome.Sharp.IconChar.None;
            btnDTotal.IconColor = Color.Black;
            btnDTotal.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnDTotal.ImageAlign = ContentAlignment.MiddleLeft;
            btnDTotal.Location = new Point(251, 3);
            btnDTotal.Name = "btnDTotal";
            btnDTotal.Size = new Size(146, 34);
            btnDTotal.TabIndex = 37;
            btnDTotal.Text = "Total Revenue";
            btnDTotal.TextAlign = ContentAlignment.TopCenter;
            btnDTotal.UseVisualStyleBackColor = true;
            btnDTotal.Click += totalRevenueToolStripMenuItem_Click;
            // 
            // btnDMionth
            // 
            btnDMionth.Dock = DockStyle.Fill;
            btnDMionth.FlatAppearance.BorderSize = 0;
            btnDMionth.FlatStyle = FlatStyle.Flat;
            btnDMionth.Font = new Font("Inter Medium", 13F, FontStyle.Bold);
            btnDMionth.ForeColor = Color.White;
            btnDMionth.IconChar = FontAwesome.Sharp.IconChar.None;
            btnDMionth.IconColor = Color.Black;
            btnDMionth.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnDMionth.ImageAlign = ContentAlignment.MiddleLeft;
            btnDMionth.Location = new Point(127, 3);
            btnDMionth.Name = "btnDMionth";
            btnDMionth.Size = new Size(118, 34);
            btnDMionth.TabIndex = 36;
            btnDMionth.Text = "Month";
            btnDMionth.TextAlign = ContentAlignment.TopCenter;
            btnDMionth.UseVisualStyleBackColor = true;
            btnDMionth.Click += monthlyToolStripMenuItem1_Click;
            // 
            // btnDriverWeek
            // 
            btnDriverWeek.Dock = DockStyle.Fill;
            btnDriverWeek.FlatAppearance.BorderSize = 0;
            btnDriverWeek.FlatStyle = FlatStyle.Flat;
            btnDriverWeek.Font = new Font("Inter Medium", 13F, FontStyle.Bold);
            btnDriverWeek.ForeColor = Color.White;
            btnDriverWeek.IconChar = FontAwesome.Sharp.IconChar.None;
            btnDriverWeek.IconColor = Color.Black;
            btnDriverWeek.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnDriverWeek.ImageAlign = ContentAlignment.MiddleLeft;
            btnDriverWeek.Location = new Point(3, 3);
            btnDriverWeek.Name = "btnDriverWeek";
            btnDriverWeek.Size = new Size(118, 34);
            btnDriverWeek.TabIndex = 35;
            btnDriverWeek.Text = "Week";
            btnDriverWeek.TextAlign = ContentAlignment.TopCenter;
            btnDriverWeek.UseVisualStyleBackColor = true;
            btnDriverWeek.Click += weeklyToolStripMenuItem1_Click;
            // 
            // panel10
            // 
            panel10.BackColor = Color.FromArgb(38, 36, 68);
            panel10.Controls.Add(lblTitle);
            panel10.Dock = DockStyle.Top;
            panel10.Location = new Point(0, 0);
            panel10.Name = "panel10";
            panel10.Size = new Size(618, 38);
            panel10.TabIndex = 65;
            // 
            // lblTitle
            // 
            lblTitle.Dock = DockStyle.Fill;
            lblTitle.Font = new Font("Inter SemiBold", 17.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(0, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(618, 38);
            lblTitle.TabIndex = 61;
            lblTitle.Text = "Driver Analysis – Weekly Revenue";
            // 
            // panelRank
            // 
            panelRank.BackColor = Color.FromArgb(153, 229, 255);
            panelRank.Controls.Add(dgvRank);
            panelRank.Dock = DockStyle.Fill;
            panelRank.Location = new Point(920, 23);
            panelRank.Name = "panelRank";
            panelRank.Size = new Size(359, 310);
            panelRank.TabIndex = 53;
            // 
            // dgvRank
            // 
            dgvRank.BorderStyle = BorderStyle.None;
            dgvRank.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRank.Dock = DockStyle.Fill;
            dgvRank.HideOuterBorders = true;
            dgvRank.Location = new Point(0, 0);
            dgvRank.Name = "dgvRank";
            dgvRank.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007BlueLightMode;
            dgvRank.ReadOnly = true;
            dgvRank.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvRank.ShowEditingIcon = false;
            dgvRank.Size = new Size(359, 310);
            dgvRank.StateCommon.Background.Color1 = Color.FromArgb(153, 229, 255);
            dgvRank.StateCommon.Background.Color2 = Color.FromArgb(153, 229, 255);
            dgvRank.StateCommon.BackStyle = Krypton.Toolkit.PaletteBackStyle.GridBackgroundList;
            dgvRank.StateCommon.DataCell.Back.Color1 = Color.FromArgb(153, 229, 255);
            dgvRank.StateCommon.DataCell.Border.Color1 = Color.White;
            dgvRank.StateCommon.DataCell.Border.Color2 = Color.White;
            dgvRank.StateCommon.DataCell.Content.Color1 = Color.FromArgb(24, 60, 114);
            dgvRank.StateCommon.DataCell.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            dgvRank.StateCommon.DataCell.Content.TextV = Krypton.Toolkit.PaletteRelativeAlign.Center;
            dgvRank.StateCommon.HeaderColumn.Back.Color1 = Color.FromArgb(38, 36, 68);
            dgvRank.StateCommon.HeaderColumn.Back.Color2 = Color.FromArgb(38, 36, 68);
            dgvRank.StateCommon.HeaderColumn.Border.Color1 = Color.White;
            dgvRank.StateCommon.HeaderColumn.Border.Color2 = Color.White;
            dgvRank.StateCommon.HeaderColumn.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            dgvRank.StateCommon.HeaderColumn.Content.TextV = Krypton.Toolkit.PaletteRelativeAlign.Center;
            dgvRank.StateSelected.DataCell.Back.Color1 = Color.FromArgb(0, 229, 255);
            dgvRank.StateSelected.DataCell.Back.Color2 = Color.FromArgb(0, 229, 255);
            dgvRank.TabIndex = 1;
            // 
            // HomeAdmin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(230, 249, 255);
            Controls.Add(tableLayoutPanel3);
            Controls.Add(tableLayoutPanel1);
            Name = "HomeAdmin";
            Size = new Size(1312, 767);
            Load += HomeAdmin_Load;
            tableLayoutPanel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            cmsPie.ResumeLayout(false);
            tableLayoutPanel4.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel1.ResumeLayout(false);
            cmsRevenue.ResumeLayout(false);
            panel8.ResumeLayout(false);
            tableLayoutPanel5.ResumeLayout(false);
            panel7.ResumeLayout(false);
            cmsDriver.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            panel11.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel9.ResumeLayout(false);
            tableLayoutPanel6.ResumeLayout(false);
            panel10.ResumeLayout(false);
            panelRank.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvRank).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private TableLayoutPanel tableLayoutPanel1;
        private OxyPlot.WindowsForms.PlotView pvPieChart;
        private Panel panel2;
        private Panel panel3;
        private ReaLTaiizor.Controls.SpaceSeparatorVertical spaceSeparatorVertical2;
        private ReaLTaiizor.Controls.SpaceSeparatorVertical spaceSeparatorVertical1;
        private ReaLTaiizor.Controls.SpaceSeparatorHorizontal spaceSeparatorHorizontal3;
        private ReaLTaiizor.Controls.SpaceSeparatorHorizontal spaceSeparatorHorizontal4;
        private ReaLTaiizor.Controls.SpaceSeparatorHorizontal spaceSeparatorHorizontal1;
        private Label lblUsers;
        private Panel panel4;
        private TableLayoutPanel tableLayoutPanel2;
        private Panel panel6;
        private Label lblNumDriver;
        private Label lblNumPassenger;
        private Panel panel5;
        private Panel panel1;
        private OxyPlot.WindowsForms.PlotView pvRevenueChart;
        private ReaLTaiizor.Controls.SpaceSeparatorVertical spaceSeparatorVertical4;
        private ReaLTaiizor.Controls.SpaceSeparatorHorizontal spaceSeparatorHorizontal2;
        private ReaLTaiizor.Controls.SpaceSeparatorVertical spaceSeparatorVertical3;
        private Panel panel8;
        private Label lblTotalRevenue;
        private Panel panel7;
        private Label lblReport;
        private ReaLTaiizor.Controls.SpaceSeparatorHorizontal spaceSeparatorHorizontal5;
        private ContextMenuStrip cmsRevenue;
        private ToolStripMenuItem weeklyToolStripMenuItem;
        private ToolStripMenuItem monthlyToolStripMenuItem;
        private ToolStripMenuItem yearlyToolStripMenuItem;
        private OxyPlot.WindowsForms.PlotView pvDrivers;
        private TableLayoutPanel tableLayoutPanel3;
        private Panel panel9;
        private ContextMenuStrip cmsDriver;
        private ToolStripMenuItem weeklyToolStripMenuItem1;
        private ToolStripMenuItem monthlyToolStripMenuItem1;
        private ToolStripMenuItem totalRevenueToolStripMenuItem;
        private ContextMenuStrip cmsPie;
        private ToolStripMenuItem passengersToolStripMenuItem;
        private ToolStripMenuItem driversToolStripMenuItem;
        private ToolStripMenuItem usersToolStripMenuItem;
        private Panel panel10;
        private Label lblTitle;
        private Panel panel11;
        private Label lblReports;
        private Panel panelRank;
        private PictureBox pictureBox1;
        private ReaLTaiizor.Controls.CyberRichTextBox cyberRichTextBox1;
        private ReaLTaiizor.Controls.CyberButton cyberButton1;
        private ReaLTaiizor.Controls.CyberButton cyberButton3;
        private Krypton.Toolkit.KryptonDataGridView dgvRank;
        private TableLayoutPanel tableLayoutPanel4;
        private FontAwesome.Sharp.IconButton btnDrivers;
        private FontAwesome.Sharp.IconButton btnPassengers;
        private FontAwesome.Sharp.IconButton btnUsers;
        private TableLayoutPanel tableLayoutPanel5;
        private FontAwesome.Sharp.IconButton btnAnnual;
        private FontAwesome.Sharp.IconButton btnMonth;
        private FontAwesome.Sharp.IconButton btnWeek;
        private TableLayoutPanel tableLayoutPanel6;
        private FontAwesome.Sharp.IconButton btnDTotal;
        private FontAwesome.Sharp.IconButton btnDMionth;
        private FontAwesome.Sharp.IconButton btnDriverWeek;
    }
}
