using Newtonsoft.Json;

namespace AsaasClient.Models.Payment
{
    public class Split
    {
        [JsonProperty(PropertyName = "walletId")]
        public string WalletId { get; set; }

        [JsonProperty(PropertyName = "fixedValue")]
        public string FixedValue { get; set; }

        [JsonProperty(PropertyName = "percentualValue")]
        public string PercentualValue { get; set; }
    }
}
