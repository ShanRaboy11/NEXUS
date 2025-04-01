using NEXUS.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Data;
using NEXUS.Classes;

namespace NEXUS.Forms
{
    public partial class RouteFinder : Form
    {
        private string currentJeepCode;
        public RouteFinder()
        {
            InitializeComponent();
        }

        private void cmbxJeepCodes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbxJeepCodes.SelectedItem != null)
            {
                currentJeepCode = cmbxJeepCodes.SelectedItem.ToString();
                JeepCodeDestinations(currentJeepCode);
            }
        }

        private void JeepCodeDestinations(string jeepCode)
        {
            string query = "SELECT [Image Path] FROM [Routes Images] WHERE [Route Number] = ?";  

            string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Shan Michael\OneDrive\文档\2nd Year 2nd Sem\OOP2\NEXUS\NEXUS.accdb";

            using (OleDbConnection conn = new OleDbConnection(connectionString))
            using (OleDbCommand cmd = new OleDbCommand(query, conn))
            {
                conn.Open();
                cmd.Parameters.AddWithValue("?", jeepCode);  

                using (OleDbDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        string imagePath = reader["Image Path"].ToString(); 
                        if (File.Exists(imagePath))
                        {
                            pbJeepDestination.Image = Image.FromFile(imagePath);
                        }
                        else
                        {
                            pbJeepDestination.Image = Resources._default;
                        }
                    }
                }
            }
        }

    }
}