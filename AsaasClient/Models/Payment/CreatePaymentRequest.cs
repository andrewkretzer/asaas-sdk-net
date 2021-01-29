using AsaasClient.Models.Common;
using AsaasClient.Models.Common.Enums;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace AsaasClient.Models.Payment
{
    public class CreatePaymentRequest
    {
        [JsonProperty(PropertyName = "customer")]
        public string CustomerId { get; set; }

        public BillingType BillingType { get; set; }

        public decimal Value { get; set; }

        public DateTime? DueDate { get; set; }

        public string Description { get; set; }

        public string ExternalReference { get; set; }

        public int InstallmentCount { get; set; }

        public decimal InstallmentValue { get; set; }

        public Discount Discount { get; set; }

        public Interest Interest { get; set; }

        public Fine Fine { get; set; }

        public bool PostalService { get; set; }

        public CreditCardRequest CreditCard { get; set; }

        public CreditCardHolderInfoRequest CreditCardHolderInfo { get; set; }

        public string RemoteIp { get; set; }

        public List<Split> Split { get; set; }
    }
}
