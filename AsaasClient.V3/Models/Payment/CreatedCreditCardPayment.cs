using AsaasClient.V3.Models.Common;
using AsaasClient.V3.Models.Payment.Base;
using Newtonsoft.Json;

namespace AsaasClient.V3.Models.Payment
{
    public class CreatedCreditCardPayment : BasePaymentResponse
    {
        [JsonProperty(PropertyName = "creditCard")]
        public CreditCard CreditCard { get; set; }
    }
}
