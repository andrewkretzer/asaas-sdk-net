using AsaasClient.V3.Models.Common;
using Newtonsoft.Json;

namespace AsaasClient.V3.Models.MyAccount
{
    public class CreatePaymentCheckoutConfigRequest
    {
        [JsonProperty(PropertyName = "logoBackgroundColor")]
        public string LogoBackgroundColor { get; set; }

        [JsonProperty(PropertyName = "infoBackgroundColor")]
        public string InfoBackgroundColor { get; set; }

        [JsonProperty(PropertyName = "fontColor")]
        public string FontColor { get; set; }

        [JsonProperty(PropertyName = "enabled")]
        public bool Enabled { get; set; }

        [JsonProperty(PropertyName = "logoFile")]
        public AsaasFile LogoFile { get; set; }
    }
}
