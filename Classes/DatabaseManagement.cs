using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data;
using Microsoft.VisualBasic.ApplicationServices;
using System.Collections;

namespace NEXUS.Classes
{
    internal class DatabaseManagement
    {
        OleDbConnection? myConn;
        OleDbDataAdapter? da;
        OleDbCommand? cmd;
        DataSet? ds;

        private static string connectionString = @"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = C:\Users\Shan Michael\OneDrive\文档\2nd Year 2nd Sem\OOP2\NEXUS\NEXUS.accdb";

        public static OleDbConnection GetConnection()
        {
            return new OleDbConnection(connectionString);
        }

        public static void CashInLoad(int userId, string name, double amount)
        {
            string query = "INSERT INTO [Cash In] ([Request Date], UserID, [Full Name], Amount)" +
                "VALUES (?, ?, ?, ?)";

            using (OleDbConnection conn = DatabaseManagement.GetConnection())
            using (OleDbCommand cmd = new OleDbCommand(query, conn))
            {
                conn.Open();

                cmd.Parameters.Add("?", OleDbType.Date).Value = DateTime.Now;
                cmd.Parameters.AddWithValue("?", userId);
                cmd.Parameters.AddWithValue("?", name);
                cmd.Parameters.AddWithValue("?", amount);

                cmd.ExecuteNonQuery();
            }
        }

        public static void CashOutRequest(int userId, string name, double amount)
        {
            string query = "INSERT INTO [Cash Out] ([Request Date], UserID, [Full Name], Amount)" +
                "VALUES (?, ?, ?, ?)";

            using (OleDbConnection conn = DatabaseManagement.GetConnection())
            using (OleDbCommand cmd = new OleDbCommand(query, conn))
            {
                conn.Open();

                cmd.Parameters.Add("?", OleDbType.Date).Value = DateTime.Now;
                cmd.Parameters.AddWithValue("?", userId);
                cmd.Parameters.AddWithValue("?", name);
                cmd.Parameters.AddWithValue("?", amount);

                cmd.ExecuteNonQuery();
            }
        }

        public static void SaveQrCode(int userID, string filePath)
        {
            string query = "UPDATE Accounts SET [QR Code] = ? WHERE ID = ?";

            using (OleDbConnection conn = DatabaseManagement.GetConnection())
            using (OleDbCommand cmd = new OleDbCommand(query, conn))
            {
                conn.Open();
                cmd.Parameters.AddWithValue("?", filePath);
                cmd.Parameters.AddWithValue("?", userID);

                cmd.ExecuteNonQuery();
            }
        }

        public Driver GetUserInfoByID(int userID)
        {
            string query = "SELECT ID, Username, [Password], [Full Name], [Email Address], Gender, [User Type], Birthday, Attachment, [Plate Number], [Profile Picture], Wallet, [QR Code], Route, [Jeep Type], Status " +
                    "FROM Accounts WHERE ID = ?";


            using (OleDbConnection conn = DatabaseManagement.GetConnection())
            using (OleDbCommand cmd = new OleDbCommand(query, conn))
            {
                conn.Open();
                cmd.Parameters.AddWithValue("?", userID);

                using (OleDbDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        int UserID = reader.GetInt32(0);
                        string username = reader.GetString(1);
                        string password = reader.GetString(2);
                        string fullName = reader.GetString(3);
                        string email = reader.GetString(4);
                        string gender = reader.GetString(5);
                        string userType = reader.GetString(6);
                        string birthday = reader.GetString(7);
                        byte[] attachment = reader.GetFieldValue<byte[]>(8);
                        string plateNumber = reader.GetString(9);
                        byte[] profilepic = reader.GetFieldValue<byte[]>(10);
                        double wallet = reader.IsDBNull(11) ? 0.0 : Convert.ToDouble(reader.GetValue(11));
                        byte[] qrcode = reader.IsDBNull(12) ? null : reader.GetFieldValue<byte[]>(12);
                        string route = reader.IsDBNull(13) ? null : reader.GetString(13);
                        string jeepType = reader.GetString(14);
                        string status = reader.IsDBNull(15) ? "Pending" : reader.GetString(15);

                        return new Driver(UserID, fullName, email, username, password, gender, userType, birthday, attachment, plateNumber, profilepic, wallet, qrcode, route, jeepType, status);
                    }
                }
            }
            return null;
        }

        public Passenger GetPassengerInfoByID(int userID)
        {
            string query = "SELECT ID, Username, [Password], [Full Name], [Email Address], Gender, [User Type], Birthday, Classification, Attachment, [Profile Picture], Wallet, Points , Status " +
                    "FROM Accounts WHERE ID = ?";


            using (OleDbConnection conn = DatabaseManagement.GetConnection())
            using (OleDbCommand cmd = new OleDbCommand(query, conn))
            {
                conn.Open();
                cmd.Parameters.AddWithValue("?", userID);

                using (OleDbDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        int UserID = reader.GetInt32(0);
                        string username = reader.GetString(1);
                        string password = reader.GetString(2);
                        string fullName = reader.GetString(3);
                        string email = reader.GetString(4);
                        string gender = reader.GetString(5);
                        string userType = reader.GetString(6);
                        string birthday = reader.GetString(7);
                        string classification = reader.GetString(8);
                        byte[] attachment = reader.IsDBNull(9) ? null : reader.GetFieldValue<byte[]>(9);
                        byte[] profilepic = reader.GetFieldValue<byte[]>(10);
                        double wallet = reader.IsDBNull(11) ? 0.0 : Convert.ToDouble(reader.GetValue(11));
                        int points = reader.IsDBNull(12) ? 0 : Convert.ToInt32(reader.GetValue(12));
                        string status = reader.IsDBNull(13) ? "Pending" : reader.GetString(13);

                        return new Passenger(UserID, fullName, email, username, password, gender, userType, birthday, classification, attachment, profilepic, wallet, points, status);
                    }
                }
            }
            return null;
        }

        public bool PaymentValid(decimal amount, int passengerID)
        {
            string queryChecker = "SELECT Wallet FROM Accounts WHERE ID = ?";
            double wallet = 0.0;  // Ensure it's initialized

            using (OleDbConnection conn = DatabaseManagement.GetConnection())
            using (OleDbCommand cmd = new OleDbCommand(queryChecker, conn))
            {
                conn.Open();
                cmd.Parameters.AddWithValue("?", passengerID);

                using (OleDbDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        wallet = reader.IsDBNull(0) ? 0.0 : Convert.ToDouble(reader.GetValue(0));
                    }
                }
            }

            return wallet >= (double)amount;  // Ensure correct logic
        }

        public static void UpdateAccountAttachment(int accountId, byte[] attachment)
        {
            string query = "UPDATE Accounts SET Attachment = ? WHERE ID = ?";

            using (OleDbConnection conn = GetConnection())
            {
                using (OleDbCommand command = new OleDbCommand(query, conn))
                {
                    command.Parameters.Add("Attachment", OleDbType.Binary).Value = attachment;
                    command.Parameters.Add("ID", OleDbType.Integer).Value = accountId;

                    conn.Open();
                    command.ExecuteNonQuery();
                }
            }
        }

        public static void UpdateAccountUsername(int accountId, string newUsername)
        {
            string query = "UPDATE Accounts SET Username = ? WHERE ID = ?";

            using (OleDbConnection conn = GetConnection())
            {
                using (OleDbCommand command = new OleDbCommand(query, conn))
                {
                    command.Parameters.Add("Username", OleDbType.VarChar).Value = newUsername;
                    command.Parameters.Add("ID", OleDbType.Integer).Value = accountId;

                    conn.Open();
                    command.ExecuteNonQuery();
                }
            }
        }

        public static void ResubmitValidID(int accountId)
        {
            string query = "UPDATE Accounts SET Status = ? WHERE ID = ?";

            using (OleDbConnection conn = GetConnection())
            {
                using (OleDbCommand command = new OleDbCommand(query, conn))
                {
                    // ORDER matters, names are ignored but harmless
                    command.Parameters.Add("Status", OleDbType.Char).Value = "Pending";
                    command.Parameters.Add("ID", OleDbType.Integer).Value = accountId;

                    conn.Open();
                    command.ExecuteNonQuery();
                }
            }
        }


        public static void UpdateAccountProfilePic(int accountId, byte[] profilepic)
        {
            string query = "UPDATE Accounts SET [Profile Picture] = ? WHERE ID = ?";

            using (OleDbConnection conn = GetConnection())
            {
                using (OleDbCommand command = new OleDbCommand(query, conn))
                {
                    command.Parameters.Add("Profile Picture", OleDbType.Binary).Value = profilepic;
                    command.Parameters.Add("ID", OleDbType.Integer).Value = accountId;

                    conn.Open();
                    command.ExecuteNonQuery();
                }
            }
        }

        public static DataTable GetUnreadNotifications(int userID)
        {
            string query = "SELECT * FROM Notifications WHERE UserID = ? AND Status = 'Unread'";

            using (OleDbConnection conn = GetConnection())
            using (OleDbCommand command = new OleDbCommand(query, conn))
            using (OleDbDataAdapter adapter = new OleDbDataAdapter(command))
            {
                command.Parameters.AddWithValue("PassengerID", userID);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
        }

        public static void MarkNotificationsAsRead(int userID)
        {
            string query = "UPDATE Notifications SET Status = 'Read' WHERE UserID = ? AND Status = 'Unread'";

            using (OleDbConnection conn = GetConnection())
            using (OleDbCommand command = new OleDbCommand(query, conn))
            {
                command.Parameters.AddWithValue("PassengerID", userID);
                conn.Open();
                command.ExecuteNonQuery();
            }
        }



        public static OleDbConnection Connect()
        {
            try
            {
                OleDbConnection conn = new OleDbConnection(connectionString);
                conn.Open();
                return conn;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database Connection Error: " + ex.Message);
                return null;
            }
        }


    }
}
