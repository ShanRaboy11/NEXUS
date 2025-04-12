namespace NEXUS.Forms
{
    partial class Receipt
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Receipt));
            lblUserFName = new Label();
            richTextBox5 = new RichTextBox();
            pictureBox1 = new PictureBox();
            spaceSeparatorHorizontal1 = new ReaLTaiizor.Controls.SpaceSeparatorHorizontal();
            richTextBox1 = new RichTextBox();
            lblAmount = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel1 = new Panel();
            lblRefNumber = new Label();
            label1 = new Label();
            pictureBox2 = new PictureBox();
            panel2 = new Panel();
            pictureBox4 = new PictureBox();
            panel3 = new Panel();
            pictureBox3 = new PictureBox();
            panel4 = new Panel();
            pictureBox5 = new PictureBox();
            btnPDF = new FontAwesome.Sharp.IconButton();
            label3 = new Label();
            lblDT = new Label();
            label5 = new Label();
            lblPassenger = new Label();
            label7 = new Label();
            lblDriver = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            SuspendLayout();
            // 
            // lblUserFName
            // 
            lblUserFName.AutoSize = true;
            lblUserFName.Font = new Font("Inter ExtraBold", 18F, FontStyle.Bold);
            lblUserFName.ForeColor = Color.FromArgb(24, 60, 114);
            lblUserFName.Location = new Point(97, 71);
            lblUserFName.Name = "lblUserFName";
            lblUserFName.Size = new Size(243, 35);
            lblUserFName.TabIndex = 51;
            lblUserFName.Text = "PAYMENT RECEIPT";
            lblUserFName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // richTextBox5
            // 
            richTextBox5.BackColor = Color.FromArgb(230, 249, 255);
            richTextBox5.BorderStyle = BorderStyle.None;
            richTextBox5.Font = new Font("Inter", 12F);
            richTextBox5.Location = new Point(26, 115);
            richTextBox5.Name = "richTextBox5";
            richTextBox5.ReadOnly = true;
            richTextBox5.Size = new Size(366, 27);
            richTextBox5.TabIndex = 53;
            richTextBox5.Text = " You've successfully completed your payment.";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Untitled_design__3_;
            pictureBox1.Location = new Point(193, 16);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(42, 42);
            pictureBox1.TabIndex = 54;
            pictureBox1.TabStop = false;
            // 
            // spaceSeparatorHorizontal1
            // 
            spaceSeparatorHorizontal1.Customization = "Kioq/yoqKv8jIyP/Kioq/w==";
            spaceSeparatorHorizontal1.Font = new Font("Verdana", 8F);
            spaceSeparatorHorizontal1.Image = null;
            spaceSeparatorHorizontal1.Location = new Point(13, 161);
            spaceSeparatorHorizontal1.Name = "spaceSeparatorHorizontal1";
            spaceSeparatorHorizontal1.NoRounding = false;
            spaceSeparatorHorizontal1.Size = new Size(390, 4);
            spaceSeparatorHorizontal1.TabIndex = 55;
            spaceSeparatorHorizontal1.Text = "spaceSeparatorHorizontal1";
            spaceSeparatorHorizontal1.Transparent = false;
            // 
            // richTextBox1
            // 
            richTextBox1.BackColor = Color.FromArgb(230, 249, 255);
            richTextBox1.BorderStyle = BorderStyle.None;
            richTextBox1.Font = new Font("Inter", 14F);
            richTextBox1.Location = new Point(139, 203);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.ReadOnly = true;
            richTextBox1.Size = new Size(159, 27);
            richTextBox1.TabIndex = 56;
            richTextBox1.Text = "Total Payment";
            // 
            // lblAmount
            // 
            lblAmount.Font = new Font("Inter ExtraBold", 22F, FontStyle.Bold);
            lblAmount.ForeColor = Color.FromArgb(24, 60, 114);
            lblAmount.Location = new Point(16, 220);
            lblAmount.Name = "lblAmount";
            lblAmount.Size = new Size(379, 63);
            lblAmount.TabIndex = 57;
            lblAmount.Text = "PAYMENT RECEIPT";
            lblAmount.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 8.133971F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 91.86603F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 186F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Controls.Add(panel1, 1, 0);
            tableLayoutPanel1.Controls.Add(panel2, 1, 1);
            tableLayoutPanel1.Controls.Add(panel3, 2, 0);
            tableLayoutPanel1.Controls.Add(panel4, 2, 1);
            tableLayoutPanel1.Location = new Point(0, 301);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(418, 196);
            tableLayoutPanel1.TabIndex = 58;
            // 
            // panel1
            // 
            panel1.Controls.Add(lblRefNumber);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(20, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(188, 92);
            panel1.TabIndex = 0;
            // 
            // lblRefNumber
            // 
            lblRefNumber.Font = new Font("Inter SemiBold", 16F, FontStyle.Bold);
            lblRefNumber.ForeColor = Color.FromArgb(24, 60, 114);
            lblRefNumber.Location = new Point(12, 42);
            lblRefNumber.Name = "lblRefNumber";
            lblRefNumber.Size = new Size(159, 31);
            lblRefNumber.TabIndex = 2;
            lblRefNumber.Text = "000000112";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Inter", 10.75F);
            label1.Location = new Point(11, 11);
            label1.Name = "label1";
            label1.Size = new Size(96, 22);
            label1.TabIndex = 1;
            label1.Text = "Ref Number";
            // 
            // pictureBox2
            // 
            pictureBox2.Dock = DockStyle.Fill;
            pictureBox2.Image = Properties.Resources.roundcorner;
            pictureBox2.Location = new Point(0, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(188, 92);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // panel2
            // 
            panel2.Controls.Add(lblPassenger);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(pictureBox4);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(20, 101);
            panel2.Name = "panel2";
            panel2.Size = new Size(188, 92);
            panel2.TabIndex = 1;
            // 
            // pictureBox4
            // 
            pictureBox4.Dock = DockStyle.Fill;
            pictureBox4.Image = Properties.Resources.roundcorner;
            pictureBox4.Location = new Point(0, 0);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(188, 92);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 1;
            pictureBox4.TabStop = false;
            // 
            // panel3
            // 
            panel3.Controls.Add(lblDT);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(pictureBox3);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(214, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(180, 92);
            panel3.TabIndex = 2;
            // 
            // pictureBox3
            // 
            pictureBox3.Dock = DockStyle.Fill;
            pictureBox3.Image = Properties.Resources.roundcorner;
            pictureBox3.Location = new Point(0, 0);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(180, 92);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 1;
            pictureBox3.TabStop = false;
            // 
            // panel4
            // 
            panel4.Controls.Add(lblDriver);
            panel4.Controls.Add(label7);
            panel4.Controls.Add(pictureBox5);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(214, 101);
            panel4.Name = "panel4";
            panel4.Size = new Size(180, 92);
            panel4.TabIndex = 3;
            // 
            // pictureBox5
            // 
            pictureBox5.Dock = DockStyle.Fill;
            pictureBox5.Image = Properties.Resources.roundcorner;
            pictureBox5.Location = new Point(0, 0);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(180, 92);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 1;
            pictureBox5.TabStop = false;
            // 
            // btnPDF
            // 
            btnPDF.Dock = DockStyle.Bottom;
            btnPDF.FlatAppearance.BorderSize = 0;
            btnPDF.FlatStyle = FlatStyle.Flat;
            btnPDF.Font = new Font("Inter Medium", 15F, FontStyle.Bold);
            btnPDF.ForeColor = Color.FromArgb(24, 60, 114);
            btnPDF.IconChar = FontAwesome.Sharp.IconChar.Download;
            btnPDF.IconColor = Color.FromArgb(24, 60, 114);
            btnPDF.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnPDF.IconSize = 40;
            btnPDF.ImageAlign = ContentAlignment.MiddleLeft;
            btnPDF.Location = new Point(0, 500);
            btnPDF.Name = "btnPDF";
            btnPDF.Padding = new Padding(95, 0, 0, 0);
            btnPDF.Size = new Size(416, 78);
            btnPDF.TabIndex = 59;
            btnPDF.Text = "         Get PDF Receipt";
            btnPDF.TextAlign = ContentAlignment.MiddleLeft;
            btnPDF.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Inter", 10.75F);
            label3.Location = new Point(12, 11);
            label3.Name = "label3";
            label3.Size = new Size(112, 22);
            label3.TabIndex = 2;
            label3.Text = "Payment Time";
            // 
            // lblDT
            // 
            lblDT.Font = new Font("Inter SemiBold", 16F, FontStyle.Bold);
            lblDT.ForeColor = Color.FromArgb(24, 60, 114);
            lblDT.Location = new Point(6, 42);
            lblDT.Name = "lblDT";
            lblDT.Size = new Size(165, 31);
            lblDT.TabIndex = 3;
            lblDT.Text = "000000112";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Inter", 10.75F);
            label5.Location = new Point(12, 11);
            label5.Name = "label5";
            label5.Size = new Size(86, 22);
            label5.TabIndex = 3;
            label5.Text = "Passenger";
            // 
            // lblPassenger
            // 
            lblPassenger.Font = new Font("Inter SemiBold", 16F, FontStyle.Bold);
            lblPassenger.ForeColor = Color.FromArgb(24, 60, 114);
            lblPassenger.Location = new Point(12, 41);
            lblPassenger.Name = "lblPassenger";
            lblPassenger.Size = new Size(165, 31);
            lblPassenger.TabIndex = 4;
            lblPassenger.Text = "000000112";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Inter", 10.75F);
            label7.Location = new Point(12, 11);
            label7.Name = "label7";
            label7.Size = new Size(54, 22);
            label7.TabIndex = 4;
            label7.Text = "Driver";
            // 
            // lblDriver
            // 
            lblDriver.Font = new Font("Inter SemiBold", 16F, FontStyle.Bold);
            lblDriver.ForeColor = Color.FromArgb(24, 60, 114);
            lblDriver.Location = new Point(7, 41);
            lblDriver.Name = "lblDriver";
            lblDriver.Size = new Size(165, 31);
            lblDriver.TabIndex = 5;
            lblDriver.Text = "000000112";
            // 
            // Receipt
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(230, 249, 255);
            ClientSize = new Size(416, 578);
            Controls.Add(btnPDF);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(richTextBox1);
            Controls.Add(spaceSeparatorHorizontal1);
            Controls.Add(pictureBox1);
            Controls.Add(richTextBox5);
            Controls.Add(lblUserFName);
            Controls.Add(lblAmount);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Receipt";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Receipt";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblUserFName;
        private RichTextBox richTextBox5;
        private PictureBox pictureBox1;
        private ReaLTaiizor.Controls.SpaceSeparatorHorizontal spaceSeparatorHorizontal1;
        private RichTextBox richTextBox1;
        private Label lblAmount;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private FontAwesome.Sharp.IconButton btnPDF;
        private PictureBox pictureBox2;
        private PictureBox pictureBox4;
        private PictureBox pictureBox3;
        private PictureBox pictureBox5;
        private Label label1;
        private Label lblRefNumber;
        private Label lblPassenger;
        private Label label5;
        private Label lblDT;
        private Label label3;
        private Label lblDriver;
        private Label label7;
    }
}