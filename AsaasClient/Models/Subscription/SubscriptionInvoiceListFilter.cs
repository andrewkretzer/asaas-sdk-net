using AsaasClient.Core;
using AsaasClient.Models.Invoice.Enums;

namespace AsaasClient.Models.Subscription
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
