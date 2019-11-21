using System.Collections.Generic;
using AsaasClient.Models.Payment.Base;
using Newtonsoft.Json;

namespace AsaasClient.Models.Payment
{
    public class CreateSplitPaymentRequest : BaseCreatePaymentRequest
    {
        [JsonProperty(PropertyName = "split")]
        public List<Split> Split { get; set; }
    }
}
