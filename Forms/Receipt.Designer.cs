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
            panel2 = new Panel();
            panel3 = new Panel();
            panel4 = new Panel();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox5 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
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
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(20, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(188, 92);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(pictureBox4);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(20, 101);
            panel2.Name = "panel2";
            panel2.Size = new Size(188, 92);
            panel2.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.Controls.Add(pictureBox3);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(214, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(180, 92);
            panel3.TabIndex = 2;
            // 
            // panel4
            // 
            panel4.Controls.Add(pictureBox5);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(214, 101);
            panel4.Name = "panel4";
            panel4.Size = new Size(180, 92);
            panel4.TabIndex = 3;
            // 
            // iconButton1
            // 
            iconButton1.Dock = DockStyle.Bottom;
            iconButton1.FlatAppearance.BorderSize = 0;
            iconButton1.FlatStyle = FlatStyle.Flat;
            iconButton1.Font = new Font("Inter Medium", 15F, FontStyle.Bold);
            iconButton1.ForeColor = Color.FromArgb(24, 60, 114);
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.Download;
            iconButton1.IconColor = Color.FromArgb(24, 60, 114);
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton1.IconSize = 40;
            iconButton1.ImageAlign = ContentAlignment.MiddleLeft;
            iconButton1.Location = new Point(0, 500);
            iconButton1.Name = "iconButton1";
            iconButton1.Padding = new Padding(95, 0, 0, 0);
            iconButton1.Size = new Size(416, 78);
            iconButton1.TabIndex = 59;
            iconButton1.Text = "         Get PDF Receipt";
            iconButton1.TextAlign = ContentAlignment.MiddleLeft;
            iconButton1.UseVisualStyleBackColor = true;
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
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Inter SemiBold", 16F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(24, 60, 114);
            label2.Location = new Point(12, 42);
            label2.Name = "label2";
            label2.Size = new Size(136, 31);
            label2.TabIndex = 2;
            label2.Text = "000000112";
            // 
            // Receipt
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(230, 249, 255);
            ClientSize = new Size(416, 578);
            Controls.Add(iconButton1);
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
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
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
        private FontAwesome.Sharp.IconButton iconButton1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox4;
        private PictureBox pictureBox3;
        private PictureBox pictureBox5;
        private Label label1;
        private Label label2;
    }
}