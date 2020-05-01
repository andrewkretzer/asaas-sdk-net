using Newtonsoft.Json;

namespace AsaasClient.V3.Models.Wallet
{
    public class Wallet
    {
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }
    }
}
