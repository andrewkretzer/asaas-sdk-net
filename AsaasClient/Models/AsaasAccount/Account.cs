using AsaasClient.Models.Common.Enums;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace AsaasClient.Models.AsaasAccount
{
    public class Account
    {
        public string Name { get; set; }

        public string Email { get; set; }

        public string LoginEmail { get; set; }

        public string CpfCnpj { get; set; }

        public CompanyType? CompanyType { get; set; }

        public string Phone { get; set; }

        public string MobilePhone { get; set; }

        public string Address { get; set; }

        public string AddressNumber { get; set; }

        public string Complement { get; set; }

        public string Province { get; set; }

        public string PostalCode { get; set; }

        public PersonType? PersonType { get; set; }

        public string City { get; set; }

        public string State { get; set; }

        public string Country { get; set; }

        public string ApiKey { get; set; }

        public string WalletId { get; set; }
    }
}
