using AsaasClient.Models.Common;
using System.Text.Json.Serialization;
using System.Collections.Generic;

namespace AsaasClient.Models.Anticipation
{
    public class CreateAnticipationRequest
    {
        [JsonPropertyName( "installment")]
        public string InstallmentId { get; set; }

        [JsonPropertyName( "payment")]
        public string PaymentId { get; set; }

        public string AgreementSignature { get; set; }

        public List<AsaasFile> Documents { get; set; }
    }
}
