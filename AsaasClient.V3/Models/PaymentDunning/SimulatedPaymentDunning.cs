using Newtonsoft.Json;

namespace AsaasClient.V3.Models.PaymentDunning
{
    public class SimulatedPaymentDunning
    {
        [JsonProperty(PropertyName = "payment")]
        public string PaymentId { get; set; }

        [JsonProperty(PropertyName = "value")]
        public decimal Value { get; set; }

        [JsonProperty(PropertyName = "typeSimulations")]
        public PaymentDunningTypeSimulations TypeSimulations { get; set; }
    }
}
