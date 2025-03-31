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
            pbDriverPicture = new PictureBox();
            tableLayoutPanel5 = new TableLayoutPanel();
            btnPay = new ReaLTaiizor.Controls.CyberButton();
            panel1 = new Panel();
            comboBox1 = new ComboBox();
            cmbxNature = new ComboBox();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            lblAmount = new Label();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbDriverPicture).BeginInit();
            tableLayoutPanel5.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
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
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.Size = new Size(700, 650);
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
            label2.Size = new Size(611, 69);
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
            tableLayoutPanel4.Location = new Point(43, 72);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 3;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 86.31179F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 13.6882133F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 270F));
            tableLayoutPanel4.Size = new Size(611, 534);
            tableLayoutPanel4.TabIndex = 25;
            // 
            // lblDateTime
            // 
            lblDateTime.AutoSize = true;
            lblDateTime.BackColor = Color.FromArgb(230, 249, 255);
            lblDateTime.Dock = DockStyle.Fill;
            lblDateTime.Font = new Font("Inter SemiBold", 16.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDateTime.ForeColor = Color.FromArgb(38, 36, 68);
            lblDateTime.Location = new Point(3, 227);
            lblDateTime.Name = "lblDateTime";
            lblDateTime.Size = new Size(605, 36);
            lblDateTime.TabIndex = 24;
            lblDateTime.Text = "DATE";
            lblDateTime.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.BackColor = Color.White;
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 31.91489F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 68.0851059F));
            tableLayoutPanel2.Controls.Add(lblDriverRoute, 1, 1);
            tableLayoutPanel2.Controls.Add(tableLayoutPanel3, 1, 0);
            tableLayoutPanel2.Controls.Add(lblPlateNum, 0, 1);
            tableLayoutPanel2.Controls.Add(pbDriverPicture, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 77.13004F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 22.8699551F));
            tableLayoutPanel2.Size = new Size(605, 221);
            tableLayoutPanel2.TabIndex = 22;
            // 
            // lblDriverRoute
            // 
            lblDriverRoute.AutoSize = true;
            lblDriverRoute.BackColor = Color.White;
            lblDriverRoute.Dock = DockStyle.Fill;
            lblDriverRoute.Font = new Font("Inter Medium", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDriverRoute.ForeColor = Color.FromArgb(24, 60, 114);
            lblDriverRoute.Location = new Point(196, 170);
            lblDriverRoute.Name = "lblDriverRoute";
            lblDriverRoute.Padding = new Padding(15, 0, 0, 0);
            lblDriverRoute.Size = new Size(406, 51);
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
            tableLayoutPanel3.Location = new Point(196, 3);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 3;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 49.1071434F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50.8928566F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 54F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel3.Size = new Size(406, 164);
            tableLayoutPanel3.TabIndex = 0;
            // 
            // lblDriverStatus
            // 
            lblDriverStatus.AutoSize = true;
            lblDriverStatus.BackColor = Color.White;
            lblDriverStatus.Dock = DockStyle.Fill;
            lblDriverStatus.Font = new Font("Inter Medium", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDriverStatus.ForeColor = Color.FromArgb(24, 60, 114);
            lblDriverStatus.Location = new Point(3, 109);
            lblDriverStatus.Name = "lblDriverStatus";
            lblDriverStatus.Padding = new Padding(15, 0, 0, 0);
            lblDriverStatus.Size = new Size(400, 55);
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
            lbl.Size = new Size(400, 54);
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
            lblDriverName.Location = new Point(3, 54);
            lblDriverName.Name = "lblDriverName";
            lblDriverName.Padding = new Padding(15, 0, 0, 0);
            lblDriverName.Size = new Size(400, 55);
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
            lblPlateNum.Location = new Point(3, 170);
            lblPlateNum.Name = "lblPlateNum";
            lblPlateNum.Size = new Size(187, 51);
            lblPlateNum.TabIndex = 2;
            lblPlateNum.Text = "Plate Number";
            lblPlateNum.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pbDriverPicture
            // 
            pbDriverPicture.Dock = DockStyle.Fill;
            pbDriverPicture.Location = new Point(3, 3);
            pbDriverPicture.Name = "pbDriverPicture";
            pbDriverPicture.Size = new Size(187, 164);
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
            tableLayoutPanel5.Location = new Point(3, 266);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 2;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 59.24528F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 40.75472F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel5.Size = new Size(605, 265);
            tableLayoutPanel5.TabIndex = 23;
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
            btnPay.Location = new Point(472, 51);
            btnPay.Name = "btnPay";
            btnPay.PenWidth = 15;
            btnPay.Rounding = true;
            btnPay.RoundingInt = 70;
            btnPay.Size = new Size(132, 51);
            btnPay.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            btnPay.TabIndex = 34;
            btnPay.Tag = "Cyber";
            btnPay.TextButton = "Confirm";
            btnPay.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            btnPay.Timer_Effect_1 = 5;
            btnPay.Timer_RGB = 300;
            btnPay.Click += btnPay_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(comboBox1);
            panel1.Controls.Add(cmbxNature);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(599, 151);
            panel1.TabIndex = 27;
            // 
            // comboBox1
            // 
            comboBox1.BackColor = Color.White;
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.Font = new Font("Inter", 12.25F);
            comboBox1.ForeColor = Color.FromArgb(24, 60, 114);
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Traffic Accident", "Mechanical Breakdown", "Theft", "Lost", "Assaults", "Sexual Harassment" });
            comboBox1.Location = new Point(406, 102);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(179, 31);
            comboBox1.TabIndex = 29;
            comboBox1.TabStop = false;
            // 
            // cmbxNature
            // 
            cmbxNature.BackColor = Color.White;
            cmbxNature.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbxNature.Font = new Font("Inter", 12.25F);
            cmbxNature.ForeColor = Color.FromArgb(24, 60, 114);
            cmbxNature.FormattingEnabled = true;
            cmbxNature.Items.AddRange(new object[] { "Traffic Accident", "Mechanical Breakdown", "Theft", "Lost", "Assaults", "Sexual Harassment" });
            cmbxNature.Location = new Point(15, 102);
            cmbxNature.Name = "cmbxNature";
            cmbxNature.Size = new Size(179, 31);
            cmbxNature.TabIndex = 28;
            cmbxNature.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(599, 151);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.Controls.Add(lblAmount);
            panel2.Controls.Add(btnPay);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(3, 160);
            panel2.Name = "panel2";
            panel2.Size = new Size(599, 102);
            panel2.TabIndex = 26;
            // 
            // lblAmount
            // 
            lblAmount.AutoSize = true;
            lblAmount.BackColor = Color.FromArgb(230, 249, 255);
            lblAmount.Dock = DockStyle.Left;
            lblAmount.Font = new Font("Inter", 39.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAmount.ForeColor = Color.FromArgb(38, 36, 68);
            lblAmount.Location = new Point(0, 0);
            lblAmount.Name = "lblAmount";
            lblAmount.Size = new Size(145, 76);
            lblAmount.TabIndex = 35;
            lblAmount.Text = "Php ";
            lblAmount.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // PaymentUC
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(230, 249, 255);
            Controls.Add(tableLayoutPanel1);
            Name = "PaymentUC";
            Size = new Size(700, 650);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel4.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbDriverPicture).EndInit();
            tableLayoutPanel5.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
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
        private ComboBox comboBox1;
        private ComboBox cmbxNature;
        private ReaLTaiizor.Controls.CyberButton btnPay;
        private Panel panel2;
        public Label lblAmount;
    }
}
