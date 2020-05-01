using Newtonsoft.Json;

namespace AsaasClient.V3.Models.Transfer
{
    public class Bank
    {
        [JsonProperty(PropertyName = "code")]
        public string Code { get; set; }
    }
}
