using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NEXUS.Forms
{
    internal class OpenRouteService
    {
        private static readonly string apiKey = "5b3ce3597851110001cf6248f1f4ce0b30f741b6bb6844928593358a"; // 🔐 Replace with your actual API key

        public static async Task GetDistanceCebuAsync()
        {
            string start = "123.9031,10.3232"; // SM City Cebu (longitude,latitude)
            string end = "123.8936,10.2943";   // Colon Street

            string url = $"https://api.openrouteservice.org/v2/directions/driving-car?api_key={apiKey}&start={start}&end={end}";

            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage response = await client.GetAsync(url);

                if (response.IsSuccessStatusCode)
                {
                    string json = await response.Content.ReadAsStringAsync();
                    JObject data = JObject.Parse(json);

                    double distanceMeters = data["features"][0]["properties"]["summary"]["distance"].Value<double>();
                    double distanceKm = distanceMeters / 1000;

                    Console.WriteLine($"🚗 Distance in Cebu: {distanceKm:F2} km");
                }
                else
                {
                    Console.WriteLine("❌ Request failed: " + response.StatusCode);
                }
            }
        }
    }
}
