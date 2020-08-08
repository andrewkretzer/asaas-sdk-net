using Newtonsoft.Json;
using System;

namespace AsaasClient.V3.Models.Bill
{
    public class BankSlipInfo
    {
        [JsonProperty(PropertyName = "identificationField")]
        public string IdentificationField { get; set; }

        [JsonProperty(PropertyName = "value")]
        public decimal Value { get; set; }

        [JsonProperty(PropertyName = "dueDate")]
        public DateTime DueDate { get; set; }

        [JsonProperty(PropertyName = "companyName")]
        public string CompanyName { get; set; }

        [JsonProperty(PropertyName = "bankCode")]
        public string BankCode { get; set; }
    }
}
