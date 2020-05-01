using Newtonsoft.Json;
using System;

namespace AsaasClient.V3.Models.ReceivableAnticipation
{
    public class SimulatedReceivableAnticipation
    {
        [JsonProperty(PropertyName = "installment")]
        public string InstallmentId { get; set; }

        [JsonProperty(PropertyName = "payment")]
        public string PaymentId { get; set; }

        [JsonProperty(PropertyName = "anticipationDate")]
        public DateTime AnticipationDate { get; set; }

        [JsonProperty(PropertyName = "dueDate")]
        public DateTime DueDate { get; set; }

        [JsonProperty(PropertyName = "anticipationDays")]
        public int AnticipationDays { get; set; }

        [JsonProperty(PropertyName = "totalValue")]
        public decimal TotalValue { get; set; }

        [JsonProperty(PropertyName = "fee")]
        public decimal Fee { get; set; }

        [JsonProperty(PropertyName = "netValue")]
        public decimal NetValue { get; set; }

        [JsonProperty(PropertyName = "value")]
        public decimal Value { get; set; }
    }
}