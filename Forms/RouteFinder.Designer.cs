namespace NEXUS.Forms
{
    partial class RouteFinder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RouteFinder));
            label1 = new Label();
            cyberRichTextBox1 = new ReaLTaiizor.Controls.CyberRichTextBox();
            label2 = new Label();
            cmbxJeepCodes = new ComboBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Inter ExtraBold", 23F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(38, 36, 68);
            label1.Location = new Point(12, 3);
            label1.Name = "label1";
            label1.Size = new Size(282, 44);
            label1.TabIndex = 20;
            label1.Text = "ROUTE FINDER";
            // 
            // cyberRichTextBox1
            // 
            cyberRichTextBox1.Alpha = 20;
            cyberRichTextBox1.BackColor = Color.Transparent;
            cyberRichTextBox1.Background_WidthPen = 3F;
            cyberRichTextBox1.BackgroundPen = true;
            cyberRichTextBox1.ColorBackground = Color.FromArgb(37, 52, 68);
            cyberRichTextBox1.ColorBackground_Pen = Color.FromArgb(29, 200, 238);
            cyberRichTextBox1.ColorLighting = Color.FromArgb(29, 200, 238);
            cyberRichTextBox1.ColorPen_1 = Color.FromArgb(29, 200, 238);
            cyberRichTextBox1.ColorPen_2 = Color.FromArgb(37, 52, 68);
            cyberRichTextBox1.CyberRichTextBoxStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            cyberRichTextBox1.Font = new Font("Inter", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cyberRichTextBox1.ForeColor = Color.FromArgb(245, 245, 245);
            cyberRichTextBox1.Lighting = false;
            cyberRichTextBox1.LinearGradientPen = false;
            cyberRichTextBox1.Location = new Point(76, 66);
            cyberRichTextBox1.Name = "cyberRichTextBox1";
            cyberRichTextBox1.PenWidth = 15;
            cyberRichTextBox1.RGB = false;
            cyberRichTextBox1.Rounding = true;
            cyberRichTextBox1.RoundingInt = 60;
            cyberRichTextBox1.Size = new Size(837, 124);
            cyberRichTextBox1.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            cyberRichTextBox1.TabIndex = 21;
            cyberRichTextBox1.Tag = "Cyber";
            cyberRichTextBox1.TextButton = resources.GetString("cyberRichTextBox1.TextButton");
            cyberRichTextBox1.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            cyberRichTextBox1.Timer_RGB = 300;
            // 
            // label2
            // 
            label2.Font = new Font("Inter Medium", 18.25F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(38, 36, 68);
            label2.Location = new Point(76, 216);
            label2.Name = "label2";
            label2.Size = new Size(282, 44);
            label2.TabIndex = 22;
            label2.Text = "Jeepney Codes :";
            // 
            // cmbxJeepCodes
            // 
            cmbxJeepCodes.BackColor = Color.FromArgb(176, 233, 255);
            cmbxJeepCodes.Font = new Font("Inter", 15.25F);
            cmbxJeepCodes.ForeColor = Color.FromArgb(24, 60, 114);
            cmbxJeepCodes.FormattingEnabled = true;
            cmbxJeepCodes.Items.AddRange(new object[] { "01C", "01K", "02B", "03A", "03B", "03L", "03Q", "04B", "04H", "04I", "04L", "04M", "06B", "06C", "06G", "06H", "07B", "08F", "08G", "09C", "09F", "09G", "10F", "10G", "10H", "10M", "11A", "12D", "12I", "12L", "13B", "13C", "13H", "14D", "17B", "17C", "17D", "20A", "21A", "22A", "22D", "22I", "23", "23D", "62B", "MI-01A", "MI-02B", "MI-03A", "MI-03B", "MI-04A", "MI-04B", "MI-05A" });
            cmbxJeepCodes.Location = new Point(312, 216);
            cmbxJeepCodes.Name = "cmbxJeepCodes";
            cmbxJeepCodes.Size = new Size(186, 36);
            cmbxJeepCodes.TabIndex = 25;
            cmbxJeepCodes.SelectedIndexChanged += cmbxJeepCodes_SelectedIndexChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(85, 275);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(828, 425);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // RouteFinder
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(230, 249, 255);
            ClientSize = new Size(988, 739);
            Controls.Add(pictureBox1);
            Controls.Add(cmbxJeepCodes);
            Controls.Add(label2);
            Controls.Add(cyberRichTextBox1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "RouteFinder";
            Text = "RouteFinder";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private ReaLTaiizor.Controls.CyberRichTextBox cyberRichTextBox1;
        private Label label2;
        private ComboBox cmbxJeepCodes;
        private PictureBox pictureBox1;
    }
}