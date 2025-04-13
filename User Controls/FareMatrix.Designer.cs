namespace NEXUS.User_Controls
{
    partial class FareMatrix
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FareMatrix));
            pbAbout = new PictureBox();
            lblUserFName = new Label();
            spaceSeparatorHorizontal1 = new ReaLTaiizor.Controls.SpaceSeparatorHorizontal();
            label3 = new Label();
            richTextBox3 = new RichTextBox();
            richTextBox1 = new RichTextBox();
            label1 = new Label();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)pbAbout).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pbAbout
            // 
            pbAbout.Cursor = Cursors.Hand;
            pbAbout.Image = Properties.Resources.Removal_915;
            pbAbout.Location = new Point(6, 9);
            pbAbout.Name = "pbAbout";
            pbAbout.Size = new Size(58, 60);
            pbAbout.SizeMode = PictureBoxSizeMode.Zoom;
            pbAbout.TabIndex = 7;
            pbAbout.TabStop = false;
            // 
            // lblUserFName
            // 
            lblUserFName.AutoSize = true;
            lblUserFName.Font = new Font("Inter ExtraBold", 18F, FontStyle.Bold);
            lblUserFName.ForeColor = Color.FromArgb(24, 60, 114);
            lblUserFName.Location = new Point(75, 22);
            lblUserFName.Name = "lblUserFName";
            lblUserFName.Size = new Size(148, 35);
            lblUserFName.TabIndex = 34;
            lblUserFName.Text = "Fare Matrix";
            // 
            // spaceSeparatorHorizontal1
            // 
            spaceSeparatorHorizontal1.Customization = "Kioq/yoqKv8jIyP/Kioq/w==";
            spaceSeparatorHorizontal1.Font = new Font("Verdana", 8F);
            spaceSeparatorHorizontal1.Image = null;
            spaceSeparatorHorizontal1.Location = new Point(-49, 83);
            spaceSeparatorHorizontal1.Name = "spaceSeparatorHorizontal1";
            spaceSeparatorHorizontal1.NoRounding = false;
            spaceSeparatorHorizontal1.Size = new Size(315, 4);
            spaceSeparatorHorizontal1.TabIndex = 49;
            spaceSeparatorHorizontal1.Text = "spaceSeparatorHorizontal1";
            spaceSeparatorHorizontal1.Transparent = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Inter Medium", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(24, 60, 114);
            label3.Location = new Point(6, 377);
            label3.Name = "label3";
            label3.Size = new Size(350, 30);
            label3.TabIndex = 42;
            label3.Text = "Common Violations and Penalties";
            // 
            // richTextBox3
            // 
            richTextBox3.BackColor = Color.FromArgb(230, 249, 255);
            richTextBox3.BorderStyle = BorderStyle.None;
            richTextBox3.Font = new Font("Inter", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            richTextBox3.Location = new Point(22, 415);
            richTextBox3.Name = "richTextBox3";
            richTextBox3.ReadOnly = true;
            richTextBox3.Size = new Size(648, 203);
            richTextBox3.TabIndex = 40;
            richTextBox3.Text = resources.GetString("richTextBox3.Text");
            // 
            // richTextBox1
            // 
            richTextBox1.BackColor = Color.FromArgb(230, 249, 255);
            richTextBox1.BorderStyle = BorderStyle.None;
            richTextBox1.Font = new Font("Inter", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            richTextBox1.Location = new Point(22, 146);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.ReadOnly = true;
            richTextBox1.Size = new Size(648, 206);
            richTextBox1.TabIndex = 38;
            richTextBox1.Text = resources.GetString("richTextBox1.Text");
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Inter Medium", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(24, 60, 114);
            label1.Location = new Point(6, 109);
            label1.Name = "label1";
            label1.Size = new Size(401, 30);
            label1.TabIndex = 36;
            label1.Text = "Franchise and Operational Compliance";
            // 
            // panel1
            // 
            panel1.AutoScroll = true;
            panel1.Controls.Add(pbAbout);
            panel1.Controls.Add(lblUserFName);
            panel1.Controls.Add(spaceSeparatorHorizontal1);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(richTextBox3);
            panel1.Controls.Add(richTextBox1);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(690, 722);
            panel1.TabIndex = 36;
            // 
            // FareMatrix
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(230, 249, 255);
            Controls.Add(panel1);
            Name = "FareMatrix";
            Size = new Size(690, 722);
            ((System.ComponentModel.ISupportInitialize)pbAbout).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private PictureBox pbAbout;
        private Label lblUserFName;
        private ReaLTaiizor.Controls.SpaceSeparatorHorizontal spaceSeparatorHorizontal1;
        private Label label3;
        private RichTextBox richTextBox3;
        private RichTextBox richTextBox1;
        private Label label1;
        private Panel panel1;
    }
}
