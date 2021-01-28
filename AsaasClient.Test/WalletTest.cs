using AsaasClient.Core.Response;
using AsaasClient.Models.Wallet;
using System.Threading.Tasks;
using Xunit;

namespace AsaasClient.Test
{
    public class WalletTest : BaseTest {

        [Fact]
        public async Task List() {
            ResponseList<Wallet> responseList = await AsaasClient.Wallet.List(0, 15);

            ValidateResponseStatus(responseList);

            Assert.NotNull(responseList.Data[0].Id);
        }
    }
}
