using AsaasClient.Core;
using AsaasClient.Core.Response;
using AsaasClient.Models.Transfer;
using AsaasClient.Models.Transfer.Base;
using System.Threading.Tasks;

namespace AsaasClient.Managers
{
    public class TransferManager : BaseManager
    {
        private const string TransfersRoute = "/transfers";

        public TransferManager(ApiSettings settings) : base(settings) { }

        public async Task<ResponseList<BaseTransfer>> List(int offset, int limit, TransferListFilter filter = null)
        {
            var queryMap = new RequestParameters();
            if (filter != null) queryMap.AddRange(filter);

            return await GetListAsync<BaseTransfer>(TransfersRoute, offset, limit, queryMap);
        }

        public async Task<ResponseObject<AsaasAccountTransfer>> Execute(AsaasAccountTransferRequest requestObj)
        {
            return await PostAsync<AsaasAccountTransfer>(TransfersRoute, requestObj);
        }

        public async Task<ResponseObject<BankAccountTransfer>> Execute(BankAccountTransferRequest requestObj)
        {
            return await PostAsync<BankAccountTransfer>(TransfersRoute, requestObj);
        }
    }
}
