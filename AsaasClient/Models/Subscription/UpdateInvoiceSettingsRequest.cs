using AsaasClient.Models.Common;
using AsaasClient.Models.Subscription.Enums;

namespace AsaasClient.Models.Subscription {
    public class UpdateInvoiceSettingsRequest {
        public decimal Deductions { get; set; }

        public EffectiveDatePeriod EffectiveDatePeriod { get; set; }

        public bool ReceivedOnly { get; set; }

        public int DaysBeforeDueDate { get; set; }

        public string Observations { get; set; }

        public Taxes Taxes { get; set; }
    }
}
