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
