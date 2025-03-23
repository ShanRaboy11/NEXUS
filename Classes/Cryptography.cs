using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using NEXUS.Properties;
using System.Data.OleDb;

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
            string query = "SELECT Username, [Password], [Full Name], [Email Address], Gender, [User Type], Birthday, Classification, Attachment " +
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
                        string storedHash = reader.GetString(1);

                        if (enteredHash.Equals(storedHash, StringComparison.OrdinalIgnoreCase))
                        {
                            string username = reader.GetString(0);
                            string fullName = reader.GetString(2);
                            string email = reader.GetString(3);
                            string gender = reader.GetString(4);
                            string userType = reader.GetString(5);
                            string birthday = reader.GetString(6);
                            string classification = reader.IsDBNull(7) ? null : reader.GetString(7);
                            string attachment = reader.IsDBNull(8) ? null : reader.GetString(8);

                            if (userType == "Passenger")
                            {
                                return new Passenger(fullName, email, username, enteredPassword, gender, userType, birthday, classification, attachment);
                            }
                            else
                            {
                                string plateNumber = reader.IsDBNull(9) ? null : reader.GetString(9);
                                return new Driver(fullName, email, username, enteredPassword, gender, userType, birthday, plateNumber, attachment);
                            }
                        }
                    }
                }
            }
            return null; 
        }
    }
}
