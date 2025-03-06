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
                videoCaptureDevice = new VideoCaptureDevice(videoDevices[0].MonikerString); // Automatically selects the first camera
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

            BarcodeReader reader = new BarcodeReader();
            Result result = reader.Decode((Bitmap)picCam.Image);

            if (result != null)
            {
                scanTimer.Stop(); // Stop scanning to prevent multiple openings
                videoCaptureDevice.SignalToStop(); // Stop the camera

                PaymentForm paymentForm = new PaymentForm(null);
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
