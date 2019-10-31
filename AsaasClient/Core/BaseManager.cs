using AsaasClient.Models.Enums;
using Newtonsoft.Json;
using System;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace AsaasClient.Core
{
    public class BaseManager
    {
        private readonly ApiSettings _settings;

        protected BaseManager(ApiSettings settings)
        {
            _settings = settings;
        }

        protected async Task<HttpResponseMessage> PostAsync(string resource, object payload = null)
        {
            using var httpClient = BuildHttpClient();

            using var content = new StringContent(
                payload != null ? JsonConvert.SerializeObject(payload) : "",
                Encoding.Default,
                "application/json");

            var url = BuildResourceUrl(resource);
            var response = await httpClient.PostAsync(url, content);

            return response;
        }

        protected async Task<HttpResponseMessage> GetAsync(string resource, Map queryMap = null)
        {
            using var httpClient = BuildHttpClient();

            var url = BuildResourceUrl(resource, queryMap);
            var response = await httpClient.GetAsync(url);

            return response;
        }

        protected async Task<HttpResponseMessage> GetListAsync(string resource, int offset, int limit, Map queryMap = null)
        {
            using var httpClient = BuildHttpClient();

            if (queryMap == null) queryMap = new Map();
            queryMap.Add("offset", offset);
            queryMap.Add("limit", limit);

            var url = BuildResourceUrl(resource, queryMap);
            var response = await httpClient.GetAsync(url);

            return response;
        }

        protected async Task<HttpResponseMessage> DeleteAsync(string resource, Map queryMap = null)
        {
            using var httpClient = BuildHttpClient();

            var url = BuildResourceUrl(resource, queryMap);
            var response = await httpClient.GetAsync(url);

            return response;
        }

        private HttpClient BuildHttpClient()
        {
            HttpClient httpClient = new HttpClient();
            httpClient.DefaultRequestHeaders.TryAddWithoutValidation("access_token", _settings.AccessToken);

            return httpClient;
        }

        private string BuildResourceUrl(string resource, Map queryMap = null)
        {
            var url = BuildBaseAddress();
            url += resource;

            if (queryMap == null || queryMap.Count == 0)
            {
                return url;
            }

            url += "?";

            foreach (var key in queryMap.Keys)
            {
                url += $"{key}={Uri.EscapeDataString(queryMap[key])}";

                if (key != queryMap.Keys.Last())
                {
                    url += "&";
                }
            }

            return url;
        }

        private string BuildBaseAddress()
        {
            if (_settings.AsaasEnvironment.IsProduction())
            {
                return "https://www.asaas.com/api/v3";
            }

            if (_settings.AsaasEnvironment.IsSandbox())
            {
                return "https://sandbox.asaas.com/v3";
            }

            // Create custom exception ? AsaasEnvironmentNotSupportedException ?
            throw new InvalidOperationException("AsaasEnvironment not supported");
        }
    }
}
