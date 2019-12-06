using AsaasClient.Core;
using AsaasClient.Core.Response;
using AsaasClient.Models.Customer;
using AsaasClient.V3;
using AsaasClient.V3.Models.Customer;
using System;
using System.Threading.Tasks;

namespace Sample
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            ApiSettings apiSettings = new ApiSettings("11df0f3f37dd8e1a745ed5b0f4bcdc119ad557c2948d258c469a1df18f161ef1", AsaasEnvironment.SANDBOX);


            AsaasApi asaasApi = new AsaasApi(apiSettings);

            Task.Run(async () =>
            {
                ResponseList<RetrievedCustomer> listResult = await asaasApi.Customer.List(0, 10);

                ResponseObject<RetrievedCustomer> objectResult = await asaasApi.Customer.Find(listResult.Data[0].Id);

                var teste = await asaasApi.Customer.Create(new CreateCustomerRequest());

                Console.ReadLine();
            });

            Console.ReadLine();
        }
    }
}
