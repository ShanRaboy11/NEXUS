using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Web.WebView2.WinForms;
using Microsoft.Web.WebView2.Core;
using System.Net.Http;
using Newtonsoft.Json;

namespace NEXUS.Forms
{
    public partial class Map : Form
    {
        public Map()
        {
            InitializeComponent();
            InitializeMap();
        }

        private async void InitializeMap()
        {
            await webViewMap.EnsureCoreWebView2Async(null);

            // Fetch location from IP
            var (latitude, longitude) = await GetLocationFromIP();

            // Load map
            LoadMap(latitude, longitude);
        }

        private async Task<(double, double)> GetLocationFromIP()
        {
            using (var httpClient = new HttpClient())
            {
                var response = await httpClient.GetStringAsync("http://ip-api.com/json/");
                var data = JsonConvert.DeserializeObject<dynamic>(response);

                double latitude = data.lat;
                double longitude = data.lon;

                return (latitude, longitude);
            }
        }

        private async void LoadMap(double latitude, double longitude)
        {
            await webViewMap.EnsureCoreWebView2Async(null);

            string mapHtml = $@"
            <!DOCTYPE html>
            <html>
            <head>
                <style>
                    body, html {{
                        height: 100%;
                        margin: 0;
                    }}
                    #map {{
                        height: 100%;
                        width: 100%;
                    }}
                </style>
                <script src=""https://maps.googleapis.com/maps/api/js?key=YOUR_API_KEY""></script>
                <script>
                    function initMap() {{
                        var location = {{ lat: {latitude}, lng: {longitude} }};
                        var map = new google.maps.Map(document.getElementById('map'), {{
                            center: location,
                            zoom: 14
                        }});
                        new google.maps.Marker({{
                            position: location,
                            map: map
                        }});
                    }}
                </script>
            </head>
            <body onload=""initMap()"">
                <div id=""map""></div>
            </body>
            </html>
        ";

            webViewMap.NavigateToString(mapHtml);
        }
    }
}
