namespace NEXUS.User_Controls
{
    partial class PassengersAdmin
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
            tableLayoutPanel1 = new TableLayoutPanel();
            btnCashIn = new FontAwesome.Sharp.IconButton();
            btnVerification = new FontAwesome.Sharp.IconButton();
            btnPassengers = new FontAwesome.Sharp.IconButton();
            panel1 = new Panel();
            pnlContainer = new Panel();
            tblVerification = new TableLayoutPanel();
            lblHeader2 = new Label();
            label1 = new Label();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            pnlContainer.SuspendLayout();
            tblVerification.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.FromArgb(230, 249, 255);
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 268F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 268F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 268F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 745F));
            tableLayoutPanel1.Controls.Add(btnCashIn, 0, 0);
            tableLayoutPanel1.Controls.Add(btnVerification, 0, 0);
            tableLayoutPanel1.Controls.Add(btnPassengers, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(1312, 70);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // btnCashIn
            // 
            btnCashIn.Dock = DockStyle.Fill;
            btnCashIn.FlatAppearance.BorderSize = 0;
            btnCashIn.FlatStyle = FlatStyle.Flat;
            btnCashIn.Font = new Font("Inter Medium", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCashIn.ForeColor = Color.Black;
            btnCashIn.IconChar = FontAwesome.Sharp.IconChar.None;
            btnCashIn.IconColor = Color.Black;
            btnCashIn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnCashIn.ImageAlign = ContentAlignment.MiddleLeft;
            btnCashIn.Location = new Point(539, 3);
            btnCashIn.Name = "btnCashIn";
            btnCashIn.Size = new Size(262, 64);
            btnCashIn.TabIndex = 36;
            btnCashIn.Text = "Cash In";
            btnCashIn.UseVisualStyleBackColor = true;
            btnCashIn.Click += btnCashIn_Click;
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
            btnVerification.Location = new Point(271, 3);
            btnVerification.Name = "btnVerification";
            btnVerification.Size = new Size(262, 64);
            btnVerification.TabIndex = 35;
            btnVerification.Text = "Verification";
            btnVerification.UseVisualStyleBackColor = true;
            btnVerification.Click += btnVerification_Click;
            // 
            // btnPassengers
            // 
            btnPassengers.Dock = DockStyle.Fill;
            btnPassengers.FlatAppearance.BorderSize = 0;
            btnPassengers.FlatStyle = FlatStyle.Flat;
            btnPassengers.Font = new Font("Inter Medium", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPassengers.ForeColor = Color.Black;
            btnPassengers.IconChar = FontAwesome.Sharp.IconChar.None;
            btnPassengers.IconColor = Color.Black;
            btnPassengers.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnPassengers.ImageAlign = ContentAlignment.MiddleLeft;
            btnPassengers.Location = new Point(3, 3);
            btnPassengers.Name = "btnPassengers";
            btnPassengers.Size = new Size(262, 64);
            btnPassengers.TabIndex = 34;
            btnPassengers.Text = "Passengers";
            btnPassengers.UseVisualStyleBackColor = true;
            btnPassengers.Click += btnPassengers_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(tableLayoutPanel1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1312, 70);
            panel1.TabIndex = 1;
            // 
            // pnlContainer
            // 
            pnlContainer.Controls.Add(tblVerification);
            pnlContainer.Dock = DockStyle.Fill;
            pnlContainer.Location = new Point(0, 70);
            pnlContainer.Name = "pnlContainer";
            pnlContainer.Size = new Size(1312, 697);
            pnlContainer.TabIndex = 2;
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
            tblVerification.Size = new Size(1312, 697);
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
            // PassengersAdmin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(230, 249, 255);
            Controls.Add(pnlContainer);
            Controls.Add(panel1);
            Name = "PassengersAdmin";
            Size = new Size(1312, 767);
            tableLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            pnlContainer.ResumeLayout(false);
            tblVerification.ResumeLayout(false);
            tblVerification.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel1;
        private Panel pnlContainer;
        private TableLayoutPanel tblVerification;
        private Label lblHeader2;
        private Label label1;
        private FontAwesome.Sharp.IconButton btnPassengers;
        private FontAwesome.Sharp.IconButton btnCashIn;
        private FontAwesome.Sharp.IconButton btnVerification;
    }
}
