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

        public async Task<ResponseObject<CreatedCustomer>> Create(CreateCustomerRequest requestObj)
        {
            var httpResponseMessage = await PostAsync(CUSTOMERS_URL, requestObj);

            var responseObject = new ResponseObject<CreatedCustomer>(httpResponseMessage);
            return responseObject;
        }

        public async Task<ResponseObject<RetrievedCustomer>> GetById(string customerId)
        {
            if (string.IsNullOrWhiteSpace(customerId)) throw new ArgumentException("customerId cannot be null");

            var queryMap = new Map();
            queryMap.Add("id", customerId);

            using var httpResponseMessage = await GetAsync(CUSTOMERS_URL, queryMap);

            var responseObject = new ResponseObject<RetrievedCustomer>(httpResponseMessage);
            return responseObject;
        }

        public async Task<ResponseObject<DeletedCustomer>> Delete(string customerId)
        {
            if (string.IsNullOrWhiteSpace(customerId)) throw new ArgumentException("customerId cannot be null");

            var queryMap = new Map();
            queryMap.Add("id", customerId);

            using var httpResponseMessage = await DeleteAsync(CUSTOMERS_URL, queryMap);

            var responseObject = new ResponseObject<DeletedCustomer>(httpResponseMessage);
            return responseObject;
        }
    }
}
