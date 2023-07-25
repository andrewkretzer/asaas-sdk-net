using AsaasClient.Models.Common;
using AsaasClient.Models.Common.Enums;
using AsaasClient.Models.Payment.Enums;
using System.Text.Json.Serialization;
using System;
using System.Collections.Generic;

namespace AsaasClient.Models.Payment
{
    public class Payment
    {
        public string Id { get; set; }

        public DateTime DateCreated { get; set; }

        [JsonPropertyName( "customer")]
        public string CustomerId { get; set; }

        [JsonPropertyName( "subscription")]
        public string SubscriptionId { get; set; }

        [JsonPropertyName( "installment")]
        public string InstallmentId { get; set; }

        public DateTime DueDate { get; set; }

        public decimal Value { get; set; }

        public decimal NetValue { get; set; }

        public Discount Discount { get; set; }

        public Interest Interest { get; set; }

        public Fine Fine { get; set; }

        public BillingType BillingType { get; set; }

        public PaymentStatus Status { get; set; }

        public string Description { get; set; }

        public string ExternalReference { get; set; }

        public DateTime OriginalDueDate { get; set; }

        public decimal? OriginalValue { get; set; }

        public decimal? InterestValue { get; set; }

        public DateTime? ConfirmedDate { get; set; }

        public DateTime? PaymentDate { get; set; }

        public DateTime? ClientPaymentDate { get; set; }

        public string InvoiceUrl { get; set; }

        public string BankSlipUrl { get; set; }

        public string InvoiceNumber { get; set; }

        public bool Deleted { get; set; }

        public bool PostalService { get; set; }

        public bool Anticipated { get; set; }

        public CreditCard CreditCard { get; set; }

        public List<Split> Split { get; set; }
    }
}
