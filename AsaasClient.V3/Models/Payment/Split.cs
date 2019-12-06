using Newtonsoft.Json;

namespace AsaasClient.V3.Models.Payment
{
    public class Split
    {
        [JsonProperty(PropertyName = "walletId")]
        public string WalletId { get; set; }

        [JsonProperty(PropertyName = "fixedValue")]
        public decimal FixedValue { get; set; }

        [JsonProperty(PropertyName = "percentualValue")]
        public decimal PercentualValue { get; set; }
    }
}
