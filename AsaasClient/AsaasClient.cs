using AsaasClient.Core;
using AsaasClient.Managers;
using System;

namespace AsaasClient
{
    public class AsaasClient
    {
        #region Endpoints
        public Lazy<CustomerManager> Customer { get; }

        public Lazy<PaymentManager> Payment { get; }
        #endregion

        public AsaasClient(string accessToken, AsaasEnvironment asaasEnvironment)
        {
            var settings = new ApiSettings
            {
                AccessToken = accessToken,
                AsaasEnvironment = asaasEnvironment
            };

            Customer = new Lazy<CustomerManager>(() => { return new CustomerManager(settings); }, true);
            Payment = new Lazy<PaymentManager>(() => { return new PaymentManager(settings); }, true);
        }
    }
}
