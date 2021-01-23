using AsaasClient.V3.Models.PaymentDunning.Enums;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;

namespace AsaasClient.V3.Models.PaymentDunning
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
