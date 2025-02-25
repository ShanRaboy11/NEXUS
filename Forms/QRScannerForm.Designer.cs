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
            ((System.ComponentModel.ISupportInitialize)picCam).BeginInit();
            SuspendLayout();
            // 
            // picCam
            // 
            picCam.Location = new Point(252, 139);
            picCam.Name = "picCam";
            picCam.Size = new Size(322, 134);
            picCam.TabIndex = 0;
            picCam.TabStop = false;
            // 
            // QRScannerForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(picCam);
            FormBorderStyle = FormBorderStyle.None;
            Name = "QRScannerForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)picCam).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Timer scanTimer;
        private PictureBox picCam;
    }
}