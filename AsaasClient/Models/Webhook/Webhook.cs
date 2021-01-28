namespace AsaasClient.Models.Webhook {
    public class Webhook {
        public string Url { get; set; }

        public string Email { get; set; }

        public int ApiVersion { get; set; }

        public bool Enabled { get; set; }

        public bool Interrupted { get; set; }

        public string AuthToken { get; set; }
    }
}
