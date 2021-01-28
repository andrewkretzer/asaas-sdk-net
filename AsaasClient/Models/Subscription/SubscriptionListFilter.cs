using AsaasClient.Core;
using AsaasClient.Models.Common.Enums;

namespace AsaasClient.Models.Subscription
{
    public class SubscriptionListFilter : RequestParameters
    {
        public string CustomerId
        {
            get => this["customer"];
            set => Add("customer", value);
        }

        public BillingType? BillingType
        {
            get => Get<BillingType?>("billingType");
            set => Add("billingType", value);
        }

        public bool? IncludeDeleted
        {
            get => Get<bool?>("includeDeleted");
            set => Add("includeDeleted", value);
        }
    }
}
