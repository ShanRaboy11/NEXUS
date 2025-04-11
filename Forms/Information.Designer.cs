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
            btnFare = new FontAwesome.Sharp.IconButton();
            btnLTFRB = new FontAwesome.Sharp.IconButton();
            btnDrivers = new FontAwesome.Sharp.IconButton();
            btnPUV = new FontAwesome.Sharp.IconButton();
            btnPassengers = new FontAwesome.Sharp.IconButton();
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
            tableLayoutPanel1.Controls.Add(btnFare, 0, 0);
            tableLayoutPanel1.Controls.Add(btnLTFRB, 0, 0);
            tableLayoutPanel1.Controls.Add(btnDrivers, 0, 0);
            tableLayoutPanel1.Controls.Add(btnPUV, 0, 0);
            tableLayoutPanel1.Controls.Add(btnPassengers, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Top;
            tableLayoutPanel1.Location = new Point(0, 28);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(690, 40);
            tableLayoutPanel1.TabIndex = 21;
            // 
            // btnFare
            // 
            btnFare.Dock = DockStyle.Fill;
            btnFare.FlatAppearance.BorderSize = 0;
            btnFare.FlatStyle = FlatStyle.Flat;
            btnFare.Font = new Font("Inter Medium", 11F, FontStyle.Bold);
            btnFare.ForeColor = Color.Black;
            btnFare.IconChar = FontAwesome.Sharp.IconChar.None;
            btnFare.IconColor = Color.Black;
            btnFare.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnFare.ImageAlign = ContentAlignment.MiddleLeft;
            btnFare.Location = new Point(417, 3);
            btnFare.Name = "btnFare";
            btnFare.Size = new Size(132, 34);
            btnFare.TabIndex = 40;
            btnFare.Text = "Fare Matrix";
            btnFare.UseVisualStyleBackColor = true;
            btnFare.Click += btnFare_Click;
            // 
            // btnLTFRB
            // 
            btnLTFRB.Dock = DockStyle.Fill;
            btnLTFRB.FlatAppearance.BorderSize = 0;
            btnLTFRB.FlatStyle = FlatStyle.Flat;
            btnLTFRB.Font = new Font("Inter Medium", 11F, FontStyle.Bold);
            btnLTFRB.ForeColor = Color.Black;
            btnLTFRB.IconChar = FontAwesome.Sharp.IconChar.None;
            btnLTFRB.IconColor = Color.Black;
            btnLTFRB.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnLTFRB.ImageAlign = ContentAlignment.MiddleLeft;
            btnLTFRB.Location = new Point(555, 3);
            btnLTFRB.Name = "btnLTFRB";
            btnLTFRB.Size = new Size(132, 34);
            btnLTFRB.TabIndex = 39;
            btnLTFRB.Text = "LTFRB";
            btnLTFRB.UseVisualStyleBackColor = true;
            btnLTFRB.Click += btnLTFRB_Click;
            // 
            // btnDrivers
            // 
            btnDrivers.Dock = DockStyle.Fill;
            btnDrivers.FlatAppearance.BorderSize = 0;
            btnDrivers.FlatStyle = FlatStyle.Flat;
            btnDrivers.Font = new Font("Inter Medium", 11F, FontStyle.Bold);
            btnDrivers.ForeColor = Color.Black;
            btnDrivers.IconChar = FontAwesome.Sharp.IconChar.None;
            btnDrivers.IconColor = Color.Black;
            btnDrivers.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnDrivers.ImageAlign = ContentAlignment.MiddleLeft;
            btnDrivers.Location = new Point(279, 3);
            btnDrivers.Name = "btnDrivers";
            btnDrivers.Size = new Size(132, 34);
            btnDrivers.TabIndex = 38;
            btnDrivers.Text = "Drivers";
            btnDrivers.UseVisualStyleBackColor = true;
            btnDrivers.Click += btnDrivers_Click;
            // 
            // btnPUV
            // 
            btnPUV.Dock = DockStyle.Fill;
            btnPUV.FlatAppearance.BorderSize = 0;
            btnPUV.FlatStyle = FlatStyle.Flat;
            btnPUV.Font = new Font("Inter Medium", 11F, FontStyle.Bold);
            btnPUV.ForeColor = Color.Black;
            btnPUV.IconChar = FontAwesome.Sharp.IconChar.None;
            btnPUV.IconColor = Color.Black;
            btnPUV.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnPUV.ImageAlign = ContentAlignment.MiddleLeft;
            btnPUV.Location = new Point(3, 3);
            btnPUV.Name = "btnPUV";
            btnPUV.Size = new Size(132, 34);
            btnPUV.TabIndex = 37;
            btnPUV.Text = "PUV Laws";
            btnPUV.UseVisualStyleBackColor = true;
            btnPUV.Click += btnPUV_Click;
            // 
            // btnPassengers
            // 
            btnPassengers.Dock = DockStyle.Fill;
            btnPassengers.FlatAppearance.BorderSize = 0;
            btnPassengers.FlatStyle = FlatStyle.Flat;
            btnPassengers.Font = new Font("Inter Medium", 11F, FontStyle.Bold);
            btnPassengers.ForeColor = Color.Black;
            btnPassengers.IconChar = FontAwesome.Sharp.IconChar.None;
            btnPassengers.IconColor = Color.Black;
            btnPassengers.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnPassengers.ImageAlign = ContentAlignment.MiddleLeft;
            btnPassengers.Location = new Point(141, 3);
            btnPassengers.Name = "btnPassengers";
            btnPassengers.Size = new Size(132, 34);
            btnPassengers.TabIndex = 36;
            btnPassengers.Text = "Passengers";
            btnPassengers.UseVisualStyleBackColor = true;
            btnPassengers.Click += btnPassengers_Click;
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
        private FontAwesome.Sharp.IconButton btnFare;
        private FontAwesome.Sharp.IconButton btnLTFRB;
        private FontAwesome.Sharp.IconButton btnDrivers;
        private FontAwesome.Sharp.IconButton btnPUV;
        private FontAwesome.Sharp.IconButton btnPassengers;
    }
}