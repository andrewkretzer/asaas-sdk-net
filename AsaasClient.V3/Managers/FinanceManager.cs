using AsaasClient.Core;
using AsaasClient.Core.Response;
using AsaasClient.V3.Models.Finance;
using System.Threading.Tasks;

namespace AsaasClient.V3.Managers
{
    public class FinanceManager : BaseManager
    {
        private const string FINANCE_URL = "/finance";
        private const string FINANCE_TRANSACTIONS_URL = "/financialTransactions";

        public FinanceManager(ApiSettings settings) : base(settings, 3) { }

        public async Task<ResponseObject<decimal>> Balance()
        {
            var url = $"{FINANCE_URL}/getCurrentBalance";
            var responseObject = await GetAsync<decimal>(url, null, false);

            return responseObject;
        }

        public async Task<ResponseList<FinancialTransaction>> ListTransactions(int offset, int limit, FinancialTransactionListFilter filter = null)
        {
            var queryMap = new RequestParameters();

            if (filter != null)
            {
                queryMap.AddRange(filter);
            }

            var responseList = await GetListAsync<FinancialTransaction>(FINANCE_TRANSACTIONS_URL, offset, limit, queryMap);

            return responseList;
        }
    }
}
