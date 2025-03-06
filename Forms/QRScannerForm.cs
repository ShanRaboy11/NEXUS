using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using AForge.Video;
using AForge.Video.DirectShow;
using ZXing;
using ZXing.Windows.Compatibility;

namespace NEXUS.Forms
{
    public partial class QRScannerForm : Form
    {
        private VideoCaptureDevice videoCaptureDevice;
        private FilterInfoCollection videoDevices;

        public QRScannerForm()
        {
            InitializeComponent();
            InitializeCamera();
        }

        private void InitializeCamera()
        {
            videoDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            if (videoDevices.Count > 0)
            {
                videoCaptureDevice = new VideoCaptureDevice(videoDevices[0].MonikerString); // Use the first available camera
                videoCaptureDevice.NewFrame += FinalFrame_NewFrame;
                videoCaptureDevice.Start();
            }
            else
            {
                MessageBox.Show("No camera detected!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FinalFrame_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            if (picCam.InvokeRequired)
            {
                picCam.Invoke(new MethodInvoker(delegate { picCam.Image = (Bitmap)eventArgs.Frame.Clone(); }));
            }
            else
            {
                picCam.Image = (Bitmap)eventArgs.Frame.Clone();
            }
        }

        private void scanTimer_Tick(object sender, EventArgs e)
        {
            if (picCam.Image == null) return;

            // Capture the current frame as a Bitmap
            Bitmap bitmap = new Bitmap(picCam.Image);

            // QR Code reader with enhanced settings
            BarcodeReader reader = new BarcodeReader
            {
                AutoRotate = true,
                Options = { TryHarder = true, PossibleFormats = new[] { BarcodeFormat.QR_CODE } }
            };

            Result result = reader.Decode(bitmap);

            if (result != null)
            {
                scanTimer.Stop(); // Stop scanning to prevent multiple openings
                videoCaptureDevice.SignalToStop(); // Stop the camera

                string decoded = result.Text.Trim();

                // Capture a snapshot if there is a match
                picCam.Image = bitmap;

                PaymentForm paymentForm = new PaymentForm(decoded); // Pass QR data
                paymentForm.Show();
                this.Close();
            }
        }

        private void btnDecode_Click(object sender, EventArgs e)
        {
            scanTimer.Start();
        }

        private void QRScannerForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (videoCaptureDevice != null && videoCaptureDevice.IsRunning)
            {
                videoCaptureDevice.SignalToStop();
                videoCaptureDevice.WaitForStop();
            }
        }
    }
}
