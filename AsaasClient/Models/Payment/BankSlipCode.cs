using System.Text.Json.Serialization;

namespace AsaasClient.Models.Payment
{
    public class BankSlipCode
    {
        [JsonPropertyName( "identificationField")]
        public string IdentificationField { get; set; }

        [JsonPropertyName( "nossoNumero")]
        public string NossoNumero { get; set; }

        [JsonPropertyName( "barCode")]
        public string BarCode { get; set; }
    }
}
