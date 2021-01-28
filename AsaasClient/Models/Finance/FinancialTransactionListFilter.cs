using AsaasClient.Core;
using System;

namespace AsaasClient.Models.Finance
{
    public class FinancialTransactionListFilter : RequestParameters
    {
        public DateTime? StartDate
        {
            get => Get<DateTime?>("startDate");
            set => Add("startDate", value);
        }

        public DateTime? FinishDate
        {
            get => Get<DateTime?>("finishDate");
            set => Add("finishDate", value);
        }
    }
}
