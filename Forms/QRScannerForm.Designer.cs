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
            scanTimer = new System.Windows.Forms.Timer(components);
            picCam = new PictureBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)picCam).BeginInit();
            SuspendLayout();
            // 
            // scanTimer
            // 
            scanTimer.Tick += scanTimer_Tick;
            // 
            // picCam
            // 
            picCam.Location = new Point(122, 135);
            picCam.Name = "picCam";
            picCam.Size = new Size(1036, 507);
            picCam.SizeMode = PictureBoxSizeMode.CenterImage;
            picCam.TabIndex = 0;
            picCam.TabStop = false;
            // 
            // label1
            // 
            label1.Font = new Font("Inter ExtraBold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(122, 62);
            label1.Name = "label1";
            label1.Size = new Size(1036, 36);
            label1.TabIndex = 1;
            label1.Text = "SCAN QR CODE";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // QRScannerForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(230, 249, 255);
            ClientSize = new Size(1312, 879);
            Controls.Add(label1);
            Controls.Add(picCam);
            FormBorderStyle = FormBorderStyle.None;
            Name = "QRScannerForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            FormClosing += QRScannerForm_FormClosing;
            ((System.ComponentModel.ISupportInitialize)picCam).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Timer scanTimer;
        private PictureBox picCam;
        private Label label1;
    }
}