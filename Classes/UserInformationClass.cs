using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.OleDb;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using BCrypt.Net;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.ApplicationServices;
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
        private byte[] profilePicture;
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
        public byte[] ProfilePicture { get => profilePicture; set => profilePicture = value; }
        public double WalletAmount { get => walletAmount; set => walletAmount = value; }
        public string Status { get => status; set => status = value; }

        // Protected property for password (Only accessible within derived classes)
        protected string HashedPassword { get; set; }

        // Protected field for database connection string
        protected string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Shan Michael\OneDrive\文档\2nd Year 2nd Sem\OOP2\NEXUS\NEXUS.accdb";

        // Constructor
        protected UserInformation(int userID, string name, string email, string username, string password, string gender, string userType, string birthday, byte[] attachment, byte[] profilepic, double wallet, string status)
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
        private string FirstName;
        private string LastName;
        private string userName;
        private string email;
        private string password;
        private string gender;
        public string FName { get => FirstName; set => FirstName = value; }
        public string LName { get => LastName; set => LastName = value; }
        public string UserName { get => userName; set => userName = value; }
        public string Email { get => email; set => email = value; }
        public string Password { get => password; set => password = value; }
        public string Gender { get => gender; set => gender = value; }
    }

    public class Passenger : UserInformation, Users
    {
        private string classification;
        private int points;
        public string Classification { get => classification; set => classification = value; }
        public int Points { get => points; set => points = value; }

        // Constructor
        public Passenger(int userId, string name, string email, string username, string password, string gender, string userType, string birthday, string classification, byte[] attachment, byte[] profilepic, double wallet, int points, string status)
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
    }

    public class Driver : UserInformation, Users
    {
        private string plateNumber;
        private byte[] qrCode;
        private string route;
        private string jeepType;
        public string PlateNumber { get => plateNumber; set => plateNumber = value; }
        public byte[] QRCode { get => qrCode; set => qrCode = value; }
        public string Route { get => route; set => route = value; }
        public string JeepType { get => jeepType; set => jeepType = value; }
        // Constructor
        public Driver(int userId, string name,  string email, string username, string password, string gender, string userType, string birthday, byte[] attachment, string plateNumber, byte[] profilepic, double wallet, byte[] qrcode, string route, string jeeptype, string status)
            : base(userId, name, email, username, password, gender, userType, birthday, attachment, profilepic, wallet, status)
        {
            PlateNumber = plateNumber;
            QRCode = qrcode;
            Route = route;
            JeepType = jeeptype;
        }

        public void SaveToDatabase()
        {
            string query = "INSERT INTO Accounts (Username, [Password], [Full Name], [Email Address], Gender, [User Type], Birthday, Attachment, [Plate Number], [Profile Picture],  Wallet, [QR Code], Route, [Jeep Type], [Status]) " +
                           "VALUES (?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?)";

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
                cmd.Parameters.AddWithValue("?", (object)this.QRCode ?? DBNull.Value);
                cmd.Parameters.AddWithValue("?", this.Route);
                cmd.Parameters.AddWithValue("?", this.JeepType);
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

    public class Trip
    {
        private int driverID;
        private int passengerID;
        private DateTime tripDate;
        private string passengerName;
        private string driverName;
        private string route;
        private string location;
        private string destination;
        private double fareAmount;

        public int DriverID { get => driverID; set => driverID = value; }
        public int PassengerID { get => passengerID; set => passengerID = value; }
        public DateTime TripDate { get => tripDate; set => tripDate = value; }
        public string PassengerName { get => passengerName; set => passengerName = value; }
        public string DriverName { get => driverName; set => driverName = value; }
        public string Route { get => route; set => route = value; }
        public string Location { get => location; set => location = value; }
        public string Destination { get => destination; set => destination = value; }
        public double FareAmount { get => fareAmount; set => fareAmount = value; }

        public Trip(int driverID, int passengerID, DateTime tripDate, string passengerName,
                string driverName, string route, string location, string destination, double fareAmount)
        {
            this.driverID = driverID;
            this.passengerID = passengerID;
            this.tripDate = tripDate;
            this.passengerName = passengerName;
            this.driverName = driverName;
            this.route = route;
            this.location = location;
            this.destination = destination;
            this.fareAmount = fareAmount;
        }

        public void SaveTripToDatabase()
        {

            string query = "INSERT INTO Trips ([Trip Date], PassengerID, Passenger, DriverID, Driver, Route, Location, Destination, [Fare Amount]) " +
                           "VALUES (?, ?, ?, ?, ?, ?, ?, ?, ?)";

            using (OleDbConnection conn = DatabaseManagement.GetConnection())
            using (OleDbCommand cmd = new OleDbCommand(query, conn))
            {
                conn.Open();

                cmd.Parameters.Add("?", OleDbType.Date).Value = this.TripDate; 
                cmd.Parameters.AddWithValue("?", this.PassengerID);
                cmd.Parameters.AddWithValue("?", this.PassengerName);
                cmd.Parameters.AddWithValue("?", this.DriverID);
                cmd.Parameters.AddWithValue("?", this.DriverName);
                cmd.Parameters.AddWithValue("?", this.Route);
                cmd.Parameters.AddWithValue("?", this.Location);
                cmd.Parameters.AddWithValue("?", this.Destination);
                cmd.Parameters.AddWithValue("?", this.FareAmount);

                cmd.ExecuteNonQuery();
            }
            SaveTransaction();
        }

        private void SaveTransaction()
        {
            string insertTransactionQuery = "INSERT INTO Transactions (UserID, TransactionDate, [Full Name], Amount, [Type]) VALUES (?, ?, ?, ?, ?)";
            using (OleDbConnection conn = DatabaseManagement.GetConnection())
            using (OleDbCommand cmd = new OleDbCommand(insertTransactionQuery, conn))
            {
                conn.Open();

                cmd.Parameters.AddWithValue("?", this.PassengerID);
                cmd.Parameters.Add("?", OleDbType.Date).Value = this.TripDate; 
                cmd.Parameters.AddWithValue("?", this.PassengerName);
                cmd.Parameters.AddWithValue("?", this.FareAmount);
                cmd.Parameters.AddWithValue("?", "Trip Payment");

                cmd.ExecuteNonQuery();
            }
            PayDriver();
        }

        private void PayDriver()
        {
            using (OleDbConnection conn = DatabaseManagement.GetConnection())
            {
                conn.Open();
                double currentWallet = 0;
                string getWalletQuery = "SELECT Wallet FROM Accounts WHERE ID = ?";
                using (OleDbCommand cmd = new OleDbCommand(getWalletQuery, conn))
                {
                    cmd.Parameters.AddWithValue("?", this.DriverID);
                    object result = cmd.ExecuteScalar();
                    if (result != null)
                    {
                        currentWallet = Convert.ToDouble(result);
                    }
                }

                double newBalance = currentWallet + this.FareAmount;
                string updateWalletQuery = "UPDATE Accounts SET Wallet = ? WHERE ID = ?";
                using (OleDbCommand cmd = new OleDbCommand(updateWalletQuery, conn))
                {
                    cmd.Parameters.AddWithValue("?", newBalance);
                    cmd.Parameters.AddWithValue("?", DriverID);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public double DeductFareAmountToWallet()
        {
            double passengerWallet = 0;
            using (OleDbConnection conn = DatabaseManagement.GetConnection())
            {
                conn.Open();
                string walletQuery = "SELECT Wallet FROM ACCOUNTS WHERE ID = ?";
                using (OleDbCommand cmd = new OleDbCommand(walletQuery, conn))
                {
                    cmd.Parameters.AddWithValue("?", this.PassengerID);
                    object result = cmd.ExecuteScalar();
                    if (result != null)
                    {
                        passengerWallet = Convert.ToDouble(result);
                    }
                }

                double newBalance = passengerWallet - this.FareAmount;
                string updateQuery = "UPDATE Accounts SET Wallet = ? WHERE ID = ?";
                using (OleDbCommand cmd = new OleDbCommand(updateQuery, conn))
                {
                    cmd.Parameters.AddWithValue("?", newBalance);
                    cmd.Parameters.AddWithValue("?", this.PassengerID);
                    cmd.ExecuteNonQuery();
                }
            }
            return passengerWallet;
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
}
