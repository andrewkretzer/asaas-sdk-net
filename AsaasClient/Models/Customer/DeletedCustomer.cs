using Newtonsoft.Json;

namespace AsaasClient.Models.Customer
{
    public class DeletedCustomer
    {
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        [JsonProperty(PropertyName = "deleted")]
        public bool Deleted { get; set; }
    }
}
