using AsaasClient.Models.Common;
using AsaasClient.Models.Common.Enums;
using AsaasClient.Models.Subscription.Enums;
using System.Text.Json.Serialization;
using System;

namespace AsaasClient.Models.Subscription
{
    public class Subscription {
        public string Id { get; set; }

        public DateTime DateCreated { get; set; }

        [JsonPropertyName( "customer")]
        public string CustomerId { get; set; }

        public BillingType BillingType { get; set; }

        public decimal Value { get; set; }

        public DateTime NextDueDate { get; set; }

        public Discount Discount { get; set; }

        public Interest Interest { get; set; }

        public Fine Fine { get; set; }

        public Cycle Cycle { get; set; }

        public string Description { get; set; }

        public DateTime? EndDate { get; set; }

        public int? MaxPayments { get; set; }

        public SubscriptionStatus Status { get; set; }

        public string ExternalReference { get; set; }

        public CreditCard CreditCard { get; set; }

        public bool Deleted { get; set; }
    }
}
