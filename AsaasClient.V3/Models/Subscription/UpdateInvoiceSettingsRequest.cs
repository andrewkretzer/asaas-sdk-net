using AsaasClient.V3.Models.Common;
using AsaasClient.V3.Models.Subscription.Enums;

namespace AsaasClient.V3.Models.Subscription {
    public class UpdateInvoiceSettingsRequest {
        public decimal Deductions { get; set; }

        public EffectiveDatePeriod EffectiveDatePeriod { get; set; }

        public bool ReceivedOnly { get; set; }

        public int DaysBeforeDueDate { get; set; }

        public string Observations { get; set; }

        public Taxes Taxes { get; set; }
    }
}
