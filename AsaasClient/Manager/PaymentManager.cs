using AsaasClient.Core;
using AsaasClient.Models.Payment;
using AsaasClient.Response;
using System.Threading.Tasks;

namespace AsaasClient.Manager
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
