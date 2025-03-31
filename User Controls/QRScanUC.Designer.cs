namespace NEXUS.User_Controls
{
    partial class QRScanUC
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
            picCam = new PictureBox();
            label2 = new Label();
            scanTimer = new System.Windows.Forms.Timer(components);
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picCam).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 617F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.Controls.Add(picCam, 1, 2);
            tableLayoutPanel1.Controls.Add(label2, 1, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 64F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 36F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 458F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 51F));
            tableLayoutPanel1.Size = new Size(700, 650);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // picCam
            // 
            picCam.Dock = DockStyle.Fill;
            picCam.Location = new Point(43, 143);
            picCam.Name = "picCam";
            picCam.Size = new Size(611, 452);
            picCam.SizeMode = PictureBoxSizeMode.Zoom;
            picCam.TabIndex = 21;
            picCam.TabStop = false;
            // 
            // label2
            // 
            label2.BackColor = Color.FromArgb(230, 249, 255);
            label2.Dock = DockStyle.Fill;
            label2.Font = new Font("Inter ExtraBold", 24F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(38, 36, 68);
            label2.Location = new Point(43, 90);
            label2.Name = "label2";
            label2.Size = new Size(611, 50);
            label2.TabIndex = 20;
            label2.Text = "SCAN QR CODE";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // scanTimer
            // 
            scanTimer.Tick += ScanTimer_Tick;
            // 
            // QRScanUC
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(230, 249, 255);
            Controls.Add(tableLayoutPanel1);
            Name = "QRScanUC";
            Size = new Size(700, 650);
            tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picCam).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label label2;
        private PictureBox picCam;
        private System.Windows.Forms.Timer scanTimer;
    }
}
