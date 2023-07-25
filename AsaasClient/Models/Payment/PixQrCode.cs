using System.Text.Json.Serialization;
using System;

namespace AsaasClient.Models.Payment
{
    public class PixQRCode
    {
        [JsonPropertyName( "encodedImage")]
        public string EncodedImage { get; set; }

        [JsonPropertyName( "payload")]
        public string Payload { get; set; }

        [JsonPropertyName( "expirationDate")]
        public DateTime ExpirationDate { get; set; }
    }
}
