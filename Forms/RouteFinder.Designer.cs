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
            label2 = new Label();
            cmbxJeepCodes = new ComboBox();
            pbJeepDestination = new PictureBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)pbJeepDestination).BeginInit();
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
            cmbxJeepCodes.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbxJeepCodes.Font = new Font("Inter", 15.25F);
            cmbxJeepCodes.ForeColor = Color.FromArgb(24, 60, 114);
            cmbxJeepCodes.FormattingEnabled = true;
            cmbxJeepCodes.Items.AddRange(new object[] { "01C", "01K", "02B", "03A", "03B", "03L", "03Q", "04B", "04H", "04I", "04L", "04M", "06B", "06C", "06G", "06H", "07B", "08F", "08G", "09C", "09F", "09G", "10F", "10G", "10H", "10M", "11A", "12D", "12I", "12L", "13B", "13C", "13H", "14D", "17B", "17C", "17D", "20A", "21A", "22A", "22D", "22I", "23", "23D", "62B", "MI-01A", "MI-02B", "MI-03A", "MI-03B", "MI-04A", "MI-04B", "MI-05A" });
            cmbxJeepCodes.Location = new Point(312, 216);
            cmbxJeepCodes.Name = "cmbxJeepCodes";
            cmbxJeepCodes.Size = new Size(186, 36);
            cmbxJeepCodes.TabIndex = 25;
            cmbxJeepCodes.TabStop = false;
            cmbxJeepCodes.SelectedIndexChanged += cmbxJeepCodes_SelectedIndexChanged;
            // 
            // pbJeepDestination
            // 
            pbJeepDestination.Image = Properties.Resources._default;
            pbJeepDestination.Location = new Point(85, 277);
            pbJeepDestination.Name = "pbJeepDestination";
            pbJeepDestination.Size = new Size(828, 425);
            pbJeepDestination.SizeMode = PictureBoxSizeMode.Zoom;
            pbJeepDestination.TabIndex = 0;
            pbJeepDestination.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(230, 249, 255);
            label3.Font = new Font("Inter", 14.25F);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(85, 68);
            label3.Name = "label3";
            label3.Size = new Size(778, 27);
            label3.TabIndex = 27;
            label3.Text = "Welcome to the NEXUS Route Finder! This panel helps you navigate the city with ease";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.FromArgb(230, 249, 255);
            label4.Font = new Font("Inter", 14.25F);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(85, 117);
            label4.Name = "label4";
            label4.Size = new Size(791, 27);
            label4.TabIndex = 28;
            label4.Text = "by providing the most efficient public utility vehicle (PUV) routes. Discover route codes";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.FromArgb(230, 249, 255);
            label5.Font = new Font("Inter", 14.25F);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(85, 164);
            label5.Name = "label5";
            label5.Size = new Size(532, 27);
            label5.TabIndex = 29;
            label5.Text = "and directions to plan your trip smoothly and conveniently";
            // 
            // RouteFinder
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(230, 249, 255);
            ClientSize = new Size(988, 739);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(pbJeepDestination);
            Controls.Add(cmbxJeepCodes);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "RouteFinder";
            Text = "RouteFinder";
            ((System.ComponentModel.ISupportInitialize)pbJeepDestination).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private ComboBox cmbxJeepCodes;
        private PictureBox pbJeepDestination;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}