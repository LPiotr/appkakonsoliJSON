using System.Net;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace appkakonsoliJSON
{
    public class GetLocationByIP
    {
        static string URL = "http://ip-api.com/json/";

        [JsonPropertyName("city")]
        public string City { get; set; }

        [JsonPropertyName("lat")]
        public double Latitude { get; set; }

        [JsonPropertyName("lon")]
        public double Longtitude { get; set; } 
    


        public string CheckMyIP()
        {
            //zwraca nam nasz adresIP publiczny od dostawcy ISP
            var externalip = new WebClient().DownloadString("https://ipv4.icanhazip.com/").TrimEnd();
            return externalip;
        }

        public string LocationName(string IPAddress)
        {
            //object location = new GetLocationByIP();

            string url = URL + IPAddress + @"?fields=city,lat,lon";
            string html = "";

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.AutomaticDecompression = DecompressionMethods.GZip;

            using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
            using (Stream stream = response.GetResponseStream())
            using (StreamReader reader = new StreamReader(stream))
            {
                html = reader.ReadToEnd();
            }


            GetLocationByIP? getLocation =
               JsonSerializer.Deserialize<GetLocationByIP>(html);

            Console.WriteLine($"Town: {getLocation?.City}");
            Console.WriteLine($"Lattitude: {getLocation?.Latitude}");
            Console.WriteLine($"Longtitude: {getLocation?.Longtitude}");


            return "";
        }
    }

}
