using Newtonsoft.Json;
using System;

namespace AsaasClient.V3.Models.Bill
{
    public class BankSlipInfo
    {
        public string IdentificationField { get; set; }

        public decimal Value { get; set; }

        public DateTime DueDate { get; set; }

        public string CompanyName { get; set; }

        public string BankCode { get; set; }
    }
}
