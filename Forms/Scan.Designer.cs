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
            btnOpenQRScan = new ReaLTaiizor.Controls.CyberButton();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Inter ExtraBold", 23F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(38, 36, 68);
            label1.Location = new Point(13, 12);
            label1.Name = "label1";
            label1.Size = new Size(315, 44);
            label1.TabIndex = 22;
            label1.Text = "SCAN ";
            // 
            // btnOpenQRScan
            // 
            btnOpenQRScan.Alpha = 20;
            btnOpenQRScan.BackColor = Color.Transparent;
            btnOpenQRScan.Background = true;
            btnOpenQRScan.Background_WidthPen = 4F;
            btnOpenQRScan.BackgroundPen = true;
            btnOpenQRScan.ColorBackground = Color.FromArgb(24, 60, 114);
            btnOpenQRScan.ColorBackground_1 = Color.FromArgb(24, 60, 114);
            btnOpenQRScan.ColorBackground_2 = Color.FromArgb(24, 60, 114);
            btnOpenQRScan.ColorBackground_Pen = Color.FromArgb(153, 229, 255);
            btnOpenQRScan.ColorLighting = Color.FromArgb(24, 60, 114);
            btnOpenQRScan.ColorPen_1 = Color.FromArgb(24, 60, 114);
            btnOpenQRScan.ColorPen_2 = Color.FromArgb(24, 60, 114);
            btnOpenQRScan.Cursor = Cursors.Hand;
            btnOpenQRScan.CyberButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            btnOpenQRScan.Effect_1 = true;
            btnOpenQRScan.Effect_1_ColorBackground = Color.FromArgb(29, 200, 238);
            btnOpenQRScan.Effect_1_Transparency = 25;
            btnOpenQRScan.Effect_2 = true;
            btnOpenQRScan.Effect_2_ColorBackground = Color.White;
            btnOpenQRScan.Effect_2_Transparency = 20;
            btnOpenQRScan.Font = new Font("Inter", 14.25F);
            btnOpenQRScan.ForeColor = Color.FromArgb(245, 245, 245);
            btnOpenQRScan.Lighting = false;
            btnOpenQRScan.LinearGradient_Background = false;
            btnOpenQRScan.LinearGradientPen = false;
            btnOpenQRScan.Location = new Point(345, 661);
            btnOpenQRScan.Name = "btnOpenQRScan";
            btnOpenQRScan.PenWidth = 15;
            btnOpenQRScan.Rounding = true;
            btnOpenQRScan.RoundingInt = 70;
            btnOpenQRScan.Size = new Size(308, 48);
            btnOpenQRScan.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            btnOpenQRScan.TabIndex = 34;
            btnOpenQRScan.Tag = "Cyber";
            btnOpenQRScan.TextButton = "Scan";
            btnOpenQRScan.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            btnOpenQRScan.Timer_Effect_1 = 5;
            btnOpenQRScan.Timer_RGB = 300;
            btnOpenQRScan.Click += btnOpenQRScan_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Inter", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(123, 86);
            label2.Name = "label2";
            label2.Size = new Size(144, 23);
            label2.TabIndex = 36;
            label2.Text = "Welcome aboard!";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Inter", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(123, 126);
            label3.Name = "label3";
            label3.Size = new Size(668, 23);
            label3.TabIndex = 37;
            label3.Text = "Scan the driver’s QR code to securely complete your payment and log your trip details.";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Inter", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(123, 175);
            label4.Name = "label4";
            label4.Size = new Size(787, 23);
            label4.TabIndex = 38;
            label4.Text = "Your ride details, including time, date, and location, will be recorded for your safety and convenience. ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Inter", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(123, 221);
            label5.Name = "label5";
            label5.Size = new Size(487, 23);
            label5.TabIndex = 39;
            label5.Text = "Ensure the QR code is visible and well-lit for a successful scan.";
            // 
            // Scan
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(230, 249, 255);
            ClientSize = new Size(988, 739);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnOpenQRScan);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Scan";
            Text = "-";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ReaLTaiizor.Controls.CyberButton btnOpenQRScan;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}