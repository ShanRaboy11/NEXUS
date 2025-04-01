using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data;

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
            string query = "SELECT ID, Username, [Password], [Full Name], [Email Address], Gender, [User Type], Birthday, Attachment, [Plate Number], [Profile Picture], Wallet, [QR Code], Route, Status " +
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
                        string status = reader.IsDBNull(14) ? "Pending" : reader.GetString(14);

                        return new Driver(UserID, fullName, email, username, password, gender, userType, birthday, attachment, plateNumber, profilepic, wallet, qrcode, route, status);
                    }
                }
            }
            return null;
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
