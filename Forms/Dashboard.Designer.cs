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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            panel2 = new Panel();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            btnLogout = new PictureBox();
            pbAbout = new PictureBox();
            btnHome = new PictureBox();
            btnScan = new PictureBox();
            btnReport = new PictureBox();
            btnHistory = new PictureBox();
            btnRate = new PictureBox();
            btnRoute = new PictureBox();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnLogout).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbAbout).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnHome).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnScan).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnReport).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnHistory).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnRate).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnRoute).BeginInit();
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
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(btnLogout);
            panel1.Controls.Add(pbAbout);
            panel1.Controls.Add(btnHome);
            panel1.Controls.Add(btnScan);
            panel1.Controls.Add(btnReport);
            panel1.Controls.Add(btnHistory);
            panel1.Controls.Add(btnRate);
            panel1.Controls.Add(btnRoute);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 28);
            panel1.Name = "panel1";
            panel1.Size = new Size(88, 879);
            panel1.TabIndex = 18;
            // 
            // btnLogout
            // 
            btnLogout.Cursor = Cursors.Hand;
            btnLogout.Image = Properties.Resources.logout_normal;
            btnLogout.Location = new Point(17, 805);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(50, 44);
            btnLogout.SizeMode = PictureBoxSizeMode.CenterImage;
            btnLogout.TabIndex = 7;
            btnLogout.TabStop = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // pbAbout
            // 
            pbAbout.Cursor = Cursors.Hand;
            pbAbout.Image = Properties.Resources.Removal_915;
            pbAbout.Location = new Point(17, 15);
            pbAbout.Name = "pbAbout";
            pbAbout.Size = new Size(53, 55);
            pbAbout.SizeMode = PictureBoxSizeMode.Zoom;
            pbAbout.TabIndex = 6;
            pbAbout.TabStop = false;
            pbAbout.Click += pbAbout_Click;
            // 
            // btnHome
            // 
            btnHome.Cursor = Cursors.Hand;
            btnHome.Image = Properties.Resources.home_normal;
            btnHome.Location = new Point(22, 175);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(45, 44);
            btnHome.SizeMode = PictureBoxSizeMode.CenterImage;
            btnHome.TabIndex = 5;
            btnHome.TabStop = false;
            btnHome.Click += btnHome_Click;
            // 
            // btnScan
            // 
            btnScan.Cursor = Cursors.Hand;
            btnScan.Image = Properties.Resources.scan_normall;
            btnScan.Location = new Point(22, 325);
            btnScan.Name = "btnScan";
            btnScan.Size = new Size(45, 44);
            btnScan.SizeMode = PictureBoxSizeMode.Zoom;
            btnScan.TabIndex = 4;
            btnScan.TabStop = false;
            btnScan.Click += btnScan_Click;
            // 
            // btnReport
            // 
            btnReport.Cursor = Cursors.Hand;
            btnReport.Image = Properties.Resources.emergency__1_;
            btnReport.Location = new Point(22, 400);
            btnReport.Name = "btnReport";
            btnReport.Size = new Size(45, 44);
            btnReport.SizeMode = PictureBoxSizeMode.Zoom;
            btnReport.TabIndex = 3;
            btnReport.TabStop = false;
            btnReport.Click += btnReport_Click;
            // 
            // btnHistory
            // 
            btnHistory.Cursor = Cursors.Hand;
            btnHistory.Image = Properties.Resources.history_normal;
            btnHistory.Location = new Point(22, 550);
            btnHistory.Name = "btnHistory";
            btnHistory.Size = new Size(45, 44);
            btnHistory.SizeMode = PictureBoxSizeMode.CenterImage;
            btnHistory.TabIndex = 2;
            btnHistory.TabStop = false;
            btnHistory.Click += btnHistory_Click;
            // 
            // btnRate
            // 
            btnRate.Cursor = Cursors.Hand;
            btnRate.Image = Properties.Resources.rate1_normal;
            btnRate.Location = new Point(22, 475);
            btnRate.Name = "btnRate";
            btnRate.Size = new Size(45, 44);
            btnRate.SizeMode = PictureBoxSizeMode.Zoom;
            btnRate.TabIndex = 1;
            btnRate.TabStop = false;
            btnRate.Click += btnRate_Click;
            // 
            // btnRoute
            // 
            btnRoute.Cursor = Cursors.Hand;
            btnRoute.Image = Properties.Resources.route_normal;
            btnRoute.Location = new Point(22, 250);
            btnRoute.Name = "btnRoute";
            btnRoute.Size = new Size(45, 44);
            btnRoute.SizeMode = PictureBoxSizeMode.CenterImage;
            btnRoute.TabIndex = 0;
            btnRoute.TabStop = false;
            btnRoute.Click += btnRoute_Click;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(230, 249, 255);
            ClientSize = new Size(1400, 907);
            Controls.Add(panel1);
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
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)btnLogout).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbAbout).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnHome).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnScan).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnReport).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnHistory).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnRate).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnRoute).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Panel panel1;
        private PictureBox btnRoute;
        private PictureBox pbAbout;
        private PictureBox btnHome;
        private PictureBox btnScan;
        private PictureBox btnReport;
        private PictureBox btnHistory;
        private PictureBox btnRate;
        private PictureBox btnLogout;
    }
}