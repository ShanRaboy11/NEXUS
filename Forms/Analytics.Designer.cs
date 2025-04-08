namespace NEXUS.Forms
{
    partial class Analytics
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Analytics));
            label3 = new Label();
            label1 = new Label();
            spaceSeparatorHorizontal1 = new ReaLTaiizor.Controls.SpaceSeparatorHorizontal();
            plotViewDriverAnalytics = new OxyPlot.WindowsForms.PlotView();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(230, 249, 255);
            label3.Font = new Font("Inter", 15F);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(101, 67);
            label3.Name = "label3";
            label3.Size = new Size(687, 28);
            label3.TabIndex = 28;
            label3.Text = "Each trip is a step forward. Review your stats and drive your progress.";
            // 
            // label1
            // 
            label1.Font = new Font("Inter ExtraBold", 20F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(38, 36, 68);
            label1.Location = new Point(12, 13);
            label1.Name = "label1";
            label1.Size = new Size(614, 44);
            label1.TabIndex = 29;
            label1.Text = "Analytics Panel";
            // 
            // spaceSeparatorHorizontal1
            // 
            spaceSeparatorHorizontal1.Customization = "Kioq/yoqKv8jIyP/Kioq/w==";
            spaceSeparatorHorizontal1.Font = new Font("Verdana", 8F);
            spaceSeparatorHorizontal1.Image = null;
            spaceSeparatorHorizontal1.Location = new Point(21, 112);
            spaceSeparatorHorizontal1.Name = "spaceSeparatorHorizontal1";
            spaceSeparatorHorizontal1.NoRounding = false;
            spaceSeparatorHorizontal1.Size = new Size(930, 4);
            spaceSeparatorHorizontal1.TabIndex = 50;
            spaceSeparatorHorizontal1.Text = "spaceSeparatorHorizontal1";
            spaceSeparatorHorizontal1.Transparent = false;
            // 
            // plotViewDriverAnalytics
            // 
            plotViewDriverAnalytics.Location = new Point(21, 151);
            plotViewDriverAnalytics.Name = "plotViewDriverAnalytics";
            plotViewDriverAnalytics.PanCursor = Cursors.Hand;
            plotViewDriverAnalytics.Size = new Size(566, 265);
            plotViewDriverAnalytics.TabIndex = 51;
            plotViewDriverAnalytics.Text = "plotView1";
            plotViewDriverAnalytics.ZoomHorizontalCursor = Cursors.SizeWE;
            plotViewDriverAnalytics.ZoomRectangleCursor = Cursors.SizeNWSE;
            plotViewDriverAnalytics.ZoomVerticalCursor = Cursors.SizeNS;
            // 
            // Analytics
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(230, 249, 255);
            ClientSize = new Size(972, 700);
            Controls.Add(plotViewDriverAnalytics);
            Controls.Add(spaceSeparatorHorizontal1);
            Controls.Add(label1);
            Controls.Add(label3);
            Font = new Font("Inter", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = SystemColors.ControlText;
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Analytics";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Analytics";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private Label label1;
        private ReaLTaiizor.Controls.SpaceSeparatorHorizontal spaceSeparatorHorizontal1;
        private OxyPlot.WindowsForms.PlotView plotView1;
        private OxyPlot.WindowsForms.PlotView plotViewDriverAnalytics;
    }
}