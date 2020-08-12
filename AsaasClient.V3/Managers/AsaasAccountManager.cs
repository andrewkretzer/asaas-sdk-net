using AsaasClient.Core;
using AsaasClient.Core.Response;
using AsaasClient.V3.Models.AsaasAccount;
using System.Threading.Tasks;

namespace AsaasClient.V3.Managers
{
    public class AsaasAccountManager : BaseManager
    {
        private const string ASAAS_ACCOUNT_URL = "/accounts";

        public AsaasAccountManager(ApiSettings settings) : base(settings, 3) { }

        public async Task<ResponseObject<Account>> Create(CreateAccountRequest requestObj)
        {
            var responseObject = await PostAsync<Account>(ASAAS_ACCOUNT_URL, requestObj);

            return responseObject;
        }

        public async Task<ResponseList<Account>> List(int offset, int limit)
        {
            var responseList = await GetListAsync<Account>(ASAAS_ACCOUNT_URL, offset, limit);

            return responseList;
        }
    }
}
