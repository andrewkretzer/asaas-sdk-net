using AsaasClient.Models.Common;
using AsaasClient.Models.Payment.Base;
using Newtonsoft.Json;

namespace AsaasClient.Models.Payment
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
