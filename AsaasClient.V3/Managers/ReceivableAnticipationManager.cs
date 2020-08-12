using AsaasClient.Core;
using AsaasClient.Core.Response;
using AsaasClient.V3.Models.ReceivableAnticipation;
using System;
using System.Threading.Tasks;

namespace AsaasClient.V3.Managers
{
    public class ReceivableAnticipationManager : BaseManager
    {
        private const string RECEIVABLE_ANTICIPATIONS_URL = "/anticipations";

        public ReceivableAnticipationManager(ApiSettings settings) : base(settings, 3) { }

        public async Task<ResponseObject<ReceivableAnticipation>> Create(CreateReceivableAnticipationRequest requestObj)
        {
            var responseObject = await PostAsync<ReceivableAnticipation>(RECEIVABLE_ANTICIPATIONS_URL, requestObj);

            return responseObject;
        }

        public async Task<ResponseObject<SimulatedReceivableAnticipation>> Simulate(SimulateReceivableAnticipationRequest requestObj)
        {
            var url = $"{RECEIVABLE_ANTICIPATIONS_URL}/simulate";
            var responseObject = await PostAsync<SimulatedReceivableAnticipation>(url, requestObj);

            return responseObject;
        }

        public async Task<ResponseObject<ReceivableAnticipation>> Find(string receivableAnticipationId)
        {
            if (string.IsNullOrWhiteSpace(receivableAnticipationId)) throw new ArgumentException("receivableAnticipationId is required");

            var responseObject = await GetAsync<ReceivableAnticipation>(RECEIVABLE_ANTICIPATIONS_URL, receivableAnticipationId);

            return responseObject;
        }

        public async Task<ResponseList<ReceivableAnticipation>> List(int offset, int limit, ReceivableAnticipationListFilter filter = null)
        {
            var queryMap = new RequestParameters();

            if (filter != null)
            {
                queryMap.AddRange(filter);
            }

            var responseList = await GetListAsync<ReceivableAnticipation>(RECEIVABLE_ANTICIPATIONS_URL, offset, limit, queryMap);

            return responseList;
        }
    }
}
