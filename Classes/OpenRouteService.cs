using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NEXUS.Classes
{
    internal class OpenRouteService
    {
        private static readonly string apiKey = "API KEY FROM OPENROUTESERVICE API"; 

        public static async Task<(double lon, double lat)> GetCoordinatesFromDatabase(string jeepCode, string location)
        {
            const string query = "SELECT Latitude, Longitude FROM Routes WHERE [Jeep Code] = ? AND [Jeep Stop] = ?";

            using (OleDbConnection conn = DatabaseManagement.GetConnection())
            using (OleDbCommand cmd = new OleDbCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("?", jeepCode);
                cmd.Parameters.AddWithValue("?", location);
                await conn.OpenAsync();

                using (OleDbDataReader reader = cmd.ExecuteReader())
                {
                    if (await reader.ReadAsync())
                    {
                        var latitudeObj = reader["Latitude"];
                        var longitudeObj = reader["Longitude"];

                        if (latitudeObj != DBNull.Value && longitudeObj != DBNull.Value)
                        {
                            double lat = Convert.ToDouble(latitudeObj);
                            double lon = Convert.ToDouble(longitudeObj);
                            return (lon, lat);
                        }
                        else
                        {
                            throw new Exception("Latitude or Longitude is missing in the database record.");
                        }
                    }
                }
            }

            throw new Exception($"Jeep stop with code '{jeepCode}' and location '{location}' not found in database.");
        }



        public static async Task<double> CalculateDistance(string jeepCode, string location, string destination)
        {
            var (startLon, startLat) = await GetCoordinatesFromDatabase(jeepCode, location);
            var (endLon, endLat) = await GetCoordinatesFromDatabase(jeepCode, destination);

            string url = $"https://api.openrouteservice.org/v2/directions/driving-car?api_key={apiKey}&start={startLon},{startLat}&end={endLon},{endLat}";

            using (HttpClient client = new HttpClient())
            {
                string json = await client.GetStringAsync(url);
                JObject data = JObject.Parse(json);

                if (data["features"] == null || data["features"].Count() == 0)
                    throw new Exception("No route data found in the API response.");

                double distanceMeters = data["features"][0]["properties"]["summary"]["distance"].Value<double>();
                double distanceKm = distanceMeters / 1000;
                return distanceKm;
            }
        }
    }
}
