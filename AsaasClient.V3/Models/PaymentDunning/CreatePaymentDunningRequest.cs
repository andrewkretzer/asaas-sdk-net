using AsaasClient.V3.Models.Common;
using AsaasClient.V3.Models.PaymentDunning.Enums;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Collections.Generic;

namespace AsaasClient.V3.Models.PaymentDunning
{
    public class CreatePaymentDunningRequest
    {
        [JsonProperty(PropertyName = "payment")]
        public string PaymentId { get; set; }

        [JsonProperty(PropertyName = "type")]
        [JsonConverter(typeof(StringEnumConverter))]
        public PaymentDunningType Type { get; set; }

        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        [JsonProperty(PropertyName = "customerInfo")]
        public PaymentDunningCustomerInfo CustomerInfo { get; set; }

        [JsonProperty(PropertyName = "documents")]
        public List<AsaasFile> Documents { get; set; }
    }
}
