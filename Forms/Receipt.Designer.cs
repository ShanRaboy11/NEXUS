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
            lblHeader = new Label();
            pictureBox1 = new PictureBox();
            line1 = new ReaLTaiizor.Controls.SpaceSeparatorHorizontal();
            lblAmount = new Label();
            btnPDF = new FontAwesome.Sharp.IconButton();
            pictureBox6 = new PictureBox();
            label2 = new Label();
            label4 = new Label();
            pnlReceipt = new Panel();
            lblRefNumber = new Label();
            label5 = new Label();
            label3 = new Label();
            lblDriver = new Label();
            label1 = new Label();
            pictureBox5 = new PictureBox();
            lblPassenger = new Label();
            label6 = new Label();
            pictureBox4 = new PictureBox();
            lblDT = new Label();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            pnlReceipt.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // lblHeader
            // 
            lblHeader.AutoSize = true;
            lblHeader.Font = new Font("Inter ExtraBold", 18F, FontStyle.Bold);
            lblHeader.ForeColor = Color.FromArgb(24, 60, 114);
            lblHeader.Location = new Point(97, 71);
            lblHeader.Name = "lblHeader";
            lblHeader.Size = new Size(243, 35);
            lblHeader.TabIndex = 51;
            lblHeader.Text = "PAYMENT RECEIPT";
            lblHeader.TextAlign = ContentAlignment.MiddleCenter;
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
            // line1
            // 
            line1.Customization = "Kioq/yoqKv8jIyP/Kioq/w==";
            line1.Font = new Font("Verdana", 8F);
            line1.Image = null;
            line1.Location = new Point(13, 161);
            line1.Name = "line1";
            line1.NoRounding = false;
            line1.Size = new Size(390, 4);
            line1.TabIndex = 55;
            line1.Text = "spaceSeparatorHorizontal1";
            line1.Transparent = false;
            // 
            // lblAmount
            // 
            lblAmount.Font = new Font("Inter ExtraBold", 33F, FontStyle.Bold);
            lblAmount.ForeColor = Color.FromArgb(24, 60, 114);
            lblAmount.Location = new Point(15, 214);
            lblAmount.Name = "lblAmount";
            lblAmount.Size = new Size(379, 63);
            lblAmount.TabIndex = 57;
            lblAmount.Text = "15.00";
            lblAmount.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnPDF
            // 
            btnPDF.FlatAppearance.BorderSize = 0;
            btnPDF.FlatStyle = FlatStyle.Flat;
            btnPDF.Font = new Font("Inter Medium", 15F, FontStyle.Bold);
            btnPDF.ForeColor = Color.FromArgb(24, 60, 114);
            btnPDF.IconChar = FontAwesome.Sharp.IconChar.Download;
            btnPDF.IconColor = Color.FromArgb(24, 60, 114);
            btnPDF.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnPDF.IconSize = 40;
            btnPDF.ImageAlign = ContentAlignment.MiddleLeft;
            btnPDF.Location = new Point(0, 514);
            btnPDF.Name = "btnPDF";
            btnPDF.Padding = new Padding(95, 0, 0, 0);
            btnPDF.Size = new Size(416, 59);
            btnPDF.TabIndex = 59;
            btnPDF.Text = "         Get PDF Receipt";
            btnPDF.TextAlign = ContentAlignment.MiddleLeft;
            btnPDF.UseVisualStyleBackColor = true;
            btnPDF.Click += btnPDF_Click;
            // 
            // pictureBox6
            // 
            pictureBox6.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(391, 7);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(20, 20);
            pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox6.TabIndex = 4;
            pictureBox6.TabStop = false;
            pictureBox6.Click += pictureBox6_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Inter", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(32, 112);
            label2.Name = "label2";
            label2.Size = new Size(363, 23);
            label2.TabIndex = 60;
            label2.Text = " You've successfully completed your payment.";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Inter", 13F);
            label4.Location = new Point(136, 189);
            label4.Name = "label4";
            label4.Size = new Size(133, 26);
            label4.TabIndex = 61;
            label4.Text = "Total Payment";
            // 
            // pnlReceipt
            // 
            pnlReceipt.Controls.Add(lblAmount);
            pnlReceipt.Controls.Add(lblRefNumber);
            pnlReceipt.Controls.Add(label5);
            pnlReceipt.Controls.Add(label3);
            pnlReceipt.Controls.Add(lblDriver);
            pnlReceipt.Controls.Add(label1);
            pnlReceipt.Controls.Add(pictureBox5);
            pnlReceipt.Controls.Add(lblPassenger);
            pnlReceipt.Controls.Add(label6);
            pnlReceipt.Controls.Add(pictureBox4);
            pnlReceipt.Controls.Add(lblDT);
            pnlReceipt.Controls.Add(pictureBox2);
            pnlReceipt.Controls.Add(pictureBox3);
            pnlReceipt.Location = new Point(0, 0);
            pnlReceipt.Name = "pnlReceipt";
            pnlReceipt.Size = new Size(416, 510);
            pnlReceipt.TabIndex = 62;
            // 
            // lblRefNumber
            // 
            lblRefNumber.Font = new Font("Inter SemiBold", 16F, FontStyle.Bold);
            lblRefNumber.ForeColor = Color.FromArgb(24, 60, 114);
            lblRefNumber.Location = new Point(32, 343);
            lblRefNumber.Name = "lblRefNumber";
            lblRefNumber.Size = new Size(159, 31);
            lblRefNumber.TabIndex = 2;
            lblRefNumber.Text = "000000112";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Inter", 12F);
            label5.Location = new Point(235, 416);
            label5.Name = "label5";
            label5.Size = new Size(56, 23);
            label5.TabIndex = 64;
            label5.Text = "Driver";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Inter", 12F);
            label3.Location = new Point(32, 416);
            label3.Name = "label3";
            label3.Size = new Size(88, 23);
            label3.TabIndex = 63;
            label3.Text = "Passenger";
            // 
            // lblDriver
            // 
            lblDriver.Font = new Font("Inter SemiBold", 16F, FontStyle.Bold);
            lblDriver.ForeColor = Color.FromArgb(24, 60, 114);
            lblDriver.Location = new Point(237, 447);
            lblDriver.Name = "lblDriver";
            lblDriver.Size = new Size(155, 31);
            lblDriver.TabIndex = 5;
            lblDriver.Text = "000000112";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Inter", 12F);
            label1.Location = new Point(232, 313);
            label1.Name = "label1";
            label1.Size = new Size(115, 23);
            label1.TabIndex = 63;
            label1.Text = "Payment Date";
            // 
            // pictureBox5
            // 
            pictureBox5.Image = Properties.Resources.roundcorner;
            pictureBox5.Location = new Point(220, 406);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(180, 92);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 1;
            pictureBox5.TabStop = false;
            // 
            // lblPassenger
            // 
            lblPassenger.Font = new Font("Inter SemiBold", 16F, FontStyle.Bold);
            lblPassenger.ForeColor = Color.FromArgb(24, 60, 114);
            lblPassenger.Location = new Point(39, 447);
            lblPassenger.Name = "lblPassenger";
            lblPassenger.Size = new Size(159, 31);
            lblPassenger.TabIndex = 4;
            lblPassenger.Text = "Mikki Claver";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Inter", 12F);
            label6.Location = new Point(31, 312);
            label6.Name = "label6";
            label6.Size = new Size(100, 23);
            label6.TabIndex = 62;
            label6.Text = "Ref Number";
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.roundcorner;
            pictureBox4.Location = new Point(18, 406);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(188, 92);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 1;
            pictureBox4.TabStop = false;
            // 
            // lblDT
            // 
            lblDT.Font = new Font("Inter SemiBold", 16F, FontStyle.Bold);
            lblDT.ForeColor = Color.FromArgb(24, 60, 114);
            lblDT.Location = new Point(226, 345);
            lblDT.Name = "lblDT";
            lblDT.Size = new Size(165, 31);
            lblDT.TabIndex = 3;
            lblDT.Text = "000000112";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.roundcorner;
            pictureBox2.Location = new Point(20, 302);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(188, 92);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.roundcorner;
            pictureBox3.Location = new Point(220, 303);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(180, 92);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 1;
            pictureBox3.TabStop = false;
            // 
            // Receipt
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(230, 249, 255);
            ClientSize = new Size(416, 578);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(pictureBox6);
            Controls.Add(line1);
            Controls.Add(pictureBox1);
            Controls.Add(lblHeader);
            Controls.Add(btnPDF);
            Controls.Add(pnlReceipt);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Receipt";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Receipt";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            pnlReceipt.ResumeLayout(false);
            pnlReceipt.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblHeader;
        private PictureBox pictureBox1;
        private ReaLTaiizor.Controls.SpaceSeparatorHorizontal line1;
        private Label lblAmount;
        private FontAwesome.Sharp.IconButton btnPDF;
        private PictureBox pictureBox6;
        private Label label2;
        private Label label4;
        private Panel pnlReceipt;
        private Label lblRefNumber;
        private Label label5;
        private Label label3;
        private Label lblDriver;
        private Label label1;
        private PictureBox pictureBox5;
        private Label lblPassenger;
        private Label label6;
        private PictureBox pictureBox4;
        private Label lblDT;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
    }
}