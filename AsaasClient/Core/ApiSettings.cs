using System;

namespace AsaasClient.Core
{
    public class ApiSettings
    {
        public string AccessToken { get; private set; }
        public AsaasEnvironment AsaasEnvironment { get; private set; }
        public TimeSpan TimeOut { get; private set; }

        public ApiSettings(string accessToken, AsaasEnvironment asaasEnvironment)
        {
            AccessToken = accessToken;
            AsaasEnvironment = asaasEnvironment;
            TimeOut = TimeSpan.FromSeconds(30);
        }
    }
}
