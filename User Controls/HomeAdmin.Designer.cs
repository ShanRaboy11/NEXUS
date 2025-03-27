namespace NEXUS.User_Controls
{
    partial class HomeAdmin
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            cyberButton3 = new ReaLTaiizor.Controls.CyberButton();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel1 = new Panel();
            label1 = new Label();
            lblUserFName = new Label();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // cyberButton3
            // 
            cyberButton3.Alpha = 20;
            cyberButton3.BackColor = Color.Transparent;
            cyberButton3.Background = true;
            cyberButton3.Background_WidthPen = 4F;
            cyberButton3.BackgroundPen = true;
            cyberButton3.ColorBackground = Color.FromArgb(153, 229, 255);
            cyberButton3.ColorBackground_1 = Color.FromArgb(38, 36, 68);
            cyberButton3.ColorBackground_2 = Color.FromArgb(41, 63, 86);
            cyberButton3.ColorBackground_Pen = Color.FromArgb(153, 229, 255);
            cyberButton3.ColorLighting = Color.FromArgb(153, 229, 255);
            cyberButton3.ColorPen_1 = Color.FromArgb(37, 52, 68);
            cyberButton3.ColorPen_2 = Color.FromArgb(41, 63, 86);
            cyberButton3.CyberButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            cyberButton3.Dock = DockStyle.Fill;
            cyberButton3.Effect_1 = true;
            cyberButton3.Effect_1_ColorBackground = Color.FromArgb(29, 200, 238);
            cyberButton3.Effect_1_Transparency = 25;
            cyberButton3.Effect_2 = true;
            cyberButton3.Effect_2_ColorBackground = Color.White;
            cyberButton3.Effect_2_Transparency = 20;
            cyberButton3.Enabled = false;
            cyberButton3.Font = new Font("Inter", 12F);
            cyberButton3.ForeColor = Color.FromArgb(38, 36, 68);
            cyberButton3.Lighting = false;
            cyberButton3.LinearGradient_Background = false;
            cyberButton3.LinearGradientPen = false;
            cyberButton3.Location = new Point(0, 0);
            cyberButton3.Name = "cyberButton3";
            cyberButton3.PenWidth = 15;
            cyberButton3.Rounding = true;
            cyberButton3.RoundingInt = 70;
            cyberButton3.Size = new Size(428, 331);
            cyberButton3.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            cyberButton3.TabIndex = 42;
            cyberButton3.Tag = "Cyber";
            cyberButton3.TextButton = "";
            cyberButton3.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            cyberButton3.Timer_Effect_1 = 5;
            cyberButton3.Timer_RGB = 300;
            cyberButton3.Click += cyberButton3_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 5;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 2.9069767F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 97.0930252F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 452F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 392F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Controls.Add(panel1, 1, 2);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 4.132231F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 95.86777F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 337F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(1312, 767);
            tableLayoutPanel1.TabIndex = 43;
            tableLayoutPanel1.Paint += tableLayoutPanel1_Paint;
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Controls.Add(lblUserFName);
            panel1.Controls.Add(cyberButton3);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(16, 412);
            panel1.Name = "panel1";
            panel1.Size = new Size(428, 331);
            panel1.TabIndex = 45;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(153, 229, 255);
            label1.Font = new Font("Inter ExtraBold", 25F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(24, 60, 114);
            label1.Location = new Point(139, 233);
            label1.Name = "label1";
            label1.Size = new Size(135, 49);
            label1.TabIndex = 44;
            label1.Text = "USERS";
            // 
            // lblUserFName
            // 
            lblUserFName.BackColor = Color.FromArgb(153, 229, 255);
            lblUserFName.Font = new Font("Inter ExtraBold", 90F, FontStyle.Bold);
            lblUserFName.ForeColor = Color.White;
            lblUserFName.Location = new Point(55, 33);
            lblUserFName.Name = "lblUserFName";
            lblUserFName.Size = new Size(317, 200);
            lblUserFName.TabIndex = 43;
            lblUserFName.Text = "0";
            lblUserFName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // HomeAdmin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(230, 249, 255);
            Controls.Add(tableLayoutPanel1);
            Name = "HomeAdmin";
            Size = new Size(1312, 767);
            tableLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Controls.CyberButton cyberButton3;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel1;
        private Label label1;
        private Label lblUserFName;
    }
}
