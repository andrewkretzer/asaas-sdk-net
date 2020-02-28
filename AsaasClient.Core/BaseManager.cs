using AsaasClient.Core.Response;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Linq;
using System.Net.Http;
using System.Net.Mime;
using System.Text;
using System.Threading.Tasks;

namespace AsaasClient.Core
{
    public class BaseManager
    {
        private readonly ApiSettings _settings;
        private readonly int _apiVersion;

        protected BaseManager(ApiSettings settings, int apiVersion)
        {
            _settings = settings;
            _apiVersion = apiVersion;
        }

        protected async Task<ResponseObject<T>> PostAsync<T>(string resource, RequestParameters parameters)
        {
            JObject jObject = new JObject();

            parameters.Keys.ToList().ForEach(key =>
            {
                jObject.Add(key, parameters[key]);
            });

            return await PostAsync<T>(resource, jObject);
        }

        protected async Task<ResponseObject<T>> PostAsync<T>(string resource, object payload)
        {
            using var httpClient = BuildHttpClient();

            using var content = new StringContent(
                JsonConvert.SerializeObject(payload),
                Encoding.UTF8,
                MediaTypeNames.Application.Json);

            var response = await httpClient.PostAsync(BuildApiRoute(resource), content);

            return await BuildResponseObject<T>(response);
        }

        protected async Task<ResponseObject<T>> GetAsync<T>(string resource)
        {
            using var httpClient = BuildHttpClient();

            var response = await httpClient.GetAsync(BuildApiRoute(resource));

            return await BuildResponseObject<T>(response);
        }

        protected async Task<ResponseList<T>> GetListAsync<T>(string resource, int offset, int limit, RequestParameters parameters = null)
        {
            using var httpClient = BuildHttpClient();

            if (parameters == null) parameters = new RequestParameters();
            parameters.Add("offset", offset);
            parameters.Add("limit", limit);

            resource += parameters.Build();
            var response = await httpClient.GetAsync(BuildApiRoute(resource));

            return await BuildResponseList<T>(response);
        }

        protected async Task<ResponseObject<T>> DeleteAsync<T>(string resource, string id, bool buildResourceUrl = true)
        {
            using var httpClient = BuildHttpClient();

            if (buildResourceUrl) resource += $"/{id}";

            var response = await httpClient.GetAsync(BuildApiRoute(resource));

            return await BuildResponseObject<T>(response);
        }

        private HttpClient BuildHttpClient()
        {
            HttpClient httpClient = new HttpClient();
            httpClient.DefaultRequestHeaders.TryAddWithoutValidation("access_token", _settings.AccessToken);
            httpClient.BaseAddress = BuildBaseAddress();
            httpClient.Timeout = _settings.TimeOut;

            return httpClient;
        }

        private string BuildApiRoute(string resource)
        {
            return $"/api/v{_apiVersion}/{resource}";
        }

        private Uri BuildBaseAddress()
        {
            if (_settings.AsaasEnvironment.IsProduction())
            {
                return new Uri("https://www.asaas.com");
            }

            if (_settings.AsaasEnvironment.IsSandbox())
            {
                return new Uri("https://sandbox.asaas.com");
            }

            // Create custom exception ? AsaasEnvironmentNotSupportedException ?
            throw new InvalidOperationException("AsaasEnvironment not supported");
        }

        private async Task<ResponseObject<T>> BuildResponseObject<T>(HttpResponseMessage httpResponseMessage)
        {
            string payload = await httpResponseMessage.Content.ReadAsStringAsync();

            return new ResponseObject<T>(httpResponseMessage.StatusCode, payload);
        }

        private async Task<ResponseList<T>> BuildResponseList<T>(HttpResponseMessage httpResponseMessage)
        {
            string payload = await httpResponseMessage.Content.ReadAsStringAsync();

            return new ResponseList<T>(httpResponseMessage.StatusCode, payload);
        }
    }
}
