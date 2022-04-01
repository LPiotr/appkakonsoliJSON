using System.Collections;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace appkakonsoliJSON
{
    public class IPAddressSearch : APISetup
    {
        string IPAddress { get; set; }

        [JsonPropertyName("q")]
        string query { get; set; }
        [JsonPropertyName("details")]
        bool? IncludeDetails  {get; set; }

    }
}
