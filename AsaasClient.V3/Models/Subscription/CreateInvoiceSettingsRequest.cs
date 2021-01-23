using AsaasClient.V3.Models.Common;
using AsaasClient.V3.Models.Subscription.Enums;

namespace AsaasClient.V3.Models.Subscription {
    public class CreateInvoiceSettingsRequest {
        public string MunicipalServiceId { get; set; }

        public string MunicipalServiceCode { get; set; }

        public string MunicipalServiceName { get; set; }

        public decimal Deductions { get; set; }

        public EffectiveDatePeriod EffectiveDatePeriod { get; set; }

        public int DaysBeforeDueDate { get; set; }

        public bool ReceivedOnly { get; set; }

        public string Observations { get; set; }

        public Taxes Taxes { get; set; }
    }
}
