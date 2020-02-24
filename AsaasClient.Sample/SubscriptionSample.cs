using AsaasClient.Core.Extension;
using AsaasClient.Core.Response;
using AsaasClient.V3;
using AsaasClient.V3.Models.Common.Enums;
using AsaasClient.V3.Models.Subscription;
using AsaasClient.V3.Models.Subscription.Enums;
using System;
using System.Threading.Tasks;

namespace AsaasClient.Sample
{
    public class SubscriptionSample
    {
        private readonly AsaasApi asaasApi;

        public SubscriptionSample(AsaasApi asaasApi)
        {
            this.asaasApi = asaasApi;
        }

        public async Task<ResponseObject<Subscription>> failOnCreate()
        {
            var request = new CreateSubscriptionRequest();

            return await asaasApi.Subscription.Create(request);
        }

        public async Task<ResponseObject<Subscription>> SuccessOnCreateWithBoleto(string customerId)
        {
            var request = new CreateSubscriptionRequest();
            request.CustomerId = customerId;
            request.BillingType = BillingType.BOLETO;
            request.Value = 20.55M;
            request.NextDueDate = DateTime.Parse(DateTime.Now.AddDays(10).ToApiRequest()).Date;
            request.Cycle = Cycle.MONTHLY;

            return await asaasApi.Subscription.Create(request);
        }

        public async Task<ResponseObject<Subscription>> SuccessOnCreateWithCreditCard(string customerId)
        {
            var request = new CreateSubscriptionRequest();
            request.CustomerId = customerId;
            request.BillingType = BillingType.CREDIT_CARD;
            request.Value = 15.55M;
            request.NextDueDate = DateTime.Parse(DateTime.Now.AddDays(10).ToApiRequest()).Date;
            request.Cycle = Cycle.YEARLY;

            return await asaasApi.Subscription.Create(request);
        }

        public async Task<ResponseObject<Subscription>> FailOnFind()
        {
            return await asaasApi.Subscription.Find("test123");
        }

        public async Task<ResponseObject<Subscription>> SuccessOnFind(string subscriptionId)
        {
            return await asaasApi.Subscription.Find(subscriptionId);
        }

        public async Task<ResponseList<Subscription>> ListWithoutFilter()
        {
            return await asaasApi.Subscription.List(0, 10);
        }

        public async Task<ResponseList<Subscription>> ListWithFilter(string customerId)
        {
            var filter = new SubscriptionListFilter();
            filter.CustomerId = customerId;
            filter.BillingType = BillingType.BOLETO;

            return await asaasApi.Subscription.List(0, 10);
        }

        public async Task<ResponseObject<Subscription>> FailOnUpdate(string subscriptionId)
        {
            return await asaasApi.Subscription.Update(subscriptionId, null);
        }

        public async Task<ResponseObject<Subscription>> SuccessOnUpdate(string subscriptionId)
        {
            var request = new UpdateSubscriptionRequest();
            request.Value = 10.15M;

            return await asaasApi.Subscription.Update(subscriptionId, request);
        }

        public async Task<ResponseObject<DeletedSubscription>> FailOnDelete()
        {
            return await asaasApi.Subscription.Delete("test123");
        }

        public async Task<ResponseObject<DeletedSubscription>> SuccessOnDelete(string subscriptionId)
        {
            return await asaasApi.Subscription.Delete(subscriptionId);
        }
    }
}
