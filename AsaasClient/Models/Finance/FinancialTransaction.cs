using System;

namespace AsaasClient.Models.Finance
{
    public class FinancialTransaction
    {
        public string Id { get; set; }

        public decimal Value { get; set; }

        public decimal Balance { get; set; }

        public string Type{ get; set; }

        public DateTime Date { get; set; }

        public string Description { get; set; }
    }
}
