using Newtonsoft.Json;

namespace AsaasClient.Models.Common
{
    public class CreditCardHolderInfoRequest
    {
        public string Name { get; set; }

        public string Email { get; set; }

        public string CpfCnpj { get; set; }

        public string PostalCode { get; set; }

        public string AddressNumber { get; set; }

        public string AddressComplement { get; set; }

        public string Phone { get; set; }

        public string MobilePhone { get; set; }
    }
}
