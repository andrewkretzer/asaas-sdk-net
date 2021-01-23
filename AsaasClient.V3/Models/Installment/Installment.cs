using AsaasClient.V3.Models.Common.Enums;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;

namespace AsaasClient.V3.Models.Installment
{
    public class Installment
    {
        public string Id { get; set; }

        public decimal Value { get; set; }

        public decimal PaymentValue { get; set; }

        public int InstallmentCount { get; set; }

        public BillingType BillingType { get; set; }

        public DateTime? PaymentDate { get; set; }

        public string Description { get; set; }

        public DateTime ExpirationDay { get; set; }

        [JsonProperty(PropertyName = "customer")]
        public string CustomerId { get; set; }

        public bool Deleted { get; set; }
    }
}
