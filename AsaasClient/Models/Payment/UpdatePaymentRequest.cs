using AsaasClient.Models.Common;
using AsaasClient.Models.Common.Enums;
using System.Text.Json.Serialization;
using System;

namespace AsaasClient.Models.Payment
{
    public class UpdatePaymentRequest {
        [JsonPropertyName( "customer")]
        public string CustomerId { get; set; }

        public BillingType? BillingType { get; set; }

        public decimal? Value { get; set; }

        public DateTime? DueDate { get; set; }

        public string Description { get; set; }

        public int? InstallmentCount { get; set; }

        public decimal? InstallmentValue { get; set; }

        public Discount Discount { get; set; }

        public Interest Interest { get; set; }

        public Fine Fine { get; set; }

        public bool? PostalService { get; set; }
    }
}