using AsaasClient.V3.Models.PaymentDunning.Enums;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;

namespace AsaasClient.V3.Models.PaymentDunning
{
    public class PaymentDunningTypeSimulations
    {
        [JsonProperty(PropertyName = "type")]
        [JsonConverter(typeof(StringEnumConverter))]
        public PaymentDunningType Type { get; set; }

        [JsonProperty(PropertyName = "isAllowed")]
        public bool IsAllowed { get; set; }

        [JsonProperty(PropertyName = "notAllowedReason")]
        public string NotAllowedReason { get; set; }

        [JsonProperty(PropertyName = "startDate")]
        public DateTime? StartDate { get; set; }

        [JsonProperty(PropertyName = "feeValue")]
        public decimal FeeValue { get; set; }

        [JsonProperty(PropertyName = "netValue")]
        public decimal NetValue { get; set; }
    }
}
