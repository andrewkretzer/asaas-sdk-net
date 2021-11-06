using AsaasClient.Core;
using AsaasClient.Core.Response;
using AsaasClient.Models.MyAccount;
using System.Threading.Tasks;

namespace AsaasClient.Managers
{
    public class MyAccountManager : BaseManager
    {
        private const string MyAccountRoute = "/myAccount";
        private const string PaymentCheckoutConfigRoute = MyAccountRoute + "/paymentCheckoutConfig";

        public MyAccountManager(ApiSettings settings) : base(settings) { }

        public async Task<ResponseObject<MyAccount>> Find()
        {
            return await GetAsync<MyAccount>(MyAccountRoute);
        }

        public async Task<ResponseObject<PaymentCheckoutConfig>> CreatePaymentCheckoutConfig(CreatePaymentCheckoutConfigRequest requestObj)
        {
            return await PostMultipartFormDataContentAsync<PaymentCheckoutConfig>(PaymentCheckoutConfigRoute, requestObj);
        }

        public async Task<ResponseObject<PaymentCheckoutConfig>> FindPaymentCheckoutConfig()
        {
            return await GetAsync<PaymentCheckoutConfig>(PaymentCheckoutConfigRoute);
        }
    }
}