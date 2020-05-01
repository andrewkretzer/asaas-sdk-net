using Newtonsoft.Json;

namespace AsaasClient.V3.Models.MyAccount
{
    public class City
    {
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        [JsonProperty(PropertyName = "ibgeCode")]
        public string IbgeCode { get; set; }

        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        [JsonProperty(PropertyName = "districtCode")]
        public string DistrictCode { get; set; }

        [JsonProperty(PropertyName = "district")]
        public string District { get; set; }

        [JsonProperty(PropertyName = "state")]
        public string State { get; set; }
    }
}
