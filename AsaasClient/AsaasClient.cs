using System;
using AsaasClient.Core;
using AsaasClient.Manager;

namespace AsaasClient
{
    public class AsaasClient
    {
        public ApiSettings Settings { get; }

        #region Endpoints
        public Lazy<CustomerManager> Customer { get; }
        #endregion

        public AsaasClient(string accessToken, AsaasEnvironment asaasEnvironment)
        {
            Settings = new ApiSettings
            {
                AccessToken = accessToken,
                AsaasEnvironment = asaasEnvironment
            };

            Customer = new Lazy<CustomerManager>(() => { return new CustomerManager(Settings); }, true);
        }
    }
}
