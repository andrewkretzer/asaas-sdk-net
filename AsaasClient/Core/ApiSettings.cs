using AsaasClient.Models.Enums;

namespace AsaasClient.Core
{
    public class ApiSettings
    {
        public string AccessToken { get; internal set; }
        public AsaasEnvironment AsaasEnvironment { get; internal set; }
    }
}
