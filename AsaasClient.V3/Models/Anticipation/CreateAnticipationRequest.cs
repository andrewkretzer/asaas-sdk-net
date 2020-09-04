using AsaasClient.V3.Models.Common;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace AsaasClient.V3.Models.Anticipation
{
    public class CreateAnticipationRequest
    {
        [JsonProperty(PropertyName = "agreementSignature")]
        public string AgreementSignature { get; set; }

        [JsonProperty(PropertyName = "installment")]
        public string InstallmentId { get; set; }

        [JsonProperty(PropertyName = "payment")]
        public string PaymentId { get; set; }

        [JsonProperty(PropertyName = "documents")]
        public List<AsaasFile> Documents { get; set; }
    }
}
