using AsaasClient.Models.Common;
using AsaasClient.Models.Enums;
using Newtonsoft.Json;

namespace AsaasClient.Core
{
    public class BasePaymentResponse
    {
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        [JsonProperty(PropertyName = "dateCreated")]
        public string DateCreated { get; set; }

        [JsonProperty(PropertyName = "customer")]
        public string Customer { get; set; }

        [JsonProperty(PropertyName = "subscription")]
        public string Subscription { get; set; }

        [JsonProperty(PropertyName = "installment")]
        public string Installment { get; set; }

        [JsonProperty(PropertyName = "dueDate")]
        public string DueDate { get; set; }

        [JsonProperty(PropertyName = "value")]
        public decimal Value { get; set; }

        [JsonProperty(PropertyName = "netValue")]
        public decimal NetValue { get; set; }

        [JsonProperty(PropertyName = "discount")]
        public Discount Discount { get; set; }

        [JsonProperty(PropertyName = "interest")]
        public Interest Interest { get; set; }

        [JsonProperty(PropertyName = "fine")]
        public Fine Fine { get; set; }

        [JsonProperty(PropertyName = "billingType")]
        public BillingType BillingType { get; set; }

        [JsonProperty(PropertyName = "status")]
        public PaymentStatus Status { get; set; }

        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        [JsonProperty(PropertyName = "externalReference")]
        public string ExternalReference { get; set; }

        [JsonProperty(PropertyName = "originalDueDate")]
        public string OriginalDueDate { get; set; }

        [JsonProperty(PropertyName = "originalValue")]
        public decimal OriginalValue { get; set; }

        [JsonProperty(PropertyName = "interestValue")]
        public decimal InterestValue { get; set; }

        [JsonProperty(PropertyName = "confirmedDate")]
        public string ConfirmedDate { get; set; }

        [JsonProperty(PropertyName = "paymentDate")]
        public string PaymentDate { get; set; }

        [JsonProperty(PropertyName = "clientPaymentDate")]
        public string ClientPaymentDate { get; set; }

        [JsonProperty(PropertyName = "invoiceUrl")]
        public string InvoiceUrl { get; set; }

        [JsonProperty(PropertyName = "bankSlipUrl")]
        public string BankSlipUrl { get; set; }

        [JsonProperty(PropertyName = "invoiceNumber")]
        public string InvoiceNumber { get; set; }

        [JsonProperty(PropertyName = "deleted")]
        public bool Deleted { get; set; }

        [JsonProperty(PropertyName = "postalService")]
        public bool PostalService { get; set; }

        [JsonProperty(PropertyName = "anticipated")]
        public bool Anticipated { get; set; }
    }
}
