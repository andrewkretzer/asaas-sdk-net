using AsaasClient.V3.Models.AsaasAccount.Enums;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace AsaasClient.V3.Models.AsaasAccount
{
    public class CreateAccountRequest
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
    }
}
