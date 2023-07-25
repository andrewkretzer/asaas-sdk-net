using System.Text.Json.Serialization;

namespace AsaasClient.Models.PaymentDunning
{
    public class SimulatedPaymentDunning {
        [JsonPropertyName( "payment")]
        public string PaymentId { get; set; }

        public decimal Value { get; set; }

        public PaymentDunningTypeSimulations TypeSimulations { get; set; }
    }
}
