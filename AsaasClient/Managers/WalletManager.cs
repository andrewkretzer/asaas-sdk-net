using AsaasClient.Core;
using AsaasClient.Core.Response;
using AsaasClient.Models.Wallet;
using System.Threading.Tasks;

namespace AsaasClient.Managers
{
    public class WalletManager : BaseManager
    {
        private const string WalletRoute = "/wallets";

        public WalletManager(ApiSettings settings) : base(settings) { }

        public async Task<ResponseList<Wallet>> List(int offset, int limit)
        {
            return await GetListAsync<Wallet>(WalletRoute, offset, limit);
        }
    }
}
