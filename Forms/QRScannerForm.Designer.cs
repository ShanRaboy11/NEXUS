namespace NEXUS.Forms
{
    partial class QRScannerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QRScannerForm));
            scanTimer = new System.Windows.Forms.Timer(components);
            picCam = new PictureBox();
            label1 = new Label();
            panel1 = new Panel();
            panel3 = new Panel();
            pictureBox6 = new PictureBox();
            pictureBox7 = new PictureBox();
            pictureBox5 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)picCam).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            SuspendLayout();
            // 
            // scanTimer
            // 
            scanTimer.Tick += scanTimer_Tick;
            // 
            // picCam
            // 
            picCam.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            picCam.Location = new Point(111, 221);
            picCam.Name = "picCam";
            picCam.Size = new Size(1095, 622);
            picCam.SizeMode = PictureBoxSizeMode.CenterImage;
            picCam.TabIndex = 0;
            picCam.TabStop = false;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.Font = new Font("Inter ExtraBold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 163);
            label1.Name = "label1";
            label1.Size = new Size(1288, 36);
            label1.TabIndex = 1;
            label1.Text = "SCAN QR CODE";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1312, 140);
            panel1.TabIndex = 2;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(pictureBox6);
            panel3.Controls.Add(pictureBox7);
            panel3.Controls.Add(pictureBox5);
            panel3.Dock = DockStyle.Right;
            panel3.Location = new Point(988, 140);
            panel3.Name = "panel3";
            panel3.Size = new Size(324, 739);
            panel3.TabIndex = 33;
            // 
            // pictureBox6
            // 
            pictureBox6.BackColor = Color.FromArgb(38, 36, 68);
            pictureBox6.Cursor = Cursors.Hand;
            pictureBox6.Image = Properties.Resources.Removal_915;
            pictureBox6.Location = new Point(37, 25);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(58, 60);
            pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox6.TabIndex = 31;
            pictureBox6.TabStop = false;
            // 
            // pictureBox7
            // 
            pictureBox7.BackColor = Color.FromArgb(38, 36, 68);
            pictureBox7.Cursor = Cursors.Hand;
            pictureBox7.Image = (Image)resources.GetObject("pictureBox7.Image");
            pictureBox7.Location = new Point(253, 25);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(58, 60);
            pictureBox7.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox7.TabIndex = 33;
            pictureBox7.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.BackColor = Color.White;
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(-15, -3);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(341, 145);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 0;
            pictureBox5.TabStop = false;
            // 
            // QRScannerForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(230, 249, 255);
            ClientSize = new Size(1312, 879);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Controls.Add(label1);
            Controls.Add(picCam);
            FormBorderStyle = FormBorderStyle.None;
            Name = "QRScannerForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            FormClosing += QRScannerForm_FormClosing;
            ((System.ComponentModel.ISupportInitialize)picCam).EndInit();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Timer scanTimer;
        private PictureBox picCam;
        private Label label1;
        private Panel panel1;
        private Panel panel3;
        private PictureBox pictureBox6;
        private PictureBox pictureBox7;
        private PictureBox pictureBox5;
    }
}