using AsaasClient.V3.Models.Transfer.Enums;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;

namespace AsaasClient.V3.Models.Transfer
{
    public class BankAccount
    {
        [JsonProperty(PropertyName = "bank")]
        public Bank Bank { get; set; }

        [JsonProperty(PropertyName = "accountName")]
        public string AccountName { get; set; }

        [JsonProperty(PropertyName = "ownerName")]
        public string OwnerName { get; set; }

        [JsonProperty(PropertyName = "ownerBirthDate")]
        public DateTime? OwnerBirthDate { get; set; }

        [JsonProperty(PropertyName = "cpfCnpj")]
        public string CpfCnpj { get; set; }

        [JsonProperty(PropertyName = "agency")]
        public string Agency { get; set; }

        [JsonProperty(PropertyName = "account")]
        public string Account { get; set; }

        [JsonProperty(PropertyName = "accountDigit")]
        public string AccountDigit { get; set; }

        [JsonProperty(PropertyName = "bankAccountType")]
        [JsonConverter(typeof(StringEnumConverter))]
        public BankAccountType BankAccountType { get; set; }
    }
}
