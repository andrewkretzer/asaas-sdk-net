using Newtonsoft.Json;

namespace AsaasClient.V3.Models.Webhook
{
    public class WebhookRequest
    {
        [JsonProperty(PropertyName = "url")]
        public string Url { get; set; }

        [JsonProperty(PropertyName = "email")]
        public string Email { get; set; }

        [JsonProperty(PropertyName = "apiVersion")]
        public int ApiVersion { get; set; }

        [JsonProperty(PropertyName = "enabled")]
        public bool Enabled { get; set; }

        [JsonProperty(PropertyName = "interrupted")]
        public bool Interrupted { get; set; }

        [JsonProperty(PropertyName = "authToken")]
        public string AuthToken { get; set; }
    }
}
