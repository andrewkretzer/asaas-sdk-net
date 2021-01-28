using Newtonsoft.Json;

namespace AsaasClient.Models.PaymentDunning
{
    public class SimulatePaymentDunningRequest
    {
        [JsonProperty(PropertyName = "payment")]
        public string PaymentId { get; set; }
    }
}
