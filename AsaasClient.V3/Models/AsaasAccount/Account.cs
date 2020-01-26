using AsaasClient.V3.Models.Common.Enums;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace AsaasClient.V3.Models.AsaasAccount
{
    public class Account
    {
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        [JsonProperty(PropertyName = "email")]
        public string Email { get; set; }

        [JsonProperty(PropertyName = "loginEmail")]
        public string LoginEmail { get; set; }

        [JsonProperty(PropertyName = "cpfCnpj")]
        public string CpfCnpj { get; set; }

        [JsonProperty(PropertyName = "companyType")]
        [JsonConverter(typeof(StringEnumConverter))]
        public CompanyType? CompanyType { get; set; }

        [JsonProperty(PropertyName = "phone")]
        public string Phone { get; set; }

        [JsonProperty(PropertyName = "mobilePhone")]
        public string MobilePhone { get; set; }

        [JsonProperty(PropertyName = "address")]
        public string Address { get; set; }

        [JsonProperty(PropertyName = "addressNumber")]
        public string AddressNumber { get; set; }

        [JsonProperty(PropertyName = "complement")]
        public string Complement { get; set; }

        [JsonProperty(PropertyName = "province")]
        public string Province { get; set; }

        [JsonProperty(PropertyName = "postalCode")]
        public string PostalCode { get; set; }

        [JsonProperty(PropertyName = "personType")]
        [JsonConverter(typeof(StringEnumConverter))]
        public PersonType? PersonType { get; set; }

        [JsonProperty(PropertyName = "city")]
        public string City { get; set; }

        [JsonProperty(PropertyName = "state")]
        public string State { get; set; }

        [JsonProperty(PropertyName = "country")]
        public string Country { get; set; }

        [JsonProperty(PropertyName = "apiKey")]
        public string ApiKey { get; set; }

        [JsonProperty(PropertyName = "walletId")]
        public string WalletId { get; set; }
    }
}
