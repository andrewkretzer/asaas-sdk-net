using Newtonsoft.Json;

namespace AsaasClient.V3.Models.Transfer
{
    public class AsaasAccountTransferRequest
    {
        [JsonProperty(PropertyName = "walletId")]
        public string WalletId { get; set; }

        [JsonProperty(PropertyName = "value")]
        public decimal Value { get; set; }
    }
}
