using AsaasClient.Core;
using AsaasClient.Core.Response;
using AsaasClient.Models.Payment;
using System.Threading.Tasks;

namespace AsaasClient.Managers
{
    public class PaymentManager : BaseManager
    {
        private const string PAYMENTS_URL = "/payments";

        public PaymentManager(ApiSettings settings) : base(settings) { }

        public async Task<ResponseObject<CreatedPayment>> Create(CreatePaymentRequest requestObj)
        {
            var responseObject = await PostAsync<CreatedPayment>(PAYMENTS_URL, requestObj);

            return responseObject;
        }
    }
}
