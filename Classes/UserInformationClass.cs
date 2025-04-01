using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using BCrypt.Net;
using NEXUS.Classes;
using NEXUS.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace NEXUS.Classes
{

    public interface Users
    {
        void SaveToDatabase();
        void SaveImageToDatabase(byte[] imageBytes, int userID);
        byte[] DefaultProfilePicture(string gender);
    }

    public abstract class UserInformation
    {
        private int userID;
        private string name;
        private string email;
        private string username;
        private string gender;
        private string userType;
        private string birthday;
        private byte[] attachment;
        private string profilePicture;
        private double walletAmount;
        private string status;

        public int UserID { get => userID; set => userID = value; }
        public string Name { get => name; set => name = value; }
        public string Email { get => email; set => email = value; }
        public string Username { get => username; set => username = value; }
        public string Gender { get => gender; set => gender = value; }
        public string UserType { get => userType; set => userType = value; }
        public string Birthday { get => birthday; set => birthday = value; }
        public byte[] Attachment { get => attachment; set => attachment = value; }
        public string ProfilePicture { get => profilePicture; set => profilePicture = value; }
        public double WalletAmount { get => walletAmount; set => walletAmount = value; }
        public string Status { get => status; set => status = value; }

        // Protected property for password (Only accessible within derived classes)
        protected string HashedPassword { get; set; }

        // Protected field for database connection string
        protected string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Shan Michael\OneDrive\文档\2nd Year 2nd Sem\OOP2\NEXUS\NEXUS.accdb";

        // Constructor
        protected UserInformation(int userID, string name, string email, string username, string password, string gender, string userType, string birthday, byte[] attachment, string profilepic, double wallet, string status)
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
        private string classification;
        private int points;
        public List<string> TripHistory { get; private set; }
        public string Classification { get => classification; set => classification = value; }
        public int Points { get => points; set => points = value; }

        // Constructor
        public Passenger(int userId, string name, string email, string username, string password, string gender, string userType, string birthday, string classification, byte[] attachment, string profilepic, double wallet, int points, string status)
            : base(userId, name, email, username, password, gender, userType, birthday, attachment, profilepic, wallet, status)
        {
            Classification = classification;
            Points = points;
        }

        public void SaveToDatabase()
        {

            string query = "INSERT INTO Accounts (Username, [Password], [Full Name], [Email Address], Gender, [User Type], Birthday, Classification, Attachment, [Profile Picture], Wallet, Points, [Status]) " +
                           "VALUES (?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?)";

            using (OleDbConnection conn = DatabaseManagement.GetConnection())
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
                cmd.Parameters.AddWithValue("?", (this.Attachment == null || this.Attachment.Length == 0) ? DBNull.Value : (object)this.Attachment);
                cmd.Parameters.AddWithValue("?", this.ProfilePicture);
                cmd.Parameters.AddWithValue("?", this.WalletAmount);
                cmd.Parameters.AddWithValue("?", this.Points);
                cmd.Parameters.AddWithValue("?", this.Status);

                cmd.ExecuteNonQuery();
            }
        }

        public void SaveImageToDatabase(byte[] imageBytes, int userID)
        {
            string query = "INSERT INTO Accounts (Attachment) VALUES (?)";

            using (OleDbConnection conn = DatabaseManagement.GetConnection())
            using (OleDbCommand command = new OleDbCommand(query, conn))
            {
                command.Parameters.Add("?", OleDbType.VarBinary).Value = imageBytes;

                try
                {
                    conn.Open();
                    command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error saving image to database: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public byte[] DefaultProfilePicture(string gender)
        {
            byte[] profilePicture = null;
            Image photo = null;
            if(gender == "Male")
            {
                photo = Image.FromFile(@"C:\Users\Shan Michael\source\repos\NEXUS\Resources\default_male.png");
            }
            else if(gender == "Female")
            {
                photo = Image.FromFile(@"C:\Users\Shan Michael\source\repos\NEXUS\Resources\defaullt_female.png");
            }
            else
            {
                photo = Image.FromFile(@"C:\Users\Shan Michael\source\repos\NEXUS\Resources\default_User.png");
            }

            if (photo != null)
            {
                using (MemoryStream ms = new MemoryStream())
                {
                    photo.Save(ms, System.Drawing.Imaging.ImageFormat.Png);

                    return ms.ToArray();
                }
            }

            return null;
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
        private string plateNumber;
        private byte[] qrCode;
        private string route;
        public string PlateNumber { get => plateNumber; set => plateNumber = value; }
        public byte[] QRCode { get => qrCode; set => qrCode = value; }
        public string Route { get => route; set => route = value; }

        // Constructor
        public Driver(int userId, string name,  string email, string username, string password, string gender, string userType, string birthday, byte[] attachment, string plateNumber, string profilepic, double wallet, byte[] qrcode, string route, string status)
            : base(userId, name, email, username, password, gender, userType, birthday, attachment, profilepic, wallet, status)
        {
            PlateNumber = plateNumber;
            QRCode = qrcode;
            Route = route;
        }

        public void SaveToDatabase()
        {
            string query = "INSERT INTO Accounts (Username, [Password], [Full Name], [Email Address], Gender, [User Type], Birthday, Attachment, [Plate Number], [Profile Picture],  Wallet, [QR Code], Route, [Status]) " +
                           "VALUES (?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?)";

            using (OleDbConnection conn = DatabaseManagement.GetConnection())
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
                cmd.Parameters.AddWithValue("?", this.QRCode);
                cmd.Parameters.AddWithValue("?", this.Route);
                cmd.Parameters.AddWithValue("?", this.Status);

                cmd.ExecuteNonQuery();
            }
        }

        public void SaveImageToDatabase(byte[] imageBytes, int userID)
        {
            // Corrected SQL query to update the QR code for the specified user
            string query = "UPDATE Accounts SET [QR Code] = ? WHERE ID = ?";

            using (OleDbConnection conn = DatabaseManagement.GetConnection())
            using (OleDbCommand command = new OleDbCommand(query, conn))
            {
                // Add parameters: First is the image data for the QR Code, then the user ID
                command.Parameters.Add("?", OleDbType.VarBinary).Value = imageBytes;
                command.Parameters.AddWithValue("?", userID);

                try
                {
                    conn.Open();
                    command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error saving image to database: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
                    
        public byte[] DefaultProfilePicture(string gender)
        {
            byte[] profilePicture = null;
            Image photo = null;
            if (gender == "Male")
            {
                photo = Image.FromFile(@"C:\Users\Shan Michael\source\repos\NEXUS\Resources\driver_Default.png");
            }
            else if (gender == "Female")
            {
                photo = Image.FromFile(@"C:\Users\Shan Michael\source\repos\NEXUS\Resources\driver_FemaleDefault.jpg");
            }
            else
            {
                photo = Image.FromFile(@"C:\Users\Shan Michael\source\repos\NEXUS\Resources\default_User.png");
            }

            if (photo != null)
            {
                using (MemoryStream ms = new MemoryStream())
                {
                    if (photo.RawFormat.Equals(System.Drawing.Imaging.ImageFormat.Jpeg))
                    {
                        photo.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                    }
                    else
                    {
                        photo.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                    }

                    return ms.ToArray();
                }
            }

            return null;
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
        public byte[] ConvertImageToByteArray(Image attachment)
        {
            using (MemoryStream convertImageMemoryStream = new MemoryStream())
            {
                attachment.Save(convertImageMemoryStream, attachment.RawFormat);
                return convertImageMemoryStream.ToArray();
            }
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

        public string SaveQrCode(byte[] qrCodeBytes, int userID)
        {
            // Define file name (Example: QR_123.png where 123 is UserID)
            string fileName = $"QR_{userID}.png";
            string filePath = Path.Combine(qrCodeFolder, fileName);

            try
            {
                // Save the byte array as an image to the file path
                File.WriteAllBytes(filePath, qrCodeBytes);
                return filePath; // Return the file path to be stored in the database
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving QR code: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        // Convert Image to byte[]
        public byte[] ConvertImageToByteArray(Image image)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                // Save the image to the memory stream in PNG format
                image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                return ms.ToArray(); // Return the byte array
            }
        }
    }

}
