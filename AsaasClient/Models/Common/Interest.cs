using Newtonsoft.Json;

namespace AsaasClient.Models.Common
{
    public class Interest
    {
        [JsonProperty(PropertyName = "value")]
        public decimal Value { get; set; }
    }
}
