using AsaasClient.Core;
using AsaasClient.Managers;
using System;

namespace AsaasClient
{
    public class AsaasClient
    {
        #region Endpoints
        private Lazy<CustomerManager> LazyCustomer { get; }
        public CustomerManager Customer => LazyCustomer.Value;

        private Lazy<PaymentManager> LazyPayment { get; }
        public PaymentManager Payment => LazyPayment.Value;
        #endregion

        public AsaasClient(ApiSettings apiSettings)
        {
            LazyCustomer = new Lazy<CustomerManager>(() => new CustomerManager(apiSettings), true);
            LazyPayment = new Lazy<PaymentManager>(() => new PaymentManager(apiSettings), true);
        }
    }
}
