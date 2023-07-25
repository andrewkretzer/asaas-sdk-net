using System.Text.Json.Serialization;

namespace AsaasClient.Models.Anticipation
{
    public class SimulateAnticipationRequest
    {
        [JsonPropertyName( "installment")]
        public string InstallmentId { get; set; }

        [JsonPropertyName( "payment")]
        public string PaymentId { get; set; }
    }
}
