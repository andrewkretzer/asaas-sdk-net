using System;
using AsaasClient.Models.Common;
using AsaasClient.Models.Common.Enums;
using Newtonsoft.Json;

namespace AsaasClient.Models.Payment.Base
{
    public abstract class BaseCreatePaymentRequest
    {
        [JsonProperty(PropertyName = "customer")]
        public string CustomerId { get; set; }

        [JsonProperty(PropertyName = "billingType")]
        public BillingType BillingType { get; set; }

        [JsonProperty(PropertyName = "value")]
        public decimal Value { get; set; }

        [JsonProperty(PropertyName = "dueDate")]
        public DateTime DueDate { get; set; }

        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        [JsonProperty(PropertyName = "externalReference")]
        public string ExternalReference { get; set; }

        [JsonProperty(PropertyName = "installmentCount")]
        public int InstallmentCount { get; set; }

        [JsonProperty(PropertyName = "installmentValue")]
        public decimal InstallmentValue { get; set; }

        [JsonProperty(PropertyName = "discount")]
        public Discount Discount { get; set; }

        [JsonProperty(PropertyName = "interest")]
        public Interest Interest { get; set; }

        [JsonProperty(PropertyName = "fine")]
        public Fine Fine { get; set; }

        [JsonProperty(PropertyName = "postalService")]
        public bool PostalService { get; set; }
    }
}
