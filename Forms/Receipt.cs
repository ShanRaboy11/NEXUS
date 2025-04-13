using FontAwesome.Sharp;
using NEXUS.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;
using PdfSharp.Pdf;
using PdfSharp.Drawing;
using System.Reflection.Metadata;
using ZXing.OneD;
using iTextSharp.text;
using iTextSharp.text.pdf;


namespace NEXUS.Forms
{
    public partial class Receipt : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
           (
           int nleftRect,
           int nTopRect,
           int nRightRect,
           int nBottomRect,
           int nWidthEllipse,
           int nHeightEllipse
           );
        public Receipt(int userID)
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            DisplayReciptInfo(userID);
            pictureBox1.Parent = pnlReceipt;
            lblAmount.Parent = pnlReceipt;
            lblHeader.Parent = pnlReceipt;
            label2.Parent = pnlReceipt;
            line1.Parent = pnlReceipt;
            label4.Parent = pnlReceipt;
            label1.Parent = pnlReceipt;
            label3.Parent = pnlReceipt;
            label5.Parent = pnlReceipt;
            label6.Parent = pnlReceipt;
            lblPassenger.Parent = pnlReceipt;
            lblDT.Parent = pnlReceipt;
            lblDriver.Parent = pnlReceipt;
            lblRefNumber.Parent = pnlReceipt;
        }

        private void DisplayReciptInfo(int userID)
        {
            string tripQuery = @"
        SELECT TOP 1 TripID, [Trip Date], Passenger, Driver, [Fare Amount]
        FROM Trips WHERE PassengerID = ? ORDER BY [Trip Date] DESC";

            using (OleDbConnection conn = DatabaseManagement.GetConnection())
            using (OleDbCommand cmd = new OleDbCommand(tripQuery, conn))
            {
                cmd.Parameters.AddWithValue("?", userID);
                conn.Open();

                using (OleDbDataReader reader = cmd.ExecuteReader())
                {
                    reader.Read();

                    int tripID = Convert.ToInt32(reader["TripID"]);
                    DateTime tripDate = Convert.ToDateTime(reader["Trip Date"]);
                    string passenger = reader["Passenger"].ToString();
                    string driver = reader["Driver"].ToString();
                    double fare = Convert.ToDouble(reader["Fare Amount"]);

                    lblRefNumber.Text = "000000" + tripID.ToString();
                    lblDT.Text = tripDate.ToString("MMMM d, yyyy");
                    lblPassenger.Text = passenger.Split(' ')[0];
                    lblDriver.Text = driver.Split(' ')[0];
                    lblAmount.Text = fare.ToString("C");
                }
            }
        }

        private void ExportReceiptToPDF(Control control, string filePath)
        {
            // Capture only the control and ignore other UI elements like dialogs
            Bitmap bmp = CaptureControl(control);

            using (FileStream stream = new FileStream(filePath, FileMode.Create))
            {
                // Define page size based on your panel's size (416x516 pixels)
                float width = 416f;
                float height = 518f;

                iTextSharp.text.Rectangle pageSize = new iTextSharp.text.Rectangle(width, height);
                iTextSharp.text.Document pdfDoc = new iTextSharp.text.Document(pageSize, 0, 0, 0, 0);
                iTextSharp.text.pdf.PdfWriter.GetInstance(pdfDoc, stream);
                pdfDoc.Open();

                using (MemoryStream ms = new MemoryStream())
                {
                    bmp.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                    iTextSharp.text.Image img = iTextSharp.text.Image.GetInstance(ms.ToArray());

                    // Set the image to its actual size and no scaling
                    img.ScaleToFit(width, height);
                    img.SetAbsolutePosition(0, 0);

                    pdfDoc.Add(img);
                }

                pdfDoc.Close();
            }
        }

        private Bitmap CaptureControl(Control control)
        {
            Bitmap bmp = new Bitmap(control.Width, control.Height);
            control.Invoke(new Action(() =>
            {
                control.DrawToBitmap(bmp, new System.Drawing.Rectangle(0, 0, control.Width, control.Height));
            }));


            foreach (Control child in control.Controls)
            {
                if (child.Visible)
                {
                    Bitmap childBmp = new Bitmap(child.Width, child.Height);
                    child.DrawToBitmap(childBmp, new System.Drawing.Rectangle(0, 0, child.Width, child.Height));
                    using (Graphics g = Graphics.FromImage(bmp))
                    {
                        g.DrawImage(childBmp, child.Location);
                    }
                }
            }

            return bmp;
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPDF_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "PDF Files (*.pdf)|*.pdf";
                sfd.FileName = "Receipt.pdf";

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    ExportReceiptToPDF(pnlReceipt, sfd.FileName);
                }
            }
        }
    }
}
