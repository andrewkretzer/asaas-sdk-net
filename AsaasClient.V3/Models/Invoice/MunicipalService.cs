using Newtonsoft.Json;

namespace AsaasClient.V3.Models.Invoice
{
    public class MunicipalService
    {
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        [JsonProperty(PropertyName = "iss")]
        public decimal Iss { get; set; }
    }
}
