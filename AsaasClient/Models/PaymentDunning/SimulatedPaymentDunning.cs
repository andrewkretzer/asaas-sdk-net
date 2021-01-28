using Newtonsoft.Json;

namespace AsaasClient.Models.PaymentDunning {
    public class SimulatedPaymentDunning {
        [JsonProperty(PropertyName = "payment")]
        public string PaymentId { get; set; }

        public decimal Value { get; set; }

        public PaymentDunningTypeSimulations TypeSimulations { get; set; }
    }
}
