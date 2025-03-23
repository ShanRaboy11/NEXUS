using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using AForge.Video;
using AForge.Video.DirectShow;
using Microsoft.Win32;
using ZXing;
using ZXing.Windows.Compatibility;

namespace NEXUS.Forms
{
    public partial class QRScannerForm : Form
    {
        //Dashboard dashboardFrom = new Dashboard();
        private VideoCaptureDevice videoCaptureDevice;
        private FilterInfoCollection videoDevices;
        private Dashboard dashboard;
        

        //Dashboard dashboardRef
        public QRScannerForm()
        {
            InitializeComponent();
            InitializeCamera();
            //this.dashboard = dashboardRef;
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
                    scanTimer.Start(); 
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
        Scan scan = new Scan(null);
        private void scanTimer_Tick(object sender, EventArgs e)
        {
            
            if (picCam.Image == null) return;

            using (Bitmap bitmap = new Bitmap(picCam.Image))
            {
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

                    this.BeginInvoke(new Action(() =>
                    {
                        this.Hide(); 
                        PaymentForm paymentForm = new PaymentForm(decoded);
                        //paymentForm.Show();
                        scan.ShowOverlay(paymentForm, null);
                        this.Close(); // Close properly to prevent freezing
                    }));
                }
            }
        }

        private void StopCamera()
        {
            if (videoCaptureDevice != null && videoCaptureDevice.IsRunning)
            {
                scanTimer.Stop();
                videoCaptureDevice.SignalToStop();
                videoCaptureDevice.WaitForStop();
                videoCaptureDevice = null;
            }
        }

        private void QRScannerForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (videoCaptureDevice != null && videoCaptureDevice.IsRunning)
            {
                videoCaptureDevice.SignalToStop();
                videoCaptureDevice.WaitForStop();
            }
        }

        private void pbClose_Click(object sender, EventArgs e)
        {
            FormClosingEventArgs args = new FormClosingEventArgs(CloseReason.UserClosing, false);
            QRScannerForm_FormClosing(this, args);

            this.Close();
        }
    }
}
