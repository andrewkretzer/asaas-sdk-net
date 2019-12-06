using AsaasClient.V3.Models.Common;
using AsaasClient.V3.Models.Common.Enums;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;

namespace AsaasClient.V3.Models.Payment.Base
{
    public abstract class BaseCreatePaymentRequest
    {
        [JsonProperty(PropertyName = "customer")]
        public string CustomerId { get; set; }

        [JsonProperty(PropertyName = "billingType")]
        [JsonConverter(typeof(StringEnumConverter))]
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
