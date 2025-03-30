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

        //Get Database Connection
        public static OleDbConnection GetConnection()
        {
            return new OleDbConnection(connectionString);
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
