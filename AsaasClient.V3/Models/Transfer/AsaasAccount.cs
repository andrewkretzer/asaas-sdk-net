using Newtonsoft.Json;

namespace AsaasClient.V3.Models.Transfer
{
    public class AsaasAccount
    {
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        [JsonProperty(PropertyName = "cpfCnpj")]
        public string CpfCnpj { get; set; }
    }
}
