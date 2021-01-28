using AsaasClient.Models.Common;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace AsaasClient.Models.Anticipation
{
    public class CreateAnticipationRequest
    {
        public string AgreementSignature { get; set; }

        [JsonProperty(PropertyName = "installment")]
        public string InstallmentId { get; set; }

        [JsonProperty(PropertyName = "payment")]
        public string PaymentId { get; set; }

        public List<AsaasFile> Documents { get; set; }
    }
}
