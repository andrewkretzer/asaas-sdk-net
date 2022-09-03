using Newtonsoft.Json;

namespace AsaasClient.Models.Common
{
    public class BankSlipCode
    {
        [JsonProperty(PropertyName = "identificationField")]
        public string IdentificationField { get; set; }

        [JsonProperty(PropertyName = "nossoNumero")]
        public string NossoNumero { get; set; }

        [JsonProperty(PropertyName = "barCode")]
        public string BarCode { get; set; }
    }
}
