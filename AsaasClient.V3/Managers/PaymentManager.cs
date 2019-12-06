using AsaasClient.Core;
using AsaasClient.Core.Response;
using AsaasClient.Models.Payment;
using AsaasClient.V3.Models.Payment;
using AsaasClient.V3.Models.Payment.Base;
using System.Threading.Tasks;

namespace AsaasClient.V3.Managers
{
    public class PaymentManager : BaseManager
    {
        private const string PAYMENTS_URL = "/payments";

        public PaymentManager(ApiSettings settings) : base(settings, 3) { }

        public async Task<ResponseObject<CreatedPayment>> Create(CreatePaymentRequest requestObj)
        {
            return await CreateGeneric<CreatedPayment>(requestObj);
        }

        public async Task<ResponseObject<CreatedPayment>> Create(CreateInstallmentPaymentRequest requestObj)
        {
            return await CreateGeneric<CreatedPayment>(requestObj);
        }

        public async Task<ResponseObject<CreatedCreditCardPayment>> Create(CreateCreditCardPaymentRequest requestObj)
        {
            return await CreateGeneric<CreatedCreditCardPayment>(requestObj);
        }

        public async Task<ResponseObject<CreatedSplitPayment>> Create(CreateSplitPaymentRequest requestObj)
        {
            return await CreateGeneric<CreatedSplitPayment>(requestObj);
        }

        private async Task<ResponseObject<T>> CreateGeneric<T>(BaseCreatePaymentRequest requestObj)
        {
            var responseObject = await PostAsync<T>(PAYMENTS_URL, requestObj);

            return responseObject;
        }
    }
}
