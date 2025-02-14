namespace NEXUS.Forms
{
    partial class About
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(About));
            pbNexus = new PictureBox();
            panel2 = new Panel();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            richTextBox1 = new RichTextBox();
            ((System.ComponentModel.ISupportInitialize)pbNexus).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pbNexus
            // 
            pbNexus.Image = Properties.Resources.NEXUS__1__removebg_preview__1_;
            pbNexus.Location = new Point(161, -14);
            pbNexus.Name = "pbNexus";
            pbNexus.Size = new Size(178, 237);
            pbNexus.SizeMode = PictureBoxSizeMode.Zoom;
            pbNexus.TabIndex = 2;
            pbNexus.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(153, 229, 255);
            panel2.Controls.Add(pictureBox3);
            panel2.Controls.Add(pictureBox2);
            panel2.Controls.Add(pictureBox1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(509, 34);
            panel2.TabIndex = 15;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(455, 11);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(14, 14);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 2;
            pictureBox3.TabStop = false;
            pictureBox3.Click += Maximize;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(424, 9);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(19, 19);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            pictureBox2.Click += Minimize;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(482, 9);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(18, 18);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += Close;
            // 
            // richTextBox1
            // 
            richTextBox1.BackColor = Color.FromArgb(230, 249, 255);
            richTextBox1.BorderStyle = BorderStyle.None;
            richTextBox1.Font = new Font("Inter", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            richTextBox1.ForeColor = Color.FromArgb(24, 60, 114);
            richTextBox1.Location = new Point(41, 174);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(428, 324);
            richTextBox1.TabIndex = 16;
            richTextBox1.TabStop = false;
            richTextBox1.Text = resources.GetString("richTextBox1.Text");
            // 
            // About
            // 
            AutoScaleDimensions = new SizeF(8F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(230, 249, 255);
            ClientSize = new Size(509, 525);
            Controls.Add(richTextBox1);
            Controls.Add(panel2);
            Controls.Add(pbNexus);
            Font = new Font("Inter", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            Name = "About";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "About";
            MouseDown += About_MouseDown;
            ((System.ComponentModel.ISupportInitialize)pbNexus).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private PictureBox pbNexus;
        private Panel panel2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private RichTextBox richTextBox1;
    }
}