using Newtonsoft.Json;
using System;

namespace AsaasClient.Models.Payment
{
    public class PixQRCode
    {
        [JsonProperty(PropertyName = "encodedImage")]
        public string EncodedImage { get; set; }

        [JsonProperty(PropertyName = "payload")]
        public string Payload { get; set; }

        [JsonProperty(PropertyName = "expirationDate")]
        public DateTime ExpirationDate { get; set; }
    }
}
