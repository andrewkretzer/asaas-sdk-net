using Newtonsoft.Json;

namespace AsaasClient.Models.Common
{
    public class Fine
    {
        [JsonProperty(PropertyName = "value")]
        public decimal Value { get; set; }
    }
}
