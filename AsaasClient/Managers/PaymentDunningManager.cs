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
        private const string PAYMENT_DUNNING_URL = "/paymentDunnings";

        public PaymentDunningManager(ApiSettings settings) : base(settings) { }

        public async Task<ResponseObject<PaymentDunning>> Create(CreatePaymentDunningRequest requestObj)
        {
            var responseObject = await PostMultipartFormDataContentAsync<PaymentDunning>(PAYMENT_DUNNING_URL, requestObj);

            return responseObject;
        }

        public async Task<ResponseObject<SimulatedPaymentDunning>> Simulate(SimulatePaymentDunningRequest requestObj)
        {
            var url = $"{PAYMENT_DUNNING_URL}/simulate";
            var responseObject = await PostAsync<SimulatedPaymentDunning>(url, requestObj);

            return responseObject;
        }

        public async Task<ResponseObject<PaymentDunning>> Find(string paymentDunningId)
        {
            if (string.IsNullOrWhiteSpace(paymentDunningId)) throw new ArgumentException("paymentDunningId is required");

            var url = $"{PAYMENT_DUNNING_URL}/{paymentDunningId}";
            var responseObject = await GetAsync<PaymentDunning>(url);

            return responseObject;
        }

        public async Task<ResponseList<PaymentDunning>> List(int offset, int limit, PaymentDunningListFilter filter = null)
        {
            var queryMap = new RequestParameters();
            if (filter != null) queryMap.AddRange(filter);

            var responseList = await GetListAsync<PaymentDunning>(PAYMENT_DUNNING_URL, offset, limit, queryMap);

            return responseList;
        }

        public async Task<ResponseList<PaymentDunningEventHistory>> ListEventHistory(string paymentDunningId, int offset, int limit)
        {
            if (string.IsNullOrWhiteSpace(paymentDunningId)) throw new ArgumentException("paymentDunningId is required");

            var url = $"{PAYMENT_DUNNING_URL}/{paymentDunningId}/history";
            var responseList = await GetListAsync<PaymentDunningEventHistory>(url, offset, limit);

            return responseList;
        }

        public async Task<ResponseList<PaymentDunningPartialPayments>> ListPartialPaymentsReceived(string paymentDunningId, int offset, int limit)
        {
            if (string.IsNullOrWhiteSpace(paymentDunningId)) throw new ArgumentException("paymentDunningId is required");

            var url = $"{PAYMENT_DUNNING_URL}/{paymentDunningId}/partialPayments";
            var responseList = await GetListAsync<PaymentDunningPartialPayments>(url, offset, limit);

            return responseList;
        }

        public async Task<ResponseList<PaymentDunningPaymentAvailable>> ListPaymentsAvailableForDunning(int offset, int limit)
        {
            var url = $"{PAYMENT_DUNNING_URL}/paymentsAvailableForDunning";
            var responseList = await GetListAsync<PaymentDunningPaymentAvailable>(url, offset, limit);

            return responseList;
        }

        public async Task<ResponseObject<PaymentDunning>> ResendDocument(string paymentDunningId, List<AsaasFile> asaasFiles)
        {
            if (string.IsNullOrWhiteSpace(paymentDunningId)) throw new ArgumentException("paymentDunningId is required");

            var url = $"{PAYMENT_DUNNING_URL}/{paymentDunningId}/documents";
            var responseObject = await PostMultipartFormDataContentAsync<PaymentDunning>(url, new { documents = asaasFiles });

            return responseObject;
        }

        public async Task<ResponseObject<PaymentDunning>> Cancel(string paymentDunningId)
        {
            if (string.IsNullOrWhiteSpace(paymentDunningId)) throw new ArgumentException("paymentDunningId is required");

            var url = $"{PAYMENT_DUNNING_URL}/{paymentDunningId}/cancel";
            var responseObject = await PostAsync<PaymentDunning>(url, new RequestParameters());

            return responseObject;
        }
    }
}
