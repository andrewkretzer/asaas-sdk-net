using AsaasClient.Core;
using AsaasClient.Core.Response;
using AsaasClient.Models.Common;
using AsaasClient.Models.Common.Enums;
using AsaasClient.Models.Customer;
using AsaasClient.Models.Payment;
using AsaasClient.Models.Payment.Enums;
using System;
using System.Threading.Tasks;

namespace AsaasClient.Sample
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Task.Run(async () =>
            {
                try
                {
                   await Run();
                } catch (Exception e)
                {
                    var a = 1;
                }
            });

            Console.ReadLine();
        }

        private static async Task Run()
        {
            // Conta criada para testes do SDK
            // Email: asaas_client@sdk.com
            // Senha: 12345678
            ApiSettings apiSettings = new ApiSettings("a4ac50ed5c79c52c59d5fab936e155fcad81ad1b17793ab678734b82dc3d34e5", AsaasEnvironment.SANDBOX);

            AsaasClient asaasApi = new AsaasClient(apiSettings);

            ResponseList<Customer> listResult = await asaasApi.Customer.List(0, 10);

            if (listResult.Data.Count > 1)
            {
                ResponseObject<Customer> objectResult = await asaasApi.Customer.Find(listResult.Data[0].Id);

                var a = 1;
            }
            var customerFailed = await asaasApi.Customer.Create(new CreateCustomerRequest());


            var customerSuccess = await asaasApi.Customer.Create(new CreateCustomerRequest()
            {
                Name = "Douglas pelo SDK da API",
                CpfCnpj = "054.420.520-00",
                Email = "asdjlads@asda.com"
            });


            var paymentFailed = await asaasApi.Payment.Create(new CreatePaymentRequest());

            var paymentSuccess = await asaasApi.Payment.Create(new CreatePaymentRequest()
            {
                CustomerId = customerSuccess.Data.Id,
                BillingType = BillingType.BOLETO,
                Value = 32.55M,
                DueDate = DateTime.Parse("25/12/2019")
            });

            var paymentList1 = await asaasApi.Payment.List(0, 10);

            var paymentFilter = new PaymentListFilter
            {
                CustomerId = customerSuccess.Data.Id,
                PaymentDateGE = DateTime.Now,
                Status = PaymentStatus.CONFIRMED
            };
            paymentFilter.Add("my_custom_filter", "zezinho");

            paymentFilter.Add("my_custom_filter", "zezinho 2");
            paymentFilter.Add("my_custom_filter 2", DateTime.Now);


            var asdasdasd = paymentFilter.PaymentDateGE;
            var wkeoq = paymentFilter.SubscriptionId;


            var qweqwe = paymentFilter.Status;

            var oaskdo = paymentFilter.Anticipated;

            paymentFilter.Anticipated = true;

            var alalal = paymentFilter.Anticipated;

            paymentFilter.PaymentDateGE = null;

            var paymentList = await asaasApi.Payment.List(0, 10, paymentFilter);


            var creditCardPayment = await asaasApi.Payment.Create(new CreatePaymentRequest()
            {
                CustomerId = customerSuccess.Data.Id,
                BillingType = BillingType.CREDIT_CARD,
                Value = 32.55M,
                DueDate = DateTime.Parse("25/12/2019"),
                CreditCard = new CreditCardRequest()
                {
                    Number = "5555555555555555",
                    HolderName = "Andre W",
                    Ccv = "123",
                    ExpiryMonth = "12",
                    ExpiryYear = "22"
                },
                CreditCardHolderInfo = new CreditCardHolderInfoRequest()
                {
                    Name = "Adrew",
                    Email = "andre.w@asaas.com.br",
                    CpfCnpj = "095.507.700-10",
                    AddressNumber = "123",
                    AddressComplement = "Mansão",
                    MobilePhone = "4799999999",
                    Phone = "4799999999",
                    PostalCode = "89233005"
                }
            });

            Console.ReadLine();

        }
    }
}
