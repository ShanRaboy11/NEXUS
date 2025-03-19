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
            cyberRichTextBox1 = new ReaLTaiizor.Controls.CyberRichTextBox();
            panel2 = new Panel();
            pictureBox4 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox5 = new PictureBox();
            pbClose = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)picCam).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbClose).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // scanTimer
            // 
            scanTimer.Tick += scanTimer_Tick;
            // 
            // picCam
            // 
            picCam.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            picCam.Location = new Point(60, 158);
            picCam.Name = "picCam";
            picCam.Size = new Size(719, 406);
            picCam.SizeMode = PictureBoxSizeMode.CenterImage;
            picCam.TabIndex = 0;
            picCam.TabStop = false;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.BackColor = Color.FromArgb(153, 229, 255);
            label1.Font = new Font("Inter ExtraBold", 24F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(38, 36, 68);
            label1.Location = new Point(306, 56);
            label1.Name = "label1";
            label1.Size = new Size(267, 76);
            label1.TabIndex = 3;
            label1.Text = "SCAN QR CODE";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // cyberRichTextBox1
            // 
            cyberRichTextBox1.Alpha = 20;
            cyberRichTextBox1.BackColor = Color.Transparent;
            cyberRichTextBox1.Background_WidthPen = 3F;
            cyberRichTextBox1.BackgroundPen = true;
            cyberRichTextBox1.ColorBackground = Color.FromArgb(153, 229, 255);
            cyberRichTextBox1.ColorBackground_Pen = Color.FromArgb(29, 200, 238);
            cyberRichTextBox1.ColorLighting = Color.FromArgb(29, 200, 238);
            cyberRichTextBox1.ColorPen_1 = Color.FromArgb(29, 200, 238);
            cyberRichTextBox1.ColorPen_2 = Color.FromArgb(37, 52, 68);
            cyberRichTextBox1.CyberRichTextBoxStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            cyberRichTextBox1.Font = new Font("Arial", 11F);
            cyberRichTextBox1.ForeColor = Color.FromArgb(245, 245, 245);
            cyberRichTextBox1.Lighting = false;
            cyberRichTextBox1.LinearGradientPen = false;
            cyberRichTextBox1.Location = new Point(281, 53);
            cyberRichTextBox1.Name = "cyberRichTextBox1";
            cyberRichTextBox1.PenWidth = 15;
            cyberRichTextBox1.RGB = false;
            cyberRichTextBox1.Rounding = true;
            cyberRichTextBox1.RoundingInt = 60;
            cyberRichTextBox1.Size = new Size(309, 80);
            cyberRichTextBox1.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            cyberRichTextBox1.TabIndex = 4;
            cyberRichTextBox1.Tag = "Cyber";
            cyberRichTextBox1.TextButton = "";
            cyberRichTextBox1.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            cyberRichTextBox1.Timer_RGB = 300;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(153, 229, 255);
            panel2.Controls.Add(pictureBox4);
            panel2.Controls.Add(pictureBox3);
            panel2.Controls.Add(pictureBox5);
            panel2.Controls.Add(pbClose);
            panel2.Controls.Add(pictureBox2);
            panel2.Controls.Add(pictureBox1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(844, 28);
            panel2.TabIndex = 18;
            // 
            // pictureBox4
            // 
            pictureBox4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(791, 6);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(14, 14);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 21;
            pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(1986, 6);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(14, 14);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 2;
            pictureBox3.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(760, 4);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(19, 19);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 20;
            pictureBox5.TabStop = false;
            // 
            // pbClose
            // 
            pbClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pbClose.Image = (Image)resources.GetObject("pbClose.Image");
            pbClose.Location = new Point(818, 4);
            pbClose.Name = "pbClose";
            pbClose.Size = new Size(18, 18);
            pbClose.SizeMode = PictureBoxSizeMode.Zoom;
            pbClose.TabIndex = 19;
            pbClose.TabStop = false;
            pbClose.Click += pbClose_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(1955, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(19, 19);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(2013, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(18, 18);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // QRScannerForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(230, 249, 255);
            ClientSize = new Size(844, 594);
            Controls.Add(panel2);
            Controls.Add(label1);
            Controls.Add(cyberRichTextBox1);
            Controls.Add(picCam);
            FormBorderStyle = FormBorderStyle.None;
            Name = "QRScannerForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            FormClosing += QRScannerForm_FormClosing;
            ((System.ComponentModel.ISupportInitialize)picCam).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbClose).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Timer scanTimer;
        private PictureBox picCam;
        private Label label1;
        private ReaLTaiizor.Controls.CyberRichTextBox cyberRichTextBox1;
        private Panel panel2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
        private PictureBox pbClose;
    }
}