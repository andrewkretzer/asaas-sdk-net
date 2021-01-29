using AsaasClient.Models.Anticipation.Enums;
using Newtonsoft.Json;
using System;

namespace AsaasClient.Models.Anticipation
{
    public class Anticipation
    {
        public string Id { get; set; }

        [JsonProperty(PropertyName = "installment")]
        public string InstallmentId { get; set; }

        [JsonProperty(PropertyName = "payment")]
        public string PaymentId { get; set; }

        public AnticipationStatus Status { get; set; }

        public DateTime AnticipationDate { get; set; }

        public DateTime DueDate { get; set; }

        public DateTime RequestDate { get; set; }

        public int AnticipationDays { get; set; }

        public decimal TotalValue { get; set; }

        public decimal Fee { get; set; }

        public decimal NetValue { get; set; }

        public decimal Value { get; set; }

        public string DenialObservation { get; set; }
    }
}
