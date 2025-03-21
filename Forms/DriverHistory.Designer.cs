namespace NEXUS.Forms
{
    partial class DriverHistory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DriverHistory));
            spaceSeparatorHorizontal1 = new ReaLTaiizor.Controls.SpaceSeparatorHorizontal();
            label3 = new Label();
            label1 = new Label();
            dgvHistory = new DataGridView();
            cmbxFilter = new ComboBox();
            label2 = new Label();
            tbxJeepCode = new TextBox();
            pbIcon = new PictureBox();
            dtDate = new ReaLTaiizor.Controls.PoisonDateTime();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvHistory).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbIcon).BeginInit();
            SuspendLayout();
            // 
            // spaceSeparatorHorizontal1
            // 
            spaceSeparatorHorizontal1.Customization = "Kioq/yoqKv8jIyP/Kioq/w==";
            spaceSeparatorHorizontal1.Font = new Font("Verdana", 8F);
            spaceSeparatorHorizontal1.Image = null;
            spaceSeparatorHorizontal1.Location = new Point(12, 133);
            spaceSeparatorHorizontal1.Name = "spaceSeparatorHorizontal1";
            spaceSeparatorHorizontal1.NoRounding = false;
            spaceSeparatorHorizontal1.Size = new Size(930, 4);
            spaceSeparatorHorizontal1.TabIndex = 52;
            spaceSeparatorHorizontal1.Text = "spaceSeparatorHorizontal1";
            spaceSeparatorHorizontal1.Transparent = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(230, 249, 255);
            label3.Font = new Font("Inter", 14F);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(76, 58);
            label3.Name = "label3";
            label3.Size = new Size(830, 27);
            label3.TabIndex = 51;
            label3.Text = "This panel keeps track of all payments received for your trips along with passenger ratings,";
            // 
            // label1
            // 
            label1.Font = new Font("Inter ExtraBold", 21F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(38, 36, 68);
            label1.Location = new Point(12, 6);
            label1.Name = "label1";
            label1.Size = new Size(511, 44);
            label1.TabIndex = 50;
            label1.Text = "History";
            // 
            // dgvHistory
            // 
            dgvHistory.BackgroundColor = Color.FromArgb(153, 229, 255);
            dgvHistory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHistory.Location = new Point(30, 214);
            dgvHistory.Name = "dgvHistory";
            dgvHistory.Size = new Size(897, 470);
            dgvHistory.TabIndex = 53;
            // 
            // cmbxFilter
            // 
            cmbxFilter.BackColor = Color.FromArgb(176, 233, 255);
            cmbxFilter.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbxFilter.Font = new Font("Inter", 14.25F);
            cmbxFilter.ForeColor = Color.FromArgb(24, 60, 114);
            cmbxFilter.FormattingEnabled = true;
            cmbxFilter.Items.AddRange(new object[] { "Date", "Rate" });
            cmbxFilter.Location = new Point(109, 161);
            cmbxFilter.Name = "cmbxFilter";
            cmbxFilter.Size = new Size(219, 35);
            cmbxFilter.TabIndex = 55;
            cmbxFilter.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(230, 249, 255);
            label2.Font = new Font("Inter SemiBold", 17F, FontStyle.Bold);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(23, 162);
            label2.Name = "label2";
            label2.Size = new Size(78, 32);
            label2.TabIndex = 54;
            label2.Text = "Filter:";
            // 
            // tbxJeepCode
            // 
            tbxJeepCode.BorderStyle = BorderStyle.None;
            tbxJeepCode.Font = new Font("Inter", 16.25F);
            tbxJeepCode.ForeColor = Color.Silver;
            tbxJeepCode.Location = new Point(703, 161);
            tbxJeepCode.Name = "tbxJeepCode";
            tbxJeepCode.Size = new Size(239, 27);
            tbxJeepCode.TabIndex = 153;
            tbxJeepCode.Text = "Jeep Code";
            tbxJeepCode.Visible = false;
            // 
            // pbIcon
            // 
            pbIcon.BackColor = Color.FromArgb(230, 249, 255);
            pbIcon.Image = Properties.Resources.jeepcode;
            pbIcon.Location = new Point(631, 151);
            pbIcon.Name = "pbIcon";
            pbIcon.Size = new Size(58, 43);
            pbIcon.SizeMode = PictureBoxSizeMode.Zoom;
            pbIcon.TabIndex = 152;
            pbIcon.TabStop = false;
            pbIcon.Visible = false;
            // 
            // dtDate
            // 
            dtDate.CalendarFont = new Font("Inter", 16.25F);
            dtDate.CalendarMonthBackground = Color.FromArgb(176, 233, 255);
            dtDate.Location = new Point(703, 157);
            dtDate.MinimumSize = new Size(0, 29);
            dtDate.Name = "dtDate";
            dtDate.Size = new Size(239, 29);
            dtDate.TabIndex = 151;
            dtDate.Visible = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.FromArgb(230, 249, 255);
            label4.Font = new Font("Inter", 14F);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(12, 93);
            label4.Name = "label4";
            label4.Size = new Size(482, 27);
            label4.TabIndex = 154;
            label4.Text = "helping you monitor your earnings and performance.";
            // 
            // DriverHistory
            // 
            AutoScaleDimensions = new SizeF(10F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(230, 249, 255);
            ClientSize = new Size(972, 700);
            Controls.Add(label4);
            Controls.Add(tbxJeepCode);
            Controls.Add(pbIcon);
            Controls.Add(dtDate);
            Controls.Add(cmbxFilter);
            Controls.Add(label2);
            Controls.Add(dgvHistory);
            Controls.Add(spaceSeparatorHorizontal1);
            Controls.Add(label3);
            Controls.Add(label1);
            Font = new Font("Inter", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 5, 4, 5);
            Name = "DriverHistory";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DriverReport";
            ((System.ComponentModel.ISupportInitialize)dgvHistory).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbIcon).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ReaLTaiizor.Controls.SpaceSeparatorHorizontal spaceSeparatorHorizontal1;
        private Label label1;
        private DataGridView dgvHistory;
        private ComboBox cmbxFilter;
        private Label label2;
        private TextBox tbxJeepCode;
        private PictureBox pbIcon;
        private ReaLTaiizor.Controls.PoisonDateTime dtDate;
        protected internal Label label3;
        protected internal Label label4;
    }
}