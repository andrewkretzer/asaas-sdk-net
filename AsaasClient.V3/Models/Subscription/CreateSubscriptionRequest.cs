using AsaasClient.V3.Models.Common;
using AsaasClient.V3.Models.Common.Enums;
using AsaasClient.V3.Models.Subscription.Enums;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;

namespace AsaasClient.V3.Models.Subscription
{
    public class CreateSubscriptionRequest
    {
        [JsonProperty(PropertyName = "customer")]
        public string CustomerId { get; set; }

        [JsonProperty(PropertyName = "billingType")]
        [JsonConverter(typeof(StringEnumConverter))]
        public BillingType BillingType { get; set; }

        [JsonProperty(PropertyName = "value")]
        public decimal Value { get; set; }

        [JsonProperty(PropertyName = "nextDueDate")]
        public DateTime NextDueDate { get; set; }

        [JsonProperty(PropertyName = "discount")]
        public Discount Discount { get; set; }

        [JsonProperty(PropertyName = "interest")]
        public Interest Interest { get; set; }

        [JsonProperty(PropertyName = "fine")]
        public Fine Fine { get; set; }

        [JsonProperty(PropertyName = "cycle")]
        [JsonConverter(typeof(StringEnumConverter))]
        public Cycle Cycle { get; set; }

        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        [JsonProperty(PropertyName = "endDate")]
        public DateTime? EndDate { get; set; }

        [JsonProperty(PropertyName = "maxPayments")]
        public int? MaxPayments { get; set; }

        [JsonProperty(PropertyName = "externalReference")]
        public string ExternalReference { get; set; }

        [JsonProperty(PropertyName = "creditCard")]
        public CreditCardRequest CreditCard { get; set; }

        [JsonProperty(PropertyName = "creditCardHolderInfo")]
        public CreditCardHolderInfoRequest CreditCardHolderInfo { get; set; }

        [JsonProperty(PropertyName = "remoteIp")]
        public string RemoteIp { get; set; }
    }
}
