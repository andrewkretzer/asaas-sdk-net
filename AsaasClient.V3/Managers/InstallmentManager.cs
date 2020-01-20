using AsaasClient.Core;
using AsaasClient.Core.Response;
using AsaasClient.V3.Models.Installment;
using System;
using System.Threading.Tasks;

namespace AsaasClient.V3.Managers
{
    public class InstallmentManager : BaseManager
    {
        private const string INSTALLMENTS_URL = "/installments";

        public InstallmentManager(ApiSettings settings) : base(settings, 3) { }

        public async Task<ResponseObject<Installment>> Find(string id)
        {
            return await GetAsync<Installment>(INSTALLMENTS_URL, id);
        }

        public async Task<ResponseList<Installment>> List(int offset, int limit)
        {
            return await GetListAsync<Installment>(INSTALLMENTS_URL, offset, limit);
        }
        public async Task<ResponseObject<DeletedInstallment>> Delete(string id)
        {
            if (string.IsNullOrWhiteSpace(id)) throw new ArgumentException("Id is required");

            var responseObject = await DeleteAsync<DeletedInstallment>(INSTALLMENTS_URL, id);

            return responseObject;
        }

        public async Task<ResponseObject<Installment>> Refund(string id)
        {
            if (string.IsNullOrWhiteSpace(id)) throw new ArgumentException("Id is required");

            var url = $"{INSTALLMENTS_URL}/{id}/refund";
            var responseObject = await PostAsync<Installment>(url, new object());

            return responseObject;
        }
    }
}
