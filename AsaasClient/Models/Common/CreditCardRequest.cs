using Newtonsoft.Json;

namespace AsaasClient.Models.Common
{
    public class CreditCardRequest
    {
        [JsonProperty(PropertyName = "holderName")]
        public string HolderName { get; set; }

        [JsonProperty(PropertyName = "number")]
        public string Number { get; set; }

        [JsonProperty(PropertyName = "expiryMonth")]
        public string ExpiryMonth { get; set; }

        [JsonProperty(PropertyName = "expiryYear")]
        public string ExpiryYear { get; set; }

        [JsonProperty(PropertyName = "ccv")]
        public string CCV { get; set; }
    }
}
