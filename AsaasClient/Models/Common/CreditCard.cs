using System.Text.Json.Serialization;

namespace AsaasClient.Models.Common
{
    public class CreditCard
    {
        [JsonPropertyName( "creditCardNumber")]
        public string Number { get; set; }

        [JsonPropertyName( "creditCardBrand")]
        public string Brand { get; set; }

        [JsonPropertyName( "creditCardToken")]
        public string Token { get; set; }
    }
}
