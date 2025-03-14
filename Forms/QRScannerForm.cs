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

        private void Maximize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Maximized;
            else
                this.WindowState = FormWindowState.Normal;
        }

        private void Minimize(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Close(object sender, EventArgs e)
        {
            this.Close();
        }

        private void InitializeCamera()
        {
            videoDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            if (videoDevices.Count > 0)
            {
                videoCaptureDevice = new VideoCaptureDevice(videoDevices[0].MonikerString);
                videoCaptureDevice.NewFrame += FinalFrame_NewFrame;

                try
                {
                    videoCaptureDevice.Start();
                    scanTimer.Start(); // Start scanning automatically!
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Camera failed to start: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("No camera detected!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FinalFrame_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            if (picCam == null || picCam.IsDisposed)
                StopCamera();

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

            Bitmap bitmap = new Bitmap(picCam.Image);

            BarcodeReader reader = new BarcodeReader
            {
                AutoRotate = true,
                Options = { TryHarder = true, PossibleFormats = new[] { BarcodeFormat.QR_CODE } }
            };

            Result result = reader.Decode(bitmap);

            if (result != null && !string.IsNullOrEmpty(result.Text))
            {
                StopCamera();

                string decoded = result.Text.Trim();

                PaymentForm paymentForm = new PaymentForm(decoded);
                paymentForm.Show();

                this.Hide(); 
            }
        }

        private void StopCamera()
        {
            if (videoCaptureDevice != null && videoCaptureDevice.IsRunning)
            {
                scanTimer.Stop(); // ✅ Stop the timer
                videoCaptureDevice.SignalToStop(); // ✅ Stop the camera
                videoCaptureDevice.WaitForStop(); // ✅ Ensure camera thread exits
                videoCaptureDevice = null; // ✅ Remove reference to avoid conflicts
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
