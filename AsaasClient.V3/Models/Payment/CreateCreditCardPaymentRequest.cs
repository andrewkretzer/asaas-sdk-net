using AsaasClient.V3.Models.Common;
using AsaasClient.V3.Models.Payment.Base;
using Newtonsoft.Json;

namespace AsaasClient.V3.Models.Payment
{
    public class CreateCreditCardPaymentRequest : BaseCreatePaymentRequest
    {
        [JsonProperty(PropertyName = "creditCard")]
        public CreditCardRequest CreditCard { get; set; }

        [JsonProperty(PropertyName = "creditCardHolderInfo")]
        public CreditCardHolderInfoRequest CreditCardHolderInfo { get; set; }

        [JsonProperty(PropertyName = "remoteIp")]
        public string RemoteIp { get; set; }
    }
}
