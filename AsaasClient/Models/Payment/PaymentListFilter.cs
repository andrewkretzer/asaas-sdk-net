using AsaasClient.Core;
using AsaasClient.Models.Common.Enums;
using AsaasClient.Models.Payment.Enums;
using System;

namespace AsaasClient.Models.Payment
{
    public class PaymentListFilter : RequestParameters
    {
        public string CustomerId
        {
            get => this["customer"];
            set => Add("customer", value);
        }

        public string SubscriptionId
        {
            get => this["subscription"];
            set => Add("subscription", value);
        }

        public string InstallmentId
        {
            get => this["installment"];
            set => Add("installment", value);
        }

        public BillingType? BillingType
        {
            get => Get<BillingType?>("billingType");
            set => Add("billingType", value);
        }

        public PaymentStatus? Status
        {
            get => Get<PaymentStatus?>("status");
            set => Add("status", value);
        }

        public string ExternalReference
        {
            get => this["externalReference"];
            set => Add("externalReference", value);
        }

        public DateTime? PaymentDate
        {
            get => Get<DateTime?>("paymentDate");
            set => Add("paymentDate", value);
        }

        public bool? Anticipated
        {
            get => Get<bool?>("anticipated");
            set => Add("anticipated", value);
        }

        public DateTime? PaymentDateGE
        {
            get => Get<DateTime?>("paymentDate[ge]");
            set => Add("paymentDate[ge]", value);
        }

        public DateTime? PaymentDateLE
        {
            get => Get<DateTime?>("paymentDate[le]");
            set => Add("paymentDate[le]", value);
        }

        public DateTime? DueDateGE
        {
            get => Get<DateTime?>("dueDate[ge]");
            set => Add("dueDate[ge]", value);
        }

        public DateTime? DueDateLE
        {
            get => Get<DateTime?>("dueDate[le]");
            set => Add("dueDate[le]", value);
        }
    }
}