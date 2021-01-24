using AsaasClient.Core;
using AsaasClient.Models.PaymentDunning.Enums;
using System;

namespace AsaasClient.Models.PaymentDunning
{
    public class PaymentDunningListFilter : RequestParameters
    {
        public PaymentDunningStatus? Status
        {
            get => Get<PaymentDunningStatus?>("status");
            set => Add("status", value);
        }

        public PaymentDunningType? Type
        {
            get => Get<PaymentDunningType?>("type");
            set => Add("type", value);
        }

        public string PaymentId
        {
            get => this["payment"];
            set => Add("payment", value);
        }

        public DateTime? RequestStartDate
        {
            get => Get<DateTime?>("requestStartDate");
            set => Add("requestStartDate", value);
        }

        public DateTime? RequestEndDate
        {
            get => Get<DateTime?>("requestEndDate");
            set => Add("requestEndDate", value);
        }
    }
}

