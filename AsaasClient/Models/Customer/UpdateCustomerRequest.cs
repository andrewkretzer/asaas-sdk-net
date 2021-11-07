namespace AsaasClient.Models.Customer
{
    public class UpdateCustomerRequest
    {
        public string Name { get; set; }

        public string CpfCnpj { get; set; }

        public string Email { get; set; }

        public string Phone { get; set; }

        public string MobilePhone { get; set; }

        public string Address { get; set; }

        public string AddressNumber { get; set; }

        public string Complement { get; set; }

        public string Province { get; set; }

        public string PostalCode { get; set; }

        public string ExternalReference { get; set; }

        public bool NotificationDisabled { get; set; }

        public string AdditionalEmails { get; set; }

        public string MunicipalInscription { get; set; }

        public string StateInscription { get; set; }

        public string Observations { get; set; }
    }
}
