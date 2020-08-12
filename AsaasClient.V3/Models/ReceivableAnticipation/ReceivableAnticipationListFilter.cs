using AsaasClient.Core;
using AsaasClient.V3.Models.ReceivableAnticipation.Enums;

namespace AsaasClient.V3.Models.ReceivableAnticipation
{
    public class ReceivableAnticipationListFilter : RequestParameters
    {
        public string PaymentId
        {
            get => this["payment"];
            set => Add("payment", value);
        }

        public string InstallmentId
        {
            get => this["installment"];
            set => Add("installment", value);
        }

        public ReceivableAnticipationStatus? Status
        {
            get => Get<ReceivableAnticipationStatus?>("status");
            set => Add("status", value);
        }
    }
}
