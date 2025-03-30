namespace NEXUS.Forms
{
    partial class CashIn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CashIn));
            label1 = new Label();
            panel2 = new Panel();
            pbClose = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            pbAbout = new PictureBox();
            lblPhp = new Label();
            tbxAmount = new TextBox();
            btnConfirm = new ReaLTaiizor.Controls.CyberButton();
            label2 = new Label();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbClose).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbAbout).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Inter SemiBold", 19F, FontStyle.Bold);
            label1.ForeColor = SystemColors.ControlDarkDark;
            label1.Location = new Point(70, 43);
            label1.Name = "label1";
            label1.Size = new Size(243, 37);
            label1.TabIndex = 34;
            label1.Text = "Deposit to NEXUS";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(153, 229, 255);
            panel2.Controls.Add(pbClose);
            panel2.Controls.Add(pictureBox3);
            panel2.Controls.Add(pictureBox2);
            panel2.Controls.Add(pictureBox1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(516, 28);
            panel2.TabIndex = 36;
            // 
            // pbClose
            // 
            pbClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pbClose.Image = (Image)resources.GetObject("pbClose.Image");
            pbClose.Location = new Point(491, 6);
            pbClose.Name = "pbClose";
            pbClose.Size = new Size(18, 18);
            pbClose.SizeMode = PictureBoxSizeMode.Zoom;
            pbClose.TabIndex = 37;
            pbClose.TabStop = false;
            pbClose.Click += pbClose_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(1658, 6);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(14, 14);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 2;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(1627, 4);
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
            pictureBox1.Location = new Point(1685, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(18, 18);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pbAbout
            // 
            pbAbout.Cursor = Cursors.Hand;
            pbAbout.Image = Properties.Resources.Removal_915;
            pbAbout.Location = new Point(9, 35);
            pbAbout.Name = "pbAbout";
            pbAbout.Size = new Size(61, 54);
            pbAbout.SizeMode = PictureBoxSizeMode.Zoom;
            pbAbout.TabIndex = 37;
            pbAbout.TabStop = false;
            // 
            // lblPhp
            // 
            lblPhp.AutoSize = true;
            lblPhp.Font = new Font("Inter ExtraBold", 19F, FontStyle.Bold);
            lblPhp.ForeColor = Color.FromArgb(24, 60, 114);
            lblPhp.Location = new Point(169, 147);
            lblPhp.Name = "lblPhp";
            lblPhp.Size = new Size(70, 37);
            lblPhp.TabIndex = 38;
            lblPhp.Text = "PHP";
            // 
            // tbxAmount
            // 
            tbxAmount.BackColor = Color.FromArgb(230, 249, 255);
            tbxAmount.BorderStyle = BorderStyle.None;
            tbxAmount.Font = new Font("Inter ExtraBold", 75F, FontStyle.Bold);
            tbxAmount.ForeColor = Color.FromArgb(24, 60, 114);
            tbxAmount.Location = new Point(45, 149);
            tbxAmount.Name = "tbxAmount";
            tbxAmount.Size = new Size(424, 121);
            tbxAmount.TabIndex = 39;
            tbxAmount.TabStop = false;
            tbxAmount.Text = "0";
            tbxAmount.TextAlign = HorizontalAlignment.Center;
            tbxAmount.Click += tbxAmount_Click;
            tbxAmount.TextChanged += tbxAmount_TextChanged;
            tbxAmount.KeyPress += tbxAmount_KeyPress;
            // 
            // btnConfirm
            // 
            btnConfirm.Alpha = 20;
            btnConfirm.BackColor = Color.Transparent;
            btnConfirm.Background = true;
            btnConfirm.Background_WidthPen = 4F;
            btnConfirm.BackgroundPen = true;
            btnConfirm.ColorBackground = Color.FromArgb(24, 60, 114);
            btnConfirm.ColorBackground_1 = Color.FromArgb(24, 60, 114);
            btnConfirm.ColorBackground_2 = Color.FromArgb(24, 60, 114);
            btnConfirm.ColorBackground_Pen = Color.FromArgb(128, 223, 255);
            btnConfirm.ColorLighting = Color.FromArgb(24, 60, 114);
            btnConfirm.ColorPen_1 = Color.FromArgb(24, 60, 114);
            btnConfirm.ColorPen_2 = Color.FromArgb(24, 60, 114);
            btnConfirm.Cursor = Cursors.Hand;
            btnConfirm.CyberButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            btnConfirm.Effect_1 = true;
            btnConfirm.Effect_1_ColorBackground = Color.FromArgb(29, 200, 238);
            btnConfirm.Effect_1_Transparency = 25;
            btnConfirm.Effect_2 = true;
            btnConfirm.Effect_2_ColorBackground = Color.White;
            btnConfirm.Effect_2_Transparency = 20;
            btnConfirm.Font = new Font("Inter", 12.25F);
            btnConfirm.ForeColor = Color.FromArgb(245, 245, 245);
            btnConfirm.Lighting = false;
            btnConfirm.LinearGradient_Background = false;
            btnConfirm.LinearGradientPen = false;
            btnConfirm.Location = new Point(154, 367);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.PenWidth = 15;
            btnConfirm.Rounding = true;
            btnConfirm.RoundingInt = 70;
            btnConfirm.Size = new Size(217, 48);
            btnConfirm.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            btnConfirm.TabIndex = 40;
            btnConfirm.Tag = "Cyber";
            btnConfirm.TextButton = "Confirm";
            btnConfirm.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            btnConfirm.Timer_Effect_1 = 5;
            btnConfirm.Timer_RGB = 300;
            btnConfirm.Click += btnConfirm_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Inter", 12F);
            label2.ForeColor = Color.DimGray;
            label2.Location = new Point(70, 330);
            label2.Name = "label2";
            label2.Size = new Size(372, 23);
            label2.TabIndex = 82;
            label2.Text = "Ensure the amount is correct before confirming.";
            // 
            // CashIn
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(230, 249, 255);
            ClientSize = new Size(516, 427);
            Controls.Add(label2);
            Controls.Add(btnConfirm);
            Controls.Add(pbAbout);
            Controls.Add(panel2);
            Controls.Add(label1);
            Controls.Add(lblPhp);
            Controls.Add(tbxAmount);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "CashIn";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CashIn";
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbClose).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbAbout).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Panel panel2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private PictureBox pbClose;
        private PictureBox pbAbout;
        private Label lblPhp;
        private TextBox tbxAmount;
        private ReaLTaiizor.Controls.CyberButton btnConfirm;
        private Label label2;
    }
}