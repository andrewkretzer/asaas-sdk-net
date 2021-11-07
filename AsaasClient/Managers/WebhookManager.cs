using AsaasClient.Core;
using AsaasClient.Core.Response;
using AsaasClient.Models.Webhook;
using System.Threading.Tasks;

namespace AsaasClient.Managers
{
    public class WebhookManager : BaseManager
    {
        private const string WebhookRoute = "/webhook";

        public WebhookManager(ApiSettings settings) : base(settings) { }

        public async Task<ResponseObject<Webhook>> CreateOrUpdatePaymentWebhook(WebhookRequest requestObj)
        {
            return await PostAsync<Webhook>(WebhookRoute, requestObj);
        }

        public async Task<ResponseObject<Webhook>> FindPaymentWebhook()
        {
            return await GetAsync<Webhook>(WebhookRoute);
        }

        public async Task<ResponseObject<Webhook>> CreateOrUpdateInvoiceWebhook(WebhookRequest requestObj)
        {
            var route = $"{WebhookRoute}/invoice";

            return await PostAsync<Webhook>(route, requestObj);
        }

        public async Task<ResponseObject<Webhook>> FindInvoiceWebhook()
        {
            var route = $"{WebhookRoute}/invoice";

            return await GetAsync<Webhook>(route);
        }
    }
}
