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

        [JsonProperty(PropertyName = "value")]
        public decimal Value { get; set; }

        [JsonProperty(PropertyName = "status")]
        [JsonConverter(typeof(StringEnumConverter))]
        public PaymentStatus Status { get; set; }

        [JsonProperty(PropertyName = "billingType")]
        [JsonConverter(typeof(StringEnumConverter))]
        public BillingType BillingType { get; set; }

        [JsonProperty(PropertyName = "dueDate")]
        public DateTime DueDate { get; set; }

        [JsonProperty(PropertyName = "typeSimulations")]
        public PaymentDunningTypeSimulations TypeSimulations { get; set; }
    }
}
