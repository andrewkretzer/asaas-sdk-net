using AsaasClient.Core;
using AsaasClient.Core.Response;
using AsaasClient.Models.Invoice;
using System;
using System.Threading.Tasks;

namespace AsaasClient.Managers
{
    public class InvoiceManager : BaseManager
    {
        private const string InvoicesRoute = "/invoices";

        public InvoiceManager(ApiSettings settings) : base(settings) { }

        public async Task<ResponseObject<Invoice>> Schedule(CreateInvoiceRequest requestObj)
        {
            return await PostAsync<Invoice>(InvoicesRoute, requestObj);
        }

        public async Task<ResponseObject<Invoice>> Update(string invoiceId, UpdateInvoiceRequest requestObj)
        {
            var route = $"{InvoicesRoute}/{invoiceId}";
            return await PostAsync<Invoice>(route, requestObj);
        }

        public async Task<ResponseObject<Invoice>> Find(string invoiceId)
        {
            var route = $"{InvoicesRoute}/{invoiceId}";
            return await GetAsync<Invoice>(route);
        }

        public async Task<ResponseList<Invoice>> List(int offset, int limit, InvoiceListFilter filter = null)
        {
            var queryMap = new RequestParameters();
            if (filter != null) queryMap.AddRange(filter);

            return await GetListAsync<Invoice>(InvoicesRoute, offset, limit, queryMap);
        }

        public async Task<ResponseObject<Invoice>> Authorize(string invoiceId)
        {
            var route = $"{InvoicesRoute}/{invoiceId}/authorize";

            return await PostAsync<Invoice>(route, new RequestParameters());
        }

        public async Task<ResponseObject<Invoice>> Cancel(string invoiceId)
        {
            var route = $"{InvoicesRoute}/{invoiceId}/cancel";
            return await PostAsync<Invoice>(route, new RequestParameters());
        }

        public async Task<ResponseList<MunicipalService>> ListMunicipalServices(string serviceDescription)
        {
            var queryMap = new RequestParameters
            {
                { "description", serviceDescription }
            };

            const string route = $"{InvoicesRoute}/municipalServices";

            return await GetListAsync<MunicipalService>(route, 0, 0, queryMap);
        }
    }
}
