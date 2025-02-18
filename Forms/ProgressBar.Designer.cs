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
            label1 = new Label();
            label2 = new Label();
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Inter Medium", 25.75F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(24, 60, 114);
            label1.Location = new Point(60, 45);
            label1.Name = "label1";
            label1.Size = new Size(143, 50);
            label1.TabIndex = 1;
            label1.Text = "NEXUS";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Inter Medium", 16.75F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(24, 60, 114);
            label2.Location = new Point(65, 300);
            label2.Name = "label2";
            label2.Size = new Size(123, 32);
            label2.TabIndex = 2;
            label2.Text = "Loading...";
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
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(progressBar1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "ProgressBar";
            Opacity = 0.9D;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ProgressBar";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ReaLTaiizor.Controls.ParrotCircleProgressBar progressBar1;
        private Label label1;
        private Label label2;
        private System.Windows.Forms.Timer timer1;
    }
}