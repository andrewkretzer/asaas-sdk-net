using Newtonsoft.Json;
using System;

namespace AsaasClient.V3.Models.PaymentDunning
{
    public class PaymentDunningEventHistory
    {
        [JsonProperty(PropertyName = "status")]
        public string Status { get; set; }

        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        [JsonProperty(PropertyName = "eventDate")]
        public DateTime EventDate { get; set; }
    }
}
