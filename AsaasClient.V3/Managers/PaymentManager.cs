using AsaasClient.Core;
using AsaasClient.Core.Response;
using AsaasClient.V3.Models.Payment;
using System;
using System.Threading.Tasks;

namespace AsaasClient.V3.Managers
{
    public class PaymentManager : BaseManager
    {
        private const string PAYMENTS_URL = "/payments";

        public PaymentManager(ApiSettings settings) : base(settings, 3) { }

        public async Task<ResponseObject<Payment>> Create(CreatePaymentRequest requestObj)
        {
            return await PostAsync<Payment>(PAYMENTS_URL, requestObj);
        }

        public async Task<ResponseObject<Payment>> Find(string id)
        {
            return await GetAsync<Payment>(PAYMENTS_URL, id);
        }

        public async Task<ResponseList<Payment>> List(int offset, int limit, PaymentListFilter filter = null)
        {
            var queryMap = new Map();

            if (filter != null)
            {
                queryMap.AddRange(filter);
            }

            var responseList = await GetListAsync<Payment>(PAYMENTS_URL, offset, limit, queryMap);

            return responseList;
        }

        public async Task<ResponseObject<Payment>> Update(string paymentId, UpdatePaymentRequest requestObj)
        {
            if (string.IsNullOrWhiteSpace(paymentId)) throw new ArgumentException("paymentId is required");

            var url = $"{PAYMENTS_URL}/{paymentId}";
            var responseObject = await PostAsync<Payment>(url, requestObj);

            return responseObject;
        }

        public async Task<ResponseObject<DeletedPayment>> Delete(string paymentId)
        {
            if (string.IsNullOrWhiteSpace(paymentId)) throw new ArgumentException("paymentId is required");

            var responseObject = await DeleteAsync<DeletedPayment>(PAYMENTS_URL, paymentId);

            return responseObject;
        }

        public async Task<ResponseObject<Payment>> Restore(string paymentId)
        {
            if (string.IsNullOrWhiteSpace(paymentId)) throw new ArgumentException("paymentId is required");

            var url = $"{PAYMENTS_URL}/{paymentId}/restore";
            var responseObject = await PostAsync<Payment>(url, new object());

            return responseObject;
        }

        public async Task<ResponseObject<Payment>> Refund(string paymentId)
        {
            if (string.IsNullOrWhiteSpace(paymentId)) throw new ArgumentException("paymentId is required");

            var url = $"{PAYMENTS_URL}/{paymentId}/refund";
            var responseObject = await PostAsync<Payment>(url, new object());

            return responseObject;
        }

        public async Task<ResponseObject<Payment>> ReceiveInCash(string paymentId, DateTime paymentDate, decimal value, bool notifyCustomer)
        {
            if (string.IsNullOrWhiteSpace(paymentId)) throw new ArgumentException("paymentId is required");

            var url = $"{PAYMENTS_URL}/{paymentId}/receiveInCash";

            Map parameters = new Map
            {
                { "paymentDate", paymentDate },
                { "value", value },
                { "notifyCustomer", notifyCustomer }
            };

            var responseObject = await PostAsync<Payment>(url, parameters);

            return responseObject;
        }
    }
}