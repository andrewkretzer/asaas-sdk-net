using AsaasClient.Core;
using AsaasClient.Core.Response;
using AsaasClient.Models.Anticipation;
using System;
using System.Threading.Tasks;

namespace AsaasClient.Managers
{
    public class AnticipationManager : BaseManager
    {
        private const string AnticipationsRoute = "/anticipations";

        public AnticipationManager(ApiSettings settings) : base(settings) { }

        public async Task<ResponseObject<Anticipation>> Create(CreateAnticipationRequest requestObj)
        {
            return await PostMultipartFormDataContentAsync<Anticipation>(AnticipationsRoute, requestObj);
        }

        public async Task<ResponseObject<SimulatedAnticipation>> Simulate(SimulateAnticipationRequest requestObj)
        {
            var route = $"{AnticipationsRoute}/simulate";

            return await PostAsync<SimulatedAnticipation>(route, requestObj);
        }

        public async Task<ResponseObject<Anticipation>> Find(string anticipationId)
        {
            return await GetAsync<Anticipation>(AnticipationsRoute, anticipationId);
        }

        public async Task<ResponseList<Anticipation>> List(int offset, int limit, AnticipationListFilter filter = null)
        {
            var queryMap = new RequestParameters();
            if (filter != null) queryMap.AddRange(filter);

            var responseList = await GetListAsync<Anticipation>(AnticipationsRoute, offset, limit, queryMap);

            return responseList;
        }
    }
}
