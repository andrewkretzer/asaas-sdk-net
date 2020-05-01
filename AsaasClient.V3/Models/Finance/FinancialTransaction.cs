using Newtonsoft.Json;
using System;

namespace AsaasClient.V3.Models.Finance
{
    public class FinancialTransaction
    {
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        [JsonProperty(PropertyName = "value")]
        public decimal Value { get; set; }

        [JsonProperty(PropertyName = "balance")]
        public decimal Balance { get; set; }

        [JsonProperty(PropertyName = "type")]
        public string Type{ get; set; }

        [JsonProperty(PropertyName = "date")]
        public DateTime Date { get; set; }

        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }
    }
}
