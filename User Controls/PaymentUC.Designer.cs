namespace NEXUS.User_Controls
{
    partial class PaymentUC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PaymentUC));
            tableLayoutPanel1 = new TableLayoutPanel();
            label2 = new Label();
            tableLayoutPanel4 = new TableLayoutPanel();
            lblDateTime = new Label();
            tableLayoutPanel2 = new TableLayoutPanel();
            lblDriverRoute = new Label();
            tableLayoutPanel3 = new TableLayoutPanel();
            lblDriverStatus = new Label();
            lbl = new Label();
            lblDriverName = new Label();
            lblPlateNum = new Label();
            tableLayoutPanel6 = new TableLayoutPanel();
            pbDriverPicture = new PictureBox();
            tableLayoutPanel5 = new TableLayoutPanel();
            panel1 = new Panel();
            cmbxDestination = new ComboBox();
            cmbxLocation = new ComboBox();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            lblAmount = new Label();
            numericMultiplier = new NumericUpDown();
            label1 = new Label();
            btnPay = new ReaLTaiizor.Controls.CyberButton();
            lbl1 = new Label();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbDriverPicture).BeginInit();
            tableLayoutPanel5.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericMultiplier).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 617F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Controls.Add(label2, 1, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel4, 1, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 11.32812F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 88.67188F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 12F));
            tableLayoutPanel1.Size = new Size(700, 700);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // label2
            // 
            label2.BackColor = Color.FromArgb(230, 249, 255);
            label2.Dock = DockStyle.Fill;
            label2.Font = new Font("Inter ExtraBold", 24F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(38, 36, 68);
            label2.Location = new Point(43, 0);
            label2.Name = "label2";
            label2.Size = new Size(611, 77);
            label2.TabIndex = 20;
            label2.Text = "PAYMENT SECTION";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 1;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.Controls.Add(lblDateTime, 0, 1);
            tableLayoutPanel4.Controls.Add(tableLayoutPanel2, 0, 0);
            tableLayoutPanel4.Controls.Add(tableLayoutPanel5, 0, 2);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(43, 80);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 3;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 87.45387F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5461254F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 332F));
            tableLayoutPanel4.Size = new Size(611, 604);
            tableLayoutPanel4.TabIndex = 25;
            // 
            // lblDateTime
            // 
            lblDateTime.AutoSize = true;
            lblDateTime.BackColor = Color.FromArgb(230, 249, 255);
            lblDateTime.Dock = DockStyle.Fill;
            lblDateTime.Font = new Font("Inter SemiBold", 16.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDateTime.ForeColor = Color.FromArgb(38, 36, 68);
            lblDateTime.Location = new Point(3, 237);
            lblDateTime.Name = "lblDateTime";
            lblDateTime.Size = new Size(605, 34);
            lblDateTime.TabIndex = 24;
            lblDateTime.Text = "DATE";
            lblDateTime.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.BackColor = Color.White;
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 32.727272F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 67.27273F));
            tableLayoutPanel2.Controls.Add(lblDriverRoute, 1, 1);
            tableLayoutPanel2.Controls.Add(tableLayoutPanel3, 1, 0);
            tableLayoutPanel2.Controls.Add(lblPlateNum, 0, 1);
            tableLayoutPanel2.Controls.Add(tableLayoutPanel6, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 79.39914F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 20.6008587F));
            tableLayoutPanel2.Size = new Size(605, 231);
            tableLayoutPanel2.TabIndex = 22;
            // 
            // lblDriverRoute
            // 
            lblDriverRoute.AutoSize = true;
            lblDriverRoute.BackColor = Color.White;
            lblDriverRoute.Dock = DockStyle.Fill;
            lblDriverRoute.Font = new Font("Inter Medium", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDriverRoute.ForeColor = Color.FromArgb(24, 60, 114);
            lblDriverRoute.Location = new Point(201, 183);
            lblDriverRoute.Name = "lblDriverRoute";
            lblDriverRoute.Padding = new Padding(20, 0, 0, 0);
            lblDriverRoute.Size = new Size(401, 48);
            lblDriverRoute.TabIndex = 6;
            lblDriverRoute.Text = "Route";
            lblDriverRoute.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.BackColor = Color.White;
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Controls.Add(lblDriverStatus, 0, 2);
            tableLayoutPanel3.Controls.Add(lbl, 0, 0);
            tableLayoutPanel3.Controls.Add(lblDriverName, 0, 1);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(201, 3);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 3;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 49.1071434F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50.8928566F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 54F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel3.Size = new Size(401, 177);
            tableLayoutPanel3.TabIndex = 0;
            // 
            // lblDriverStatus
            // 
            lblDriverStatus.AutoSize = true;
            lblDriverStatus.BackColor = Color.White;
            lblDriverStatus.Dock = DockStyle.Fill;
            lblDriverStatus.Font = new Font("Inter Medium", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDriverStatus.ForeColor = Color.FromArgb(24, 60, 114);
            lblDriverStatus.Location = new Point(3, 122);
            lblDriverStatus.Name = "lblDriverStatus";
            lblDriverStatus.Padding = new Padding(15, 0, 0, 0);
            lblDriverStatus.Size = new Size(395, 55);
            lblDriverStatus.TabIndex = 5;
            lblDriverStatus.Text = "Status";
            lblDriverStatus.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lbl
            // 
            lbl.AutoSize = true;
            lbl.BackColor = Color.FromArgb(153, 229, 255);
            lbl.Dock = DockStyle.Fill;
            lbl.Font = new Font("Inter", 18.25F, FontStyle.Bold);
            lbl.ForeColor = Color.FromArgb(24, 60, 114);
            lbl.Location = new Point(3, 0);
            lbl.Name = "lbl";
            lbl.Size = new Size(395, 60);
            lbl.TabIndex = 3;
            lbl.Text = "DRIVER";
            lbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblDriverName
            // 
            lblDriverName.AutoSize = true;
            lblDriverName.BackColor = Color.White;
            lblDriverName.Dock = DockStyle.Fill;
            lblDriverName.Font = new Font("Inter Medium", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDriverName.ForeColor = Color.FromArgb(24, 60, 114);
            lblDriverName.Location = new Point(3, 60);
            lblDriverName.Name = "lblDriverName";
            lblDriverName.Padding = new Padding(15, 0, 0, 0);
            lblDriverName.Size = new Size(395, 62);
            lblDriverName.TabIndex = 4;
            lblDriverName.Text = "Name";
            lblDriverName.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblPlateNum
            // 
            lblPlateNum.AutoSize = true;
            lblPlateNum.BackColor = Color.White;
            lblPlateNum.Dock = DockStyle.Fill;
            lblPlateNum.Font = new Font("Inter Medium", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPlateNum.ForeColor = Color.FromArgb(24, 60, 114);
            lblPlateNum.Location = new Point(3, 183);
            lblPlateNum.Name = "lblPlateNum";
            lblPlateNum.Size = new Size(192, 48);
            lblPlateNum.TabIndex = 2;
            lblPlateNum.Text = "Plate Number";
            lblPlateNum.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel6
            // 
            tableLayoutPanel6.ColumnCount = 3;
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 152F));
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel6.Controls.Add(pbDriverPicture, 1, 1);
            tableLayoutPanel6.Dock = DockStyle.Fill;
            tableLayoutPanel6.Location = new Point(3, 3);
            tableLayoutPanel6.Name = "tableLayoutPanel6";
            tableLayoutPanel6.RowCount = 2;
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 10.7594938F));
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 89.24051F));
            tableLayoutPanel6.Size = new Size(192, 177);
            tableLayoutPanel6.TabIndex = 7;
            // 
            // pbDriverPicture
            // 
            pbDriverPicture.Dock = DockStyle.Fill;
            pbDriverPicture.Location = new Point(23, 22);
            pbDriverPicture.Name = "pbDriverPicture";
            pbDriverPicture.Size = new Size(146, 152);
            pbDriverPicture.SizeMode = PictureBoxSizeMode.Zoom;
            pbDriverPicture.TabIndex = 1;
            pbDriverPicture.TabStop = false;
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.ColumnCount = 1;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.Controls.Add(panel1, 0, 0);
            tableLayoutPanel5.Controls.Add(panel2, 0, 1);
            tableLayoutPanel5.Dock = DockStyle.Fill;
            tableLayoutPanel5.Location = new Point(3, 274);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 2;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 47.40061F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 52.59939F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel5.Size = new Size(605, 327);
            tableLayoutPanel5.TabIndex = 23;
            // 
            // panel1
            // 
            panel1.Controls.Add(cmbxDestination);
            panel1.Controls.Add(cmbxLocation);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(599, 149);
            panel1.TabIndex = 27;
            // 
            // cmbxDestination
            // 
            cmbxDestination.BackColor = Color.White;
            cmbxDestination.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbxDestination.Font = new Font("Inter", 12.25F);
            cmbxDestination.ForeColor = Color.FromArgb(24, 60, 114);
            cmbxDestination.FormattingEnabled = true;
            cmbxDestination.Location = new Point(397, 97);
            cmbxDestination.Name = "cmbxDestination";
            cmbxDestination.Size = new Size(179, 31);
            cmbxDestination.TabIndex = 29;
            cmbxDestination.TabStop = false;
            // 
            // cmbxLocation
            // 
            cmbxLocation.BackColor = Color.White;
            cmbxLocation.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbxLocation.Font = new Font("Inter", 12.25F);
            cmbxLocation.ForeColor = Color.FromArgb(24, 60, 114);
            cmbxLocation.FormattingEnabled = true;
            cmbxLocation.Location = new Point(23, 97);
            cmbxLocation.Name = "cmbxLocation";
            cmbxLocation.Size = new Size(179, 31);
            cmbxLocation.TabIndex = 28;
            cmbxLocation.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(599, 149);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.Controls.Add(lblAmount);
            panel2.Controls.Add(numericMultiplier);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(btnPay);
            panel2.Controls.Add(lbl1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(3, 158);
            panel2.Name = "panel2";
            panel2.Size = new Size(599, 166);
            panel2.TabIndex = 26;
            // 
            // lblAmount
            // 
            lblAmount.AutoSize = true;
            lblAmount.BackColor = Color.FromArgb(230, 249, 255);
            lblAmount.Font = new Font("Inter", 41.75F, FontStyle.Bold);
            lblAmount.ForeColor = Color.FromArgb(38, 36, 68);
            lblAmount.Location = new Point(150, 54);
            lblAmount.Name = "lblAmount";
            lblAmount.Size = new Size(165, 80);
            lblAmount.TabIndex = 38;
            lblAmount.Text = "0.00";
            lblAmount.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // numericMultiplier
            // 
            numericMultiplier.Font = new Font("Inter Medium", 14.75F, FontStyle.Bold);
            numericMultiplier.ForeColor = Color.FromArgb(38, 36, 68);
            numericMultiplier.Location = new Point(224, 4);
            numericMultiplier.Maximum = new decimal(new int[] { 16, 0, 0, 0 });
            numericMultiplier.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericMultiplier.Name = "numericMultiplier";
            numericMultiplier.Size = new Size(120, 31);
            numericMultiplier.TabIndex = 37;
            numericMultiplier.Value = new decimal(new int[] { 1, 0, 0, 0 });
            numericMultiplier.ValueChanged += numericMultiplier_ValueChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(230, 249, 255);
            label1.Font = new Font("Inter", 14.75F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(38, 36, 68);
            label1.Location = new Point(5, 3);
            label1.Name = "label1";
            label1.Size = new Size(209, 28);
            label1.TabIndex = 36;
            label1.Text = "No. of Passenger/s :";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnPay
            // 
            btnPay.Alpha = 20;
            btnPay.BackColor = Color.Transparent;
            btnPay.Background = true;
            btnPay.Background_WidthPen = 4F;
            btnPay.BackgroundPen = true;
            btnPay.ColorBackground = Color.FromArgb(24, 60, 114);
            btnPay.ColorBackground_1 = Color.FromArgb(24, 60, 114);
            btnPay.ColorBackground_2 = Color.FromArgb(24, 60, 114);
            btnPay.ColorBackground_Pen = Color.FromArgb(153, 229, 255);
            btnPay.ColorLighting = Color.FromArgb(24, 60, 114);
            btnPay.ColorPen_1 = Color.FromArgb(24, 60, 114);
            btnPay.ColorPen_2 = Color.FromArgb(24, 60, 114);
            btnPay.Cursor = Cursors.Hand;
            btnPay.CyberButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            btnPay.Effect_1 = true;
            btnPay.Effect_1_ColorBackground = Color.FromArgb(29, 200, 238);
            btnPay.Effect_1_Transparency = 25;
            btnPay.Effect_2 = true;
            btnPay.Effect_2_ColorBackground = Color.White;
            btnPay.Effect_2_Transparency = 20;
            btnPay.Font = new Font("Inter", 12.25F);
            btnPay.ForeColor = Color.FromArgb(245, 245, 245);
            btnPay.Lighting = false;
            btnPay.LinearGradient_Background = false;
            btnPay.LinearGradientPen = false;
            btnPay.Location = new Point(465, 110);
            btnPay.Name = "btnPay";
            btnPay.PenWidth = 15;
            btnPay.Rounding = true;
            btnPay.RoundingInt = 70;
            btnPay.Size = new Size(135, 53);
            btnPay.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            btnPay.TabIndex = 34;
            btnPay.Tag = "Cyber";
            btnPay.TextButton = "Confirm";
            btnPay.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            btnPay.Timer_Effect_1 = 5;
            btnPay.Timer_RGB = 300;
            btnPay.Click += btnPay_Click;
            // 
            // lbl1
            // 
            lbl1.AutoSize = true;
            lbl1.BackColor = Color.FromArgb(230, 249, 255);
            lbl1.Font = new Font("Inter", 41.75F, FontStyle.Bold);
            lbl1.ForeColor = Color.FromArgb(38, 36, 68);
            lbl1.Location = new Point(94, 53);
            lbl1.Name = "lbl1";
            lbl1.Size = new Size(74, 80);
            lbl1.TabIndex = 35;
            lbl1.Text = "₱";
            lbl1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // PaymentUC
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(230, 249, 255);
            Controls.Add(tableLayoutPanel1);
            Name = "PaymentUC";
            Size = new Size(700, 700);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel4.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            tableLayoutPanel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbDriverPicture).EndInit();
            tableLayoutPanel5.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericMultiplier).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label label2;
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel3;
        private PictureBox pbDriverPicture;
        private Label lblPlateNum;
        public Label lblDriverName;
        public Label lbl;
        public Label lblDriverStatus;
        public Label lblDriverRoute;
        private TableLayoutPanel tableLayoutPanel4;
        private TableLayoutPanel tableLayoutPanel5;
        public Label lblDateTime;
        private PictureBox pictureBox1;
        private Panel panel1;
        private ComboBox cmbxDestination;
        private ComboBox cmbxLocation;
        private ReaLTaiizor.Controls.CyberButton btnPay;
        private Panel panel2;
        public Label lbl1;
        public Label label1;
        private NumericUpDown numericMultiplier;
        public Label lblAmount;
        private TableLayoutPanel tableLayoutPanel6;
    }
}
