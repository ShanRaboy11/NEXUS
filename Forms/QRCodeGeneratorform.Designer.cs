namespace NEXUS.Forms
{
    partial class QRCodeGeneratorform
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QRCodeGeneratorform));
            pbQRCode = new PictureBox();
            cmxSave = new ContextMenuStrip(components);
            saveToolStripMenuItem = new ToolStripMenuItem();
            btnQRGenerate = new ReaLTaiizor.Controls.CyberButton();
            pnlBG = new Panel();
            btnSaveQR = new ReaLTaiizor.Controls.CyberButton();
            lblNoteQR = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pbQRCode).BeginInit();
            cmxSave.SuspendLayout();
            SuspendLayout();
            // 
            // pbQRCode
            // 
            pbQRCode.ContextMenuStrip = cmxSave;
            pbQRCode.Location = new Point(167, 125);
            pbQRCode.Name = "pbQRCode";
            pbQRCode.Size = new Size(614, 449);
            pbQRCode.SizeMode = PictureBoxSizeMode.Zoom;
            pbQRCode.TabIndex = 20;
            pbQRCode.TabStop = false;
            // 
            // cmxSave
            // 
            cmxSave.Font = new Font("Inter", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmxSave.Items.AddRange(new ToolStripItem[] { saveToolStripMenuItem });
            cmxSave.Name = "cmxSave";
            cmxSave.Size = new Size(107, 26);
            // 
            // saveToolStripMenuItem
            // 
            saveToolStripMenuItem.Image = Properties.Resources._1904659_arrow_backup_down_download_save_icon;
            saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            saveToolStripMenuItem.Size = new Size(106, 22);
            saveToolStripMenuItem.Text = "Save";
            saveToolStripMenuItem.Click += save_Click;
            // 
            // btnQRGenerate
            // 
            btnQRGenerate.Alpha = 20;
            btnQRGenerate.BackColor = Color.Transparent;
            btnQRGenerate.Background = true;
            btnQRGenerate.Background_WidthPen = 4F;
            btnQRGenerate.BackgroundPen = true;
            btnQRGenerate.ColorBackground = Color.FromArgb(24, 60, 114);
            btnQRGenerate.ColorBackground_1 = Color.FromArgb(24, 60, 114);
            btnQRGenerate.ColorBackground_2 = Color.FromArgb(24, 60, 114);
            btnQRGenerate.ColorBackground_Pen = Color.FromArgb(153, 229, 255);
            btnQRGenerate.ColorLighting = Color.FromArgb(24, 60, 114);
            btnQRGenerate.ColorPen_1 = Color.FromArgb(24, 60, 114);
            btnQRGenerate.ColorPen_2 = Color.FromArgb(24, 60, 114);
            btnQRGenerate.Cursor = Cursors.Hand;
            btnQRGenerate.CyberButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            btnQRGenerate.Effect_1 = true;
            btnQRGenerate.Effect_1_ColorBackground = Color.FromArgb(29, 200, 238);
            btnQRGenerate.Effect_1_Transparency = 25;
            btnQRGenerate.Effect_2 = true;
            btnQRGenerate.Effect_2_ColorBackground = Color.White;
            btnQRGenerate.Effect_2_Transparency = 20;
            btnQRGenerate.Font = new Font("Inter", 12.25F);
            btnQRGenerate.ForeColor = Color.FromArgb(245, 245, 245);
            btnQRGenerate.Lighting = false;
            btnQRGenerate.LinearGradient_Background = false;
            btnQRGenerate.LinearGradientPen = false;
            btnQRGenerate.Location = new Point(319, 626);
            btnQRGenerate.Name = "btnQRGenerate";
            btnQRGenerate.PenWidth = 15;
            btnQRGenerate.Rounding = true;
            btnQRGenerate.RoundingInt = 70;
            btnQRGenerate.Size = new Size(311, 44);
            btnQRGenerate.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            btnQRGenerate.TabIndex = 22;
            btnQRGenerate.Tag = "Cyber";
            btnQRGenerate.TextButton = "Generate";
            btnQRGenerate.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            btnQRGenerate.Timer_Effect_1 = 5;
            btnQRGenerate.Timer_RGB = 300;
            btnQRGenerate.Click += btnQRGenerate_Click;
            // 
            // pnlBG
            // 
            pnlBG.BackColor = Color.FromArgb(153, 229, 255);
            pnlBG.Location = new Point(136, 102);
            pnlBG.Name = "pnlBG";
            pnlBG.Size = new Size(675, 500);
            pnlBG.TabIndex = 23;
            // 
            // btnSaveQR
            // 
            btnSaveQR.Alpha = 20;
            btnSaveQR.BackColor = Color.Transparent;
            btnSaveQR.Background = true;
            btnSaveQR.Background_WidthPen = 4F;
            btnSaveQR.BackgroundPen = true;
            btnSaveQR.ColorBackground = Color.FromArgb(24, 60, 114);
            btnSaveQR.ColorBackground_1 = Color.FromArgb(24, 60, 114);
            btnSaveQR.ColorBackground_2 = Color.FromArgb(24, 60, 114);
            btnSaveQR.ColorBackground_Pen = Color.FromArgb(153, 229, 255);
            btnSaveQR.ColorLighting = Color.FromArgb(24, 60, 114);
            btnSaveQR.ColorPen_1 = Color.FromArgb(24, 60, 114);
            btnSaveQR.ColorPen_2 = Color.FromArgb(24, 60, 114);
            btnSaveQR.Cursor = Cursors.Hand;
            btnSaveQR.CyberButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            btnSaveQR.Effect_1 = true;
            btnSaveQR.Effect_1_ColorBackground = Color.FromArgb(29, 200, 238);
            btnSaveQR.Effect_1_Transparency = 25;
            btnSaveQR.Effect_2 = true;
            btnSaveQR.Effect_2_ColorBackground = Color.White;
            btnSaveQR.Effect_2_Transparency = 20;
            btnSaveQR.Font = new Font("Inter", 12.25F);
            btnSaveQR.ForeColor = Color.FromArgb(245, 245, 245);
            btnSaveQR.Lighting = false;
            btnSaveQR.LinearGradient_Background = false;
            btnSaveQR.LinearGradientPen = false;
            btnSaveQR.Location = new Point(319, 681);
            btnSaveQR.Name = "btnSaveQR";
            btnSaveQR.PenWidth = 15;
            btnSaveQR.Rounding = true;
            btnSaveQR.RoundingInt = 70;
            btnSaveQR.Size = new Size(311, 44);
            btnSaveQR.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            btnSaveQR.TabIndex = 24;
            btnSaveQR.Tag = "Cyber";
            btnSaveQR.TextButton = "Save your QR Code";
            btnSaveQR.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            btnSaveQR.Timer_Effect_1 = 5;
            btnSaveQR.Timer_RGB = 300;
            btnSaveQR.Visible = false;
            btnSaveQR.Click += btnSaveQR_Click;
            // 
            // lblNoteQR
            // 
            lblNoteQR.AutoSize = true;
            lblNoteQR.BackColor = Color.FromArgb(230, 249, 255);
            lblNoteQR.Font = new Font("Inter", 14F);
            lblNoteQR.ForeColor = Color.Black;
            lblNoteQR.Location = new Point(54, 54);
            lblNoteQR.Name = "lblNoteQR";
            lblNoteQR.Size = new Size(849, 27);
            lblNoteQR.TabIndex = 156;
            lblNoteQR.Text = "Generate your unique QR code to streamline trip logging and secure hassle-free transactions.";
            // 
            // label1
            // 
            label1.Font = new Font("Inter ExtraBold", 21F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(38, 36, 68);
            label1.Location = new Point(12, 1);
            label1.Name = "label1";
            label1.Size = new Size(511, 44);
            label1.TabIndex = 155;
            label1.Text = "QR Code";
            // 
            // QRCodeGeneratorform
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(230, 249, 255);
            ClientSize = new Size(988, 739);
            Controls.Add(lblNoteQR);
            Controls.Add(label1);
            Controls.Add(btnSaveQR);
            Controls.Add(btnQRGenerate);
            Controls.Add(pbQRCode);
            Controls.Add(pnlBG);
            Font = new Font("Inter", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "QRCodeGeneratorform";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "QRCodeGeneratorform";
            ((System.ComponentModel.ISupportInitialize)pbQRCode).EndInit();
            cmxSave.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pbQRCode;
        private ReaLTaiizor.Controls.CyberButton btnQRGenerate;
        private ContextMenuStrip cmxSave;
        private ToolStripMenuItem saveToolStripMenuItem;
        private Panel pnlBG;
        private ReaLTaiizor.Controls.CyberButton btnSaveQR;
        protected internal Label lblNoteQR;
        private Label label1;
    }
}