using AsaasClient.Core;
using AsaasClient.Core.Response;
using AsaasClient.Models.Wallet;
using System.Threading.Tasks;

namespace AsaasClient.Managers
{
    public class WalletManager : BaseManager
    {
        private const string WALLET_URL = "/wallets";

        public WalletManager(ApiSettings settings) : base(settings) { }

        public async Task<ResponseList<Wallet>> List(int offset, int limit)
        {
            var responseList = await GetListAsync<Wallet>(WALLET_URL, offset, limit);

            return responseList;
        }
    }
}
