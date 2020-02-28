using AsaasClient.Core;
using AsaasClient.V3.Managers;
using System;

namespace AsaasClient.V3
{
    public class AsaasApi
    {
        #region Lazy
        private Lazy<CustomerManager> LazyCustomer { get; }
        private Lazy<PaymentManager> LazyPayment { get; }
        private Lazy<InstallmentManager> LazyInstallment { get; }
        private Lazy<SubscriptionManager> LazySubscription { get; }
        private Lazy<FinanceManager> LazyFinance { get; }
        #endregion

        #region Managers
        public CustomerManager Customer => LazyCustomer.Value;
        public PaymentManager Payment => LazyPayment.Value;
        public InstallmentManager Installment => LazyInstallment.Value;
        public SubscriptionManager Subscription => LazySubscription.Value;
        public FinanceManager Finance => LazyFinance.Value;
        #endregion

        public AsaasApi(ApiSettings apiSettings)
        {
            LazyCustomer = new Lazy<CustomerManager>(() => new CustomerManager(apiSettings), true);
            LazyPayment = new Lazy<PaymentManager>(() => new PaymentManager(apiSettings), true);
            LazyInstallment = new Lazy<InstallmentManager>(() => new InstallmentManager(apiSettings), true);
            LazySubscription = new Lazy<SubscriptionManager>(() => new SubscriptionManager(apiSettings), true);
            LazyFinance = new Lazy<FinanceManager>(() => new FinanceManager(apiSettings), true);
        }
    }
}
