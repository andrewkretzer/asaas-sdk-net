using AsaasClient.Core;
using AsaasClient.Core.Response;
using AsaasClient.Models.Installment;
using System;
using System.Threading.Tasks;

namespace AsaasClient.Managers
{
    public class InstallmentManager : BaseManager
    {
        private const string InstallmentsRoute = "/installments";

        public InstallmentManager(ApiSettings settings) : base(settings) { }

        public async Task<ResponseObject<Installment>> Find(string installmentId)
        {
            var route = $"{InstallmentsRoute}/{installmentId}";
            return await GetAsync<Installment>(route);
        }

        public async Task<ResponseList<Installment>> List(int offset, int limit)
        {
            return await GetListAsync<Installment>(InstallmentsRoute, offset, limit);
        }

        public async Task<ResponseObject<DeletedInstallment>> Delete(string installmentId)
        {
            var route = $"{InstallmentsRoute}/{installmentId}";

            return await DeleteAsync<DeletedInstallment>(route);
        }

        public async Task<ResponseObject<Installment>> Refund(string installmentId)
        {
            var route = $"{InstallmentsRoute}/{installmentId}/refund";

            return await PostAsync<Installment>(route, new RequestParameters());
        }
    }
}
