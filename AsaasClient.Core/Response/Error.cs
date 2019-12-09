using Newtonsoft.Json;

namespace AsaasClient.Core.Response
{
    public class Error
    {
        [JsonProperty(PropertyName = "code")]
        public string Code { get; internal set; }

        [JsonProperty(PropertyName = "description")]
        public string Description { get; internal set; }
    }
}
