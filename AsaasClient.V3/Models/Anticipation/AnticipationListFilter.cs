using AsaasClient.Core;
using AsaasClient.V3.Models.Anticipation.Enums;

namespace AsaasClient.V3.Models.Anticipation
{
    public class AnticipationListFilter : RequestParameters
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

        public AnticipationStatus? Status
        {
            get => Get<AnticipationStatus?>("status");
            set => Add("status", value);
        }
    }
}
