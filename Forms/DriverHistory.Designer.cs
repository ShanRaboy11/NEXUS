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
            cmbxFilter = new ComboBox();
            label2 = new Label();
            pbIcon = new PictureBox();
            dtDate = new ReaLTaiizor.Controls.PoisonDateTime();
            label4 = new Label();
            pbEmpty = new PictureBox();
            dgvDriverHistory = new Krypton.Toolkit.KryptonDataGridView();
            ((System.ComponentModel.ISupportInitialize)pbIcon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbEmpty).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvDriverHistory).BeginInit();
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
            cmbxFilter.SelectedIndexChanged += cmbxFilter_SelectedIndexChanged;
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
            // pbIcon
            // 
            pbIcon.BackColor = Color.FromArgb(230, 249, 255);
            pbIcon.Image = Properties.Resources._115762_calendar_date_event_month_icon;
            pbIcon.Location = new Point(631, 154);
            pbIcon.Name = "pbIcon";
            pbIcon.Size = new Size(58, 43);
            pbIcon.SizeMode = PictureBoxSizeMode.Zoom;
            pbIcon.TabIndex = 152;
            pbIcon.TabStop = false;
            pbIcon.Visible = false;
            // 
            // dtDate
            // 
            dtDate.CalendarFont = new Font("Inter", 18.25F);
            dtDate.CalendarMonthBackground = Color.FromArgb(176, 233, 255);
            dtDate.FontSize = ReaLTaiizor.Extension.Poison.PoisonDateTimeSize.Tall;
            dtDate.Location = new Point(703, 159);
            dtDate.MinimumSize = new Size(0, 35);
            dtDate.Name = "dtDate";
            dtDate.Size = new Size(226, 35);
            dtDate.TabIndex = 151;
            dtDate.Visible = false;
            dtDate.ValueChanged += dtDate_ValueChanged;
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
            // pbEmpty
            // 
            pbEmpty.Image = (Image)resources.GetObject("pbEmpty.Image");
            pbEmpty.Location = new Point(32, 220);
            pbEmpty.Name = "pbEmpty";
            pbEmpty.Size = new Size(897, 452);
            pbEmpty.TabIndex = 155;
            pbEmpty.TabStop = false;
            pbEmpty.Visible = false;
            // 
            // dgvDriverHistory
            // 
            dgvDriverHistory.BorderStyle = BorderStyle.None;
            dgvDriverHistory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDriverHistory.HideOuterBorders = true;
            dgvDriverHistory.Location = new Point(32, 220);
            dgvDriverHistory.Name = "dgvDriverHistory";
            dgvDriverHistory.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007BlueLightMode;
            dgvDriverHistory.ReadOnly = true;
            dgvDriverHistory.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDriverHistory.ShowEditingIcon = false;
            dgvDriverHistory.Size = new Size(897, 452);
            dgvDriverHistory.StateCommon.Background.Color1 = Color.FromArgb(230, 249, 255);
            dgvDriverHistory.StateCommon.Background.Color2 = Color.FromArgb(153, 229, 255);
            dgvDriverHistory.StateCommon.BackStyle = Krypton.Toolkit.PaletteBackStyle.GridBackgroundList;
            dgvDriverHistory.StateCommon.DataCell.Back.Color1 = Color.FromArgb(153, 229, 255);
            dgvDriverHistory.StateCommon.DataCell.Border.Color1 = Color.White;
            dgvDriverHistory.StateCommon.DataCell.Border.Color2 = Color.White;
            dgvDriverHistory.StateCommon.DataCell.Content.Color1 = Color.FromArgb(24, 60, 114);
            dgvDriverHistory.StateCommon.DataCell.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            dgvDriverHistory.StateCommon.DataCell.Content.TextV = Krypton.Toolkit.PaletteRelativeAlign.Center;
            dgvDriverHistory.StateCommon.HeaderColumn.Back.Color1 = Color.FromArgb(38, 36, 68);
            dgvDriverHistory.StateCommon.HeaderColumn.Back.Color2 = Color.FromArgb(38, 36, 68);
            dgvDriverHistory.StateCommon.HeaderColumn.Border.Color1 = Color.White;
            dgvDriverHistory.StateCommon.HeaderColumn.Border.Color2 = Color.White;
            dgvDriverHistory.StateCommon.HeaderColumn.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            dgvDriverHistory.StateCommon.HeaderColumn.Content.TextV = Krypton.Toolkit.PaletteRelativeAlign.Center;
            dgvDriverHistory.StateSelected.DataCell.Back.Color1 = Color.FromArgb(0, 229, 255);
            dgvDriverHistory.StateSelected.DataCell.Back.Color2 = Color.FromArgb(0, 229, 255);
            dgvDriverHistory.TabIndex = 156;
            // 
            // DriverHistory
            // 
            AutoScaleDimensions = new SizeF(10F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(230, 249, 255);
            ClientSize = new Size(972, 700);
            Controls.Add(pbEmpty);
            Controls.Add(label4);
            Controls.Add(pbIcon);
            Controls.Add(dtDate);
            Controls.Add(cmbxFilter);
            Controls.Add(label2);
            Controls.Add(spaceSeparatorHorizontal1);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(dgvDriverHistory);
            Font = new Font("Inter", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 5, 4, 5);
            Name = "DriverHistory";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DriverReport";
            Load += DriverHistory_Load;
            ((System.ComponentModel.ISupportInitialize)pbIcon).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbEmpty).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvDriverHistory).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ReaLTaiizor.Controls.SpaceSeparatorHorizontal spaceSeparatorHorizontal1;
        private Label label1;
        private ComboBox cmbxFilter;
        private Label label2;
        private PictureBox pbIcon;
        private ReaLTaiizor.Controls.PoisonDateTime dtDate;
        protected internal Label label3;
        protected internal Label label4;
        private PictureBox pbEmpty;
        private Krypton.Toolkit.KryptonDataGridView dgvDriverHistory;
    }
}