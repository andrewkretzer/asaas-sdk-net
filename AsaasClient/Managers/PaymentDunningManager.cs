using AsaasClient.Core;
using AsaasClient.Core.Response;
using AsaasClient.Models.Common;
using AsaasClient.Models.PaymentDunning;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AsaasClient.Managers
{
    public class PaymentDunningManager : BaseManager
    {
        private const string PaymentDunningRoute = "/paymentDunnings";

        public PaymentDunningManager(ApiSettings settings) : base(settings) { }

        public async Task<ResponseObject<PaymentDunning>> Create(CreatePaymentDunningRequest requestObj)
        {
            return await PostMultipartFormDataContentAsync<PaymentDunning>(PaymentDunningRoute, requestObj);
        }

        public async Task<ResponseObject<SimulatedPaymentDunning>> Simulate(SimulatePaymentDunningRequest requestObj)
        {
            const string route = $"{PaymentDunningRoute}/simulate";

            return await PostAsync<SimulatedPaymentDunning>(route, requestObj);
        }

        public async Task<ResponseObject<PaymentDunning>> Find(string paymentDunningId)
        {
            var route = $"{PaymentDunningRoute}/{paymentDunningId}";

            return await GetAsync<PaymentDunning>(route);
        }

        public async Task<ResponseList<PaymentDunning>> List(int offset, int limit, PaymentDunningListFilter filter = null)
        {
            var queryMap = new RequestParameters();
            if (filter != null) queryMap.AddRange(filter);

            return await GetListAsync<PaymentDunning>(PaymentDunningRoute, offset, limit, queryMap);
        }

        public async Task<ResponseList<PaymentDunningEventHistory>> ListEventHistory(string paymentDunningId, int offset, int limit)
        {
            var route = $"{PaymentDunningRoute}/{paymentDunningId}/history";

            return await GetListAsync<PaymentDunningEventHistory>(route, offset, limit);
        }

        public async Task<ResponseList<PaymentDunningPartialPayments>> ListPartialPaymentsReceived(string paymentDunningId, int offset, int limit)
        {
            var route = $"{PaymentDunningRoute}/{paymentDunningId}/partialPayments";

            return await GetListAsync<PaymentDunningPartialPayments>(route, offset, limit);
        }

        public async Task<ResponseList<PaymentDunningPaymentAvailable>> ListPaymentsAvailableForDunning(int offset, int limit)
        {
            const string route = $"{PaymentDunningRoute}/paymentsAvailableForDunning";

            return await GetListAsync<PaymentDunningPaymentAvailable>(route, offset, limit);
        }

        public async Task<ResponseObject<PaymentDunning>> ResendDocument(string paymentDunningId, List<AsaasFile> asaasFiles)
        {
            var route = $"{PaymentDunningRoute}/{paymentDunningId}/documents";

            return await PostMultipartFormDataContentAsync<PaymentDunning>(route, new { documents = asaasFiles });
        }

        public async Task<ResponseObject<PaymentDunning>> Cancel(string paymentDunningId)
        {
            var route = $"{PaymentDunningRoute}/{paymentDunningId}/cancel";

            return await PostAsync<PaymentDunning>(route, new RequestParameters());
        }
    }
}
