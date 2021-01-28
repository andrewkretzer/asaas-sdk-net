using Newtonsoft.Json;
using System;

namespace AsaasClient.V3.Models.Bill
{
    public class CreateBillPaymentRequest
    {
        public string IdentificationField { get; set; }

        public DateTime ScheduleDate { get; set; }

        public string Description { get; set; }

        public decimal Discount { get; set; }

        public DateTime DueDate { get; set; }

        public decimal Value { get; set; }
    }
}
