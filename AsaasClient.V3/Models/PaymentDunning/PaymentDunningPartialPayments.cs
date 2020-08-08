using Newtonsoft.Json;
using System;

namespace AsaasClient.V3.Models.PaymentDunning
{
    public class PaymentDunningPartialPayments
    {
        [JsonProperty(PropertyName = "value")]
        public decimal Value { get; set; }

        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        [JsonProperty(PropertyName = "paymentDate")]
        public DateTime PaymentDate { get; set; }
    }
}
