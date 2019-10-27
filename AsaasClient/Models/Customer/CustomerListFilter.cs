using System.Collections.Generic;

namespace AsaasClient.Models.Customer
{
    public class CustomerListFilter
    {
        public List<string> Names { get; set; }
        public List<string> Emails { get; set; }
        public List<string> CpfCnpjs { get; set; }
        public List<string> ExternalReferences { get; set; }
    }
}
