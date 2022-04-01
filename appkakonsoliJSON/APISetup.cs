using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace appkakonsoliJSON
{
    public class APISetup
    {
        [JsonPropertyName("apikey")]
        string? APIKey { get; set; }

        [JsonPropertyName("language")]
        string? Langugage { get; set; }
        [JsonPropertyName("details")]
        bool? Details { get; set; }
    }
}
