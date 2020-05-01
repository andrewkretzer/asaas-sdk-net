using Newtonsoft.Json;

namespace AsaasClient.V3.Models.Transfer
{
    public class BankAccountTransferRequest
    {
        [JsonProperty(PropertyName = "value")]
        public decimal Value { get; set; }

        [JsonProperty(PropertyName = "bankAccount")]
        public BankAccount BankAccount { get; set; }
    }
}
