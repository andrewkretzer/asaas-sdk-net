using AsaasClient.Core;
using AsaasClient.V3.Models.ReceivableAnticipation.Enums;

namespace AsaasClient.V3.Models.ReceivableAnticipation
{
    public class ReceivableAnticipationListFilter : RequestParameters
    {
        public ReceivableAnticipationStatus? Status
        {
            get => Get<ReceivableAnticipationStatus?>("status");
            set => Add("status", value);
        }
    }
}
