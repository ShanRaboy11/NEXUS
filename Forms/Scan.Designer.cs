namespace NEXUS.Forms
{
    partial class Scan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Scan));
            label1 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            cyberRichTextBox1 = new ReaLTaiizor.Controls.CyberRichTextBox();
            btnUploadQR = new PictureBox();
            lblUpload = new Label();
            pictureBox2 = new PictureBox();
            label6 = new Label();
            btnSubmitQR = new ReaLTaiizor.Controls.CyberButton();
            ((System.ComponentModel.ISupportInitialize)btnUploadQR).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Inter ExtraBold", 23F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(38, 36, 68);
            label1.Location = new Point(24, 35);
            label1.Name = "label1";
            label1.Size = new Size(315, 44);
            label1.TabIndex = 22;
            label1.Text = "Welcome aboard!";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(153, 229, 255);
            label3.Font = new Font("Inter", 13F);
            label3.Location = new Point(98, 127);
            label3.Name = "label3";
            label3.Size = new Size(749, 26);
            label3.TabIndex = 37;
            label3.Text = "Scan the driver’s QR code to securely complete your payment and log your trip details.";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.FromArgb(153, 229, 255);
            label4.Font = new Font("Inter", 12.25F);
            label4.Location = new Point(96, 172);
            label4.Name = "label4";
            label4.Size = new Size(833, 24);
            label4.TabIndex = 38;
            label4.Text = "Your ride details, including time, date, and location, will be recorded for your safety and convenience. ";
            // 
            // label5
            // 
            label5.Font = new Font("Inter Medium", 13F, FontStyle.Bold);
            label5.Location = new Point(69, 615);
            label5.Name = "label5";
            label5.Size = new Size(866, 23);
            label5.TabIndex = 39;
            label5.Text = "Ensure the QR code is visible and well-lit for a successful scan.";
            label5.TextAlign = ContentAlignment.MiddleCenter;
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
            cyberRichTextBox1.Location = new Point(69, 100);
            cyberRichTextBox1.Name = "cyberRichTextBox1";
            cyberRichTextBox1.PenWidth = 15;
            cyberRichTextBox1.RGB = false;
            cyberRichTextBox1.Rounding = true;
            cyberRichTextBox1.RoundingInt = 60;
            cyberRichTextBox1.Size = new Size(866, 130);
            cyberRichTextBox1.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            cyberRichTextBox1.TabIndex = 40;
            cyberRichTextBox1.Tag = "Cyber";
            cyberRichTextBox1.TextButton = "";
            cyberRichTextBox1.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            cyberRichTextBox1.Timer_RGB = 300;
            // 
            // btnUploadQR
            // 
            btnUploadQR.BackColor = Color.White;
            btnUploadQR.Image = (Image)resources.GetObject("btnUploadQR.Image");
            btnUploadQR.Location = new Point(534, 277);
            btnUploadQR.Name = "btnUploadQR";
            btnUploadQR.Size = new Size(401, 294);
            btnUploadQR.SizeMode = PictureBoxSizeMode.CenterImage;
            btnUploadQR.TabIndex = 41;
            btnUploadQR.TabStop = false;
            btnUploadQR.Click += btnUploadQR_Click;
            // 
            // lblUpload
            // 
            lblUpload.AutoSize = true;
            lblUpload.BackColor = Color.White;
            lblUpload.Font = new Font("Inter", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblUpload.ForeColor = Color.FromArgb(24, 60, 114);
            lblUpload.Location = new Point(674, 461);
            lblUpload.Name = "lblUpload";
            lblUpload.Size = new Size(138, 23);
            lblUpload.TabIndex = 42;
            lblUpload.Text = "Upload QR Code";
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.White;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(69, 277);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(401, 294);
            pictureBox2.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox2.TabIndex = 43;
            pictureBox2.TabStop = false;
            pictureBox2.Click += btnOpenQRScan_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.White;
            label6.Font = new Font("Inter", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(24, 60, 114);
            label6.Location = new Point(208, 461);
            label6.Name = "label6";
            label6.Size = new Size(120, 23);
            label6.TabIndex = 44;
            label6.Text = "Scan QR Code";
            label6.Click += btnOpenQRScan_Click;
            // 
            // btnSubmitQR
            // 
            btnSubmitQR.Alpha = 20;
            btnSubmitQR.BackColor = Color.Transparent;
            btnSubmitQR.Background = true;
            btnSubmitQR.Background_WidthPen = 4F;
            btnSubmitQR.BackgroundPen = true;
            btnSubmitQR.ColorBackground = Color.FromArgb(24, 60, 114);
            btnSubmitQR.ColorBackground_1 = Color.FromArgb(24, 60, 114);
            btnSubmitQR.ColorBackground_2 = Color.FromArgb(24, 60, 114);
            btnSubmitQR.ColorBackground_Pen = Color.FromArgb(153, 229, 255);
            btnSubmitQR.ColorLighting = Color.FromArgb(24, 60, 114);
            btnSubmitQR.ColorPen_1 = Color.FromArgb(24, 60, 114);
            btnSubmitQR.ColorPen_2 = Color.FromArgb(24, 60, 114);
            btnSubmitQR.Cursor = Cursors.Hand;
            btnSubmitQR.CyberButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            btnSubmitQR.Effect_1 = true;
            btnSubmitQR.Effect_1_ColorBackground = Color.FromArgb(29, 200, 238);
            btnSubmitQR.Effect_1_Transparency = 25;
            btnSubmitQR.Effect_2 = true;
            btnSubmitQR.Effect_2_ColorBackground = Color.White;
            btnSubmitQR.Effect_2_Transparency = 20;
            btnSubmitQR.Font = new Font("Inter", 14.25F);
            btnSubmitQR.ForeColor = Color.FromArgb(245, 245, 245);
            btnSubmitQR.Lighting = false;
            btnSubmitQR.LinearGradient_Background = false;
            btnSubmitQR.LinearGradientPen = false;
            btnSubmitQR.Location = new Point(336, 669);
            btnSubmitQR.Name = "btnSubmitQR";
            btnSubmitQR.PenWidth = 15;
            btnSubmitQR.Rounding = true;
            btnSubmitQR.RoundingInt = 70;
            btnSubmitQR.Size = new Size(312, 46);
            btnSubmitQR.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            btnSubmitQR.TabIndex = 45;
            btnSubmitQR.Tag = "Cyber";
            btnSubmitQR.TextButton = "Submit";
            btnSubmitQR.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            btnSubmitQR.Timer_Effect_1 = 5;
            btnSubmitQR.Timer_RGB = 300;
            // 
            // Scan
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(230, 249, 255);
            ClientSize = new Size(988, 739);
            Controls.Add(btnSubmitQR);
            Controls.Add(label6);
            Controls.Add(pictureBox2);
            Controls.Add(lblUpload);
            Controls.Add(btnUploadQR);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(cyberRichTextBox1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Scan";
            Text = "-";
            ((System.ComponentModel.ISupportInitialize)btnUploadQR).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label3;
        private Label label4;
        private Label label5;
        private ReaLTaiizor.Controls.CyberRichTextBox cyberRichTextBox1;
        private PictureBox btnUploadQR;
        private Label lblUpload;
        private PictureBox pictureBox2;
        private Label label6;
        private ReaLTaiizor.Controls.CyberButton btnSubmitQR;
    }
}