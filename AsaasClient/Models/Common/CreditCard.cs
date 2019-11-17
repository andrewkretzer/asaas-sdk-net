using Newtonsoft.Json;

namespace AsaasClient.Models.Common
{
    public class CreditCard
    {
        [JsonProperty(PropertyName = "creditCardNumber")]
        public string Number { get; set; }

        [JsonProperty(PropertyName = "creditCardBrand")]
        public string CreditCardBrand { get; set; }

        [JsonProperty(PropertyName = "creditCardToken")]
        public string CreditCardToken { get; set; }
    }
}
