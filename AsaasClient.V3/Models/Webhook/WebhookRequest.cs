namespace AsaasClient.V3.Models.Webhook {
    public class WebhookRequest {
        public string Url { get; set; }

        public string Email { get; set; }

        public int ApiVersion { get; set; }

        public bool Enabled { get; set; }

        public bool Interrupted { get; set; }

        public string AuthToken { get; set; }
    }
}
