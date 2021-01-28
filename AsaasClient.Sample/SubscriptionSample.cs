using AsaasClient.Core.Response;
using AsaasClient.Models.Common.Enums;
using AsaasClient.Models.Subscription;
using AsaasClient.Models.Subscription.Enums;
using System;
using System.Threading.Tasks;

namespace AsaasClient.Sample
{
    public class SubscriptionSample
    {
        private readonly AsaasClient _asaasClient;

        public SubscriptionSample(AsaasClient asaasClient)
        {
            this._asaasClient = asaasClient;
        }

        public async Task<ResponseObject<Subscription>> FailOnCreate()
        {
            var request = new CreateSubscriptionRequest();

            return await _asaasClient.Subscription.Create(request);
        }

        public async Task<ResponseObject<Subscription>> SuccessOnCreateWithBoleto(string customerId)
        {
            var request = new CreateSubscriptionRequest();
            request.CustomerId = customerId;
            request.BillingType = BillingType.BOLETO;
            request.Value = 20.55M;
            request.NextDueDate = DateTime.Now.AddDays(10).Date;
            request.Cycle = Cycle.MONTHLY;

            return await _asaasClient.Subscription.Create(request);
        }

        public async Task<ResponseObject<Subscription>> SuccessOnCreateWithCreditCard(string customerId)
        {
            var request = new CreateSubscriptionRequest();
            request.CustomerId = customerId;
            request.BillingType = BillingType.CREDIT_CARD;
            request.Value = 15.55M;
            request.NextDueDate = DateTime.Now.AddDays(10).Date;
            request.Cycle = Cycle.YEARLY;

            return await _asaasClient.Subscription.Create(request);
        }

        public async Task<ResponseObject<Subscription>> FailOnFind()
        {
            return await _asaasClient.Subscription.Find("test123");
        }

        public async Task<ResponseObject<Subscription>> SuccessOnFind(string subscriptionId)
        {
            return await _asaasClient.Subscription.Find(subscriptionId);
        }

        public async Task<ResponseList<Subscription>> ListWithoutFilter()
        {
            return await _asaasClient.Subscription.List(0, 10);
        }

        public async Task<ResponseList<Subscription>> ListWithFilter(string customerId)
        {
            var filter = new SubscriptionListFilter();
            filter.CustomerId = customerId;
            filter.BillingType = BillingType.BOLETO;

            return await _asaasClient.Subscription.List(0, 10);
        }

        public async Task<ResponseObject<Subscription>> FailOnUpdate(string subscriptionId)
        {
            return await _asaasClient.Subscription.Update(subscriptionId, null);
        }

        public async Task<ResponseObject<Subscription>> SuccessOnUpdate(string subscriptionId)
        {
            var request = new UpdateSubscriptionRequest();
            request.Value = 10.15M;

            return await _asaasClient.Subscription.Update(subscriptionId, request);
        }

        public async Task<ResponseObject<DeletedSubscription>> FailOnDelete()
        {
            return await _asaasClient.Subscription.Delete("test123");
        }

        public async Task<ResponseObject<DeletedSubscription>> SuccessOnDelete(string subscriptionId)
        {
            return await _asaasClient.Subscription.Delete(subscriptionId);
        }
    }
}
