using Newtonsoft.Json;
using System;

namespace AsaasClient.V3.Models.Bill
{
    public class SimulatedBillPayment
    {
        public DateTime MinimumScheduleDate { get; set; }

        public decimal Fee { get; set; }

        public BankSlipInfo BankSlipInfo { get; set; }
    }
}
