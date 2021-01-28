using Newtonsoft.Json;
using System;

namespace AsaasClient.Models.PaymentDunning
{
    public class PaymentDunningPartialPayments
    {
        public decimal Value { get; set; }

        public string Description { get; set; }

        public DateTime PaymentDate { get; set; }
    }
}
