using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BCrypt.Net;
using NEXUS.Classes;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace NEXUS.Classes
{

    public interface Users
    {
        float ProcessPayment();
        double CheckBalance();
    }

    public abstract class UserInformation
    {
        public int UserID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Username { get; set; }
        protected string HashedPassword { get; set; }
        public string Gender { get; set; }
        public string UserType { get; set; }
        public string Birthday { get; set; }
        public string Attachment {  get; set; }
        public string ProfilePicture { get; set; }
        public double WalletAmount { get; set; }

        // Constructor
        protected UserInformation(int  userID, string name,  string email, string username, string password, string gender, string userType, string birthday, string attachment, string profilepic, double wallet)
        {
            UserID = userID;
            Name = name;
            Email = email;
            Username = username;
            HashedPassword = Cryptography.ToSHA256(password);
            Gender = gender;
            UserType = userType;
            Birthday = birthday;
            Attachment = attachment;
            ProfilePicture = profilepic;
            WalletAmount = wallet;
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

    public class Passenger : UserInformation
    {
        public List<string> TripHistory { get; private set; }
        public string Classification { get; set; }
        public int Points { get; set; }

        private string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Shan Michael\OneDrive\文档\2nd Year 2nd Sem\OOP2\NEXUS\NEXUS.accdb";

        // Constructor
        public Passenger(int userId, string name, string email, string username, string password, string gender, string userType, string birthday, string classification, string attachment, string profilepic, double wallet, int points)
            : base(userId, name, email, username, password, gender, userType, birthday, attachment, profilepic, wallet)
        {
            Classification = classification;
            Points = points;
        }

        public void SaveToDatabase()
        {
            string query = "INSERT INTO Passengers (Username, [Password], [Full Name], [Email Address], Gender, [User Type], Birthday, Classification, Attachment, [Profile Picture], Wallet, Points) " +
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
                cmd.Parameters.AddWithValue("?", Classification);
                cmd.Parameters.AddWithValue("?", string.IsNullOrEmpty(this.Attachment) ? DBNull.Value : this.Attachment);
                cmd.Parameters.AddWithValue("?", this.ProfilePicture);
                cmd.Parameters.AddWithValue("?", this.WalletAmount);
                cmd.Parameters.AddWithValue("?", this.Points);

                cmd.ExecuteNonQuery();
            }
        }

        // Method to add trip history
        public void AddTrip(string tripDetails)
        {
            if (!string.IsNullOrWhiteSpace(tripDetails))
            {
                TripHistory.Add(tripDetails);
            }
        }
    }

    public class Driver : UserInformation
    {
        private string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Shan Michael\OneDrive\文档\2nd Year 2nd Sem\OOP2\NEXUS\NEXUS.accdb";
        public string PlateNumber { get; set; }

        // Constructor
        public Driver(int userId, string name,  string email, string username, string password, string gender, string userType, string birthday, string attachment, string plateNumber, string profilepic, double wallet)
            : base(userId, name, email, username, password, gender, userType, birthday, attachment, profilepic, wallet)
        {
            PlateNumber = plateNumber;
        }

        public void SaveToDatabase()
        {
            string query = "INSERT INTO Drivers (Username, [Password], [Full Name], [Email Address], Gender, [User Type], Birthday, Attachment, [Plate Number], [Profile Picture],  Wallet) " +
                           "VALUES (?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?)";

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
}
