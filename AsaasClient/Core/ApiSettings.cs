using AsaasClient.Models.Enums;
using System;

namespace AsaasClient.Core
{
    public class ApiSettings
    {
        public string AccessToken { get; internal set; }
        public AsaasEnvironment AsaasEnvironment { get; internal set; }
        public TimeSpan TimeOut { get; internal set; } = TimeSpan.FromSeconds(30);
    }
}
