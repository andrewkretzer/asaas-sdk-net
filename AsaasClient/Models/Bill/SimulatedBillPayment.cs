using System;

namespace AsaasClient.Models.Bill
{
    public class SimulatedBillPayment
    {
        public DateTime MinimumScheduleDate { get; set; }

        public decimal Fee { get; set; }

        public BankSlipInfo BankSlipInfo { get; set; }
    }
}
