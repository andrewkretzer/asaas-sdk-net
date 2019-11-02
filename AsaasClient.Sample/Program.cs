using AsaasClient.Core;
using AsaasClient.Core.Response;
using AsaasClient.Models.Customer;
using System;
using System.Threading.Tasks;

namespace AsaasClient.Sample
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            ApiSettings apiSettings = new ApiSettings("11df0f3f37dd8e1a745ed5b0f4bcdc119ad557c2948d258c469a1df18f161ef1", AsaasEnvironment.SANDBOX);

            AsaasClient asaasClient = new AsaasClient(apiSettings);

            Task.Run(async () =>
            {
                ResponseList<RetrievedCustomer> listResult = await asaasClient.Customer.List(0, 10);

                ResponseObject<RetrievedCustomer> objectResult = await asaasClient.Customer.Find(listResult.Data[0].Id);

                var teste = await asaasClient.Customer.Create(new CreateCustomerRequest());

                Console.ReadLine();
            });

            Console.ReadLine();
        }
    }
}
