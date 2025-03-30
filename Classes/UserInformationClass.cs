using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BCrypt.Net;
using NEXUS.Classes;
using NEXUS.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace NEXUS.Classes
{

    public interface Users
    {
        void SaveToDatabase();
        //float ProcessPayment();
        //double CheckBalance();
    }

    public abstract class UserInformation
    {
        // Private fields for encapsulation
        private int userID;
        private string name;
        private string email;
        private string username;
        private string gender;
        private string userType;
        private string birthday;
        private string attachment;
        private string profilePicture;
        private double walletAmount;
        private string status;

        // Public properties with encapsulated private fields
        public int UserID { get => userID; set => userID = value; }
        public string Name { get => name; set => name = value; }
        public string Email { get => email; set => email = value; }
        public string Username { get => username; set => username = value; }
        public string Gender { get => gender; set => gender = value; }
        public string UserType { get => userType; set => userType = value; }
        public string Birthday { get => birthday; set => birthday = value; }
        public string Attachment { get => attachment; set => attachment = value; }
        public string ProfilePicture { get => profilePicture; set => profilePicture = value; }
        public double WalletAmount { get => walletAmount; set => walletAmount = value; }
        public string Status { get => status; set => status = value; }

        // Protected property for password (Only accessible within derived classes)
        protected string HashedPassword { get; set; }

        // Protected field for database connection string
        protected string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Shan Michael\OneDrive\文档\2nd Year 2nd Sem\OOP2\NEXUS\NEXUS.accdb";

        // Constructor
        protected UserInformation(int userID, string name, string email, string username, string password, string gender, string userType, string birthday, string attachment, string profilepic, double wallet, string status)
        {
            this.userID = userID;
            this.name = name;
            this.email = email;
            this.username = username;
            HashedPassword = Cryptography.ToSHA256(password);
            this.gender = gender;
            this.userType = userType;
            this.birthday = birthday;
            this.attachment = attachment;
            this.profilePicture = profilepic;
            this.walletAmount = wallet;
            this.status = status;
        }
    }


    public class UserRegistrationData
    {
        public string FName { get; set; }
        public string LName { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Gender { get; set; }
    }

    public class Passenger : UserInformation, Users
    {
        public List<string> TripHistory { get; private set; }
        public string Classification { get; set; }
        public int Points { get; set; }


        // Constructor
        public Passenger(int userId, string name, string email, string username, string password, string gender, string userType, string birthday, string classification, string attachment, string profilepic, double wallet, int points, string status)
            : base(userId, name, email, username, password, gender, userType, birthday, attachment, profilepic, wallet, status)
        {
            Classification = classification;
            Points = points;
        }

        public void SaveToDatabase()
        {

            string query = "INSERT INTO Accounts (Username, [Password], [Full Name], [Email Address], Gender, [User Type], Birthday, Classification, Attachment, [Profile Picture], Wallet, Points, [Status]) " +
                           "VALUES (?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?)";

            using (OleDbConnection conn = new OleDbConnection(connectionString))
            using (OleDbCommand cmd = new OleDbCommand(query, conn))
            {
                conn.Open();

                cmd.Parameters.AddWithValue("?", this.Username);
                cmd.Parameters.AddWithValue("?", this.HashedPassword);
                cmd.Parameters.AddWithValue("?", this.Name);
                cmd.Parameters.AddWithValue("?", this.Email);
                cmd.Parameters.AddWithValue("?", this.Gender);
                cmd.Parameters.AddWithValue("?", this.UserType);
                cmd.Parameters.AddWithValue("?", this.Birthday);
                cmd.Parameters.AddWithValue("?", Classification);
                cmd.Parameters.AddWithValue("?", string.IsNullOrEmpty(this.Attachment) ? DBNull.Value : this.Attachment);
                cmd.Parameters.AddWithValue("?", this.ProfilePicture);
                cmd.Parameters.AddWithValue("?", this.WalletAmount);
                cmd.Parameters.AddWithValue("?", this.Points);
                cmd.Parameters.AddWithValue("?", this.Status);

                cmd.ExecuteNonQuery();
            }
        }


        public void AddTrip(string tripDetails)
        {
            if (!string.IsNullOrWhiteSpace(tripDetails))
            {
                TripHistory.Add(tripDetails);
            }
        }
    }

    public class Driver : UserInformation, Users
    {
        public string PlateNumber { get; set; }
        public string QRCode { get; set; }
        public string Route { get; set; }

        // Constructor
        public Driver(int userId, string name,  string email, string username, string password, string gender, string userType, string birthday, string attachment, string plateNumber, string profilepic, double wallet, string qrcode, string route, string status)
            : base(userId, name, email, username, password, gender, userType, birthday, attachment, profilepic, wallet, status)
        {
            PlateNumber = plateNumber;
            QRCode = qrcode;
            Route = route;
        }

        public void SaveToDatabase()
        {
            string query = "INSERT INTO Accounts (Username, [Password], [Full Name], [Email Address], Gender, [User Type], Birthday, Attachment, [Plate Number], [Profile Picture],  Wallet, Route, [Status]) " +
                           "VALUES (?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?)";

            using (OleDbConnection conn = new OleDbConnection(connectionString))
            using (OleDbCommand cmd = new OleDbCommand(query, conn))
            {
                conn.Open();

                cmd.Parameters.AddWithValue("?", this.Username);
                cmd.Parameters.AddWithValue("?", this.HashedPassword);
                cmd.Parameters.AddWithValue("?", this.Name);
                cmd.Parameters.AddWithValue("?", this.Email);
                cmd.Parameters.AddWithValue("?", this.Gender);
                cmd.Parameters.AddWithValue("?", this.UserType);
                cmd.Parameters.AddWithValue("?", this.Birthday);
                cmd.Parameters.AddWithValue("?", this.Attachment);
                cmd.Parameters.AddWithValue("?", PlateNumber);
                cmd.Parameters.AddWithValue("?", this.ProfilePicture);
                cmd.Parameters.AddWithValue("?", this.WalletAmount);
                cmd.Parameters.AddWithValue("?", this.Route);
                cmd.Parameters.AddWithValue("?", this.Status);

                cmd.ExecuteNonQuery();
            }
        }
    }

    public class EmergencyReport
    {
        public int PassengerID { get; private set; }
        public int DriverID { get; private set; }
        public string IncidentDetails { get; private set; }
        public DateTime TimeStamp { get; private set; }

        // Constructor
        public EmergencyReport(int passengerID, int driverID, string incidentDetails)
        {
            PassengerID = passengerID;
            DriverID = driverID;
            IncidentDetails = !string.IsNullOrWhiteSpace(incidentDetails) ? incidentDetails : "No details provided";
            TimeStamp = DateTime.Now;
        }
    }

    public class RatingSystem
    {
        public int PassengerID { get; private set; }
        public int DriverID { get; private set; }
        public int Rating { get; private set; }
        public string Feedback { get; private set; }

        // Constructor
        public RatingSystem(int passengerID, int driverID, int rating, string feedback)
        {
            PassengerID = passengerID;
            DriverID = driverID;
            SetRating(rating);
            Feedback = !string.IsNullOrWhiteSpace(feedback) ? feedback : "No feedback provided";
        }

        public void SetRating(int rating)
        {
            if (rating < 1 || rating > 5)
            {
                throw new ArgumentException("Rating must be between 1 and 5.");
            }
            Rating = rating;
        }
    }


    public class Trip
    {
        public string RouteTaken { get; private set; }
        public double FarePaid { get; private set; }
        public DateTime TripTimeStamp { get; private set; }

        // Constructor (exclude TripID since it's DB-generated)
        public Trip(string routeTaken, double farePaid)
        {
            if (string.IsNullOrWhiteSpace(routeTaken))
                throw new ArgumentException("RouteTaken cannot be empty.");

            if (farePaid < 0)
                throw new ArgumentException("Fare cannot be negative.");

            RouteTaken = routeTaken;
            FarePaid = farePaid;
            TripTimeStamp = DateTime.Now;
        }

        // Generate a receipt string
        public string GenerateReceipt()
        {
            return $"Trip Receipt\n" +
                   $"-----------------------\n" +
                   $"Route: {RouteTaken}\n" +
                   $"Fare Paid: {FarePaid:C}\n" +
                   $"Date: {TripTimeStamp:yyyy-MM-dd HH:mm:ss}\n";
        }
    }

    public class Attachment
    {
        private readonly string uploadFolder;

        public Attachment()
        {
            // Use AppContext.BaseDirectory and append the correct folder
            uploadFolder = Path.Combine(AppContext.BaseDirectory, "Attachments");

            // Ensure the directory exists
            if (!Directory.Exists(uploadFolder))
            {
                Directory.CreateDirectory(uploadFolder);
            }
        }

        public Image UploadAndSaveImage(string sourcePath)
        {
            string fileName = Path.GetFileName(sourcePath); // Extract the file name only
            string destinationPath = Path.Combine(uploadFolder, fileName); // Full destination path

            try
            {
                File.Copy(sourcePath, destinationPath, true); // Overwrite if exists
                return Image.FromFile(destinationPath); // Return the saved image
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving image: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        public string GetSavedFilePath(string fileName)
        {
            return Path.Combine(uploadFolder, fileName); // Return full path of stored image
        }
    }

    public class QRCodeManager
    {
        private readonly string qrCodeFolder;

        public QRCodeManager()
        {
            // Define folder for QR codes
            qrCodeFolder = Path.Combine(AppContext.BaseDirectory, "QR Codes");

            // Ensure the directory exists
            if (!Directory.Exists(qrCodeFolder))
            {
                Directory.CreateDirectory(qrCodeFolder);
            }
        }

        public string SaveQrCode(Image qrImage, int userID)
        {
            // Define file name (Example: QR_123.png where 123 is UserID)
            string fileName = $"QR_{userID}.png";
            string filePath = Path.Combine(qrCodeFolder, fileName);

            try
            {
                // Save the QR code image
                qrImage.Save(filePath, System.Drawing.Imaging.ImageFormat.Png);
                return filePath; // Return the file path to be stored in the database
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving QR code: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }
    }
}
