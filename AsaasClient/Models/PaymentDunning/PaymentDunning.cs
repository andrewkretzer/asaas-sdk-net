using AsaasClient.Models.PaymentDunning.Enums;
using Newtonsoft.Json;
using System;

namespace AsaasClient.Models.PaymentDunning {
    public class PaymentDunning {

        public string Id { get; set; }

        public string DunningNumber { get; set; }

        public PaymentDunningStatus Status { get; set; }

        public PaymentDunningType Type { get; set; }

        [JsonProperty(PropertyName = "payment")]
        public string PaymentId { get; set; }

        public DateTime RequestDate { get; set; }

        public string Description { get; set; }

        public decimal Value { get; set; }

        public decimal FeeValue { get; set; }

        public decimal NetValue { get; set; }

        public decimal ReceivedInCashFeeValue { get; set; }

        public string DenialReason { get; set; }

        public decimal CancellationFeeValue { get; set; }

        public bool IsNecessaryResendDocumentation { get; set; }

        public bool CanBeCancelled { get; set; }
    }
}
