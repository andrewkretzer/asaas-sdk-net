using AsaasClient.Core;
using AsaasClient.Core.Response;
using AsaasClient.V3.Models.Anticipation;
using System;
using System.Threading.Tasks;

namespace AsaasClient.V3.Managers
{
    public class AnticipationManager : BaseManager
    {
        private const string ANTICIPATIONS_URL = "/anticipations";

        public AnticipationManager(ApiSettings settings) : base(settings, 3) { }

        public async Task<ResponseObject<Anticipation>> Create(CreateAnticipationRequest requestObj)
        {
            var responseObject = await PostMultipartFormDataContentAsync<Anticipation>(ANTICIPATIONS_URL, requestObj);

            return responseObject;
        }

        public async Task<ResponseObject<SimulatedAnticipation>> Simulate(SimulateAnticipationRequest requestObj)
        {
            var url = $"{ANTICIPATIONS_URL}/simulate";
            var responseObject = await PostAsync<SimulatedAnticipation>(url, requestObj);

            return responseObject;
        }

        public async Task<ResponseObject<Anticipation>> Find(string anticipationId)
        {
            if (string.IsNullOrWhiteSpace(anticipationId)) throw new ArgumentException("anticipationId is required");

            var responseObject = await GetAsync<Anticipation>(ANTICIPATIONS_URL, anticipationId);

            return responseObject;
        }

        public async Task<ResponseList<Anticipation>> List(int offset, int limit, AnticipationListFilter filter = null)
        {
            var queryMap = new RequestParameters();

            if (filter != null)
            {
                queryMap.AddRange(filter);
            }

            var responseList = await GetListAsync<Anticipation>(ANTICIPATIONS_URL, offset, limit, queryMap);

            return responseList;
        }
    }
}
