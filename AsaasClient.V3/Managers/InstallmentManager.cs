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

        public async Task<ResponseObject<Installment>> Find(string installmentId)
        {
            return await GetAsync<Installment>(INSTALLMENTS_URL, installmentId);
        }

        public async Task<ResponseList<Installment>> List(int offset, int limit)
        {
            return await GetListAsync<Installment>(INSTALLMENTS_URL, offset, limit);
        }
        public async Task<ResponseObject<DeletedInstallment>> Delete(string installmentId)
        {
            if (string.IsNullOrWhiteSpace(installmentId)) throw new ArgumentException("installmentId is required");

            var responseObject = await DeleteAsync<DeletedInstallment>(INSTALLMENTS_URL, installmentId);

            return responseObject;
        }

        public async Task<ResponseObject<Installment>> Refund(string installmentId)
        {
            if (string.IsNullOrWhiteSpace(installmentId)) throw new ArgumentException("installmentId is required");

            var url = $"{INSTALLMENTS_URL}/{installmentId}/refund";
            var responseObject = await PostAsync<Installment>(url, new object());

            return responseObject;
        }
    }
}
