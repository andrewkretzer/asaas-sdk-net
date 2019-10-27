using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using AsaasClient.Models.Enums;
using Newtonsoft.Json;

namespace AsaasClient.Core
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
            using var httpClient = new HttpClient();
            AddAccessTokenRequestHeader(httpClient);

            using var content = new StringContent(
                JsonConvert.SerializeObject(payload),
                Encoding.UTF8,
                "application/json");

            var url = BuildResourceUrl(resource);
            var response = await httpClient.PostAsync(url, content);

            return response;
        }

        protected async Task<HttpResponseMessage> GetAsync(string resource, Map queryMap = null)
        {
            using var httpClient = new HttpClient();
            AddAccessTokenRequestHeader(httpClient);

            var url = BuildResourceUrl(resource, queryMap);
            var response = await httpClient.GetAsync(url);

            return response;
        }

        protected async Task<HttpResponseMessage> DeleteAsync(string resource, Map queryMap = null)
        {
            using var httpClient = new HttpClient();
            AddAccessTokenRequestHeader(httpClient);

            var url = BuildResourceUrl(resource, queryMap);
            var response = await httpClient.GetAsync(url);

            return response;
        }

        private void AddAccessTokenRequestHeader(HttpClient httpClient)
        {
            httpClient.DefaultRequestHeaders.TryAddWithoutValidation("access_token", _settings.AccessToken);
        }

        private string BuildResourceUrl(string resource, Map queryParams = null)
        {
            var url = BuildBaseAddress();
            url += resource;

            if (queryParams != null)
            {
                for (int i = 0; i < queryParams.Count; i++)
                {

                    if (i == 0)
                    {
                        url += $"?{queryParams.Get(i).Key}={Uri.EscapeDataString(queryParams.Get(i).Value.ToString())}";
                    }
                    else
                    {
                        url += $"&{queryParams.Get(i).Key}={Uri.EscapeDataString(queryParams.Get(i).Value.ToString())}";
                    }
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
