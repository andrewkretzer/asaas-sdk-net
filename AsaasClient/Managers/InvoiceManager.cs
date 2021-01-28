using AsaasClient.Core;
using AsaasClient.Core.Response;
using AsaasClient.Models.Invoice;
using System;
using System.Threading.Tasks;

namespace AsaasClient.Managers
{
    public class InvoiceManager : BaseManager
    {
        private const string INVOICES_URL = "/invoices";

        public InvoiceManager(ApiSettings settings) : base(settings) { }

        public async Task<ResponseObject<Invoice>> Schedule(CreateInvoiceRequest requestObj)
        {
            var responseObject = await PostAsync<Invoice>(INVOICES_URL, requestObj);

            return responseObject;
        }

        public async Task<ResponseObject<Invoice>> Update(string invoiceId, UpdateInvoiceRequest requestObj)
        {
            if (string.IsNullOrWhiteSpace(invoiceId)) throw new ArgumentException("invoiceId is required");

            var url = $"{INVOICES_URL}/{invoiceId}";
            var responseObject = await PostAsync<Invoice>(url, requestObj);

            return responseObject;
        }

        public async Task<ResponseObject<Invoice>> Find(string invoiceId)
        {
            if (string.IsNullOrWhiteSpace(invoiceId)) throw new ArgumentException("invoiceId is required");

            var responseObject = await GetAsync<Invoice>(INVOICES_URL, invoiceId);

            return responseObject;
        }

        public async Task<ResponseList<Invoice>> List(int offset, int limit, InvoiceListFilter filter = null)
        {
            var queryMap = new RequestParameters();

            if (filter != null)
            {
                queryMap.AddRange(filter);
            }

            var responseList = await GetListAsync<Invoice>(INVOICES_URL, offset, limit, queryMap);

            return responseList;
        }

        public async Task<ResponseObject<Invoice>> Authorize(string invoiceId)
        {
            if (string.IsNullOrWhiteSpace(invoiceId)) throw new ArgumentException("invoiceId is required");

            var url = $"{INVOICES_URL}/{invoiceId}/authorize";
            var responseObject = await PostAsync<Invoice>(url, new object());

            return responseObject;
        }

        public async Task<ResponseObject<Invoice>> Cancel(string invoiceId)
        {
            if (string.IsNullOrWhiteSpace(invoiceId)) throw new ArgumentException("invoiceId is required");

            var url = $"{INVOICES_URL}/{invoiceId}/cancel";
            var responseObject = await PostAsync<Invoice>(url, new object());

            return responseObject;
        }

        public async Task<ResponseList<MunicipalService>> ListMunicipalServices(string serviceDescription)
        {
            var queryMap = new RequestParameters
            {
                { "description", serviceDescription }
            };

            var url = $"{INVOICES_URL}/municipalServices";
            var responseList = await GetListAsync<MunicipalService>(url, 0, 0, queryMap);

            return responseList;
        }
    }
}
