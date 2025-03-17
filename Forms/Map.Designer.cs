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
            webViewMap = new Microsoft.Web.WebView2.WinForms.WebView2();
            ((System.ComponentModel.ISupportInitialize)webViewMap).BeginInit();
            SuspendLayout();
            // 
            // webViewMap
            // 
            webViewMap.AllowExternalDrop = true;
            webViewMap.CreationProperties = null;
            webViewMap.DefaultBackgroundColor = Color.White;
            webViewMap.Dock = DockStyle.Fill;
            webViewMap.Location = new Point(0, 0);
            webViewMap.Name = "webViewMap";
            webViewMap.Size = new Size(988, 739);
            webViewMap.TabIndex = 0;
            webViewMap.ZoomFactor = 1D;
            // 
            // Map
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(988, 739);
            Controls.Add(webViewMap);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Map";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Map";
            ((System.ComponentModel.ISupportInitialize)webViewMap).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Microsoft.Web.WebView2.WinForms.WebView2 webViewMap;
    }
}