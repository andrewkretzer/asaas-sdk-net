using Newtonsoft.Json;

namespace AsaasClient.V3.Models.MyAccount
{
    public class PaymentCheckoutConfig
    {
        [JsonProperty(PropertyName = "logoBackgroundColor")]
        public string LogoBackgroundColor { get; set; }

        [JsonProperty(PropertyName = "infoBackgroundColor")]
        public string InfoBackgroundColor { get; set; }

        [JsonProperty(PropertyName = "fontColor")]
        public string FontColor { get; set; }

        [JsonProperty(PropertyName = "enabled")]
        public bool Enabled { get; set; }

        [JsonProperty(PropertyName = "logoUrl")]
        public string LogoUrl { get; set; }

        [JsonProperty(PropertyName = "observations")]
        public string Observations { get; set; }

        [JsonProperty(PropertyName = "status")]
        public string Status { get; set; }
    }
}
