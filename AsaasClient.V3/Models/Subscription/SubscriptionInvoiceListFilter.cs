using AsaasClient.Core;
using AsaasClient.V3.Models.Invoice.Enums;

namespace AsaasClient.V3.Models.Subscription
{
    public class SubscriptionInvoiceListFilter : RequestParameters
    {
        public InvoiceStatus? InvoiceStatus
        {
            get => Get<InvoiceStatus?>("status");
            set => Add("status", value);
        }
    }
}
