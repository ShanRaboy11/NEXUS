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
            poisonDateTime1 = new ReaLTaiizor.Controls.PoisonDateTime();
            label2 = new Label();
            label3 = new Label();
            pnlUsername = new Panel();
            tbxIncidentLocation = new TextBox();
            panel1 = new Panel();
            label4 = new Label();
            panel2 = new Panel();
            cmbxMonth = new ComboBox();
            label5 = new Label();
            panel3 = new Panel();
            rtbxIncidentDescription = new RichTextBox();
            pnlUsername.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
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
            // poisonDateTime1
            // 
            poisonDateTime1.CalendarFont = new Font("Inter", 12.25F);
            poisonDateTime1.CalendarMonthBackground = Color.FromArgb(176, 233, 255);
            poisonDateTime1.Location = new Point(15, 8);
            poisonDateTime1.MinimumSize = new Size(0, 29);
            poisonDateTime1.Name = "poisonDateTime1";
            poisonDateTime1.Size = new Size(210, 29);
            poisonDateTime1.TabIndex = 22;
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
            label3.Location = new Point(496, 83);
            label3.Name = "label3";
            label3.Size = new Size(182, 28);
            label3.TabIndex = 24;
            label3.Text = "Incident Location:";
            // 
            // pnlUsername
            // 
            pnlUsername.BackColor = Color.White;
            pnlUsername.BackgroundImageLayout = ImageLayout.None;
            pnlUsername.Controls.Add(tbxIncidentLocation);
            pnlUsername.Location = new Point(524, 123);
            pnlUsername.Name = "pnlUsername";
            pnlUsername.Size = new Size(365, 48);
            pnlUsername.TabIndex = 25;
            // 
            // tbxIncidentLocation
            // 
            tbxIncidentLocation.BackColor = Color.White;
            tbxIncidentLocation.BorderStyle = BorderStyle.None;
            tbxIncidentLocation.Font = new Font("Inter", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbxIncidentLocation.ForeColor = Color.FromArgb(24, 60, 114);
            tbxIncidentLocation.Location = new Point(13, 14);
            tbxIncidentLocation.Name = "tbxIncidentLocation";
            tbxIncidentLocation.Size = new Size(339, 20);
            tbxIncidentLocation.TabIndex = 10;
            tbxIncidentLocation.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.BackgroundImageLayout = ImageLayout.None;
            panel1.Controls.Add(poisonDateTime1);
            panel1.Location = new Point(99, 123);
            panel1.Name = "panel1";
            panel1.Size = new Size(237, 48);
            panel1.TabIndex = 26;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Inter Medium", 15F, FontStyle.Bold);
            label4.Location = new Point(62, 212);
            label4.Name = "label4";
            label4.Size = new Size(165, 28);
            label4.TabIndex = 27;
            label4.Text = "Incident Nature:";
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.BackgroundImageLayout = ImageLayout.None;
            panel2.Controls.Add(cmbxMonth);
            panel2.Location = new Point(99, 255);
            panel2.Name = "panel2";
            panel2.Size = new Size(237, 48);
            panel2.TabIndex = 26;
            // 
            // cmbxMonth
            // 
            cmbxMonth.BackColor = Color.FromArgb(176, 233, 255);
            cmbxMonth.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbxMonth.Font = new Font("Inter", 11.25F);
            cmbxMonth.ForeColor = Color.FromArgb(24, 60, 114);
            cmbxMonth.FormattingEnabled = true;
            cmbxMonth.Items.AddRange(new object[] { "Traffic Accident", "Mechanical Breakdown", "Theft", "Lost", "Assaults", "Sexual Harassment" });
            cmbxMonth.Location = new Point(15, 9);
            cmbxMonth.Name = "cmbxMonth";
            cmbxMonth.Size = new Size(210, 30);
            cmbxMonth.TabIndex = 25;
            cmbxMonth.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Inter Medium", 15F, FontStyle.Bold);
            label5.Location = new Point(66, 331);
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
            panel3.Location = new Point(99, 376);
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
            // Report
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(230, 249, 255);
            ClientSize = new Size(988, 739);
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
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ReaLTaiizor.Controls.PoisonDateTime poisonDateTime1;
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
        private ComboBox cmbxMonth;
    }
}