using AsaasClient.Core;
using AsaasClient.Core.Response;
using System.Threading.Tasks;

namespace AsaasClient.V3.Managers
{
    public class FinanceManager : BaseManager
    {
        private const string FINANCE_URL = "/finance";

        public FinanceManager(ApiSettings settings) : base(settings, 3) { }

        public async Task<ResponseObject<decimal>> Balance()
        {
            var url = $"{FINANCE_URL}/getCurrentBalance";
            var responseObject = await GetAsync<decimal>(url);

            return responseObject;
        }
    }
}
