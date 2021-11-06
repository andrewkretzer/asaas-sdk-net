using System;

namespace AsaasClient.Core
{
    public class ApiSettings
    {
        public string AccessToken { get; }
        public AsaasEnvironment AsaasEnvironment { get; }
        public TimeSpan TimeOut { get; set; }

        public ApiSettings(string accessToken, AsaasEnvironment asaasEnvironment)
        {
            AccessToken = accessToken;
            AsaasEnvironment = asaasEnvironment;
            TimeOut = TimeSpan.FromSeconds(30);
        }
    }
}
