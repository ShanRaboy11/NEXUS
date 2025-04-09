namespace NEXUS.Forms
{
    partial class Message
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Message));
            lblMessage = new Label();
            btnOK = new ReaLTaiizor.Controls.CyberButton();
            pbDialogIcon = new PictureBox();
            panel4 = new Panel();
            panel3 = new Panel();
            panel2 = new Panel();
            panel1 = new Panel();
            btnClose = new FontAwesome.Sharp.IconButton();
            lblMesage1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pbDialogIcon).BeginInit();
            SuspendLayout();
            // 
            // lblMessage
            // 
            lblMessage.Font = new Font("Inter Medium", 12.5F, FontStyle.Bold);
            lblMessage.ForeColor = Color.FromArgb(24, 60, 114);
            lblMessage.Location = new Point(3, 145);
            lblMessage.Name = "lblMessage";
            lblMessage.Size = new Size(439, 40);
            lblMessage.TabIndex = 2;
            lblMessage.Text = "Login Successful";
            lblMessage.TextAlign = ContentAlignment.MiddleCenter;
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
            btnOK.ColorBackground_Pen = Color.FromArgb(153, 229, 255);
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
            btnOK.Location = new Point(155, 196);
            btnOK.Name = "btnOK";
            btnOK.PenWidth = 15;
            btnOK.Rounding = true;
            btnOK.RoundingInt = 70;
            btnOK.Size = new Size(137, 43);
            btnOK.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            btnOK.TabIndex = 6;
            btnOK.Tag = "Cyber";
            btnOK.TextButton = "OK";
            btnOK.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            btnOK.Timer_Effect_1 = 5;
            btnOK.Timer_RGB = 300;
            btnOK.Click += btnOK_Click;
            // 
            // pbDialogIcon
            // 
            pbDialogIcon.Image = Properties.Resources.Animation___1743240515087;
            pbDialogIcon.Location = new Point(124, 14);
            pbDialogIcon.Name = "pbDialogIcon";
            pbDialogIcon.Size = new Size(186, 124);
            pbDialogIcon.SizeMode = PictureBoxSizeMode.Zoom;
            pbDialogIcon.TabIndex = 7;
            pbDialogIcon.TabStop = false;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(24, 60, 114);
            panel4.Dock = DockStyle.Bottom;
            panel4.Location = new Point(4, 252);
            panel4.Name = "panel4";
            panel4.Size = new Size(438, 4);
            panel4.TabIndex = 10;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(24, 60, 114);
            panel3.Dock = DockStyle.Right;
            panel3.Location = new Point(442, 4);
            panel3.Name = "panel3";
            panel3.Size = new Size(4, 252);
            panel3.TabIndex = 12;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(24, 60, 114);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(4, 252);
            panel2.TabIndex = 11;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(24, 60, 114);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(446, 4);
            panel1.TabIndex = 9;
            // 
            // btnClose
            // 
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Inter", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnClose.IconChar = FontAwesome.Sharp.IconChar.Close;
            btnClose.IconColor = Color.FromArgb(24, 60, 114);
            btnClose.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnClose.IconSize = 28;
            btnClose.ImageAlign = ContentAlignment.MiddleLeft;
            btnClose.Location = new Point(406, 4);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(36, 29);
            btnClose.TabIndex = 34;
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // lblMesage1
            // 
            lblMesage1.Font = new Font("Inter Medium", 11.5F, FontStyle.Bold);
            lblMesage1.ForeColor = Color.FromArgb(24, 60, 114);
            lblMesage1.Location = new Point(12, 155);
            lblMesage1.Name = "lblMesage1";
            lblMesage1.Size = new Size(422, 40);
            lblMesage1.TabIndex = 35;
            lblMesage1.Text = "Please wait until the verification process is complete.";
            lblMesage1.TextAlign = ContentAlignment.MiddleCenter;
            lblMesage1.Visible = false;
            // 
            // Message
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(230, 249, 255);
            ClientSize = new Size(446, 256);
            Controls.Add(btnClose);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(pbDialogIcon);
            Controls.Add(btnOK);
            Controls.Add(lblMessage);
            Controls.Add(lblMesage1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Message";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Message";
            ((System.ComponentModel.ISupportInitialize)pbDialogIcon).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label lblMessage;
        private ReaLTaiizor.Controls.CyberButton btnOK;
        private PictureBox pbDialogIcon;
        private Panel panel4;
        private Panel panel3;
        private Panel panel2;
        private Panel panel1;
        private FontAwesome.Sharp.IconButton btnClose;
        private Label lblMesage1;
    }
}