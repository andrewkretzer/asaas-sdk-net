using Newtonsoft.Json;

namespace AsaasClient.V3.Models.PaymentDunning
{
    public class PaymentDunningCustomerInfo
    {
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        [JsonProperty(PropertyName = "cpfCnpj")]
        public string CpfCnpj { get; set; }

        [JsonProperty(PropertyName = "primaryPhone")]
        public string PrimaryPhone { get; set; }

        [JsonProperty(PropertyName = "secondaryPhone")]
        public string SecondaryPhone { get; set; }

        [JsonProperty(PropertyName = "postalCode")]
        public string PostalCode { get; set; }

        [JsonProperty(PropertyName = "address")]
        public string Address { get; set; }

        [JsonProperty(PropertyName = "addressNumber")]
        public string AddressNumber { get; set; }

        [JsonProperty(PropertyName = "complement")]
        public string Complement { get; set; }

        [JsonProperty(PropertyName = "province")]
        public string Province { get; set; }
    }
}
