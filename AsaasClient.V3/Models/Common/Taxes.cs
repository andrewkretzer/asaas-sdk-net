using Newtonsoft.Json;

namespace AsaasClient.V3.Models.Common
{
    public class Taxes
    {
        [JsonProperty(PropertyName = "retainIss")]
        public bool RetainIss { get; set; }

        [JsonProperty(PropertyName = "iss")]
        public decimal Iss { get; set; }

        [JsonProperty(PropertyName = "cofins")]
        public decimal Cofins { get; set; }

        [JsonProperty(PropertyName = "csll")]
        public decimal Csll { get; set; }

        [JsonProperty(PropertyName = "inss")]
        public decimal Inss { get; set; }

        [JsonProperty(PropertyName = "ir")]
        public decimal Ir { get; set; }

        [JsonProperty(PropertyName = "pis")]
        public decimal Pis { get; set; }
    }
}
