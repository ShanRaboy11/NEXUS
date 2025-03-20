namespace NEXUS.Forms
{
    partial class History
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(History));
            label1 = new Label();
            label3 = new Label();
            spaceSeparatorHorizontal1 = new ReaLTaiizor.Controls.SpaceSeparatorHorizontal();
            dtDate = new ReaLTaiizor.Controls.PoisonDateTime();
            label2 = new Label();
            dgvHistory = new DataGridView();
            cmbxFilter = new ComboBox();
            pbIcon = new PictureBox();
            tbxJeepCode = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvHistory).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbIcon).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Inter ExtraBold", 21F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(38, 36, 68);
            label1.Location = new Point(13, 14);
            label1.Name = "label1";
            label1.Size = new Size(511, 44);
            label1.TabIndex = 21;
            label1.Text = "Stay on top of your trips with ease!";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(230, 249, 255);
            label3.Font = new Font("Inter", 15F);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(77, 69);
            label3.Name = "label3";
            label3.Size = new Size(790, 28);
            label3.TabIndex = 45;
            label3.Text = "Easily access the details of your past journeys, including date, time, and location.";
            // 
            // spaceSeparatorHorizontal1
            // 
            spaceSeparatorHorizontal1.Customization = "Kioq/yoqKv8jIyP/Kioq/w==";
            spaceSeparatorHorizontal1.Font = new Font("Verdana", 8F);
            spaceSeparatorHorizontal1.Image = null;
            spaceSeparatorHorizontal1.Location = new Point(19, 111);
            spaceSeparatorHorizontal1.Name = "spaceSeparatorHorizontal1";
            spaceSeparatorHorizontal1.NoRounding = false;
            spaceSeparatorHorizontal1.Size = new Size(930, 4);
            spaceSeparatorHorizontal1.TabIndex = 49;
            spaceSeparatorHorizontal1.Text = "spaceSeparatorHorizontal1";
            spaceSeparatorHorizontal1.Transparent = false;
            // 
            // dtDate
            // 
            dtDate.CalendarFont = new Font("Inter", 16.25F);
            dtDate.CalendarMonthBackground = Color.FromArgb(176, 233, 255);
            dtDate.Location = new Point(699, 150);
            dtDate.MinimumSize = new Size(0, 29);
            dtDate.Name = "dtDate";
            dtDate.Size = new Size(239, 29);
            dtDate.TabIndex = 50;
            dtDate.Visible = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(230, 249, 255);
            label2.Font = new Font("Inter SemiBold", 17F, FontStyle.Bold);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(41, 147);
            label2.Name = "label2";
            label2.Size = new Size(78, 32);
            label2.TabIndex = 51;
            label2.Text = "Filter:";
            // 
            // dgvHistory
            // 
            dgvHistory.BackgroundColor = Color.FromArgb(153, 229, 255);
            dgvHistory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHistory.Location = new Point(41, 211);
            dgvHistory.Name = "dgvHistory";
            dgvHistory.Size = new Size(897, 470);
            dgvHistory.TabIndex = 52;
            dgvHistory.Visible = false;
            // 
            // cmbxFilter
            // 
            cmbxFilter.BackColor = Color.FromArgb(176, 233, 255);
            cmbxFilter.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbxFilter.Font = new Font("Inter", 14.25F);
            cmbxFilter.ForeColor = Color.FromArgb(24, 60, 114);
            cmbxFilter.FormattingEnabled = true;
            cmbxFilter.Items.AddRange(new object[] { "Date", "Jeep Code" });
            cmbxFilter.Location = new Point(127, 146);
            cmbxFilter.Name = "cmbxFilter";
            cmbxFilter.Size = new Size(219, 35);
            cmbxFilter.TabIndex = 53;
            cmbxFilter.TabStop = false;
            cmbxFilter.SelectedIndexChanged += cmbxFilter_SelectedIndexChanged;
            // 
            // pbIcon
            // 
            pbIcon.BackColor = Color.FromArgb(230, 249, 255);
            pbIcon.Image = Properties.Resources.jeepcode;
            pbIcon.Location = new Point(627, 144);
            pbIcon.Name = "pbIcon";
            pbIcon.Size = new Size(58, 43);
            pbIcon.SizeMode = PictureBoxSizeMode.Zoom;
            pbIcon.TabIndex = 149;
            pbIcon.TabStop = false;
            pbIcon.Visible = false;
            // 
            // tbxJeepCode
            // 
            tbxJeepCode.BorderStyle = BorderStyle.None;
            tbxJeepCode.Font = new Font("Inter", 16.25F);
            tbxJeepCode.ForeColor = Color.Silver;
            tbxJeepCode.Location = new Point(699, 154);
            tbxJeepCode.Name = "tbxJeepCode";
            tbxJeepCode.Size = new Size(239, 27);
            tbxJeepCode.TabIndex = 150;
            tbxJeepCode.Text = "Jeep Code";
            tbxJeepCode.Visible = false;
            tbxJeepCode.Click += tbxJeepCode_Click;
            // 
            // History
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(230, 249, 255);
            ClientSize = new Size(972, 700);
            Controls.Add(tbxJeepCode);
            Controls.Add(pbIcon);
            Controls.Add(cmbxFilter);
            Controls.Add(dgvHistory);
            Controls.Add(label2);
            Controls.Add(dtDate);
            Controls.Add(spaceSeparatorHorizontal1);
            Controls.Add(label3);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "History";
            Text = "History";
            ((System.ComponentModel.ISupportInitialize)dgvHistory).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbIcon).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label3;
        private ReaLTaiizor.Controls.SpaceSeparatorHorizontal spaceSeparatorHorizontal1;
        private ReaLTaiizor.Controls.PoisonDateTime dtDate;
        private Label label2;
        private DataGridView dgvHistory;
        private ComboBox cmbxFilter;
        private PictureBox pbIcon;
        private TextBox tbxJeepCode;
    }
}