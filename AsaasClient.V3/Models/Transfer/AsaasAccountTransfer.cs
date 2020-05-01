using AsaasClient.V3.Models.Transfer.Base;
using AsaasClient.V3.Models.Transfer.Enums;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace AsaasClient.V3.Models.Transfer
{
    public class AsaasAccountTransfer : BaseTransfer
    {
        [JsonProperty(PropertyName = "walletId")]
        public string WalletId { get; set; }

        [JsonProperty(PropertyName = "status")]
        [JsonConverter(typeof(StringEnumConverter))]
        public AsaasAccountTransferStatus Status { get; set; }

        [JsonProperty(PropertyName = "account")]
        public AsaasAccount Account { get; set; }
    }
}
