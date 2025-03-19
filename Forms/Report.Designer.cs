namespace NEXUS.Forms
{
    partial class Report
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Report));
            label1 = new Label();
            dtIncidentDate = new ReaLTaiizor.Controls.PoisonDateTime();
            label2 = new Label();
            label3 = new Label();
            pnlUsername = new Panel();
            tbxLocation = new TextBox();
            tbxIncidentLocation = new TextBox();
            panel1 = new Panel();
            label4 = new Label();
            panel2 = new Panel();
            cmbxNature = new ComboBox();
            label5 = new Label();
            panel3 = new Panel();
            rtbxIncidentDescription = new RichTextBox();
            label6 = new Label();
            label7 = new Label();
            panel4 = new Panel();
            btnAttach = new FontAwesome.Sharp.IconButton();
            lblFileName = new Label();
            btnSubmitReport = new ReaLTaiizor.Controls.CyberButton();
            panel5 = new Panel();
            poisonDateTime3 = new ReaLTaiizor.Controls.PoisonDateTime();
            pnlUsername.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Inter ExtraBold", 23F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(38, 36, 68);
            label1.Location = new Point(9, 13);
            label1.Name = "label1";
            label1.Size = new Size(315, 44);
            label1.TabIndex = 21;
            label1.Text = "REPORT INCIDENT";
            // 
            // dtIncidentDate
            // 
            dtIncidentDate.CalendarFont = new Font("Inter", 12.25F);
            dtIncidentDate.CalendarMonthBackground = Color.FromArgb(176, 233, 255);
            dtIncidentDate.Location = new Point(15, 8);
            dtIncidentDate.MinimumSize = new Size(0, 29);
            dtIncidentDate.Name = "dtIncidentDate";
            dtIncidentDate.Size = new Size(239, 29);
            dtIncidentDate.TabIndex = 22;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Inter Medium", 15F, FontStyle.Bold);
            label2.Location = new Point(62, 83);
            label2.Name = "label2";
            label2.Size = new Size(169, 28);
            label2.TabIndex = 23;
            label2.Text = "Date of Incident:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Inter Medium", 15F, FontStyle.Bold);
            label3.Location = new Point(589, 186);
            label3.Name = "label3";
            label3.Size = new Size(182, 28);
            label3.TabIndex = 24;
            label3.Text = "Incident Location:";
            // 
            // pnlUsername
            // 
            pnlUsername.BackColor = Color.White;
            pnlUsername.BackgroundImageLayout = ImageLayout.None;
            pnlUsername.Controls.Add(tbxLocation);
            pnlUsername.Location = new Point(617, 226);
            pnlUsername.Name = "pnlUsername";
            pnlUsername.Size = new Size(267, 48);
            pnlUsername.TabIndex = 25;
            // 
            // tbxLocation
            // 
            tbxLocation.BorderStyle = BorderStyle.None;
            tbxLocation.Font = new Font("Inter", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbxLocation.Location = new Point(14, 15);
            tbxLocation.Name = "tbxLocation";
            tbxLocation.Size = new Size(239, 20);
            tbxLocation.TabIndex = 0;
            // 
            // tbxIncidentLocation
            // 
            tbxIncidentLocation.BackColor = Color.White;
            tbxIncidentLocation.BorderStyle = BorderStyle.None;
            tbxIncidentLocation.Font = new Font("Inter", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbxIncidentLocation.ForeColor = Color.FromArgb(24, 60, 114);
            tbxIncidentLocation.Location = new Point(396, -349);
            tbxIncidentLocation.Name = "tbxIncidentLocation";
            tbxIncidentLocation.Size = new Size(339, 20);
            tbxIncidentLocation.TabIndex = 10;
            tbxIncidentLocation.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.BackgroundImageLayout = ImageLayout.None;
            panel1.Controls.Add(dtIncidentDate);
            panel1.Location = new Point(99, 123);
            panel1.Name = "panel1";
            panel1.Size = new Size(266, 48);
            panel1.TabIndex = 26;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Inter Medium", 15F, FontStyle.Bold);
            label4.Location = new Point(62, 186);
            label4.Name = "label4";
            label4.Size = new Size(165, 28);
            label4.TabIndex = 27;
            label4.Text = "Incident Nature:";
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.BackgroundImageLayout = ImageLayout.None;
            panel2.Controls.Add(cmbxNature);
            panel2.Location = new Point(99, 229);
            panel2.Name = "panel2";
            panel2.Size = new Size(266, 48);
            panel2.TabIndex = 26;
            // 
            // cmbxNature
            // 
            cmbxNature.BackColor = Color.FromArgb(176, 233, 255);
            cmbxNature.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbxNature.Font = new Font("Inter", 11.25F);
            cmbxNature.ForeColor = Color.FromArgb(24, 60, 114);
            cmbxNature.FormattingEnabled = true;
            cmbxNature.Items.AddRange(new object[] { "Traffic Accident", "Mechanical Breakdown", "Theft", "Lost", "Assaults", "Sexual Harassment" });
            cmbxNature.Location = new Point(15, 9);
            cmbxNature.Name = "cmbxNature";
            cmbxNature.Size = new Size(239, 30);
            cmbxNature.TabIndex = 25;
            cmbxNature.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Inter Medium", 15F, FontStyle.Bold);
            label5.Location = new Point(66, 305);
            label5.Name = "label5";
            label5.Size = new Size(210, 28);
            label5.TabIndex = 28;
            label5.Text = "Incident Description:";
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.BackgroundImageLayout = ImageLayout.None;
            panel3.Controls.Add(rtbxIncidentDescription);
            panel3.Location = new Point(99, 350);
            panel3.Name = "panel3";
            panel3.Size = new Size(790, 194);
            panel3.TabIndex = 27;
            // 
            // rtbxIncidentDescription
            // 
            rtbxIncidentDescription.BackColor = Color.White;
            rtbxIncidentDescription.BorderStyle = BorderStyle.None;
            rtbxIncidentDescription.Font = new Font("Inter", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rtbxIncidentDescription.Location = new Point(15, 16);
            rtbxIncidentDescription.Name = "rtbxIncidentDescription";
            rtbxIncidentDescription.Size = new Size(762, 161);
            rtbxIncidentDescription.TabIndex = 0;
            rtbxIncidentDescription.Text = "";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Inter Medium", 15F, FontStyle.Bold);
            label6.Location = new Point(589, 83);
            label6.Name = "label6";
            label6.Size = new Size(173, 28);
            label6.TabIndex = 29;
            label6.Text = "Time of Incident:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Inter Medium", 15F, FontStyle.Bold);
            label7.Location = new Point(66, 566);
            label7.Name = "label7";
            label7.Size = new Size(164, 28);
            label7.TabIndex = 30;
            label7.Text = "Documentation:";
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.BackgroundImageLayout = ImageLayout.None;
            panel4.Controls.Add(btnAttach);
            panel4.Controls.Add(tbxIncidentLocation);
            panel4.Controls.Add(lblFileName);
            panel4.Location = new Point(99, 606);
            panel4.Name = "panel4";
            panel4.Size = new Size(266, 48);
            panel4.TabIndex = 27;
            // 
            // btnAttach
            // 
            btnAttach.IconChar = FontAwesome.Sharp.IconChar.Image;
            btnAttach.IconColor = Color.Black;
            btnAttach.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnAttach.IconSize = 30;
            btnAttach.Location = new Point(208, 8);
            btnAttach.Name = "btnAttach";
            btnAttach.Size = new Size(46, 35);
            btnAttach.TabIndex = 32;
            btnAttach.UseVisualStyleBackColor = true;
            btnAttach.Click += btnAttach_Click;
            // 
            // lblFileName
            // 
            lblFileName.Cursor = Cursors.Hand;
            lblFileName.Font = new Font("Inter", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblFileName.Location = new Point(15, 12);
            lblFileName.Name = "lblFileName";
            lblFileName.Size = new Size(187, 23);
            lblFileName.TabIndex = 31;
            lblFileName.Click += lblFileName_Click;
            // 
            // btnSubmitReport
            // 
            btnSubmitReport.Alpha = 20;
            btnSubmitReport.BackColor = Color.Transparent;
            btnSubmitReport.Background = true;
            btnSubmitReport.Background_WidthPen = 4F;
            btnSubmitReport.BackgroundPen = true;
            btnSubmitReport.ColorBackground = Color.FromArgb(24, 60, 114);
            btnSubmitReport.ColorBackground_1 = Color.FromArgb(24, 60, 114);
            btnSubmitReport.ColorBackground_2 = Color.FromArgb(24, 60, 114);
            btnSubmitReport.ColorBackground_Pen = Color.FromArgb(153, 229, 255);
            btnSubmitReport.ColorLighting = Color.FromArgb(24, 60, 114);
            btnSubmitReport.ColorPen_1 = Color.FromArgb(24, 60, 114);
            btnSubmitReport.ColorPen_2 = Color.FromArgb(24, 60, 114);
            btnSubmitReport.Cursor = Cursors.Hand;
            btnSubmitReport.CyberButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            btnSubmitReport.Effect_1 = true;
            btnSubmitReport.Effect_1_ColorBackground = Color.FromArgb(29, 200, 238);
            btnSubmitReport.Effect_1_Transparency = 25;
            btnSubmitReport.Effect_2 = true;
            btnSubmitReport.Effect_2_ColorBackground = Color.White;
            btnSubmitReport.Effect_2_Transparency = 20;
            btnSubmitReport.Font = new Font("Inter", 12.25F);
            btnSubmitReport.ForeColor = Color.FromArgb(245, 245, 245);
            btnSubmitReport.Lighting = false;
            btnSubmitReport.LinearGradient_Background = false;
            btnSubmitReport.LinearGradientPen = false;
            btnSubmitReport.Location = new Point(357, 674);
            btnSubmitReport.Name = "btnSubmitReport";
            btnSubmitReport.PenWidth = 15;
            btnSubmitReport.Rounding = true;
            btnSubmitReport.RoundingInt = 70;
            btnSubmitReport.Size = new Size(311, 44);
            btnSubmitReport.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            btnSubmitReport.TabIndex = 33;
            btnSubmitReport.Tag = "Cyber";
            btnSubmitReport.TextButton = "Submit";
            btnSubmitReport.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            btnSubmitReport.Timer_Effect_1 = 5;
            btnSubmitReport.Timer_RGB = 300;
            btnSubmitReport.Click += btnSubmitReport_Click;
            // 
            // panel5
            // 
            panel5.BackColor = Color.White;
            panel5.BackgroundImageLayout = ImageLayout.None;
            panel5.Controls.Add(poisonDateTime3);
            panel5.Location = new Point(617, 123);
            panel5.Name = "panel5";
            panel5.Size = new Size(267, 48);
            panel5.TabIndex = 27;
            // 
            // poisonDateTime3
            // 
            poisonDateTime3.CalendarFont = new Font("Inter", 12.25F);
            poisonDateTime3.CalendarMonthBackground = Color.FromArgb(176, 233, 255);
            poisonDateTime3.Format = DateTimePickerFormat.Time;
            poisonDateTime3.Location = new Point(15, 8);
            poisonDateTime3.MinimumSize = new Size(0, 29);
            poisonDateTime3.Name = "poisonDateTime3";
            poisonDateTime3.Size = new Size(239, 29);
            poisonDateTime3.TabIndex = 22;
            // 
            // Report
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(230, 249, 255);
            ClientSize = new Size(988, 739);
            Controls.Add(panel5);
            Controls.Add(btnSubmitReport);
            Controls.Add(panel4);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(panel3);
            Controls.Add(label5);
            Controls.Add(panel2);
            Controls.Add(label4);
            Controls.Add(panel1);
            Controls.Add(pnlUsername);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Report";
            Text = "Report";
            pnlUsername.ResumeLayout(false);
            pnlUsername.PerformLayout();
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ReaLTaiizor.Controls.PoisonDateTime dtIncidentDate;
        private Label label2;
        private Label label3;
        private Panel pnlUsername;
        private Panel panel1;
        private TextBox tbxIncidentLocation;
        private Label label4;
        private Panel panel2;
        private Label label5;
        private Panel panel3;
        private RichTextBox rtbxIncidentDescription;
        private ComboBox cmbxNature;
        private Label label6;
        private Label label7;
        private Panel panel4;
        private Label lblFileName;
        private FontAwesome.Sharp.IconButton btnAttach;
        private ReaLTaiizor.Controls.CyberButton btnSubmitReport;
        private Panel panel5;
        private ReaLTaiizor.Controls.PoisonDateTime poisonDateTime3;
        private TextBox tbxLocation;
    }
}