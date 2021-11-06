using AsaasClient.Core;
using AsaasClient.Core.Response;
using AsaasClient.Models.AsaasAccount;
using System.Threading.Tasks;

namespace AsaasClient.Managers
{
    public class AsaasAccountManager : BaseManager
    {
        private const string AsaasAccountRoute = "/accounts";

        public AsaasAccountManager(ApiSettings settings) : base(settings) { }

        public async Task<ResponseObject<Account>> Create(CreateAccountRequest requestObj)
        {
            return await PostAsync<Account>(AsaasAccountRoute, requestObj);
        }

        public async Task<ResponseList<Account>> List(int offset, int limit)
        {
            return await GetListAsync<Account>(AsaasAccountRoute, offset, limit);
        }
    }
}
