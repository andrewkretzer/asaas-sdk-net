using Newtonsoft.Json;

namespace AsaasClient.V3.Models.ReceivableAnticipation
{
    public class CreateReceivableAnticipationRequest
    {
        [JsonProperty(PropertyName = "agreementSignature")]
        public string AgreementSignature { get; set; }

        [JsonProperty(PropertyName = "installment")]
        public string InstallmentId { get; set; }

        [JsonProperty(PropertyName = "payment")]
        public string PaymentId { get; set; }

        [JsonProperty(PropertyName = "documents")]
        public string Documents { get; set; }
    }
}
