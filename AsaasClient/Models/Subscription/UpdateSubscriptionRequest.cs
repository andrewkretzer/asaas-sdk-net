using AsaasClient.Models.Common;
using AsaasClient.Models.Common.Enums;
using AsaasClient.Models.Subscription.Enums;
using System;

namespace AsaasClient.Models.Subscription {
    public class UpdateSubscriptionRequest {
        public BillingType? BillingType { get; set; }

        public decimal? Value { get; set; }

        public DateTime? NextDueDate { get; set; }

        public Discount Discount { get; set; }

        public Interest Interest { get; set; }

        public Fine Fine { get; set; }

        public Cycle? Cycle { get; set; }

        public string Description { get; set; }

        public bool? UpdatePendingPayments { get; set; }

        public string ExternalReference { get; set; }
    }
}
