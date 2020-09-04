using Newtonsoft.Json;
using System;

namespace AsaasClient.V3.Models.Bill
{
    public class SimulatedBillPayment
    {
        [JsonProperty(PropertyName = "minimumScheduleDate")]
        public DateTime MinimumScheduleDate { get; set; }

        [JsonProperty(PropertyName = "fee")]
        public decimal Fee { get; set; }

        [JsonProperty(PropertyName = "bankSlipInfo")]
        public BankSlipInfo BankSlipInfo { get; set; }
    }
}
