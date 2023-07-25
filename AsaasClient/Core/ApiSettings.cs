using System;

namespace AsaasClient.Core
{
    public class ApiSettings
    {
        public string AccessToken { get; set; }
        public string BaseUrl { get; set; }
        public TimeSpan TimeOut { get; set; }

        public ApiSettings() { }
        public ApiSettings(string accessToken, AsaasEnvironment asaasEnvironment)
        {
            AccessToken = accessToken;
            BaseUrl = asaasEnvironment == AsaasEnvironment.PRODUCTION ? "https://www.asaas.com" : "https://sandbox.asaas.com";

            TimeOut = TimeSpan.FromSeconds(30);
        }
        public ApiSettings(string accessToken, string baseUrl)
        {
            AccessToken = accessToken;
            BaseUrl = baseUrl;
            TimeOut = TimeSpan.FromSeconds(30);
        }
    }
}
