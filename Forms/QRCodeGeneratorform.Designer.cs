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
            panel2 = new Panel();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            pbQRCode = new PictureBox();
            airButton1 = new ReaLTaiizor.Controls.AirButton();
            btnQRGenerate = new ReaLTaiizor.Controls.CyberButton();
            cmxSave = new ContextMenuStrip(components);
            saveToolStripMenuItem = new ToolStripMenuItem();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbQRCode).BeginInit();
            cmxSave.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(153, 229, 255);
            panel2.Controls.Add(pictureBox3);
            panel2.Controls.Add(pictureBox2);
            panel2.Controls.Add(pictureBox1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(514, 32);
            panel2.TabIndex = 19;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(457, 8);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(14, 16);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 2;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(426, 6);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(19, 22);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(484, 6);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(18, 20);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pbQRCode
            // 
            pbQRCode.ContextMenuStrip = cmxSave;
            pbQRCode.Location = new Point(111, 73);
            pbQRCode.Name = "pbQRCode";
            pbQRCode.Size = new Size(279, 228);
            pbQRCode.SizeMode = PictureBoxSizeMode.Zoom;
            pbQRCode.TabIndex = 20;
            pbQRCode.TabStop = false;
            // 
            // airButton1
            // 
            airButton1.Customization = "7e3t//Ly8v/r6+v/5ubm/+vr6//f39//p6en/zw8PP8UFBT/gICA/w==";
            airButton1.Font = new Font("Segoe UI", 9F);
            airButton1.Image = null;
            airButton1.Location = new Point(229, 432);
            airButton1.Name = "airButton1";
            airButton1.NoRounding = false;
            airButton1.Size = new Size(8, 9);
            airButton1.TabIndex = 21;
            airButton1.Text = "airButton1";
            airButton1.Transparent = false;
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
            btnQRGenerate.ColorBackground_Pen = Color.FromArgb(128, 223, 255);
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
            btnQRGenerate.Location = new Point(91, 395);
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
            // QRCodeGeneratorform
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(230, 249, 255);
            ClientSize = new Size(514, 481);
            Controls.Add(btnQRGenerate);
            Controls.Add(airButton1);
            Controls.Add(pbQRCode);
            Controls.Add(panel2);
            Font = new Font("Inter", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "QRCodeGeneratorform";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "QRCodeGeneratorform";
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbQRCode).EndInit();
            cmxSave.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private PictureBox pbQRCode;
        private ReaLTaiizor.Controls.AirButton airButton1;
        private ReaLTaiizor.Controls.CyberButton btnQRGenerate;
        private ContextMenuStrip cmxSave;
        private ToolStripMenuItem saveToolStripMenuItem;
    }
}