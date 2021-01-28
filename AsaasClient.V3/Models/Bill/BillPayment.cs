using AsaasClient.V3.Models.Bill.Enums;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;

namespace AsaasClient.V3.Models.Bill
{
    public class BillPayment
    {
        public string Id { get; set; }

        public BillPaymentStatus Status { get; set; }

        public decimal Value { get; set; }

        public decimal Discount { get; set; }

        public string IdentificationField { get; set; }

        public DateTime DueDate { get; set; }

        public DateTime ScheduleDate { get; set; }

        public decimal Fee { get; set; }

        public string Description { get; set; }

        public string CompanyName { get; set; }

        public string TransactionReceiptUrl { get; set; }

        public bool CanBeCancelled { get; set; }

        public string FailReasons { get; set; }
    }
}
