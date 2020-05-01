using Newtonsoft.Json;

namespace AsaasClient.V3.Models.ReceivableAnticipation
{
    public class SimulateReceivableAnticipationRequest
    {
        [JsonProperty(PropertyName = "installment")]
        public string InstallmentId { get; set; }

        [JsonProperty(PropertyName = "payment")]
        public string PaymentId { get; set; }
    }
}
