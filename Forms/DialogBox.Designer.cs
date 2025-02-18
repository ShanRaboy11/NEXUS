namespace NEXUS.Forms
{
    partial class DialogBox
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DialogBox));
            pbDialogIcon = new PictureBox();
            Pausetimer = new System.Windows.Forms.Timer(components);
            label1 = new Label();
            btnOK = new ReaLTaiizor.Controls.CyberButton();
            ((System.ComponentModel.ISupportInitialize)pbDialogIcon).BeginInit();
            SuspendLayout();
            // 
            // pbDialogIcon
            // 
            pbDialogIcon.Image = (Image)resources.GetObject("pbDialogIcon.Image");
            pbDialogIcon.Location = new Point(72, -2);
            pbDialogIcon.Name = "pbDialogIcon";
            pbDialogIcon.Size = new Size(181, 119);
            pbDialogIcon.SizeMode = PictureBoxSizeMode.Zoom;
            pbDialogIcon.TabIndex = 0;
            pbDialogIcon.TabStop = false;
            // 
            // Pausetimer
            // 
            Pausetimer.Enabled = true;
            Pausetimer.Interval = 2500;
            Pausetimer.Tick += Pausetimer_Tick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Inter Medium", 12F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(24, 60, 114);
            label1.Location = new Point(96, 109);
            label1.Name = "label1";
            label1.Size = new Size(142, 23);
            label1.TabIndex = 1;
            label1.Text = "Login Successful";
            // 
            // btnOK
            // 
            btnOK.Alpha = 20;
            btnOK.BackColor = Color.Transparent;
            btnOK.Background = true;
            btnOK.Background_WidthPen = 4F;
            btnOK.BackgroundPen = true;
            btnOK.ColorBackground = Color.FromArgb(24, 60, 114);
            btnOK.ColorBackground_1 = Color.FromArgb(24, 60, 114);
            btnOK.ColorBackground_2 = Color.FromArgb(24, 60, 114);
            btnOK.ColorBackground_Pen = Color.FromArgb(128, 223, 255);
            btnOK.ColorLighting = Color.FromArgb(24, 60, 114);
            btnOK.ColorPen_1 = Color.FromArgb(24, 60, 114);
            btnOK.ColorPen_2 = Color.FromArgb(24, 60, 114);
            btnOK.Cursor = Cursors.Hand;
            btnOK.CyberButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            btnOK.Effect_1 = true;
            btnOK.Effect_1_ColorBackground = Color.FromArgb(29, 200, 238);
            btnOK.Effect_1_Transparency = 25;
            btnOK.Effect_2 = true;
            btnOK.Effect_2_ColorBackground = Color.White;
            btnOK.Effect_2_Transparency = 20;
            btnOK.Font = new Font("Inter", 10F);
            btnOK.ForeColor = Color.FromArgb(245, 245, 245);
            btnOK.Lighting = false;
            btnOK.LinearGradient_Background = false;
            btnOK.LinearGradientPen = false;
            btnOK.Location = new Point(111, 150);
            btnOK.Name = "btnOK";
            btnOK.PenWidth = 15;
            btnOK.Rounding = true;
            btnOK.RoundingInt = 70;
            btnOK.Size = new Size(107, 38);
            btnOK.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            btnOK.TabIndex = 5;
            btnOK.Tag = "Cyber";
            btnOK.TextButton = "OK";
            btnOK.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            btnOK.Timer_Effect_1 = 5;
            btnOK.Timer_RGB = 300;
            btnOK.Click += btnOK_Click;
            // 
            // DialogBox
            // 
            AutoScaleDimensions = new SizeF(8F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(327, 204);
            Controls.Add(btnOK);
            Controls.Add(label1);
            Controls.Add(pbDialogIcon);
            Font = new Font("Inter", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            Name = "DialogBox";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DialogBox";
            ((System.ComponentModel.ISupportInitialize)pbDialogIcon).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pbDialogIcon;
        private System.Windows.Forms.Timer Pausetimer;
        private Label label1;
        private ReaLTaiizor.Controls.CyberButton btnOK;
    }
}