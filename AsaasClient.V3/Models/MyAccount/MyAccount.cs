using AsaasClient.V3.Models.Common.Enums;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;

namespace AsaasClient.V3.Models.MyAccount
{
    public class MyAccount
    {
        public string Name { get; set; }

        public string Email { get; set; }

        public string CpfCnpj { get; set; }

        public CompanyType CompanyType { get; set; }

        public string Phone { get; set; }

        public string MobilePhone { get; set; }

        public string Address { get; set; }

        public string AddressNumber { get; set; }

        public string Complement { get; set; }

        public string Province { get; set; }

        public string PostalCode { get; set; }

        public PersonType PersonType { get; set; }

        public City City { get; set; }

        public string InscricaoEstadual { get; set; }

        public DateTime? BirthDate { get; set; }

        public string Status { get; set; }

        public string DenialReason { get; set; }
    }
}
