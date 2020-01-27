using AsaasClient.V3.Models.Common.Enums;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;

namespace AsaasClient.V3.Models.Installment
{
    public class Installment
    {
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        [JsonProperty(PropertyName = "value")]
        public decimal Value { get; set; }

        [JsonProperty(PropertyName = "paymentValue")]
        public decimal PaymentValue { get; set; }

        [JsonProperty(PropertyName = "installmentCount")]
        public int InstallmentCount { get; set; }

        [JsonProperty(PropertyName = "billingType")]
        [JsonConverter(typeof(StringEnumConverter))]
        public BillingType BillingType { get; set; }

        [JsonProperty(PropertyName = "paymentDate")]
        public DateTime? PaymentDate { get; set; }

        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        [JsonProperty(PropertyName = "expirationDay")]
        public DateTime ExpirationDay { get; set; }

        [JsonProperty(PropertyName = "customer")]
        public string CustomerId { get; set; }

        [JsonProperty(PropertyName = "deleted")]
        public bool Deleted { get; set; }
    }
}
