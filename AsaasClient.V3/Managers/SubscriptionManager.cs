using AsaasClient.Core;
using AsaasClient.Core.Response;
using AsaasClient.V3.Models.Subscription;
using System;
using System.Threading.Tasks;

namespace AsaasClient.V3.Managers
{
    public class SubscriptionManager : BaseManager
    {
        private const string SUBSCRIPTIONS_URL = "/subscriptions";

        public SubscriptionManager(ApiSettings settings) : base(settings, 3) { }

        public async Task<ResponseObject<Subscription>> Create(CreateSubscriptionRequest requestObj)
        {
            return await PostAsync<Subscription>(SUBSCRIPTIONS_URL, requestObj);
        }

        public async Task<ResponseObject<Subscription>> Find(string subscriptionId)
        {
            return await GetAsync<Subscription>(SUBSCRIPTIONS_URL, subscriptionId);
        }

        public async Task<ResponseList<Subscription>> List(int offset, int limit, SubscriptionListFilter filter = null)
        {
            var queryMap = new RequestParameters();

            if (filter != null)
            {
                queryMap.AddRange(filter);
            }

            var responseList = await GetListAsync<Subscription>(SUBSCRIPTIONS_URL, offset, limit, queryMap);

            return responseList;
        }

        public async Task<ResponseObject<Subscription>> Update(string subscriptionId, UpdateSubscriptionRequest requestObj)
        {
            if (string.IsNullOrWhiteSpace(subscriptionId)) throw new ArgumentException("subscriptionId is required");

            var url = $"{SUBSCRIPTIONS_URL}/{subscriptionId}";
            var responseObject = await PostAsync<Subscription>(url, requestObj);

            return responseObject;
        }

        public async Task<ResponseObject<DeletedSubscription>> Delete(string subscriptionId)
        {
            if (string.IsNullOrWhiteSpace(subscriptionId)) throw new ArgumentException("subscriptionId is required");

            var responseObject = await DeleteAsync<DeletedSubscription>(SUBSCRIPTIONS_URL, subscriptionId);

            return responseObject;
        }
    }
}
