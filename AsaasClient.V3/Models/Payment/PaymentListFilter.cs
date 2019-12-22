using AsaasClient.Core;
using AsaasClient.Core.Extension;
using AsaasClient.Core.Utils;
using AsaasClient.V3.Models.Common.Enums;
using AsaasClient.V3.Models.Payment.Enums;
using System;

namespace AsaasClient.V3.Models.Payment
{
    public class PaymentListFilter : Map
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
            get => EnumUtils.Parse<BillingType?>(this["billingType"]);
            set => Add("billingType", value.ToString());
        }

        public PaymentStatus? Status
        {
            get => EnumUtils.Parse<PaymentStatus?>(this["status"]);
            set => Add("status", value.ToString());
        }

        public string ExternalReference
        {
            get => this["externalReference"];
            set => Add("externalReference", value);
        }

        public DateTime? PaymentDate
        {
            get => DateTimeUtils.Parse(this["paymentDate"]);
            set => Add("paymentDate", value.Value.ToApiRequest());
        }

        public bool Anticipated
        {
            get => Convert.ToBoolean(this["anticipated"]);
            set => Add("anticipated", value);
        }

        public DateTime? PaymentDateGE
        {
            get => DateTimeUtils.Parse(this["paymentDate[ge]"]);
            set => Add("paymentDate[ge]", value.Value.ToApiRequest());
        }

        public DateTime? PaymentDateLE
        {
            get => DateTimeUtils.Parse(this["paymentDate[le]"]);
            set => Add("paymentDate[le]", value.Value.ToApiRequest());
        }

        public DateTime? DueDateGE
        {
            get => DateTimeUtils.Parse(this["dueDate[ge]"]);
            set => Add("dueDate[ge]", value.Value.ToApiRequest());
        }

        public DateTime? DueDateLE
        {
            get => DateTimeUtils.Parse(this["dueDate[le]"]);
            set => Add("dueDate[le]", value.Value.ToApiRequest());
        }
    }
}