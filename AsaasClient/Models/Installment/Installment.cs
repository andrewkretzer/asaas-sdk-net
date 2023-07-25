using AsaasClient.Models.Common.Enums;
using System.Text.Json.Serialization;
using System;

namespace AsaasClient.Models.Installment
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

        [JsonPropertyName( "customer")]
        public string CustomerId { get; set; }

        public bool Deleted { get; set; }
    }
}
