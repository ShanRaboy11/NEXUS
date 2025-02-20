namespace NEXUS.Forms
{
    partial class ProgressBar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProgressBar));
            progressBar1 = new ReaLTaiizor.Controls.ParrotCircleProgressBar();
            lblIdentifier = new Label();
            lblLoading = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // progressBar1
            // 
            progressBar1.AnimationSpeed = 5;
            progressBar1.CompositingQualityType = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
            progressBar1.FilledColor = Color.FromArgb(0, 229, 255);
            progressBar1.FilledColorAlpha = 130;
            progressBar1.FilledThickness = 10;
            progressBar1.Font = new Font("Inter", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            progressBar1.InterpolationType = System.Drawing.Drawing2D.InterpolationMode.HighQualityBilinear;
            progressBar1.IsAnimated = false;
            progressBar1.Location = new Point(52, 124);
            progressBar1.Name = "progressBar1";
            progressBar1.Percentage = 50;
            progressBar1.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            progressBar1.ShowText = true;
            progressBar1.Size = new Size(150, 150);
            progressBar1.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            progressBar1.TabIndex = 0;
            progressBar1.TextColor = Color.FromArgb(85, 213, 219);
            progressBar1.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            progressBar1.TextSize = 25;
            progressBar1.UnFilledColor = Color.FromArgb(28, 48, 43);
            progressBar1.UnfilledThickness = 10;
            // 
            // lblIdentifier
            // 
            lblIdentifier.Font = new Font("Inter", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblIdentifier.ForeColor = Color.FromArgb(24, 60, 114);
            lblIdentifier.Location = new Point(12, 45);
            lblIdentifier.Name = "lblIdentifier";
            lblIdentifier.Size = new Size(231, 50);
            lblIdentifier.TabIndex = 1;
            lblIdentifier.Text = "NEXUS";
            lblIdentifier.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblLoading
            // 
            lblLoading.Font = new Font("Inter Medium", 16.75F, FontStyle.Bold);
            lblLoading.ForeColor = Color.FromArgb(24, 60, 114);
            lblLoading.Location = new Point(12, 300);
            lblLoading.Name = "lblLoading";
            lblLoading.Size = new Size(231, 32);
            lblLoading.TabIndex = 2;
            lblLoading.Text = "Loading...";
            lblLoading.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // ProgressBar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(255, 378);
            Controls.Add(lblLoading);
            Controls.Add(lblIdentifier);
            Controls.Add(progressBar1);
            Cursor = Cursors.AppStarting;
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "ProgressBar";
            Opacity = 0.9D;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ProgressBar";
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Controls.ParrotCircleProgressBar progressBar1;
        private Label lblIdentifier;
        private Label lblLoading;
        private System.Windows.Forms.Timer timer1;
    }
}