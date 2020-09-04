using AsaasClient.V3.Models.PaymentDunning.Enums;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;

namespace AsaasClient.V3.Models.PaymentDunning
{
    public class PaymentDunning
    {
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        [JsonProperty(PropertyName = "dunningNumber")]
        public string DunningNumber { get; set; }

        [JsonProperty(PropertyName = "status")]
        [JsonConverter(typeof(StringEnumConverter))]
        public PaymentDunningStatus Status { get; set; }

        [JsonProperty(PropertyName = "type")]
        [JsonConverter(typeof(StringEnumConverter))]
        public PaymentDunningType Type { get; set; }

        [JsonProperty(PropertyName = "payment")]
        public string PaymentId { get; set; }

        [JsonProperty(PropertyName = "requestDate")]
        public DateTime RequestDate { get; set; }

        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        [JsonProperty(PropertyName = "value")]
        public decimal Value { get; set; }

        [JsonProperty(PropertyName = "feeValue")]
        public decimal FeeValue { get; set; }

        [JsonProperty(PropertyName = "netValue")]
        public decimal NetValue { get; set; }

        [JsonProperty(PropertyName = "receivedInCashFeeValue")]
        public decimal ReceivedInCashFeeValue { get; set; }

        [JsonProperty(PropertyName = "denialReason")]
        public string DenialReason { get; set; }

        [JsonProperty(PropertyName = "cancellationFeeValue")]
        public decimal CancellationFeeValue { get; set; }

        [JsonProperty(PropertyName = "isNecessaryResendDocumentation")]
        public bool IsNecessaryResendDocumentation { get; set; }

        [JsonProperty(PropertyName = "canBeCancelled")]
        public bool CanBeCancelled { get; set; }
    }
}
