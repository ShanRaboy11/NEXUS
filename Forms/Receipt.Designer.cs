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
            spaceSeparatorVertical7 = new ReaLTaiizor.Controls.SpaceSeparatorVertical();
            spaceSeparatorHorizontal7 = new ReaLTaiizor.Controls.SpaceSeparatorHorizontal();
            spaceSeparatorVertical8 = new ReaLTaiizor.Controls.SpaceSeparatorVertical();
            spaceSeparatorHorizontal8 = new ReaLTaiizor.Controls.SpaceSeparatorHorizontal();
            spaceSeparatorVertical5 = new ReaLTaiizor.Controls.SpaceSeparatorVertical();
            spaceSeparatorHorizontal5 = new ReaLTaiizor.Controls.SpaceSeparatorHorizontal();
            spaceSeparatorVertical6 = new ReaLTaiizor.Controls.SpaceSeparatorVertical();
            spaceSeparatorHorizontal6 = new ReaLTaiizor.Controls.SpaceSeparatorHorizontal();
            spaceSeparatorVertical3 = new ReaLTaiizor.Controls.SpaceSeparatorVertical();
            spaceSeparatorHorizontal3 = new ReaLTaiizor.Controls.SpaceSeparatorHorizontal();
            spaceSeparatorVertical4 = new ReaLTaiizor.Controls.SpaceSeparatorVertical();
            spaceSeparatorHorizontal4 = new ReaLTaiizor.Controls.SpaceSeparatorHorizontal();
            spaceSeparatorVertical2 = new ReaLTaiizor.Controls.SpaceSeparatorVertical();
            spaceSeparatorHorizontal2 = new ReaLTaiizor.Controls.SpaceSeparatorHorizontal();
            spaceSeparatorVertical1 = new ReaLTaiizor.Controls.SpaceSeparatorVertical();
            spaceSeparatorHorizontal1 = new ReaLTaiizor.Controls.SpaceSeparatorHorizontal();
            lblRefNumber = new Label();
            label5 = new Label();
            label3 = new Label();
            lblDriver = new Label();
            label1 = new Label();
            lblPassenger = new Label();
            label6 = new Label();
            lblDT = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            pnlReceipt.SuspendLayout();
            SuspendLayout();
            // 
            // lblHeader
            // 
            lblHeader.AutoSize = true;
            lblHeader.Font = new Font("Inter ExtraBold", 18F, FontStyle.Bold);
            lblHeader.ForeColor = Color.FromArgb(24, 60, 114);
            lblHeader.Location = new Point(90, 71);
            lblHeader.Name = "lblHeader";
            lblHeader.Size = new Size(243, 35);
            lblHeader.TabIndex = 51;
            lblHeader.Text = "PAYMENT RECEIPT";
            lblHeader.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Removal_9151;
            pictureBox1.Location = new Point(188, 17);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(45, 45);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
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
            lblAmount.Font = new Font("Inter ExtraBold", 35F, FontStyle.Bold);
            lblAmount.ForeColor = Color.FromArgb(24, 60, 114);
            lblAmount.Location = new Point(12, 214);
            lblAmount.Name = "lblAmount";
            lblAmount.Size = new Size(391, 63);
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
            btnPDF.Location = new Point(0, 523);
            btnPDF.Margin = new Padding(3, 0, 3, 3);
            btnPDF.Name = "btnPDF";
            btnPDF.Padding = new Padding(95, 0, 0, 0);
            btnPDF.Size = new Size(416, 45);
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
            label2.Location = new Point(27, 112);
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
            pnlReceipt.Controls.Add(spaceSeparatorVertical7);
            pnlReceipt.Controls.Add(spaceSeparatorHorizontal7);
            pnlReceipt.Controls.Add(spaceSeparatorVertical8);
            pnlReceipt.Controls.Add(spaceSeparatorHorizontal8);
            pnlReceipt.Controls.Add(spaceSeparatorVertical5);
            pnlReceipt.Controls.Add(spaceSeparatorHorizontal5);
            pnlReceipt.Controls.Add(spaceSeparatorVertical6);
            pnlReceipt.Controls.Add(spaceSeparatorHorizontal6);
            pnlReceipt.Controls.Add(spaceSeparatorVertical3);
            pnlReceipt.Controls.Add(spaceSeparatorHorizontal3);
            pnlReceipt.Controls.Add(spaceSeparatorVertical4);
            pnlReceipt.Controls.Add(spaceSeparatorHorizontal4);
            pnlReceipt.Controls.Add(spaceSeparatorVertical2);
            pnlReceipt.Controls.Add(spaceSeparatorHorizontal2);
            pnlReceipt.Controls.Add(spaceSeparatorVertical1);
            pnlReceipt.Controls.Add(spaceSeparatorHorizontal1);
            pnlReceipt.Controls.Add(lblAmount);
            pnlReceipt.Controls.Add(lblRefNumber);
            pnlReceipt.Controls.Add(label5);
            pnlReceipt.Controls.Add(label3);
            pnlReceipt.Controls.Add(lblDriver);
            pnlReceipt.Controls.Add(label1);
            pnlReceipt.Controls.Add(lblPassenger);
            pnlReceipt.Controls.Add(label6);
            pnlReceipt.Controls.Add(lblDT);
            pnlReceipt.Location = new Point(0, 0);
            pnlReceipt.Name = "pnlReceipt";
            pnlReceipt.Size = new Size(416, 518);
            pnlReceipt.TabIndex = 62;
            // 
            // spaceSeparatorVertical7
            // 
            spaceSeparatorVertical7.Customization = "Kioq/yoqKv8jIyP/Kioq/w==";
            spaceSeparatorVertical7.Font = new Font("Verdana", 8F);
            spaceSeparatorVertical7.Image = null;
            spaceSeparatorVertical7.Location = new Point(215, 407);
            spaceSeparatorVertical7.Name = "spaceSeparatorVertical7";
            spaceSeparatorVertical7.NoRounding = false;
            spaceSeparatorVertical7.Size = new Size(4, 92);
            spaceSeparatorVertical7.TabIndex = 79;
            spaceSeparatorVertical7.Text = "spaceSeparatorVertical7";
            spaceSeparatorVertical7.Transparent = false;
            // 
            // spaceSeparatorHorizontal7
            // 
            spaceSeparatorHorizontal7.Customization = "Kioq/yoqKv8jIyP/Kioq/w==";
            spaceSeparatorHorizontal7.Font = new Font("Verdana", 8F);
            spaceSeparatorHorizontal7.Image = null;
            spaceSeparatorHorizontal7.Location = new Point(215, 495);
            spaceSeparatorHorizontal7.Name = "spaceSeparatorHorizontal7";
            spaceSeparatorHorizontal7.NoRounding = false;
            spaceSeparatorHorizontal7.Size = new Size(180, 4);
            spaceSeparatorHorizontal7.TabIndex = 78;
            spaceSeparatorHorizontal7.Text = "spaceSeparatorHorizontal7";
            spaceSeparatorHorizontal7.Transparent = false;
            // 
            // spaceSeparatorVertical8
            // 
            spaceSeparatorVertical8.Customization = "Kioq/yoqKv8jIyP/Kioq/w==";
            spaceSeparatorVertical8.Font = new Font("Verdana", 8F);
            spaceSeparatorVertical8.Image = null;
            spaceSeparatorVertical8.Location = new Point(391, 407);
            spaceSeparatorVertical8.Name = "spaceSeparatorVertical8";
            spaceSeparatorVertical8.NoRounding = false;
            spaceSeparatorVertical8.Size = new Size(4, 92);
            spaceSeparatorVertical8.TabIndex = 77;
            spaceSeparatorVertical8.Text = "spaceSeparatorVertical8";
            spaceSeparatorVertical8.Transparent = false;
            // 
            // spaceSeparatorHorizontal8
            // 
            spaceSeparatorHorizontal8.Customization = "Kioq/yoqKv8jIyP/Kioq/w==";
            spaceSeparatorHorizontal8.Font = new Font("Verdana", 8F);
            spaceSeparatorHorizontal8.Image = null;
            spaceSeparatorHorizontal8.Location = new Point(215, 407);
            spaceSeparatorHorizontal8.Name = "spaceSeparatorHorizontal8";
            spaceSeparatorHorizontal8.NoRounding = false;
            spaceSeparatorHorizontal8.Size = new Size(180, 4);
            spaceSeparatorHorizontal8.TabIndex = 76;
            spaceSeparatorHorizontal8.Text = "spaceSeparatorHorizontal8";
            spaceSeparatorHorizontal8.Transparent = false;
            // 
            // spaceSeparatorVertical5
            // 
            spaceSeparatorVertical5.Customization = "Kioq/yoqKv8jIyP/Kioq/w==";
            spaceSeparatorVertical5.Font = new Font("Verdana", 8F);
            spaceSeparatorVertical5.Image = null;
            spaceSeparatorVertical5.Location = new Point(20, 407);
            spaceSeparatorVertical5.Name = "spaceSeparatorVertical5";
            spaceSeparatorVertical5.NoRounding = false;
            spaceSeparatorVertical5.Size = new Size(4, 92);
            spaceSeparatorVertical5.TabIndex = 75;
            spaceSeparatorVertical5.Text = "spaceSeparatorVertical5";
            spaceSeparatorVertical5.Transparent = false;
            // 
            // spaceSeparatorHorizontal5
            // 
            spaceSeparatorHorizontal5.Customization = "Kioq/yoqKv8jIyP/Kioq/w==";
            spaceSeparatorHorizontal5.Font = new Font("Verdana", 8F);
            spaceSeparatorHorizontal5.Image = null;
            spaceSeparatorHorizontal5.Location = new Point(20, 495);
            spaceSeparatorHorizontal5.Name = "spaceSeparatorHorizontal5";
            spaceSeparatorHorizontal5.NoRounding = false;
            spaceSeparatorHorizontal5.Size = new Size(180, 4);
            spaceSeparatorHorizontal5.TabIndex = 74;
            spaceSeparatorHorizontal5.Text = "spaceSeparatorHorizontal5";
            spaceSeparatorHorizontal5.Transparent = false;
            // 
            // spaceSeparatorVertical6
            // 
            spaceSeparatorVertical6.Customization = "Kioq/yoqKv8jIyP/Kioq/w==";
            spaceSeparatorVertical6.Font = new Font("Verdana", 8F);
            spaceSeparatorVertical6.Image = null;
            spaceSeparatorVertical6.Location = new Point(196, 407);
            spaceSeparatorVertical6.Name = "spaceSeparatorVertical6";
            spaceSeparatorVertical6.NoRounding = false;
            spaceSeparatorVertical6.Size = new Size(4, 92);
            spaceSeparatorVertical6.TabIndex = 73;
            spaceSeparatorVertical6.Text = "spaceSeparatorVertical6";
            spaceSeparatorVertical6.Transparent = false;
            // 
            // spaceSeparatorHorizontal6
            // 
            spaceSeparatorHorizontal6.Customization = "Kioq/yoqKv8jIyP/Kioq/w==";
            spaceSeparatorHorizontal6.Font = new Font("Verdana", 8F);
            spaceSeparatorHorizontal6.Image = null;
            spaceSeparatorHorizontal6.Location = new Point(20, 407);
            spaceSeparatorHorizontal6.Name = "spaceSeparatorHorizontal6";
            spaceSeparatorHorizontal6.NoRounding = false;
            spaceSeparatorHorizontal6.Size = new Size(180, 4);
            spaceSeparatorHorizontal6.TabIndex = 72;
            spaceSeparatorHorizontal6.Text = "spaceSeparatorHorizontal6";
            spaceSeparatorHorizontal6.Transparent = false;
            // 
            // spaceSeparatorVertical3
            // 
            spaceSeparatorVertical3.Customization = "Kioq/yoqKv8jIyP/Kioq/w==";
            spaceSeparatorVertical3.Font = new Font("Verdana", 8F);
            spaceSeparatorVertical3.Image = null;
            spaceSeparatorVertical3.Location = new Point(215, 299);
            spaceSeparatorVertical3.Name = "spaceSeparatorVertical3";
            spaceSeparatorVertical3.NoRounding = false;
            spaceSeparatorVertical3.Size = new Size(4, 92);
            spaceSeparatorVertical3.TabIndex = 71;
            spaceSeparatorVertical3.Text = "spaceSeparatorVertical3";
            spaceSeparatorVertical3.Transparent = false;
            // 
            // spaceSeparatorHorizontal3
            // 
            spaceSeparatorHorizontal3.Customization = "Kioq/yoqKv8jIyP/Kioq/w==";
            spaceSeparatorHorizontal3.Font = new Font("Verdana", 8F);
            spaceSeparatorHorizontal3.Image = null;
            spaceSeparatorHorizontal3.Location = new Point(215, 387);
            spaceSeparatorHorizontal3.Name = "spaceSeparatorHorizontal3";
            spaceSeparatorHorizontal3.NoRounding = false;
            spaceSeparatorHorizontal3.Size = new Size(180, 4);
            spaceSeparatorHorizontal3.TabIndex = 70;
            spaceSeparatorHorizontal3.Text = "spaceSeparatorHorizontal3";
            spaceSeparatorHorizontal3.Transparent = false;
            // 
            // spaceSeparatorVertical4
            // 
            spaceSeparatorVertical4.Customization = "Kioq/yoqKv8jIyP/Kioq/w==";
            spaceSeparatorVertical4.Font = new Font("Verdana", 8F);
            spaceSeparatorVertical4.Image = null;
            spaceSeparatorVertical4.Location = new Point(391, 299);
            spaceSeparatorVertical4.Name = "spaceSeparatorVertical4";
            spaceSeparatorVertical4.NoRounding = false;
            spaceSeparatorVertical4.Size = new Size(4, 92);
            spaceSeparatorVertical4.TabIndex = 69;
            spaceSeparatorVertical4.Text = "spaceSeparatorVertical4";
            spaceSeparatorVertical4.Transparent = false;
            // 
            // spaceSeparatorHorizontal4
            // 
            spaceSeparatorHorizontal4.Customization = "Kioq/yoqKv8jIyP/Kioq/w==";
            spaceSeparatorHorizontal4.Font = new Font("Verdana", 8F);
            spaceSeparatorHorizontal4.Image = null;
            spaceSeparatorHorizontal4.Location = new Point(215, 299);
            spaceSeparatorHorizontal4.Name = "spaceSeparatorHorizontal4";
            spaceSeparatorHorizontal4.NoRounding = false;
            spaceSeparatorHorizontal4.Size = new Size(180, 4);
            spaceSeparatorHorizontal4.TabIndex = 68;
            spaceSeparatorHorizontal4.Text = "spaceSeparatorHorizontal4";
            spaceSeparatorHorizontal4.Transparent = false;
            // 
            // spaceSeparatorVertical2
            // 
            spaceSeparatorVertical2.Customization = "Kioq/yoqKv8jIyP/Kioq/w==";
            spaceSeparatorVertical2.Font = new Font("Verdana", 8F);
            spaceSeparatorVertical2.Image = null;
            spaceSeparatorVertical2.Location = new Point(20, 299);
            spaceSeparatorVertical2.Name = "spaceSeparatorVertical2";
            spaceSeparatorVertical2.NoRounding = false;
            spaceSeparatorVertical2.Size = new Size(4, 92);
            spaceSeparatorVertical2.TabIndex = 67;
            spaceSeparatorVertical2.Text = "spaceSeparatorVertical2";
            spaceSeparatorVertical2.Transparent = false;
            // 
            // spaceSeparatorHorizontal2
            // 
            spaceSeparatorHorizontal2.Customization = "Kioq/yoqKv8jIyP/Kioq/w==";
            spaceSeparatorHorizontal2.Font = new Font("Verdana", 8F);
            spaceSeparatorHorizontal2.Image = null;
            spaceSeparatorHorizontal2.Location = new Point(20, 387);
            spaceSeparatorHorizontal2.Name = "spaceSeparatorHorizontal2";
            spaceSeparatorHorizontal2.NoRounding = false;
            spaceSeparatorHorizontal2.Size = new Size(180, 4);
            spaceSeparatorHorizontal2.TabIndex = 66;
            spaceSeparatorHorizontal2.Text = "spaceSeparatorHorizontal2";
            spaceSeparatorHorizontal2.Transparent = false;
            // 
            // spaceSeparatorVertical1
            // 
            spaceSeparatorVertical1.Customization = "Kioq/yoqKv8jIyP/Kioq/w==";
            spaceSeparatorVertical1.Font = new Font("Verdana", 8F);
            spaceSeparatorVertical1.Image = null;
            spaceSeparatorVertical1.Location = new Point(196, 299);
            spaceSeparatorVertical1.Name = "spaceSeparatorVertical1";
            spaceSeparatorVertical1.NoRounding = false;
            spaceSeparatorVertical1.Size = new Size(4, 92);
            spaceSeparatorVertical1.TabIndex = 65;
            spaceSeparatorVertical1.Text = "spaceSeparatorVertical1";
            spaceSeparatorVertical1.Transparent = false;
            // 
            // spaceSeparatorHorizontal1
            // 
            spaceSeparatorHorizontal1.Customization = "Kioq/yoqKv8jIyP/Kioq/w==";
            spaceSeparatorHorizontal1.Font = new Font("Verdana", 8F);
            spaceSeparatorHorizontal1.Image = null;
            spaceSeparatorHorizontal1.Location = new Point(20, 299);
            spaceSeparatorHorizontal1.Name = "spaceSeparatorHorizontal1";
            spaceSeparatorHorizontal1.NoRounding = false;
            spaceSeparatorHorizontal1.Size = new Size(180, 4);
            spaceSeparatorHorizontal1.TabIndex = 63;
            spaceSeparatorHorizontal1.Text = "spaceSeparatorHorizontal1";
            spaceSeparatorHorizontal1.Transparent = false;
            // 
            // lblRefNumber
            // 
            lblRefNumber.Font = new Font("Inter SemiBold", 16F, FontStyle.Bold);
            lblRefNumber.ForeColor = Color.FromArgb(24, 60, 114);
            lblRefNumber.Location = new Point(31, 344);
            lblRefNumber.Name = "lblRefNumber";
            lblRefNumber.Size = new Size(159, 31);
            lblRefNumber.TabIndex = 2;
            lblRefNumber.Text = "000000112";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Inter", 12F);
            label5.Location = new Point(225, 420);
            label5.Name = "label5";
            label5.Size = new Size(56, 23);
            label5.TabIndex = 64;
            label5.Text = "Driver";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Inter", 12F);
            label3.Location = new Point(34, 420);
            label3.Name = "label3";
            label3.Size = new Size(88, 23);
            label3.TabIndex = 63;
            label3.Text = "Passenger";
            // 
            // lblDriver
            // 
            lblDriver.Font = new Font("Inter SemiBold", 16F, FontStyle.Bold);
            lblDriver.ForeColor = Color.FromArgb(24, 60, 114);
            lblDriver.Location = new Point(233, 453);
            lblDriver.Name = "lblDriver";
            lblDriver.Size = new Size(155, 31);
            lblDriver.TabIndex = 5;
            lblDriver.Text = "000000112";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Inter", 12F);
            label1.Location = new Point(225, 313);
            label1.Name = "label1";
            label1.Size = new Size(115, 23);
            label1.TabIndex = 63;
            label1.Text = "Payment Date";
            // 
            // lblPassenger
            // 
            lblPassenger.Font = new Font("Inter SemiBold", 16F, FontStyle.Bold);
            lblPassenger.ForeColor = Color.FromArgb(24, 60, 114);
            lblPassenger.Location = new Point(40, 453);
            lblPassenger.Name = "lblPassenger";
            lblPassenger.Size = new Size(152, 31);
            lblPassenger.TabIndex = 4;
            lblPassenger.Text = "Mikki Claver";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Inter", 12F);
            label6.Location = new Point(33, 313);
            label6.Name = "label6";
            label6.Size = new Size(100, 23);
            label6.TabIndex = 62;
            label6.Text = "Ref Number";
            // 
            // lblDT
            // 
            lblDT.Font = new Font("Inter SemiBold", 16F, FontStyle.Bold);
            lblDT.ForeColor = Color.FromArgb(24, 60, 114);
            lblDT.Location = new Point(223, 344);
            lblDT.Name = "lblDT";
            lblDT.Size = new Size(165, 31);
            lblDT.TabIndex = 3;
            lblDT.Text = "000000112";
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
        private Label lblPassenger;
        private Label label6;
        private Label lblDT;
        private ReaLTaiizor.Controls.SpaceSeparatorHorizontal spaceSeparatorHorizontal1;
        private ReaLTaiizor.Controls.SpaceSeparatorVertical spaceSeparatorVertical7;
        private ReaLTaiizor.Controls.SpaceSeparatorHorizontal spaceSeparatorHorizontal7;
        private ReaLTaiizor.Controls.SpaceSeparatorVertical spaceSeparatorVertical8;
        private ReaLTaiizor.Controls.SpaceSeparatorHorizontal spaceSeparatorHorizontal8;
        private ReaLTaiizor.Controls.SpaceSeparatorVertical spaceSeparatorVertical5;
        private ReaLTaiizor.Controls.SpaceSeparatorHorizontal spaceSeparatorHorizontal5;
        private ReaLTaiizor.Controls.SpaceSeparatorVertical spaceSeparatorVertical6;
        private ReaLTaiizor.Controls.SpaceSeparatorHorizontal spaceSeparatorHorizontal6;
        private ReaLTaiizor.Controls.SpaceSeparatorVertical spaceSeparatorVertical3;
        private ReaLTaiizor.Controls.SpaceSeparatorHorizontal spaceSeparatorHorizontal3;
        private ReaLTaiizor.Controls.SpaceSeparatorVertical spaceSeparatorVertical4;
        private ReaLTaiizor.Controls.SpaceSeparatorHorizontal spaceSeparatorHorizontal4;
        private ReaLTaiizor.Controls.SpaceSeparatorVertical spaceSeparatorVertical2;
        private ReaLTaiizor.Controls.SpaceSeparatorHorizontal spaceSeparatorHorizontal2;
        private ReaLTaiizor.Controls.SpaceSeparatorVertical spaceSeparatorVertical1;
    }
}