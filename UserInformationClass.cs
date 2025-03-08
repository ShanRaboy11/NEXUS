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
        public int UserID { get; set; }
        public string Name { get; set; }
        public string ContactInfo { get; set; }
        public string Email { get; set; }
        public string Username { get; set; }
        private string hashedPassword; 
        public double WalletAmount { get; set; }

        // Constructor
        protected UserInformation(int userId, string name, string contactInfo, string email, string username, string password)
        {
            UserID = userId;
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
        public Passenger(int userID, string name, string contactInfo, string email, string username, string password)
            : base(userID, name, contactInfo, email, username, password)
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
        public Driver(int userID, string name, string contactInfo, string email, string username, string password, double ratings, string vehicleType, string plateNumber)
            : base(userID, name, contactInfo, email, username, password)
        {
            Ratings = ratings;
            VehicleType = vehicleType;
            PlateNumber = plateNumber;
        }
    }

    public class EmergencyReport
    {
        public int ReportID;
        public int PassengerID;
        public int DriverID;
        public string IncidentDetails;
        public DateTime TimeStamp;
    }

    public class RatingSystem
    {
        public int RatingID;
        public int PassengerID;
        public int DriverID;
        public string Feedback;
    }

    public class Trip
    {
        public int TripID;
        public string RouteTaken;
        public double FarePaid;
        public DateTime TripTimeStamp;

        public string GenerateReceipt()
        {
            return null;
        }
    }
}
