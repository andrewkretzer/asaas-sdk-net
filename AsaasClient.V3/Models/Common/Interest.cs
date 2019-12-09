using Newtonsoft.Json;

namespace AsaasClient.V3.Models.Common
{
    public class Interest
    {
        [JsonProperty(PropertyName = "value")]
        public decimal Value { get; set; }
    }
}
