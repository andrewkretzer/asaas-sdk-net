using AsaasClient.Core.Interfaces;
using AsaasClient.Core.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Mime;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace AsaasClient.Core
{
    public class BaseManager
    {
        private readonly ApiSettings _settings;
        private static readonly HttpClient HttpClient = new();

        protected BaseManager(ApiSettings settings)
        {
            _settings = settings;
        }

        protected async Task<ResponseObject<T>> PostMultipartFormDataContentAsync<T>(string resource, object payload)
        {
            ConfigureHttpClient();
            HttpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/x-www-form-urlencoded"));

            using var multipartContent = new MultipartFormDataContent();

            PropertyInfo[] properties = payload.GetType().GetProperties();
            foreach (PropertyInfo prop in properties)
            {
                string jsonPropertyName = prop.GetCustomAttribute<JsonPropertyNameAttribute>()?.Name;
                if (string.IsNullOrEmpty(jsonPropertyName)) jsonPropertyName = char.ToLowerInvariant(prop.Name[0]) + prop.Name[1..];

                if (prop.PropertyType.IsAssignableFrom(typeof(List<IAsaasFile>)))
                {
                    List<IAsaasFile> asaasFiles = prop.GetValue(payload) as List<IAsaasFile>;
                    foreach (IAsaasFile asaasFile in asaasFiles)
                    {
                        multipartContent.Add(BuildByteArrayContent(asaasFile), jsonPropertyName, asaasFile.FileName);
                    }
                    continue;
                }

                if (prop.PropertyType == typeof(IAsaasFile))
                {
                    IAsaasFile asaasFile = prop.GetValue(payload) as IAsaasFile;
                    multipartContent.Add(BuildByteArrayContent(asaasFile), jsonPropertyName, asaasFile.FileName);
                    continue;
                }

                multipartContent.Add(new StringContent(prop.GetValue(payload).ToString()), jsonPropertyName);
            }

            var response = await HttpClient.PostAsync(BuildApiRoute(resource), multipartContent);

            return await BuildResponseObject<T>(response);
        }

        protected async Task<ResponseObject<T>> PostAsync<T>(string resource, RequestParameters parameters)
        {
            var jsonObject = new JsonObject();

            parameters.Keys.ToList().ForEach(key =>
            {
                jsonObject.Add(key, JsonValue.Create(parameters[key]));
            });

            return await PostAsync<T>(resource, jsonObject);
        }

        protected async Task<ResponseObject<T>> PostAsync<T>(string resource, object payload)
        {
            ConfigureHttpClient();

            using var content = new StringContent(
                JsonSerializer.Serialize(payload, new JsonSerializerOptions { PropertyNamingPolicy = JsonNamingPolicy.CamelCase, IgnoreNullValues = true }),
                Encoding.UTF8,
                MediaTypeNames.Application.Json);

            var response = await HttpClient.PostAsync(BuildApiRoute(resource), content);

            return await BuildResponseObject<T>(response);
        }

        protected async Task<ResponseObject<T>> GetAsync<T>(string resource, string id = null)
        {
            ConfigureHttpClient();

            if (!string.IsNullOrEmpty(id))
            {
                resource += $"/{id}";
            }

            var response = await HttpClient.GetAsync(BuildApiRoute(resource));

            return await BuildResponseObject<T>(response);
        }

        protected async Task<ResponseList<T>> GetListAsync<T>(string resource, int offset, int limit, RequestParameters parameters = null)
        {
            ConfigureHttpClient();

            parameters ??= new RequestParameters();
            parameters.Add("offset", offset);
            parameters.Add("limit", limit);

            resource += parameters.Build();
            var response = await HttpClient.GetAsync(BuildApiRoute(resource));

            return await BuildResponseList<T>(response);
        }

        protected async Task<ResponseObject<T>> DeleteAsync<T>(string resource, string id = null)
        {
            ConfigureHttpClient();

            if (!string.IsNullOrEmpty(id))
            {
                resource += $"/{id}";
            }

            var response = await HttpClient.DeleteAsync(BuildApiRoute(resource));

            return await BuildResponseObject<T>(response);
        }

        private void ConfigureHttpClient()
        {
            HttpClient.DefaultRequestHeaders.Clear();
            HttpClient.DefaultRequestHeaders.TryAddWithoutValidation("access_token", _settings.AccessToken);
            HttpClient.BaseAddress = new Uri(_settings.BaseUrl);
            HttpClient.Timeout = _settings.TimeOut;

        }

        private string BuildApiRoute(string resource)
        {
            return $"/api/v3/{resource}";
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

        private ByteArrayContent BuildByteArrayContent(IAsaasFile asaasFile)
        {
            ByteArrayContent fileContent = new ByteArrayContent(asaasFile.FileContent);
            fileContent.Headers.ContentType = MediaTypeHeaderValue.Parse("multipart/form-data");

            return fileContent;
        }
    }

}
