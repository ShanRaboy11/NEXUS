using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using NEXUS.Properties;
using System.Data.OleDb;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace NEXUS.Classes
{
    public class Cryptography
    {
        public static string ToSHA256(string s)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(s));
                StringBuilder sb = new StringBuilder();

                for (int i = 0; i < bytes.Length; i++)
                {
                    sb.Append(bytes[i].ToString("x2"));
                }

                return sb.ToString();
            }
        }

        public static UserInformation VerifyPassword(string userName, string enteredPassword)
        {
            string query = "SELECT ID, Username, [Password], [Full Name], [Email Address], Gender, [User Type], Birthday, Classification, Attachment, [Profile picture], Wallet, Points, [QR Code], Route, [Status] " +
                   "FROM Accounts WHERE Username = ?";

            string enteredHash = ToSHA256(enteredPassword);

            using (OleDbConnection conn = DatabaseManagement.GetConnection())
            using (OleDbCommand cmd = new OleDbCommand(query, conn))
            {
                conn.Open();
                cmd.Parameters.AddWithValue("?", userName);

                using (OleDbDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read()) // If a record is found
                    {
                        string storedHash = reader.GetString(2);

                        if (enteredHash.Equals(storedHash, StringComparison.OrdinalIgnoreCase))
                        {
                            int userID = reader.GetInt32(0);  // Retrieve UserID
                            string username = reader.GetString(1);
                            string password = reader.GetString(2);
                            string fullName = reader.GetString(3);
                            string email = reader.GetString(4);
                            string gender = reader.GetString(5);
                            string userType = reader.GetString(6);
                            string birthday = reader.GetString(7);
                            string classification = reader.IsDBNull(8) ? null : reader.GetString(8);
                            byte[] attachment = reader.IsDBNull(9) ? null : reader.GetFieldValue<byte[]>(9);
                            string profilepic = reader.GetString(10);
                            double wallet = reader.IsDBNull(11) ? 0.0 : Convert.ToDouble(reader.GetValue(11));
                            int points = reader.IsDBNull(12) ? 0 : Convert.ToInt32(reader.GetValue(12));
                            byte[] qrcode = reader.IsDBNull(13) ? null : reader.GetFieldValue<byte[]>(13);
                            string route = reader.IsDBNull(14) ? null : reader.GetString(14);
                            string status = reader.GetString(15);

                            if (userType == "Passenger")
                            {
                                return new Passenger(userID, fullName, email, username, password, gender, userType, birthday, classification, attachment, profilepic, wallet, points, status);
                            }
                            else
                            {
                                string plateNumber = reader.IsDBNull(10) ? null : reader.GetString(10);
                                return new Driver(userID, fullName, email, username, password, gender, userType, birthday, attachment, plateNumber, profilepic, wallet, qrcode, route, status);
                            }
                        }
                    }
                }
            }
            return null; 
        }

        public static UserInformation GetUserInfo(string Username, string Usertype)
        {
            if(Usertype == "Passenger")
            {
                string query = "SELECT ID, Username, [Password], [Full Name], [Email Address], Gender, [User Type], Birthday, Classification, Attachment, [Profile Picture], Wallet, Points, [Status] " +
                   "FROM Accounts WHERE Username = ?";


                using (OleDbConnection conn = DatabaseManagement.GetConnection())
                using (OleDbCommand cmd = new OleDbCommand(query, conn))
                {
                    conn.Open();
                    cmd.Parameters.AddWithValue("?", Username);

                    using (OleDbDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            int userID = reader.GetInt32(0);  // Retrieve UserID
                            string username = reader.GetString(1);
                            string password = reader.GetString(2);
                            string fullName = reader.GetString(3);
                            string email = reader.GetString(4);
                            string gender = reader.GetString(5);
                            string userType = reader.GetString(6);
                            string birthday = reader.GetString(7);
                            string classification = reader.IsDBNull(8) ? null : reader.GetString(8);
                            byte[] attachment = reader.IsDBNull(9) ? null : reader.GetFieldValue<byte[]>(9);
                            string profilepic = reader.GetString(10);
                            double wallet = reader.IsDBNull(11) ? 0.0 : Convert.ToDouble(reader.GetValue(11));
                            int points = reader.IsDBNull(12) ? 0 : Convert.ToInt32(reader.GetValue(12));
                            string status = reader.GetString(13);

                            return new Passenger(userID, fullName, email, username, password, gender, userType, birthday, classification, attachment, profilepic, wallet, points, status);
                        }
                    }
                }
                return null;
            }
            else
            {
                string query = "SELECT ID, Username, [Password], [Full Name], [Email Address], Gender, [User Type], Birthday, Attachment, [Plate Number], [Profile Picture], Wallet, [QR Code], Route, Status " +
                   "FROM Accounts WHERE Username = ?";


                using (OleDbConnection conn = DatabaseManagement.GetConnection())
                using (OleDbCommand cmd = new OleDbCommand(query, conn))
                {
                    conn.Open();
                    cmd.Parameters.AddWithValue("?", Username);

                    using (OleDbDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            int userID = reader.GetInt32(0);  
                            string username = reader.GetString(1);
                            string password = reader.GetString(2);
                            string fullName = reader.GetString(3);
                            string email = reader.GetString(4);
                            string gender = reader.GetString(5);
                            string userType = reader.GetString(6);
                            string birthday = reader.GetString(7);
                            byte[] attachment = reader.GetFieldValue<byte[]>(8);
                            string plateNumber = reader.GetString(9);
                            string profilepic = reader.GetString(10);
                            double wallet = reader.IsDBNull(11) ? 0.0 : Convert.ToDouble(reader.GetValue(11));
                            byte[] qrcode = reader.IsDBNull(12) ? null : reader.GetFieldValue<byte[]>(12);
                            string route = reader.IsDBNull(13) ? null : reader.GetString(13); 
                            string status = reader.IsDBNull(14) ? "Pending" : reader.GetString(14);

                            return new Driver(userID, fullName, email, username, password, gender, userType, birthday, attachment, plateNumber, profilepic, wallet, qrcode, route, status);
                        }
                    }
                }
                return null;
            }
        }

        public static void AdminPassword(string password)
        {
            string hashedPassword = ToSHA256(password);
            string query = "UPDATE Accounts SET [Password] = ? WHERE Username = 'admin'";

            using (OleDbConnection connect = DatabaseManagement.GetConnection())
            {
                using (OleDbCommand cmd = new OleDbCommand(query, connect))
                {
                    connect.Open();
                    cmd.Parameters.AddWithValue("?", hashedPassword);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public static bool VerifyAdminPassword(string password)
        {
            string enteredHash = ToSHA256(password); 
            string query = "SELECT [Password] FROM Accounts WHERE Username = 'admin'";

            using (OleDbConnection conn = DatabaseManagement.GetConnection())
            using (OleDbCommand cmd = new OleDbCommand(query, conn))
            {
                conn.Open();

                using (OleDbDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read()) 
                    {
                        string storedHash = reader.GetString(0);
                        return enteredHash.Equals(storedHash, StringComparison.OrdinalIgnoreCase);
                    }
                }
            }
            return false;
        }

    }
}
