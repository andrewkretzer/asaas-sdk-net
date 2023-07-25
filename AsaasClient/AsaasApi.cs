using AsaasClient.Core;
using AsaasClient.Managers;
using System;

namespace AsaasClient
{
    public interface IAsaasService
    {
        CustomerManager Customer { get; }
        PaymentManager Payment { get; }
        InstallmentManager Installment { get; }
        SubscriptionManager Subscription { get; }
        FinanceManager Finance { get; }
        TransferManager Transfer { get; }
        WalletManager Wallet { get; }
        WebhookManager Webhook { get; }
        AsaasAccountManager AsaasAccount { get; }
        AnticipationManager ReceivableAnticipation { get; }
        MyAccountManager MyAccount { get; }
        InvoiceManager Invoice { get; }
        PaymentDunningManager PaymentDunning { get; }
        BillPaymentManager BillPayment { get; }
    }

    public class AsaasApi : IAsaasService
    {
        #region Lazy
        private Lazy<CustomerManager> LazyCustomer { get; }
        private Lazy<PaymentManager> LazyPayment { get; }
        private Lazy<InstallmentManager> LazyInstallment { get; }
        private Lazy<SubscriptionManager> LazySubscription { get; }
        private Lazy<FinanceManager> LazyFinance { get; }
        private Lazy<TransferManager> LazyTransfer { get; }
        private Lazy<WalletManager> LazyWallet { get; }
        private Lazy<WebhookManager> LazyWebhook { get; }
        private Lazy<AsaasAccountManager> LazyAsaasAccount { get; }
        private Lazy<AnticipationManager> LazyReceivableAnticipation { get; }
        private Lazy<MyAccountManager> LazyMyAccount { get; }
        private Lazy<InvoiceManager> LazyInvoice { get; }
        private Lazy<PaymentDunningManager> LazyPaymentDunning { get; }
        private Lazy<BillPaymentManager> LazyBillPayment { get; }
        #endregion

        #region Managers
        public CustomerManager Customer => LazyCustomer.Value;
        public PaymentManager Payment => LazyPayment.Value;
        public InstallmentManager Installment => LazyInstallment.Value;
        public SubscriptionManager Subscription => LazySubscription.Value;
        public FinanceManager Finance => LazyFinance.Value;
        public TransferManager Transfer => LazyTransfer.Value;
        public WalletManager Wallet => LazyWallet.Value;
        public WebhookManager Webhook => LazyWebhook.Value;
        public AsaasAccountManager AsaasAccount => LazyAsaasAccount.Value;
        public AnticipationManager ReceivableAnticipation => LazyReceivableAnticipation.Value;
        public MyAccountManager MyAccount => LazyMyAccount.Value;
        public InvoiceManager Invoice => LazyInvoice.Value;
        public PaymentDunningManager PaymentDunning => LazyPaymentDunning.Value;
        public BillPaymentManager BillPayment => LazyBillPayment.Value;
        #endregion



        public AsaasApi(ApiSettings apiSettings)
        {
            LazyCustomer = new Lazy<CustomerManager>(() => new CustomerManager(apiSettings), true);
            LazyPayment = new Lazy<PaymentManager>(() => new PaymentManager(apiSettings), true);
            LazyInstallment = new Lazy<InstallmentManager>(() => new InstallmentManager(apiSettings), true);
            LazySubscription = new Lazy<SubscriptionManager>(() => new SubscriptionManager(apiSettings), true);
            LazyFinance = new Lazy<FinanceManager>(() => new FinanceManager(apiSettings), true);
            LazyTransfer = new Lazy<TransferManager>(() => new TransferManager(apiSettings), true);
            LazyWallet = new Lazy<WalletManager>(() => new WalletManager(apiSettings), true);
            LazyWebhook = new Lazy<WebhookManager>(() => new WebhookManager(apiSettings), true);
            LazyAsaasAccount = new Lazy<AsaasAccountManager>(() => new AsaasAccountManager(apiSettings), true);
            LazyReceivableAnticipation = new Lazy<AnticipationManager>(() => new AnticipationManager(apiSettings), true);
            LazyMyAccount = new Lazy<MyAccountManager>(() => new MyAccountManager(apiSettings), true);
            LazyInvoice = new Lazy<InvoiceManager>(() => new InvoiceManager(apiSettings), true);
            LazyPaymentDunning = new Lazy<PaymentDunningManager>(() => new PaymentDunningManager(apiSettings), true);
            LazyBillPayment = new Lazy<BillPaymentManager>(() => new BillPaymentManager(apiSettings), true);
        }
    }

}
