namespace NEXUS.Forms
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            pictureBox6 = new PictureBox();
            pbMap = new PictureBox();
            label1 = new Label();
            panel1 = new Panel();
            pbLaws = new PictureBox();
            label2 = new Label();
            panel3 = new Panel();
            panel2 = new Panel();
            label3 = new Label();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbMap).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbLaws).BeginInit();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox6
            // 
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(4, -5);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(980, 243);
            pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox6.TabIndex = 34;
            pictureBox6.TabStop = false;
            // 
            // pbMap
            // 
            pbMap.Cursor = Cursors.Hand;
            pbMap.Image = (Image)resources.GetObject("pbMap.Image");
            pbMap.Location = new Point(41, 59);
            pbMap.Name = "pbMap";
            pbMap.Size = new Size(828, 223);
            pbMap.TabIndex = 35;
            pbMap.TabStop = false;
            pbMap.Click += pbMap_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.Font = new Font("Inter SemiBold", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(38, 36, 68);
            label1.Location = new Point(1, 1);
            label1.Name = "label1";
            label1.Size = new Size(85, 55);
            label1.TabIndex = 36;
            label1.Text = "Map";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(pbLaws);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(42, 250);
            panel1.Name = "panel1";
            panel1.Size = new Size(445, 275);
            panel1.TabIndex = 37;
            // 
            // pbLaws
            // 
            pbLaws.Cursor = Cursors.Hand;
            pbLaws.Image = (Image)resources.GetObject("pbLaws.Image");
            pbLaws.Location = new Point(21, 56);
            pbLaws.Name = "pbLaws";
            pbLaws.Size = new Size(398, 195);
            pbLaws.SizeMode = PictureBoxSizeMode.Zoom;
            pbLaws.TabIndex = 38;
            pbLaws.TabStop = false;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label2.Font = new Font("Inter SemiBold", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(38, 36, 68);
            label2.Location = new Point(2, 1);
            label2.Name = "label2";
            label2.Size = new Size(252, 45);
            label2.TabIndex = 37;
            label2.Text = "Information Panel";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(153, 229, 255);
            panel3.Controls.Add(pbMap);
            panel3.Controls.Add(label1);
            panel3.Location = new Point(42, 547);
            panel3.Name = "panel3";
            panel3.Size = new Size(910, 193);
            panel3.TabIndex = 38;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(label3);
            panel2.Controls.Add(pictureBox2);
            panel2.Location = new Point(507, 250);
            panel2.Name = "panel2";
            panel2.Size = new Size(445, 275);
            panel2.TabIndex = 38;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label3.Font = new Font("Inter SemiBold", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(38, 36, 68);
            label3.Location = new Point(1, 2);
            label3.Name = "label3";
            label3.Size = new Size(141, 45);
            label3.TabIndex = 39;
            label3.Text = "Weather";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox2
            // 
            pictureBox2.Cursor = Cursors.Hand;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(27, 56);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(398, 195);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 39;
            pictureBox2.TabStop = false;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(230, 249, 255);
            ClientSize = new Size(988, 739);
            Controls.Add(panel2);
            Controls.Add(panel3);
            Controls.Add(pictureBox6);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Home";
            Text = "Home";
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbMap).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbLaws).EndInit();
            panel3.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox6;
        private PictureBox pbMap;
        private Label label1;
        private Panel panel3;
        private Panel panel2;
        private PictureBox pbLaws;
        private Label label2;
        private PictureBox pictureBox2;
        private Label label3;
    }
}