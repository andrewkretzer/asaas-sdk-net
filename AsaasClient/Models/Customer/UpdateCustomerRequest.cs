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

        public UpdateCustomerRequest(Customer customer)
        {
            Name = customer.Name;
            CpfCnpj = customer.CpfCnpj;
            Email = customer.Email;
            Phone = customer.Phone;
            MobilePhone = customer.MobilePhone;
            Address = customer.Address;
            AddressNumber = customer.AddressNumber;
            Complement = customer.Complement;
            Province = customer.Province;
            PostalCode = customer.PostalCode;
            ExternalReference = customer.ExternalReference;
            NotificationDisabled = customer.NotificationDisabled;
            AdditionalEmails = customer.AdditionalEmails;
            MunicipalInscription = customer.MunicipalInscription;
            StateInscription = customer.StateInscription;
            Observations = customer.Observations;
        }
    }
}
