using Newtonsoft.Json;

namespace AsaasClient.Models.Customer
{
    public class CreateCustomerRequest
    {
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        [JsonProperty(PropertyName = "email")]
        public string Email { get; set; }

        [JsonProperty(PropertyName = "phone")]
        public string Phone { get; set; }

        [JsonProperty(PropertyName = "mobilePhone")]
        public string MobilePhone { get; set; }

        [JsonProperty(PropertyName = "cpfCnpj")]
        public string CpfCnpj { get; set; }

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

        [JsonProperty(PropertyName = "externalReference")]
        public string ExternalReference { get; set; }

        [JsonProperty(PropertyName = "notificationDisabled")]
        public string NotificationDisabled { get; set; }

        [JsonProperty(PropertyName = "additionalEmails")]
        public string AdditionalEmails { get; set; }

        [JsonProperty(PropertyName = "municipalInscription")]
        public string MunicipalInscription { get; set; }

        [JsonProperty(PropertyName = "stateInscription")]
        public string StateInscription { get; set; }

        [JsonProperty(PropertyName = "groupName")]
        public string GroupName { get; set; }
    }
}
