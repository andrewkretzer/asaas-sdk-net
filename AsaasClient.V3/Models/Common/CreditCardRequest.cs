using Newtonsoft.Json;

namespace AsaasClient.V3.Models.Common
{
    public class CreditCardRequest
    {
        public string HolderName { get; set; }

        public string Number { get; set; }

        public string ExpiryMonth { get; set; }

        public string ExpiryYear { get; set; }

        public string Ccv { get; set; }
    }
}
