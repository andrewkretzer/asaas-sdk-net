using System.Text.Json.Serialization;

namespace AsaasClient.Models.PaymentDunning
{
    public class SimulatePaymentDunningRequest
    {
        [JsonPropertyName( "payment")]
        public string PaymentId { get; set; }
    }
}
