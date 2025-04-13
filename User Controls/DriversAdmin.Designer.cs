namespace NEXUS.User_Controls
{
    partial class DriversAdmin
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
            btnCashOut = new FontAwesome.Sharp.IconButton();
            btnDrivers = new FontAwesome.Sharp.IconButton();
            btnVerification = new FontAwesome.Sharp.IconButton();
            pnlDisplay = new Panel();
            tblVerification = new TableLayoutPanel();
            label2 = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            pnlDisplay.SuspendLayout();
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
            panel1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.White;
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.Controls.Add(btnCashOut, 2, 0);
            tableLayoutPanel1.Controls.Add(btnDrivers, 0, 0);
            tableLayoutPanel1.Controls.Add(btnVerification, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(1312, 70);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // btnCashOut
            // 
            btnCashOut.Dock = DockStyle.Fill;
            btnCashOut.FlatAppearance.BorderSize = 0;
            btnCashOut.FlatStyle = FlatStyle.Flat;
            btnCashOut.Font = new Font("Inter Medium", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCashOut.ForeColor = Color.Black;
            btnCashOut.IconChar = FontAwesome.Sharp.IconChar.None;
            btnCashOut.IconColor = Color.Black;
            btnCashOut.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnCashOut.ImageAlign = ContentAlignment.MiddleLeft;
            btnCashOut.Location = new Point(877, 3);
            btnCashOut.Name = "btnCashOut";
            btnCashOut.Size = new Size(432, 64);
            btnCashOut.TabIndex = 36;
            btnCashOut.Text = "Cash Out";
            btnCashOut.UseVisualStyleBackColor = true;
            btnCashOut.Click += iconButton1_Click;
            // 
            // btnDrivers
            // 
            btnDrivers.Dock = DockStyle.Fill;
            btnDrivers.FlatAppearance.BorderSize = 0;
            btnDrivers.FlatStyle = FlatStyle.Flat;
            btnDrivers.Font = new Font("Inter Medium", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDrivers.ForeColor = Color.Black;
            btnDrivers.IconChar = FontAwesome.Sharp.IconChar.None;
            btnDrivers.IconColor = Color.Black;
            btnDrivers.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnDrivers.ImageAlign = ContentAlignment.MiddleLeft;
            btnDrivers.Location = new Point(3, 3);
            btnDrivers.Name = "btnDrivers";
            btnDrivers.Size = new Size(431, 64);
            btnDrivers.TabIndex = 34;
            btnDrivers.Text = "Drivers";
            btnDrivers.UseVisualStyleBackColor = true;
            btnDrivers.Click += btnDrivers_Click;
            // 
            // btnVerification
            // 
            btnVerification.Dock = DockStyle.Fill;
            btnVerification.FlatAppearance.BorderSize = 0;
            btnVerification.FlatStyle = FlatStyle.Flat;
            btnVerification.Font = new Font("Inter Medium", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnVerification.ForeColor = Color.Black;
            btnVerification.IconChar = FontAwesome.Sharp.IconChar.None;
            btnVerification.IconColor = Color.Black;
            btnVerification.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnVerification.ImageAlign = ContentAlignment.MiddleLeft;
            btnVerification.Location = new Point(440, 3);
            btnVerification.Name = "btnVerification";
            btnVerification.Size = new Size(431, 64);
            btnVerification.TabIndex = 35;
            btnVerification.Text = "Verification";
            btnVerification.UseVisualStyleBackColor = true;
            btnVerification.Click += btnVerification_Click;
            // 
            // pnlDisplay
            // 
            pnlDisplay.Controls.Add(tblVerification);
            pnlDisplay.Dock = DockStyle.Fill;
            pnlDisplay.Location = new Point(0, 70);
            pnlDisplay.Name = "pnlDisplay";
            pnlDisplay.Size = new Size(1312, 697);
            pnlDisplay.TabIndex = 1;
            // 
            // tblVerification
            // 
            tblVerification.AutoScroll = true;
            tblVerification.ColumnCount = 4;
            tblVerification.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 41.3318024F));
            tblVerification.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 58.6681976F));
            tblVerification.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 222F));
            tblVerification.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 217F));
            tblVerification.Controls.Add(label2, 1, 0);
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
            tblVerification.Size = new Size(1312, 697);
            tblVerification.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Fill;
            label2.Font = new Font("Inter SemiBold", 20F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(24, 60, 114);
            label2.Location = new Point(357, 5);
            label2.Name = "label2";
            label2.Size = new Size(490, 45);
            label2.TabIndex = 1;
            label2.Text = "Attachment";
            label2.TextAlign = ContentAlignment.MiddleCenter;
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
            // DriversAdmin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(230, 249, 255);
            Controls.Add(pnlDisplay);
            Controls.Add(panel1);
            Name = "DriversAdmin";
            Size = new Size(1312, 767);
            panel1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            pnlDisplay.ResumeLayout(false);
            tblVerification.ResumeLayout(false);
            tblVerification.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel pnlDisplay;
        private TableLayoutPanel tblVerification;
        private Label label2;
        private Label label1;
        private TableLayoutPanel tableLayoutPanel1;
        private FontAwesome.Sharp.IconButton btnVerification;
        private FontAwesome.Sharp.IconButton btnDrivers;
        private FontAwesome.Sharp.IconButton btnCashOut;
    }
}
