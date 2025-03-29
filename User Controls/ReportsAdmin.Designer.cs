namespace NEXUS.User_Controls
{
    partial class ReportsAdmin
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
            panel1 = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            btnRate = new FontAwesome.Sharp.IconButton();
            btnUpdates = new FontAwesome.Sharp.IconButton();
            btnReports = new FontAwesome.Sharp.IconButton();
            panel2 = new Panel();
            tableLayoutPanel2 = new TableLayoutPanel();
            pnlContainer = new Panel();
            tblVerification = new TableLayoutPanel();
            lblHeader2 = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panel2.SuspendLayout();
            pnlContainer.SuspendLayout();
            tblVerification.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(tableLayoutPanel1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1312, 70);
            panel1.TabIndex = 2;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.FromArgb(230, 249, 255);
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 268F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 268F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 268F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 745F));
            tableLayoutPanel1.Controls.Add(btnRate, 0, 0);
            tableLayoutPanel1.Controls.Add(btnUpdates, 0, 0);
            tableLayoutPanel1.Controls.Add(btnReports, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(1312, 70);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // btnRate
            // 
            btnRate.Dock = DockStyle.Fill;
            btnRate.FlatAppearance.BorderSize = 0;
            btnRate.FlatStyle = FlatStyle.Flat;
            btnRate.Font = new Font("Inter Medium", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRate.ForeColor = Color.Black;
            btnRate.IconChar = FontAwesome.Sharp.IconChar.None;
            btnRate.IconColor = Color.Black;
            btnRate.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnRate.ImageAlign = ContentAlignment.MiddleLeft;
            btnRate.Location = new Point(539, 3);
            btnRate.Name = "btnRate";
            btnRate.Size = new Size(262, 64);
            btnRate.TabIndex = 36;
            btnRate.Text = "Rates";
            btnRate.UseVisualStyleBackColor = true;
            btnRate.Click += btnRate_Click;
            // 
            // btnUpdates
            // 
            btnUpdates.Dock = DockStyle.Fill;
            btnUpdates.FlatAppearance.BorderSize = 0;
            btnUpdates.FlatStyle = FlatStyle.Flat;
            btnUpdates.Font = new Font("Inter Medium", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUpdates.ForeColor = Color.Black;
            btnUpdates.IconChar = FontAwesome.Sharp.IconChar.None;
            btnUpdates.IconColor = Color.Black;
            btnUpdates.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnUpdates.ImageAlign = ContentAlignment.MiddleLeft;
            btnUpdates.Location = new Point(271, 3);
            btnUpdates.Name = "btnUpdates";
            btnUpdates.Size = new Size(262, 64);
            btnUpdates.TabIndex = 35;
            btnUpdates.Text = "Update Report";
            btnUpdates.UseVisualStyleBackColor = true;
            btnUpdates.Click += btnUpdate_Click;
            // 
            // btnReports
            // 
            btnReports.Dock = DockStyle.Fill;
            btnReports.FlatAppearance.BorderSize = 0;
            btnReports.FlatStyle = FlatStyle.Flat;
            btnReports.Font = new Font("Inter Medium", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnReports.ForeColor = Color.Black;
            btnReports.IconChar = FontAwesome.Sharp.IconChar.None;
            btnReports.IconColor = Color.Black;
            btnReports.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnReports.ImageAlign = ContentAlignment.MiddleLeft;
            btnReports.Location = new Point(3, 3);
            btnReports.Name = "btnReports";
            btnReports.Size = new Size(262, 64);
            btnReports.TabIndex = 34;
            btnReports.Text = "Reports";
            btnReports.UseVisualStyleBackColor = true;
            btnReports.Click += btnReport_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(tableLayoutPanel2);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 70);
            panel2.Name = "panel2";
            panel2.Size = new Size(1312, 55);
            panel2.TabIndex = 3;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.BackColor = Color.FromArgb(230, 249, 255);
            tableLayoutPanel2.ColumnCount = 4;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 268F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 625F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 222F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 434F));
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(0, 0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(1312, 55);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // pnlContainer
            // 
            pnlContainer.Controls.Add(tblVerification);
            pnlContainer.Dock = DockStyle.Fill;
            pnlContainer.Location = new Point(0, 125);
            pnlContainer.Name = "pnlContainer";
            pnlContainer.Size = new Size(1312, 642);
            pnlContainer.TabIndex = 4;
            // 
            // tblVerification
            // 
            tblVerification.AutoScroll = true;
            tblVerification.BackColor = Color.FromArgb(230, 249, 255);
            tblVerification.ColumnCount = 4;
            tblVerification.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 41.3318024F));
            tblVerification.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 58.6681976F));
            tblVerification.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 222F));
            tblVerification.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 217F));
            tblVerification.Controls.Add(lblHeader2, 1, 0);
            tblVerification.Controls.Add(label1, 0, 0);
            tblVerification.Dock = DockStyle.Fill;
            tblVerification.Location = new Point(0, 0);
            tblVerification.Name = "tblVerification";
            tblVerification.Padding = new Padding(5);
            tblVerification.RowCount = 21;
            tblVerification.RowStyles.Add(new RowStyle(SizeType.Absolute, 45F));
            tblVerification.RowStyles.Add(new RowStyle(SizeType.Absolute, 45F));
            tblVerification.RowStyles.Add(new RowStyle(SizeType.Absolute, 45F));
            tblVerification.RowStyles.Add(new RowStyle(SizeType.Absolute, 45F));
            tblVerification.RowStyles.Add(new RowStyle(SizeType.Absolute, 45F));
            tblVerification.RowStyles.Add(new RowStyle(SizeType.Absolute, 45F));
            tblVerification.RowStyles.Add(new RowStyle(SizeType.Absolute, 45F));
            tblVerification.RowStyles.Add(new RowStyle(SizeType.Absolute, 45F));
            tblVerification.RowStyles.Add(new RowStyle(SizeType.Absolute, 45F));
            tblVerification.RowStyles.Add(new RowStyle(SizeType.Absolute, 45F));
            tblVerification.RowStyles.Add(new RowStyle(SizeType.Absolute, 45F));
            tblVerification.RowStyles.Add(new RowStyle(SizeType.Absolute, 45F));
            tblVerification.RowStyles.Add(new RowStyle(SizeType.Absolute, 45F));
            tblVerification.RowStyles.Add(new RowStyle(SizeType.Absolute, 45F));
            tblVerification.RowStyles.Add(new RowStyle(SizeType.Absolute, 45F));
            tblVerification.RowStyles.Add(new RowStyle(SizeType.Absolute, 45F));
            tblVerification.RowStyles.Add(new RowStyle(SizeType.Absolute, 45F));
            tblVerification.RowStyles.Add(new RowStyle(SizeType.Absolute, 45F));
            tblVerification.RowStyles.Add(new RowStyle(SizeType.Absolute, 45F));
            tblVerification.RowStyles.Add(new RowStyle(SizeType.Absolute, 45F));
            tblVerification.RowStyles.Add(new RowStyle(SizeType.Absolute, 45F));
            tblVerification.Size = new Size(1312, 642);
            tblVerification.TabIndex = 1;
            // 
            // lblHeader2
            // 
            lblHeader2.AutoSize = true;
            lblHeader2.Dock = DockStyle.Fill;
            lblHeader2.Font = new Font("Inter SemiBold", 20F, FontStyle.Bold);
            lblHeader2.ForeColor = Color.FromArgb(24, 60, 114);
            lblHeader2.Location = new Point(357, 5);
            lblHeader2.Name = "lblHeader2";
            lblHeader2.Size = new Size(490, 45);
            lblHeader2.TabIndex = 1;
            lblHeader2.Text = "Attachment";
            lblHeader2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Inter SemiBold", 20F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(24, 60, 114);
            label1.Location = new Point(8, 5);
            label1.Name = "label1";
            label1.Size = new Size(343, 45);
            label1.TabIndex = 0;
            label1.Text = "Name";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ReportsAdmin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(230, 249, 255);
            Controls.Add(pnlContainer);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "ReportsAdmin";
            Size = new Size(1312, 767);
            panel1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            pnlContainer.ResumeLayout(false);
            tblVerification.ResumeLayout(false);
            tblVerification.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TableLayoutPanel tableLayoutPanel1;
        private FontAwesome.Sharp.IconButton btnRate;
        private FontAwesome.Sharp.IconButton btnUpdates;
        private FontAwesome.Sharp.IconButton btnReports;
        private Panel panel2;
        private TableLayoutPanel tableLayoutPanel2;
        private Panel pnlContainer;
        private TableLayoutPanel tblVerification;
        private Label lblHeader2;
        private Label label1;
    }
}
