using AsaasClient.V3.Models.Transfer.Base;
using AsaasClient.V3.Models.Transfer.Enums;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace AsaasClient.V3.Models.Transfer
{
    public class BankAccountTransfer : BaseTransfer
    {
        [JsonProperty(PropertyName = "netValue")]
        public decimal NetValue { get; set; }

        [JsonProperty(PropertyName = "status")]
        [JsonConverter(typeof(StringEnumConverter))]
        public BankAccountTransferStatus Status { get; set; }

        [JsonProperty(PropertyName = "bankAccount")]
        public BankAccount BankAccount { get; set; }
    }
}
