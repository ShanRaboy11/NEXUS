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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(History));
            label1 = new Label();
            label3 = new Label();
            spaceSeparatorHorizontal1 = new ReaLTaiizor.Controls.SpaceSeparatorHorizontal();
            dtDate = new ReaLTaiizor.Controls.PoisonDateTime();
            label2 = new Label();
            cmsDataGrid = new ContextMenuStrip(components);
            displayToolStripMenuItem = new ToolStripMenuItem();
            rateToolStripMenuItem = new ToolStripMenuItem();
            cmbxFilter = new ComboBox();
            pbIcon = new PictureBox();
            dgvHistory = new Krypton.Toolkit.KryptonDataGridView();
            cmbxJeepCodes = new ComboBox();
            pbEmpty = new PictureBox();
            cmsDataGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbIcon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvHistory).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbEmpty).BeginInit();
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
            dtDate.CalendarFont = new Font("Inter", 17.25F);
            dtDate.CalendarMonthBackground = Color.FromArgb(176, 233, 255);
            dtDate.FontSize = ReaLTaiizor.Extension.Poison.PoisonDateTimeSize.Tall;
            dtDate.Location = new Point(720, 144);
            dtDate.MinimumSize = new Size(0, 35);
            dtDate.Name = "dtDate";
            dtDate.Size = new Size(205, 35);
            dtDate.TabIndex = 50;
            dtDate.Visible = false;
            dtDate.ValueChanged += dtpTripDate_ValueChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(230, 249, 255);
            label2.Font = new Font("Inter SemiBold", 17F, FontStyle.Bold);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(35, 147);
            label2.Name = "label2";
            label2.Size = new Size(78, 32);
            label2.TabIndex = 51;
            label2.Text = "Filter:";
            // 
            // cmsDataGrid
            // 
            cmsDataGrid.Font = new Font("Segoe UI", 9F);
            cmsDataGrid.Items.AddRange(new ToolStripItem[] { displayToolStripMenuItem, rateToolStripMenuItem });
            cmsDataGrid.Name = "contextMenuStrip1";
            cmsDataGrid.Size = new Size(113, 48);
            // 
            // displayToolStripMenuItem
            // 
            displayToolStripMenuItem.Image = Properties.Resources._9104142_fullscreen_expand_maximize_enlarge_screen_icon;
            displayToolStripMenuItem.Name = "displayToolStripMenuItem";
            displayToolStripMenuItem.Size = new Size(112, 22);
            displayToolStripMenuItem.Text = "Display";
            // 
            // rateToolStripMenuItem
            // 
            rateToolStripMenuItem.Image = Properties.Resources.rate_hover;
            rateToolStripMenuItem.Name = "rateToolStripMenuItem";
            rateToolStripMenuItem.Size = new Size(112, 22);
            rateToolStripMenuItem.Text = "Rate";
            rateToolStripMenuItem.Click += rateToolStripMenuItem_Click;
            // 
            // cmbxFilter
            // 
            cmbxFilter.BackColor = Color.FromArgb(176, 233, 255);
            cmbxFilter.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbxFilter.Font = new Font("Inter", 14.25F);
            cmbxFilter.ForeColor = Color.FromArgb(24, 60, 114);
            cmbxFilter.FormattingEnabled = true;
            cmbxFilter.Items.AddRange(new object[] { "Date", "Jeep Code", "Rated Trips", "Unrated Trips" });
            cmbxFilter.Location = new Point(121, 146);
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
            pbIcon.Location = new Point(639, 134);
            pbIcon.Name = "pbIcon";
            pbIcon.Size = new Size(74, 51);
            pbIcon.SizeMode = PictureBoxSizeMode.Zoom;
            pbIcon.TabIndex = 149;
            pbIcon.TabStop = false;
            pbIcon.Visible = false;
            // 
            // dgvHistory
            // 
            dgvHistory.BorderStyle = BorderStyle.None;
            dgvHistory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHistory.ContextMenuStrip = cmsDataGrid;
            dgvHistory.HideOuterBorders = true;
            dgvHistory.Location = new Point(35, 211);
            dgvHistory.Name = "dgvHistory";
            dgvHistory.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007BlueLightMode;
            dgvHistory.ReadOnly = true;
            dgvHistory.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvHistory.ShowEditingIcon = false;
            dgvHistory.Size = new Size(897, 452);
            dgvHistory.StateCommon.Background.Color1 = Color.FromArgb(230, 249, 255);
            dgvHistory.StateCommon.Background.Color2 = Color.FromArgb(153, 229, 255);
            dgvHistory.StateCommon.BackStyle = Krypton.Toolkit.PaletteBackStyle.GridBackgroundList;
            dgvHistory.StateCommon.DataCell.Back.Color1 = Color.FromArgb(153, 229, 255);
            dgvHistory.StateCommon.DataCell.Border.Color1 = Color.White;
            dgvHistory.StateCommon.DataCell.Border.Color2 = Color.White;
            dgvHistory.StateCommon.DataCell.Content.Color1 = Color.FromArgb(24, 60, 114);
            dgvHistory.StateCommon.DataCell.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            dgvHistory.StateCommon.DataCell.Content.TextV = Krypton.Toolkit.PaletteRelativeAlign.Center;
            dgvHistory.StateCommon.HeaderColumn.Back.Color1 = Color.FromArgb(38, 36, 68);
            dgvHistory.StateCommon.HeaderColumn.Back.Color2 = Color.FromArgb(38, 36, 68);
            dgvHistory.StateCommon.HeaderColumn.Border.Color1 = Color.White;
            dgvHistory.StateCommon.HeaderColumn.Border.Color2 = Color.White;
            dgvHistory.StateCommon.HeaderColumn.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            dgvHistory.StateCommon.HeaderColumn.Content.TextV = Krypton.Toolkit.PaletteRelativeAlign.Center;
            dgvHistory.StatePressed.HeaderColumn.Content.Color1 = Color.White;
            dgvHistory.StatePressed.HeaderColumn.Content.Color2 = Color.White;
            dgvHistory.StateSelected.DataCell.Back.Color1 = Color.FromArgb(0, 229, 255);
            dgvHistory.StateSelected.DataCell.Back.Color2 = Color.FromArgb(0, 229, 255);
            dgvHistory.StateSelected.HeaderColumn.Content.Color1 = Color.White;
            dgvHistory.StateSelected.HeaderColumn.Content.Color2 = Color.White;
            dgvHistory.TabIndex = 151;
            // 
            // cmbxJeepCodes
            // 
            cmbxJeepCodes.BackColor = Color.FromArgb(176, 233, 255);
            cmbxJeepCodes.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbxJeepCodes.Font = new Font("Inter", 16F);
            cmbxJeepCodes.ForeColor = Color.FromArgb(24, 60, 114);
            cmbxJeepCodes.FormattingEnabled = true;
            cmbxJeepCodes.Items.AddRange(new object[] { "01C", "01K", "02B", "03A", "03B", "03L", "03Q", "04B", "04H", "04I", "04L", "04M", "06B", "06C", "06G", "06H", "07B", "08F", "08G", "09C", "09F", "09G", "10F", "10G", "10H", "10M", "11A", "12D", "12G", "12I", "12L", "13B", "13C", "13H", "14D", "17B", "17C", "17D", "20A", "21A", "22A", "22D", "22I", "23", "23D", "62B", "MI-01A", "MI-02B", "MI-03A", "MI-03B" });
            cmbxJeepCodes.Location = new Point(730, 142);
            cmbxJeepCodes.Name = "cmbxJeepCodes";
            cmbxJeepCodes.Size = new Size(186, 38);
            cmbxJeepCodes.TabIndex = 152;
            cmbxJeepCodes.TabStop = false;
            cmbxJeepCodes.Visible = false;
            cmbxJeepCodes.SelectedIndexChanged += cmbxJeepCodes_SelectedIndexChanged;
            // 
            // pbEmpty
            // 
            pbEmpty.Image = (Image)resources.GetObject("pbEmpty.Image");
            pbEmpty.Location = new Point(35, 211);
            pbEmpty.Name = "pbEmpty";
            pbEmpty.Size = new Size(897, 452);
            pbEmpty.TabIndex = 153;
            pbEmpty.TabStop = false;
            pbEmpty.Visible = false;
            // 
            // History
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(230, 249, 255);
            ClientSize = new Size(972, 700);
            Controls.Add(pbEmpty);
            Controls.Add(cmbxJeepCodes);
            Controls.Add(dgvHistory);
            Controls.Add(pbIcon);
            Controls.Add(cmbxFilter);
            Controls.Add(label2);
            Controls.Add(dtDate);
            Controls.Add(spaceSeparatorHorizontal1);
            Controls.Add(label3);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "History";
            Text = "History";
            Load += History_Load;
            cmsDataGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbIcon).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvHistory).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbEmpty).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label3;
        private ReaLTaiizor.Controls.SpaceSeparatorHorizontal spaceSeparatorHorizontal1;
        private ReaLTaiizor.Controls.PoisonDateTime dtDate;
        private Label label2;
        private ComboBox cmbxFilter;
        private PictureBox pbIcon;
        private ContextMenuStrip cmsDataGrid;
        private ToolStripMenuItem displayToolStripMenuItem;
        private ToolStripMenuItem rateToolStripMenuItem;
        private Krypton.Toolkit.KryptonDataGridView dgvHistory;
        private ComboBox cmbxJeepCodes;
        private PictureBox pbEmpty;
    }
}