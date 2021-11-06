using AsaasClient.Core;
using AsaasClient.Core.Response;
using AsaasClient.Models.Payment;
using System;
using System.Threading.Tasks;

namespace AsaasClient.Managers
{
    public class PaymentManager : BaseManager
    {
        private const string PaymentsRoute = "/payments";

        public PaymentManager(ApiSettings settings) : base(settings) { }

        public async Task<ResponseObject<Payment>> Create(CreatePaymentRequest requestObj)
        {
            return await PostAsync<Payment>(PaymentsRoute, requestObj);
        }

        public async Task<ResponseObject<Payment>> Find(string id)
        {
            var route = $"{PaymentsRoute}/{id}";
            return await GetAsync<Payment>(route);
        }

        public async Task<ResponseList<Payment>> List(int offset, int limit, PaymentListFilter filter = null)
        {
            var queryMap = new RequestParameters();
            if (filter != null) queryMap.AddRange(filter);

            return await GetListAsync<Payment>(PaymentsRoute, offset, limit, queryMap);
        }

        public async Task<ResponseObject<Payment>> Update(string paymentId, UpdatePaymentRequest requestObj)
        {
            var route = $"{PaymentsRoute}/{paymentId}";

            return await PostAsync<Payment>(route, requestObj);
        }

        public async Task<ResponseObject<DeletedPayment>> Delete(string paymentId)
        {
            var route = $"{PaymentsRoute}/{paymentId}";
            return await DeleteAsync<DeletedPayment>(route);
        }

        public async Task<ResponseObject<Payment>> Restore(string paymentId)
        {
            var route = $"{PaymentsRoute}/{paymentId}/restore";

            return await PostAsync<Payment>(route, new RequestParameters());
        }

        public async Task<ResponseObject<Payment>> Refund(string paymentId)
        {
            var route = $"{PaymentsRoute}/{paymentId}/refund";
            return await PostAsync<Payment>(route, new RequestParameters());
        }

        public async Task<ResponseObject<Payment>> ReceiveInCash(string paymentId, DateTime paymentDate, decimal value, bool notifyCustomer)
        {
            var route = $"{PaymentsRoute}/{paymentId}/receiveInCash";

            RequestParameters parameters = new RequestParameters
            {
                { "paymentDate", paymentDate },
                { "value", value },
                { "notifyCustomer", notifyCustomer }
            };

            return await PostAsync<Payment>(route, parameters);
        }
    }
}