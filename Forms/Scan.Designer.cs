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
            btnOpenQRScan.Font = new Font("Inter", 12.25F);
            btnOpenQRScan.ForeColor = Color.FromArgb(245, 245, 245);
            btnOpenQRScan.Lighting = false;
            btnOpenQRScan.LinearGradient_Background = false;
            btnOpenQRScan.LinearGradientPen = false;
            btnOpenQRScan.Location = new Point(347, 660);
            btnOpenQRScan.Name = "btnOpenQRScan";
            btnOpenQRScan.PenWidth = 15;
            btnOpenQRScan.Rounding = true;
            btnOpenQRScan.RoundingInt = 70;
            btnOpenQRScan.Size = new Size(290, 42);
            btnOpenQRScan.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            btnOpenQRScan.TabIndex = 34;
            btnOpenQRScan.Tag = "Cyber";
            btnOpenQRScan.TextButton = "Scan";
            btnOpenQRScan.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            btnOpenQRScan.Timer_Effect_1 = 5;
            btnOpenQRScan.Timer_RGB = 300;
            btnOpenQRScan.Click += this.btnOpenQRScan_Click;
            // 
            // Scan
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(230, 249, 255);
            ClientSize = new Size(988, 739);
            Controls.Add(btnOpenQRScan);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Scan";
            Text = "-";
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private ReaLTaiizor.Controls.CyberButton btnOpenQRScan;
    }
}