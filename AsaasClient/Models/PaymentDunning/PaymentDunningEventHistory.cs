using System;

namespace AsaasClient.Models.PaymentDunning
{
    public class PaymentDunningEventHistory
    {
        public string Status { get; set; }

        public string Description { get; set; }

        public DateTime EventDate { get; set; }
    }
}
