using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BCrypt.Net;

namespace NEXUS
{
    public interface Users
    {
        float ProcessPayment();
        double CheckBalance();
    }

    public abstract class UserInformation
    {
        public string Name { get; set; }
        public string ContactInfo { get; set; }
        public string Email { get; set; }
        public string Username { get; set; }
        private string hashedPassword; 
        public double WalletAmount { get; set; }

        // Constructor
        protected UserInformation(string name, string contactInfo, string email, string username, string password)
        {
            Name = name;
            ContactInfo = contactInfo;
            Email = email;
            Username = username;
            SetPassword(password);
        }

        public void SetPassword(string password)
        {
            if (!string.IsNullOrWhiteSpace(password))
            {
                hashedPassword = BCrypt.Net.BCrypt.HashPassword(password);
            }
        }

        // Verify password input against stored hash
        public bool VerifyPassword(string password)
        {
            return BCrypt.Net.BCrypt.Verify(password, hashedPassword);
        }

    }

    public class Passenger : UserInformation
    {
        public List<string> TripHistory { get; private set; }

        // Constructor
        public Passenger(string name, string contactInfo, string email, string username, string password)
            : base(name, contactInfo, email, username, password)
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
        public double Ratings { get; set; }
        public string VehicleType { get; set; }
        public string PlateNumber { get; set; }

        // Constructor
        public Driver(string name, string contactInfo, string email, string username, string password, double ratings, string vehicleType, string plateNumber)
            : base(name, contactInfo, email, username, password)
        {
            Ratings = ratings;
            VehicleType = vehicleType;
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
