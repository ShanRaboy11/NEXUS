namespace NEXUS.User_Controls
{
    partial class DataGrid
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
            components = new System.ComponentModel.Container();
            dgvUsers = new Krypton.Toolkit.KryptonDataGridView();
            contextMenuStrip1 = new ContextMenuStrip(components);
            deleteToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)dgvUsers).BeginInit();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvUsers
            // 
            dgvUsers.BorderStyle = BorderStyle.None;
            dgvUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsers.ContextMenuStrip = contextMenuStrip1;
            dgvUsers.Dock = DockStyle.Fill;
            dgvUsers.HideOuterBorders = true;
            dgvUsers.Location = new Point(0, 0);
            dgvUsers.Name = "dgvUsers";
            dgvUsers.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007BlueLightMode;
            dgvUsers.ReadOnly = true;
            dgvUsers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvUsers.ShowEditingIcon = false;
            dgvUsers.Size = new Size(1312, 697);
            dgvUsers.StateCommon.Background.Color1 = Color.FromArgb(230, 249, 255);
            dgvUsers.StateCommon.Background.Color2 = Color.FromArgb(153, 229, 255);
            dgvUsers.StateCommon.BackStyle = Krypton.Toolkit.PaletteBackStyle.GridBackgroundList;
            dgvUsers.StateCommon.DataCell.Back.Color1 = Color.FromArgb(153, 229, 255);
            dgvUsers.StateCommon.DataCell.Border.Color1 = Color.White;
            dgvUsers.StateCommon.DataCell.Border.Color2 = Color.White;
            dgvUsers.StateCommon.DataCell.Content.Color1 = Color.FromArgb(24, 60, 114);
            dgvUsers.StateCommon.DataCell.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            dgvUsers.StateCommon.DataCell.Content.TextV = Krypton.Toolkit.PaletteRelativeAlign.Center;
            dgvUsers.StateCommon.HeaderColumn.Back.Color1 = Color.FromArgb(38, 36, 68);
            dgvUsers.StateCommon.HeaderColumn.Back.Color2 = Color.FromArgb(38, 36, 68);
            dgvUsers.StateCommon.HeaderColumn.Border.Color1 = Color.White;
            dgvUsers.StateCommon.HeaderColumn.Border.Color2 = Color.White;
            dgvUsers.StateCommon.HeaderColumn.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            dgvUsers.StateCommon.HeaderColumn.Content.TextV = Krypton.Toolkit.PaletteRelativeAlign.Center;
            dgvUsers.StateSelected.DataCell.Back.Color1 = Color.FromArgb(0, 229, 255);
            dgvUsers.StateSelected.DataCell.Back.Color2 = Color.FromArgb(0, 229, 255);
            dgvUsers.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Font = new Font("Segoe UI", 9F);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { deleteToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(120, 30);
            // 
            // deleteToolStripMenuItem
            // 
            deleteToolStripMenuItem.Font = new Font("Inter", 10F);
            deleteToolStripMenuItem.Image = Properties.Resources.close__1_;
            deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            deleteToolStripMenuItem.Size = new Size(119, 26);
            deleteToolStripMenuItem.Text = "Delete";
            deleteToolStripMenuItem.Click += deleteToolStripMenuItem_Click;
            // 
            // DataGrid
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(230, 249, 255);
            Controls.Add(dgvUsers);
            Name = "DataGrid";
            Size = new Size(1312, 697);
            Load += DataGrid_Load;
            ((System.ComponentModel.ISupportInitialize)dgvUsers).EndInit();
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Krypton.Toolkit.KryptonDataGridView dgvUsers;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem deleteToolStripMenuItem;
    }
}
