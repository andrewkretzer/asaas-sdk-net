using AsaasClient.Models.Common.Enums;
using AsaasClient.Models.Payment.Enums;
using System.Text.Json.Serialization;
using System;

namespace AsaasClient.Models.PaymentDunning
{
    public class PaymentDunningPaymentAvailable
    {
        [JsonPropertyName( "payment")]
        public string PaymentId { get; set; }

        [JsonPropertyName( "customer")]
        public string CustomerId { get; set; }

        public decimal Value { get; set; }

        public PaymentStatus Status { get; set; }

        public BillingType BillingType { get; set; }

        public DateTime DueDate { get; set; }

        public PaymentDunningTypeSimulations TypeSimulations { get; set; }
    }
}
