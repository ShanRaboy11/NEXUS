using System;
using System.Data.SqlTypes;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Video;
using AForge.Video.DirectShow;
using NEXUS.Classes;
using NEXUS.Forms;
using ZXing;
using ZXing.Windows.Compatibility;

namespace NEXUS.User_Controls
{
    public partial class QRScanUC : UserControl
    {
        private FilterInfoCollection videoDevices;
        private VideoCaptureDevice videoCaptureDevice;
        private Panel containerPanel;
        private int PassengerID;
        private bool isProcessing = false; 
        bool cameraInitialized = false;
        public QRScanUC(Panel pnlContainer, int passengerID)
        {
            InitializeComponent();
            containerPanel = pnlContainer;
            this.PassengerID = passengerID;
            InitializeCamera();
            this.Disposed += QRScanUC_Disposed;
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
            if (picCam.InvokeRequired)
            {
                picCam.Invoke(new MethodInvoker(() => picCam.Image = (Bitmap)eventArgs.Frame.Clone()));
            }
            else
            {
                picCam.Image = (Bitmap)eventArgs.Frame.Clone();
            }
        }

        private async void ScanTimer_Tick(object sender, EventArgs e)
        {
            if (picCam.Image == null || isProcessing) return;

            isProcessing = true; // Prevent multiple scans at the same time

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
                    string decoded = result.Text.Trim();

                    // Stop camera asynchronously to avoid UI freeze
                    await Task.Run(() => StopCamera());

                    this.BeginInvoke(new Action(() =>
                    {
                        try
                        {
                            if (int.TryParse(decoded, out int driverID))
                            {
                                containerPanel.Controls.Clear();
                                PaymentUC paymentUC = new PaymentUC(decoded, PassengerID)
                                {
                                    Dock = DockStyle.Fill
                                };
                                containerPanel.Controls.Add(paymentUC);
                                StopCamera();
                                scanTimer.Stop();
                            }
                            else
                            {
                                throw new System.FormatException("Invalid QR code");
                            }
                        }
                        catch (Exception ex)
                        {
                            DialogBox dialogBox = new DialogBox();
                            Scan scan = new Scan(0);
                            dialogBox.ShowIcon("invalid qr code");

                            scan.ShowOverlay(dialogBox, null);

                            if (!cameraInitialized)
                            {
                                Task.Run(() => InitializeCamera());
                                cameraInitialized = true;  
                                isProcessing = false;
                            }
                            containerPanel.Controls.Clear(); 

                            QRScanUC newQRScanUC = new QRScanUC(containerPanel, PassengerID);

                            containerPanel.Controls.Add(newQRScanUC);
                        }
                    }));
                }
            }

            isProcessing = false; // Allow scanning again if needed
        }

        private void StopCamera()
        {
            if (videoCaptureDevice != null && videoCaptureDevice.IsRunning)
            {
                scanTimer?.Stop();
                videoCaptureDevice.NewFrame -= FinalFrame_NewFrame; // Unsubscribe event
                videoCaptureDevice.SignalToStop();
                videoCaptureDevice.WaitForStop();
                videoCaptureDevice = null;
            }
        }

        private void QRScanUC_Disposed(object sender, EventArgs e)
        {
            StopCamera();
        }
    }
}
