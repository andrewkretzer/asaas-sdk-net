using AsaasClient.Models.Common;
using AsaasClient.Models.Payment.Base;
using Newtonsoft.Json;

namespace AsaasClient.Models.Payment
{
    public class CreatedCreditCardPayment : BasePaymentResponse
    {
        [JsonProperty(PropertyName = "creditCard")]
        public CreditCard CreditCard { get; set; }
    }
}
