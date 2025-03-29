namespace NEXUS.User_Controls
{
    partial class TransactionsAdmin
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
            btnTrips = new FontAwesome.Sharp.IconButton();
            btnTransactions = new FontAwesome.Sharp.IconButton();
            panel2 = new Panel();
            tableLayoutPanel2 = new TableLayoutPanel();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            label2 = new Label();
            cmbxFilter = new Krypton.Toolkit.KryptonComboBox();
            pnlContainer = new Panel();
            tblVerification = new TableLayoutPanel();
            lblHeader2 = new Label();
            label1 = new Label();
            kryptonDateTimePicker1 = new Krypton.Toolkit.KryptonDateTimePicker();
            panel1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panel2.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)cmbxFilter).BeginInit();
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
            panel1.TabIndex = 3;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.FromArgb(230, 249, 255);
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 268F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 268F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 268F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 745F));
            tableLayoutPanel1.Controls.Add(btnTrips, 0, 0);
            tableLayoutPanel1.Controls.Add(btnTransactions, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(1312, 70);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // btnTrips
            // 
            btnTrips.Dock = DockStyle.Fill;
            btnTrips.FlatAppearance.BorderSize = 0;
            btnTrips.FlatStyle = FlatStyle.Flat;
            btnTrips.Font = new Font("Inter Medium", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTrips.ForeColor = Color.Black;
            btnTrips.IconChar = FontAwesome.Sharp.IconChar.None;
            btnTrips.IconColor = Color.Black;
            btnTrips.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnTrips.ImageAlign = ContentAlignment.MiddleLeft;
            btnTrips.Location = new Point(271, 3);
            btnTrips.Name = "btnTrips";
            btnTrips.Size = new Size(262, 64);
            btnTrips.TabIndex = 35;
            btnTrips.Text = "Trips";
            btnTrips.UseVisualStyleBackColor = true;
            // 
            // btnTransactions
            // 
            btnTransactions.Dock = DockStyle.Fill;
            btnTransactions.FlatAppearance.BorderSize = 0;
            btnTransactions.FlatStyle = FlatStyle.Flat;
            btnTransactions.Font = new Font("Inter Medium", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTransactions.ForeColor = Color.Black;
            btnTransactions.IconChar = FontAwesome.Sharp.IconChar.None;
            btnTransactions.IconColor = Color.Black;
            btnTransactions.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnTransactions.ImageAlign = ContentAlignment.MiddleLeft;
            btnTransactions.Location = new Point(3, 3);
            btnTransactions.Name = "btnTransactions";
            btnTransactions.Size = new Size(262, 64);
            btnTransactions.TabIndex = 34;
            btnTransactions.Text = "Transactions";
            btnTransactions.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.Controls.Add(tableLayoutPanel2);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 70);
            panel2.Name = "panel2";
            panel2.Size = new Size(1312, 55);
            panel2.TabIndex = 4;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.BackColor = Color.FromArgb(230, 249, 255);
            tableLayoutPanel2.ColumnCount = 6;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 100F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 154F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 814F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 481F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Controls.Add(iconButton1, 2, 0);
            tableLayoutPanel2.Controls.Add(label2, 0, 0);
            tableLayoutPanel2.Controls.Add(cmbxFilter, 1, 0);
            tableLayoutPanel2.Controls.Add(kryptonDateTimePicker1, 3, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(0, 0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(1312, 55);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // iconButton1
            // 
            iconButton1.BackColor = Color.FromArgb(230, 249, 255);
            iconButton1.Dock = DockStyle.Right;
            iconButton1.Enabled = false;
            iconButton1.FlatStyle = FlatStyle.Flat;
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.Calendar;
            iconButton1.IconColor = Color.Black;
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton1.IconSize = 38;
            iconButton1.Location = new Point(1009, 3);
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new Size(56, 49);
            iconButton1.TabIndex = 4;
            iconButton1.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Fill;
            label2.Font = new Font("Inter", 16.25F);
            label2.ForeColor = Color.FromArgb(24, 60, 114);
            label2.Location = new Point(3, 0);
            label2.Name = "label2";
            label2.Size = new Size(94, 55);
            label2.TabIndex = 1;
            label2.Text = "Filter:";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // cmbxFilter
            // 
            cmbxFilter.Dock = DockStyle.Fill;
            cmbxFilter.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbxFilter.DropDownWidth = 148;
            cmbxFilter.Items.AddRange(new object[] { "Cash In", "Payments" });
            cmbxFilter.Location = new Point(103, 3);
            cmbxFilter.Name = "cmbxFilter";
            cmbxFilter.Size = new Size(148, 49);
            cmbxFilter.StateCommon.ComboBox.Back.Color1 = Color.FromArgb(153, 229, 255);
            cmbxFilter.StateCommon.ComboBox.Content.Font = new Font("Inter", 13F);
            cmbxFilter.StateCommon.ComboBox.Content.Padding = new Padding(1);
            cmbxFilter.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            cmbxFilter.StateCommon.DropBack.Color1 = Color.White;
            cmbxFilter.StateCommon.DropBack.Color2 = Color.White;
            cmbxFilter.StateCommon.Item.Back.Color1 = Color.FromArgb(153, 229, 255);
            cmbxFilter.StateCommon.Item.Content.ShortText.Color1 = Color.FromArgb(24, 60, 114);
            cmbxFilter.StateCommon.Item.Content.ShortText.Font = new Font("Inter", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbxFilter.StateDisabled.Item.Content.ShortText.Font = new Font("Inter", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbxFilter.StateNormal.Item.Content.ShortText.Color1 = Color.FromArgb(24, 60, 114);
            cmbxFilter.StateNormal.Item.Content.ShortText.Font = new Font("Inter", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbxFilter.TabIndex = 2;
            cmbxFilter.TabStop = false;
            // 
            // pnlContainer
            // 
            pnlContainer.Controls.Add(tblVerification);
            pnlContainer.Dock = DockStyle.Fill;
            pnlContainer.Location = new Point(0, 125);
            pnlContainer.Name = "pnlContainer";
            pnlContainer.Size = new Size(1312, 642);
            pnlContainer.TabIndex = 5;
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
            // kryptonDateTimePicker1
            // 
            kryptonDateTimePicker1.Dock = DockStyle.Left;
            kryptonDateTimePicker1.Location = new Point(1071, 3);
            kryptonDateTimePicker1.Name = "kryptonDateTimePicker1";
            kryptonDateTimePicker1.Size = new Size(238, 49);
            kryptonDateTimePicker1.StateCommon.Back.Color1 = Color.FromArgb(153, 229, 255);
            kryptonDateTimePicker1.StateCommon.Content.Font = new Font("Inter Medium", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            kryptonDateTimePicker1.TabIndex = 5;
            kryptonDateTimePicker1.UpDownButtonStyle = Krypton.Toolkit.ButtonStyle.CalendarDay;
            // 
            // TransactionsAdmin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(230, 249, 255);
            Controls.Add(pnlContainer);
            Controls.Add(panel2);
            Controls.Add(panel1);
            ForeColor = Color.FromArgb(230, 249, 255);
            Name = "TransactionsAdmin";
            Size = new Size(1312, 767);
            panel1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)cmbxFilter).EndInit();
            pnlContainer.ResumeLayout(false);
            tblVerification.ResumeLayout(false);
            tblVerification.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TableLayoutPanel tableLayoutPanel1;
        private FontAwesome.Sharp.IconButton btnTrips;
        private FontAwesome.Sharp.IconButton btnTransactions;
        private Panel panel2;
        private TableLayoutPanel tableLayoutPanel2;
        private Panel pnlContainer;
        private TableLayoutPanel tblVerification;
        private Label lblHeader2;
        private Label label1;
        private Label label2;
        private Krypton.Toolkit.KryptonComboBox cmbxFilter;
        private FontAwesome.Sharp.IconButton iconButton1;
        private Krypton.Toolkit.KryptonDateTimePicker kryptonDateTimePicker1;
    }
}
