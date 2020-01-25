using AsaasClient.Core;
using AsaasClient.Core.Response;
using AsaasClient.V3.Models.Wallet;
using System.Threading.Tasks;

namespace AsaasClient.V3.Managers
{
    public class WalletManager : BaseManager
    {
        private const string WALLET_URL = "/wallets";

        public WalletManager(ApiSettings settings) : base(settings, 3) { }

        public async Task<ResponseList<Wallet>> List()
        {
            var responseList = await GetListAsync<Wallet>(WALLET_URL, 0, 0);

            return responseList;
        }
    }
}
