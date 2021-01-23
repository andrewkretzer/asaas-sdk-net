using Newtonsoft.Json;
using System;

namespace AsaasClient.V3.Models.Anticipation
{
    public class SimulatedAnticipation
    {
        [JsonProperty(PropertyName = "installment")]
        public string InstallmentId { get; set; }

        [JsonProperty(PropertyName = "payment")]
        public string PaymentId { get; set; }

        public DateTime AnticipationDate { get; set; }

        public DateTime DueDate { get; set; }

        public int AnticipationDays { get; set; }

        public decimal TotalValue { get; set; }

        public decimal Fee { get; set; }

        public decimal NetValue { get; set; }

        public decimal Value { get; set; }

        public bool IsDocumentationRequired { get; set; }
    }
}