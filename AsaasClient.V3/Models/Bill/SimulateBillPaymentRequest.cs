using Newtonsoft.Json;

namespace AsaasClient.V3.Models.Bill
{
    public class SimulateBillPaymentRequest
    {
        [JsonProperty(PropertyName = "identificationField")]
        public string IdentificationField { get; set; }

        [JsonProperty(PropertyName = "barCode")]
        public string BarCode { get; set; }
    }
}
