using Newtonsoft.Json;

namespace AsaasClient.Models.Common.Base
{
    public abstract class BaseDeleted
    {
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        [JsonProperty(PropertyName = "deleted")]
        public bool Deleted { get; set; }
    }
}