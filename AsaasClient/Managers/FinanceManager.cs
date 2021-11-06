using AsaasClient.Core;
using AsaasClient.Core.Response;
using AsaasClient.Models.Finance;
using System.Threading.Tasks;

namespace AsaasClient.Managers
{
    public class FinanceManager : BaseManager
    {
        private const string FinanceRoute = "/finance";
        private const string FinanceTransactionsRoute = "/financialTransactions";

        public FinanceManager(ApiSettings settings) : base(settings) { }

        public async Task<ResponseObject<decimal>> Balance()
        {
            const string route = $"{FinanceRoute}/getCurrentBalance";

            return await GetAsync<decimal>(route);
        }

        public async Task<ResponseList<FinancialTransaction>> ListTransactions(int offset, int limit, FinancialTransactionListFilter filter = null)
        {
            var queryMap = new RequestParameters();
            if (filter != null) queryMap.AddRange(filter);

            return await GetListAsync<FinancialTransaction>(FinanceTransactionsRoute, offset, limit, queryMap);
        }
    }
}
