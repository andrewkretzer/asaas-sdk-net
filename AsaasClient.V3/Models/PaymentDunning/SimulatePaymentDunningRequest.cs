using Newtonsoft.Json;

namespace AsaasClient.V3.Models.PaymentDunning
{
    public class SimulatePaymentDunningRequest
    {
        [JsonProperty(PropertyName = "payment")]
        public string PaymentId { get; set; }
    }
}
