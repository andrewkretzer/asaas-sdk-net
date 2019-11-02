using Newtonsoft.Json;

namespace AsaasClient.Core.Response
{
    public class Error
    {
        [JsonProperty(PropertyName = "code")]
        public string Code { get; }

        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }
    }
}
