namespace NEXUS.User_Controls
{
    partial class LTFRB
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LTFRB));
            richTextBox3 = new RichTextBox();
            richTextBox1 = new RichTextBox();
            label1 = new Label();
            panel1 = new Panel();
            richTextBox5 = new RichTextBox();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // richTextBox3
            // 
            richTextBox3.BackColor = Color.FromArgb(230, 249, 255);
            richTextBox3.BorderStyle = BorderStyle.None;
            richTextBox3.Font = new Font("Inter", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            richTextBox3.Location = new Point(22, 470);
            richTextBox3.Name = "richTextBox3";
            richTextBox3.ReadOnly = true;
            richTextBox3.Size = new Size(648, 125);
            richTextBox3.TabIndex = 40;
            richTextBox3.Text = resources.GetString("richTextBox3.Text");
            // 
            // richTextBox1
            // 
            richTextBox1.BackColor = Color.FromArgb(230, 249, 255);
            richTextBox1.BorderStyle = BorderStyle.None;
            richTextBox1.Font = new Font("Inter", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            richTextBox1.Location = new Point(22, 230);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.ReadOnly = true;
            richTextBox1.Size = new Size(648, 224);
            richTextBox1.TabIndex = 38;
            richTextBox1.Text = resources.GetString("richTextBox1.Text");
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Inter Medium", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(24, 60, 114);
            label1.Location = new Point(18, 181);
            label1.Name = "label1";
            label1.Size = new Size(650, 30);
            label1.TabIndex = 36;
            label1.Text = "Land Transportation Franchising and Regulatory Board (LTFRB)";
            // 
            // panel1
            // 
            panel1.AutoScroll = true;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(richTextBox5);
            panel1.Controls.Add(richTextBox3);
            panel1.Controls.Add(richTextBox1);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(690, 722);
            panel1.TabIndex = 36;
            // 
            // richTextBox5
            // 
            richTextBox5.BackColor = Color.FromArgb(230, 249, 255);
            richTextBox5.BorderStyle = BorderStyle.None;
            richTextBox5.Font = new Font("Inter", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            richTextBox5.Location = new Point(22, 619);
            richTextBox5.Name = "richTextBox5";
            richTextBox5.ReadOnly = true;
            richTextBox5.Size = new Size(648, 81);
            richTextBox5.TabIndex = 45;
            richTextBox5.Text = resources.GetString("richTextBox5.Text");
            // 
            // pictureBox1
            // 
            pictureBox1.Cursor = Cursors.Hand;
            pictureBox1.Image = Properties.Resources.image_removebg_preview__12_;
            pictureBox1.Location = new Point(260, 23);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(161, 137);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 50;
            pictureBox1.TabStop = false;
            // 
            // LTFRB
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(230, 249, 255);
            Controls.Add(panel1);
            Name = "LTFRB";
            Size = new Size(690, 722);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private RichTextBox richTextBox3;
        private RichTextBox richTextBox1;
        private Label label1;
        private Panel panel1;
        private PictureBox pictureBox1;
        private RichTextBox richTextBox5;
    }
}
