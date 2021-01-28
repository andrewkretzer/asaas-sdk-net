using AsaasClient.Models.PaymentDunning.Enums;
using System;

namespace AsaasClient.Models.PaymentDunning
{
    public class PaymentDunningTypeSimulations
    {
        public PaymentDunningType Type { get; set; }

        public bool IsAllowed { get; set; }

        public string NotAllowedReason { get; set; }

        public DateTime? StartDate { get; set; }

        public decimal FeeValue { get; set; }

        public decimal NetValue { get; set; }
    }
}
