using AsaasClient.Core;
using AsaasClient.V3.Models.Common.Enums;

namespace AsaasClient.V3.Models.Subscription
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
            get => Get<bool?>("anticipated");
            set => Add("anticipated", value);
        }
    }
}
