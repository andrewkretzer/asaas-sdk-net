using Newtonsoft.Json;

namespace AsaasClient.V3.Models.Anticipation
{
    public class SimulateAnticipationRequest
    {
        [JsonProperty(PropertyName = "installment")]
        public string InstallmentId { get; set; }

        [JsonProperty(PropertyName = "payment")]
        public string PaymentId { get; set; }
    }
}
