using AsaasClient.Models.Common.Enums;

namespace AsaasClient.Models.AsaasAccount
{
    public class CreateAccountRequest
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
    }
}
