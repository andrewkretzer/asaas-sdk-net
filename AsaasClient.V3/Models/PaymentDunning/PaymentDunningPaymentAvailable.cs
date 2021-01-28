using AsaasClient.V3.Models.Common.Enums;
using AsaasClient.V3.Models.Payment.Enums;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;

namespace AsaasClient.V3.Models.PaymentDunning
{
    public class PaymentDunningPaymentAvailable
    {
        [JsonProperty(PropertyName = "payment")]
        public string PaymentId { get; set; }

        [JsonProperty(PropertyName = "customer")]
        public string CustomerId { get; set; }

        public decimal Value { get; set; }

        public PaymentStatus Status { get; set; }

        public BillingType BillingType { get; set; }

        public DateTime DueDate { get; set; }

        public PaymentDunningTypeSimulations TypeSimulations { get; set; }
    }
}
