using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BCrypt.Net;
using NEXUS.Classes;

namespace NEXUS.Classes
{
    public interface Users
    {
        float ProcessPayment();
        double CheckBalance();
    }

    public abstract class UserInformation
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Username { get; set; }
        private string HashedPassword;
        public string Gender { get; set; }
        public string UserType { get; set; }
        public string Birthday { get; set; }
        public string Classification { get; set; }
        public double WalletAmount { get; set; }

        // Constructor
        protected UserInformation(string name,  string email, string username, string password, string gender, string userType, string birthday, string classification)
        {
            Name = name;
            Email = email;
            Username = username;
            HashedPassword = Cryptography.ToSHA256(password);
            Gender = gender;
            UserType = userType;
            Birthday = birthday;
            Classification = classification;
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

        // Constructor
        public Passenger(string name, string email, string username, string password, string gender, string userType, string birthday, string classification)
            : base(name, email, username, password, gender, userType, birthday, classification)
        { }

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
        public string PlateNumber { get; set; }

        // Constructor
        public Driver(string name,  string email, string username, string password, string gender, string userType, string birthday, string classification,  string plateNumber)
            : base(name, email, username, password, gender, userType, birthday, classification)
        {
            PlateNumber = plateNumber;
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
