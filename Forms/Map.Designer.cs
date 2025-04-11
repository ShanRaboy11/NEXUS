namespace NEXUS.Forms
{
    partial class Map
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Map));
            webViewMap = new Microsoft.Web.WebView2.WinForms.WebView2();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            panel2 = new Panel();
            pbClose = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)webViewMap).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbClose).BeginInit();
            SuspendLayout();
            // 
            // webViewMap
            // 
            webViewMap.AllowExternalDrop = true;
            webViewMap.BackColor = Color.FromArgb(230, 249, 255);
            webViewMap.CreationProperties = null;
            webViewMap.DefaultBackgroundColor = Color.White;
            webViewMap.Dock = DockStyle.Fill;
            webViewMap.Location = new Point(0, 28);
            webViewMap.Name = "webViewMap";
            webViewMap.Size = new Size(988, 711);
            webViewMap.TabIndex = 0;
            webViewMap.ZoomFactor = 1D;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(2157, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(18, 18);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(2099, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(19, 19);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(2130, 6);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(14, 14);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 2;
            pictureBox3.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(153, 229, 255);
            panel2.Controls.Add(pbClose);
            panel2.Controls.Add(pictureBox3);
            panel2.Controls.Add(pictureBox2);
            panel2.Controls.Add(pictureBox1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(988, 28);
            panel2.TabIndex = 18;
            // 
            // pbClose
            // 
            pbClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pbClose.Image = (Image)resources.GetObject("pbClose.Image");
            pbClose.Location = new Point(963, 5);
            pbClose.Name = "pbClose";
            pbClose.Size = new Size(18, 18);
            pbClose.SizeMode = PictureBoxSizeMode.Zoom;
            pbClose.TabIndex = 3;
            pbClose.TabStop = false;
            pbClose.Click += pbClose_Click;
            // 
            // Map
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(988, 739);
            Controls.Add(webViewMap);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Map";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Map";
            ((System.ComponentModel.ISupportInitialize)webViewMap).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbClose).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Microsoft.Web.WebView2.WinForms.WebView2 webViewMap;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Panel panel2;
        private PictureBox pbClose;
    }
}