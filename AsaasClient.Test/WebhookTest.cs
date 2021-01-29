using AsaasClient.Core.Response;
using AsaasClient.Models.Webhook;
using System.Threading.Tasks;
using Xunit;

namespace AsaasClient.Test
{
    public class WebhookTest : BaseTest {

        [Fact]
        public async Task Payment() {
            WebhookRequest webhookRequest = new WebhookRequest {
                Url = "asaassdk.com",
                ApiVersion = 2,
                Email = "test@test.com",
                Enabled = true,
                AuthToken = "123",
                Interrupted = false
            };

            ResponseObject<Webhook> createdWebhook = await AsaasClient.Webhook.CreateOrUpdatePaymentWebhook(webhookRequest);
            ValidateResponseStatus(createdWebhook);

            ValidateResponseWebhook(webhookRequest, createdWebhook.Data);

            webhookRequest.Url = "asaasSdk.com";
            webhookRequest.ApiVersion = 3;
            webhookRequest.Email = "test2@test2.com";
            webhookRequest.Enabled = false;
            webhookRequest.AuthToken = "321";
            webhookRequest.Interrupted = true;

            ResponseObject<Webhook> updatedWebhook = await AsaasClient.Webhook.CreateOrUpdatePaymentWebhook(webhookRequest);
            ValidateResponseStatus(updatedWebhook);

            ValidateResponseWebhook(webhookRequest, updatedWebhook.Data);

            ResponseObject<Webhook> findResponse = await AsaasClient.Webhook.FindPaymentWebhook();
            ValidateResponseStatus(findResponse);

            ValidateResponseWebhook(webhookRequest, findResponse.Data);
        }

        [Fact]
        public async Task Invoice() {
            WebhookRequest webhookRequest = new WebhookRequest {
                Url = "asaassdk.com",
                ApiVersion = 2,
                Email = "test@test.com",
                Enabled = true,
                AuthToken = "123",
                Interrupted = false
            };

            ResponseObject<Webhook> createdWebhook = await AsaasClient.Webhook.CreateOrUpdateInvoiceWebhook(webhookRequest);
            ValidateResponseStatus(createdWebhook);

            ValidateResponseWebhook(webhookRequest, createdWebhook.Data);

            webhookRequest.Url = "asaasSdk.com";
            webhookRequest.ApiVersion = 3;
            webhookRequest.Email = "test2@test2.com";
            webhookRequest.Enabled = false;
            webhookRequest.AuthToken = "321";
            webhookRequest.Interrupted = true;

            ResponseObject<Webhook> updatedWebhook = await AsaasClient.Webhook.CreateOrUpdateInvoiceWebhook(webhookRequest);
            ValidateResponseStatus(updatedWebhook);

            ValidateResponseWebhook(webhookRequest, updatedWebhook.Data);

            ResponseObject<Webhook> findResponse = await AsaasClient.Webhook.FindInvoiceWebhook();
            ValidateResponseStatus(findResponse);

            ValidateResponseWebhook(webhookRequest, findResponse.Data);
        }

        private void ValidateResponseWebhook(WebhookRequest webhookRequest, Webhook webhook) {
            Assert.Equal(webhookRequest.Url, webhook.Url);
            Assert.Equal(webhookRequest.ApiVersion, webhook.ApiVersion);
            Assert.Equal(webhookRequest.Email, webhook.Email);
            Assert.Equal(webhookRequest.Enabled, webhook.Enabled);
            Assert.Equal(webhookRequest.AuthToken, webhook.AuthToken);
            Assert.Equal(webhookRequest.Interrupted, webhook.Interrupted);
        }
    }
}
