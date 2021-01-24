using AsaasClient.Core;
using AsaasClient.Core.Response;
using AsaasClient.Models.Bill;
using System;
using System.Threading.Tasks;

namespace AsaasClient.Managers
{
    public class BillPaymentManager : BaseManager
    {
        private const string BILL_PAYMENT_URL = "/bill";

        public BillPaymentManager(ApiSettings settings) : base(settings) { }

        public async Task<ResponseObject<BillPayment>> Create(CreateBillPaymentRequest requestObj)
        {
            var responseObject = await PostAsync<BillPayment>(BILL_PAYMENT_URL, requestObj);

            return responseObject;
        }

        public async Task<ResponseObject<SimulatedBillPayment>> Simulate(SimulateBillPaymentRequest requestObj)
        {
            var url = $"{BILL_PAYMENT_URL}/simulate";
            var responseObject = await PostAsync<SimulatedBillPayment>(url, requestObj);

            return responseObject;
        }

        public async Task<ResponseObject<BillPayment>> Find(string billPaymentId)
        {
            if (string.IsNullOrWhiteSpace(billPaymentId)) throw new ArgumentException("billPaymentId is required");

            var url = $"{BILL_PAYMENT_URL}/{billPaymentId}";
            var responseObject = await GetAsync<BillPayment>(url);

            return responseObject;
        }

        public async Task<ResponseList<BillPayment>> List(int offset, int limit)
        {
            var responseList = await GetListAsync<BillPayment>(BILL_PAYMENT_URL, offset, limit, new RequestParameters());

            return responseList;
        }

        public async Task<ResponseObject<BillPayment>> Cancel(string billPaymentId)
        {
            if (string.IsNullOrWhiteSpace(billPaymentId)) throw new ArgumentException("billPaymentId is required");

            var url = $"{BILL_PAYMENT_URL}/{billPaymentId}/cancel";
            var responseObject = await PostAsync<BillPayment>(url, new RequestParameters());

            return responseObject;
        }
    }
}
