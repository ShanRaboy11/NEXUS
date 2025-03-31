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
            tableLayoutPanel1 = new TableLayoutPanel();
            label2 = new Label();
            tableLayoutPanel2 = new TableLayoutPanel();
            tableLayoutPanel3 = new TableLayoutPanel();
            pbDriverPicture = new PictureBox();
            lblPlateNum = new Label();
            lblDriverRoute = new Label();
            lblDriverName = new Label();
            lblDriverStatus = new Label();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbDriverPicture).BeginInit();
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
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 1, 1);
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
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 31.91489F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 68.0851059F));
            tableLayoutPanel2.Controls.Add(tableLayoutPanel3, 1, 0);
            tableLayoutPanel2.Controls.Add(pbDriverPicture, 0, 0);
            tableLayoutPanel2.Controls.Add(lblPlateNum, 0, 1);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(43, 72);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 3;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 77.13004F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 22.8699551F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 310F));
            tableLayoutPanel2.Size = new Size(611, 534);
            tableLayoutPanel2.TabIndex = 22;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Controls.Add(lblDriverStatus, 0, 2);
            tableLayoutPanel3.Controls.Add(lblDriverRoute, 0, 0);
            tableLayoutPanel3.Controls.Add(lblDriverName, 0, 1);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(197, 3);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 3;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 49.1071434F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50.8928566F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 54F));
            tableLayoutPanel3.Size = new Size(411, 166);
            tableLayoutPanel3.TabIndex = 0;
            // 
            // pbDriverPicture
            // 
            pbDriverPicture.Dock = DockStyle.Fill;
            pbDriverPicture.Location = new Point(3, 3);
            pbDriverPicture.Name = "pbDriverPicture";
            pbDriverPicture.Size = new Size(188, 166);
            pbDriverPicture.TabIndex = 1;
            pbDriverPicture.TabStop = false;
            // 
            // lblPlateNum
            // 
            lblPlateNum.AutoSize = true;
            lblPlateNum.Dock = DockStyle.Fill;
            lblPlateNum.Font = new Font("Inter Medium", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPlateNum.ForeColor = Color.FromArgb(24, 60, 114);
            lblPlateNum.Location = new Point(3, 172);
            lblPlateNum.Name = "lblPlateNum";
            lblPlateNum.Size = new Size(188, 51);
            lblPlateNum.TabIndex = 2;
            lblPlateNum.Text = "Plate Number";
            lblPlateNum.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblDriverRoute
            // 
            lblDriverRoute.AutoSize = true;
            lblDriverRoute.Dock = DockStyle.Fill;
            lblDriverRoute.Font = new Font("Inter", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDriverRoute.ForeColor = Color.FromArgb(24, 60, 114);
            lblDriverRoute.Location = new Point(3, 0);
            lblDriverRoute.Name = "lblDriverRoute";
            lblDriverRoute.Size = new Size(405, 55);
            lblDriverRoute.TabIndex = 3;
            lblDriverRoute.Text = "Route";
            lblDriverRoute.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblDriverName
            // 
            lblDriverName.AutoSize = true;
            lblDriverName.Dock = DockStyle.Fill;
            lblDriverName.Font = new Font("Inter Medium", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDriverName.ForeColor = Color.FromArgb(24, 60, 114);
            lblDriverName.Location = new Point(3, 55);
            lblDriverName.Name = "lblDriverName";
            lblDriverName.Padding = new Padding(15, 0, 0, 0);
            lblDriverName.Size = new Size(405, 57);
            lblDriverName.TabIndex = 4;
            lblDriverName.Text = "Name";
            lblDriverName.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblDriverStatus
            // 
            lblDriverStatus.AutoSize = true;
            lblDriverStatus.Dock = DockStyle.Fill;
            lblDriverStatus.Font = new Font("Inter Medium", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDriverStatus.ForeColor = Color.FromArgb(24, 60, 114);
            lblDriverStatus.Location = new Point(3, 112);
            lblDriverStatus.Name = "lblDriverStatus";
            lblDriverStatus.Padding = new Padding(15, 0, 0, 0);
            lblDriverStatus.Size = new Size(405, 54);
            lblDriverStatus.TabIndex = 5;
            lblDriverStatus.Text = "Status";
            lblDriverStatus.TextAlign = ContentAlignment.MiddleLeft;
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
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbDriverPicture).EndInit();
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
        public Label lblDriverRoute;
        public Label lblDriverStatus;
    }
}
