using Newtonsoft.Json;
using System;

namespace AsaasClient.V3.Models.PaymentDunning
{
    public class PaymentDunningPartialPayments
    {
        public decimal Value { get; set; }

        public string Description { get; set; }

        public DateTime PaymentDate { get; set; }
    }
}
