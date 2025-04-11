namespace NEXUS.Forms
{
    partial class Information
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Information));
            pictureBox4 = new PictureBox();
            panel2 = new Panel();
            pbClose = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            pnlBG = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            btnLTFRB = new Button();
            btnFare = new Button();
            btnDrivers = new Button();
            btnPassengers = new Button();
            btnPUV = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbClose).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox4
            // 
            pictureBox4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(1453, 5);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(18, 18);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 3;
            pictureBox4.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(153, 229, 255);
            panel2.Controls.Add(pbClose);
            panel2.Controls.Add(pictureBox4);
            panel2.Controls.Add(pictureBox3);
            panel2.Controls.Add(pictureBox2);
            panel2.Controls.Add(pictureBox1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(690, 28);
            panel2.TabIndex = 19;
            // 
            // pbClose
            // 
            pbClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pbClose.Image = (Image)resources.GetObject("pbClose.Image");
            pbClose.Location = new Point(668, 6);
            pbClose.Name = "pbClose";
            pbClose.Size = new Size(18, 18);
            pbClose.SizeMode = PictureBoxSizeMode.Zoom;
            pbClose.TabIndex = 20;
            pbClose.TabStop = false;
            pbClose.Click += pbClose_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(2620, 6);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(14, 14);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 2;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(2589, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(19, 19);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(2647, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(18, 18);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pnlBG
            // 
            pnlBG.Dock = DockStyle.Fill;
            pnlBG.Location = new Point(0, 68);
            pnlBG.Name = "pnlBG";
            pnlBG.Size = new Size(690, 722);
            pnlBG.TabIndex = 20;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.White;
            tableLayoutPanel1.ColumnCount = 5;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Controls.Add(btnLTFRB, 4, 0);
            tableLayoutPanel1.Controls.Add(btnFare, 3, 0);
            tableLayoutPanel1.Controls.Add(btnDrivers, 2, 0);
            tableLayoutPanel1.Controls.Add(btnPassengers, 1, 0);
            tableLayoutPanel1.Controls.Add(btnPUV, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Top;
            tableLayoutPanel1.Location = new Point(0, 28);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(690, 40);
            tableLayoutPanel1.TabIndex = 21;
            // 
            // btnLTFRB
            // 
            btnLTFRB.Dock = DockStyle.Fill;
            btnLTFRB.FlatStyle = FlatStyle.Flat;
            btnLTFRB.Font = new Font("Inter", 11F);
            btnLTFRB.Location = new Point(555, 3);
            btnLTFRB.Name = "btnLTFRB";
            btnLTFRB.Size = new Size(132, 34);
            btnLTFRB.TabIndex = 4;
            btnLTFRB.Text = "LTFRB";
            btnLTFRB.UseVisualStyleBackColor = true;
            // 
            // btnFare
            // 
            btnFare.Dock = DockStyle.Fill;
            btnFare.FlatStyle = FlatStyle.Flat;
            btnFare.Font = new Font("Inter", 11F);
            btnFare.Location = new Point(417, 3);
            btnFare.Name = "btnFare";
            btnFare.Size = new Size(132, 34);
            btnFare.TabIndex = 3;
            btnFare.Text = "Fare Matrix";
            btnFare.UseVisualStyleBackColor = true;
            // 
            // btnDrivers
            // 
            btnDrivers.Dock = DockStyle.Fill;
            btnDrivers.FlatStyle = FlatStyle.Flat;
            btnDrivers.Font = new Font("Inter", 11F);
            btnDrivers.Location = new Point(279, 3);
            btnDrivers.Name = "btnDrivers";
            btnDrivers.Size = new Size(132, 34);
            btnDrivers.TabIndex = 2;
            btnDrivers.Text = "Drivers";
            btnDrivers.UseVisualStyleBackColor = true;
            // 
            // btnPassengers
            // 
            btnPassengers.Dock = DockStyle.Fill;
            btnPassengers.FlatStyle = FlatStyle.Flat;
            btnPassengers.Font = new Font("Inter", 11F);
            btnPassengers.Location = new Point(141, 3);
            btnPassengers.Name = "btnPassengers";
            btnPassengers.Size = new Size(132, 34);
            btnPassengers.TabIndex = 1;
            btnPassengers.Text = "Passengers";
            btnPassengers.UseVisualStyleBackColor = true;
            // 
            // btnPUV
            // 
            btnPUV.Dock = DockStyle.Fill;
            btnPUV.FlatStyle = FlatStyle.Flat;
            btnPUV.Font = new Font("Inter", 11F);
            btnPUV.Location = new Point(3, 3);
            btnPUV.Name = "btnPUV";
            btnPUV.Size = new Size(132, 34);
            btnPUV.TabIndex = 0;
            btnPUV.Text = "PUV Laws";
            btnPUV.UseVisualStyleBackColor = true;
            btnPUV.Click += btnPUV_Click;
            // 
            // Information
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(230, 249, 255);
            ClientSize = new Size(690, 790);
            Controls.Add(pnlBG);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Information";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Information";
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbClose).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox4;
        private Panel panel2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private PictureBox pbClose;
        private Panel pnlBG;
        private TableLayoutPanel tableLayoutPanel1;
        private Button btnPUV;
        private Button btnLTFRB;
        private Button btnFare;
        private Button btnDrivers;
        private Button btnPassengers;
    }
}