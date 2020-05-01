using AsaasClient.Core.Response;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Mime;
using System.Text;
using System.Threading.Tasks;

namespace AsaasClient.Core
{
    public class BaseManager
    {
        private const string PRODUCTION_URL = "https://www.asaas.com";
        private const string SANDBOX_URL = "https://sandbox.asaas.com";

        private readonly ApiSettings _settings;
        private readonly int _apiVersion;

        protected BaseManager(ApiSettings settings, int apiVersion)
        {
            _settings = settings;
            _apiVersion = apiVersion;
        }

        protected async Task<ResponseObject<T>> PostAsync<T>(string resource, RequestParameters parameters, List<string> filePaths)
        {
            using var httpClient = BuildHttpClient();
            httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/x-www-form-urlencoded"));

            using var multipartContent = new MultipartFormDataContent();

            parameters.Keys.ToList().ForEach(key =>
            {
                multipartContent.Add(new StringContent(parameters[key].ToString()), key);
            });
            
            foreach (var path in filePaths)
            {
                using FileStream fileStream = new FileStream(path, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);

                using StreamContent streamContent = new StreamContent(fileStream);

                ByteArrayContent fileContent = new ByteArrayContent(await streamContent.ReadAsByteArrayAsync());
                fileContent.Headers.ContentType = MediaTypeHeaderValue.Parse("multipart/form-data");

                multipartContent.Add(fileContent, path, Path.GetFileName(path));
            }

            var response = await httpClient.PostAsync(BuildApiRoute(resource), multipartContent);

            return await BuildResponseObject<T>(response);
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

        protected async Task<ResponseObject<T>> GetAsync<T>(string resource, string id = null)
        {
            using var httpClient = BuildHttpClient();

            if (!string.IsNullOrEmpty(id))
            {
                resource += $"/{id}";
            }

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

        protected async Task<ResponseObject<T>> DeleteAsync<T>(string resource, string id = null)
        {
            using var httpClient = BuildHttpClient();

            if (!string.IsNullOrEmpty(id))
            {
                resource += $"/{id}";
            }

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
                return new Uri(PRODUCTION_URL);
            }

            if (_settings.AsaasEnvironment.IsSandbox())
            {
                return new Uri(SANDBOX_URL);
            }

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
