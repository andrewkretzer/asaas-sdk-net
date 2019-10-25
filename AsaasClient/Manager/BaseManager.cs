using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using AsaasClient.Core;
using Newtonsoft.Json;

namespace AsaasClient.Manager
{
    public class BaseManager
    {
        private readonly ApiSettings _settings;

        protected BaseManager(ApiSettings settings)
        {
            _settings = settings;
        }

        protected async Task<HttpResponseMessage> PostAsync(string resource, object payload)
        {
            using var httpClient = new HttpClient { BaseAddress = buildBaseAddress() };
            httpClient.DefaultRequestHeaders.TryAddWithoutValidation("access_token", _settings.AccessToken);

            using var content = new StringContent(
                JsonConvert.SerializeObject(payload),
                Encoding.UTF8,
                "application/json");

            using var response = await httpClient.PostAsync(resource, content);
            return response;
        }

        private Uri buildBaseAddress()
        {
            var url = "";

            if (_settings.AsaasEnvironment.IsProduction())
            {
                url = "https://www.asaas.com/api/v3";
            }
            else if (_settings.AsaasEnvironment.IsSandbox())
            {
                url = "https://sandbox.asaas.com/v3";
            }

            return new Uri(url);
        }
    }
}
