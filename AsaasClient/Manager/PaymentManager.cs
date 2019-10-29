using System.Threading.Tasks;
using AsaasClient.Core;
using AsaasClient.Models.Payment;
using AsaasClient.Response;

namespace AsaasClient.Manager
{
    public class PaymentManager : BaseManager
    {
        private const string PAYMENTS_URL = "/payments";

        public PaymentManager(ApiSettings settings) : base(settings) { }

        public async Task<ResponseObject<CreatedPayment>> Create(CreatePaymentRequest requestObj)
        {
            using var httpResponseMessage = await PostAsync(PAYMENTS_URL, requestObj);

            var responseObject = new ResponseObject<CreatedPayment>(httpResponseMessage);
            return responseObject;
        }
    }
}
