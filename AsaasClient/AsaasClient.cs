using System;
using AsaasClient.Core;
using AsaasClient.Manager;
using AsaasClient.Models.Enums;

namespace AsaasClient
{
    public class AsaasClient
    {
        #region Endpoints
        public Lazy<CustomerManager> Customer { get; }
        #endregion

        public AsaasClient(string accessToken, AsaasEnvironment asaasEnvironment)
        {
            var settings = new ApiSettings
            {
                AccessToken = accessToken,
                AsaasEnvironment = asaasEnvironment
            };

            Customer = new Lazy<CustomerManager>(() => { return new CustomerManager(settings); }, true);
        }
    }
}
