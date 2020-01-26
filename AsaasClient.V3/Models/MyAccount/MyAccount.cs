using AsaasClient.V3.Models.Common.Enums;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;

namespace AsaasClient.V3.Models.MyAccount
{
    public class MyAccount
    {
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        [JsonProperty(PropertyName = "email")]
        public string Email { get; set; }

        [JsonProperty(PropertyName = "cpfCnpj")]
        public string CpfCnpj { get; set; }

        [JsonProperty(PropertyName = "companyType")]
        [JsonConverter(typeof(StringEnumConverter))]
        public CompanyType CompanyType { get; set; }

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
        public PersonType PersonType { get; set; }

        [JsonProperty(PropertyName = "city")]
        public City City { get; set; }

        [JsonProperty(PropertyName = "inscricaoEstadual")]
        public string InscricaoEstadual { get; set; }

        [JsonProperty(PropertyName = "birthDate")]
        public DateTime? BirthDate { get; set; }

        [JsonProperty(PropertyName = "status")]
        public string Status { get; set; }

        [JsonProperty(PropertyName = "denialReason")]
        public string DenialReason { get; set; }
    }
}
