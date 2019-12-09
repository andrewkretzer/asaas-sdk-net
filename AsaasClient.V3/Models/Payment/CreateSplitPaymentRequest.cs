using AsaasClient.V3.Models.Payment.Base;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace AsaasClient.V3.Models.Payment
{
    public class CreateSplitPaymentRequest : BaseCreatePaymentRequest
    {
        [JsonProperty(PropertyName = "split")]
        public List<Split> Split { get; set; }
    }
}
