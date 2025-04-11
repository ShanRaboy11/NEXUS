using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Web.WebView2.WinForms;
using Newtonsoft.Json;

namespace NEXUS.Forms
{
    public partial class Map : Form
    {
        double latitude = 10.295261349234304;
        double longitude = 123.88125737517491;
        public Map()
        {
            InitializeComponent();
            InitializeMap();
        }

        private async void InitializeMap()
        {
            await webViewMap.EnsureCoreWebView2Async(null);

            webViewMap.CoreWebView2.PermissionRequested += (sender, args) =>
            {
                if (args.PermissionKind == Microsoft.Web.WebView2.Core.CoreWebView2PermissionKind.Geolocation)
                    args.State = Microsoft.Web.WebView2.Core.CoreWebView2PermissionState.Allow;
            };

            var (latitude, longitude) = await GetLocationFromIP();

            string mapHtml = $@"
<!DOCTYPE html>
<html>
<head>
    <meta charset='utf-8' />
    <title>Map</title>
    <meta name='viewport' content='width=device-width, initial-scale=1.0'>
    <link rel='stylesheet' href='https://unpkg.com/leaflet@1.9.4/dist/leaflet.css'/>
    <script src='https://unpkg.com/leaflet@1.9.4/dist/leaflet.js'></script>
    <style>
        html, body {{
            height: 100%;
            margin: 0;
            font-family: Arial, sans-serif;
        }}
        #loading {{
            position: absolute;
            top: 0;
            left: 0;
            width: 100%;
            height: 100%;
            background: white;
            display: flex;
            align-items: center;
            justify-content: center;
            font-size: 20px;
            font-weight: bold;
            z-index: 1000;
        }}
        #map {{
            width: 100%;
            height: 100%;
            display: none;
        }}
    </style>
</head>
<body>
    <div id='loading'>Detecting your current location...</div>
    <div id='map'></div>
    <script>
        setTimeout(function() {{
            document.getElementById('loading').style.display = 'none';
            document.getElementById('map').style.display = 'block';

            var map = L.map('map').setView([{latitude}, {longitude}], 14);

            L.tileLayer('https://{{s}}.tile.openstreetmap.org/{{z}}/{{x}}/{{y}}.png', {{
                maxZoom: 19,
                attribution: '&copy; OpenStreetMap contributors'
            }}).addTo(map);

            var marker = L.marker([{latitude}, {longitude}]).addTo(map)
                .bindPopup('You are here.')
                .openPopup();

        }}, 2000); // simulate loading delay
    </script>
</body>
</html>
";
            webViewMap.NavigateToString(mapHtml);
        }

        private async Task<(double, double)> GetLocationFromIP()
        {
            try
            {
                using (var httpClient = new HttpClient())
                {
                    var response = await httpClient.GetStringAsync("http://ip-api.com/json/");
                    var data = JsonConvert.DeserializeObject<dynamic>(response);
                    return (latitude, longitude);
                }
            }
            catch
            {
                return (latitude, longitude);
            }
        }
    }
}
