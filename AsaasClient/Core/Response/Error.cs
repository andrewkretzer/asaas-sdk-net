using System.Text.Json.Serialization;

namespace AsaasClient.Core.Response
{
    public class Error
    {
        [JsonPropertyName("code")]
        public string Code { get; internal set; }

        [JsonPropertyName( "description")]
        public string Description { get; internal set; }
    }
}
