using AsaasClient.Models.Common;
using AsaasClient.Models.Subscription.Enums;

namespace AsaasClient.Models.Subscription
{
    public class SubscriptionInvoiceSettings {
        public string MunicipalServiceId { get; set; }

        public string MunicipalServiceCode { get; set; }

        public string MunicipalServiceName { get; set; }

        public decimal Deductions { get; set; }

        public EffectiveDatePeriod InvoiceCreationPeriod { get; set; }

        public int DaysBeforeDueDate { get; set; }

        public bool ReceivedOnly { get; set; }

        public string Observations { get; set; }

        public Taxes Taxes { get; set; }
    }
}
