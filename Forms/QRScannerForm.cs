using System;
using System.Diagnostics;  // Required for opening URLs
using System.Drawing;
using System.Windows.Forms;
using AForge.Video;
using AForge.Video.DirectShow;
using ZXing;
using ZXing.QrCode;

namespace NEXUS.Forms
{
    public partial class QRScannerForm : Form
    {
        private VideoCaptureDevice videoSource;
        private FilterInfoCollection videoDevices;

        public QRScannerForm()
        {
            InitializeComponent();
            videoDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            if (videoDevices.Count > 0)
            {
                videoSource = new VideoCaptureDevice(videoDevices[0].MonikerString);
                videoSource.NewFrame += VideoSource_NewFrame;
            }

            // Initialize and start timer for scanning
            scanTimer.Interval = 500; // Scan every 500ms
            scanTimer.Tick += ScanTimer_Tick;
        }

        private void btnStartCamera_Click(object sender, EventArgs e)
        {
            if (videoSource != null && !videoSource.IsRunning)
            {
                videoSource.Start();
                scanTimer.Start();
            }
        }

        private void btnStopCamera_Click(object sender, EventArgs e)
        {
            if (videoSource != null && videoSource.IsRunning)
            {
                scanTimer.Stop();
                videoSource.SignalToStop();
                videoSource.WaitForStop();
                picCam.Image = null;
            }
        }

        // 📷 Display camera feed in PictureBox
        private void VideoSource_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            Bitmap frame = (Bitmap)eventArgs.Frame.Clone();
            picCam.Image = frame;
        }

        // 📌 QR Code Scanning Logic
        private void ScanTimer_Tick(object sender, EventArgs e)
        {
            if (picCam.Image == null)
                return;

            try
            {
                Bitmap img = new Bitmap(picCam.Image);
                BarcodeReader reader = new BarcodeReader();
                Result result = reader.Decode(img);

                if (result != null)
                {
                    txtQRContent.Text = result.Text;  // Display scanned content
                    scanTimer.Stop();  // Stop scanning after successful read

                    // 🎯 Open scanned URL in the default web browser
                    OpenScannedURL(result.Text);
                }

                img.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error scanning QR code: " + ex.Message);
            }
        }

        // 🌍 Function to Open the Scanned URL
        private void OpenScannedURL(string url)
        {
            try
            {
                if (Uri.IsWellFormedUriString(url, UriKind.Absolute))
                {
                    Process.Start(new ProcessStartInfo(url) { UseShellExecute = true });
                }
                else
                {
                    MessageBox.Show("Scanned content is not a valid URL.", "Invalid QR Code", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error opening the scanned URL: " + ex.Message);
            }
        }

        private void QRCodeScannerForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (videoSource != null && videoSource.IsRunning)
            {
                scanTimer.Stop();
                videoSource.SignalToStop();
                videoSource.WaitForStop();
            }
        }
    }
}
