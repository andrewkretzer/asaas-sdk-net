using Newtonsoft.Json;

namespace AsaasClient.Response
{
    public class Error
    {
        [JsonProperty(PropertyName = "code")]
        public string Code { get; }

        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }
    }
}
