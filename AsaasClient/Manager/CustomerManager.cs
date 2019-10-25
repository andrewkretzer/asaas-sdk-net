using System;
using System.Threading.Tasks;
using AsaasClient.Core;
using AsaasClient.Models.Customer;
using AsaasClient.Response;

namespace AsaasClient.Manager
{
    public class CustomerManager : BaseManager
    {
        private const string CUSTOMERS_URL = "/customers";

        public CustomerManager(ApiSettings settings) : base(settings) { }

        public async Task<ResponseObject<CreatedCustomer>> Create(Object obj)
        {
            var httpResponseMessage = await PostAsync(CUSTOMERS_URL, obj);
            var responseObject = new ResponseObject<CreatedCustomer>(httpResponseMessage);
            return responseObject;
        }
    }
}
