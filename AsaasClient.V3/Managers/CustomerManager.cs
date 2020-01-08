using AsaasClient.Core;
using AsaasClient.Core.Response;
using AsaasClient.Models.Customer;
using AsaasClient.V3.Models.Customer;
using System;
using System.Threading.Tasks;

namespace AsaasClient.V3.Managers
{
    public class CustomerManager : BaseManager
    {
        private const string CUSTOMERS_URL = "/customers";

        public CustomerManager(ApiSettings settings) : base(settings, 3) { }

        public async Task<ResponseObject<Customer>> Create(CreateCustomerRequest requestObj)
        {
            var responseObject = await PostAsync<Customer>(CUSTOMERS_URL, requestObj);

            return responseObject;
        }

        public async Task<ResponseObject<Customer>> Find(string customerId)
        {
            if (string.IsNullOrWhiteSpace(customerId)) throw new ArgumentException("customerId is required");

            var responseObject = await GetAsync<Customer>(CUSTOMERS_URL, customerId);

            return responseObject;
        }

        public async Task<ResponseList<Customer>> List(int offset, int limit, CustomerListFilter filter = null)
        {
            var queryMap = new Map();

            if (filter != null)
            {
                queryMap.AddRange(filter);
            }

            var responseList = await GetListAsync<Customer>(CUSTOMERS_URL, offset, limit, queryMap);

            return responseList;
        }

        public async Task<ResponseObject<Customer>> Update(string customerId, UpdateCustomerRequest requestObj)
        {
            if (string.IsNullOrWhiteSpace(customerId)) throw new ArgumentException("customerId is required");

            var url = $"{CUSTOMERS_URL}/{customerId}";
            var responseObject = await PostAsync<Customer>(url, requestObj);

            return responseObject;
        }

        public async Task<ResponseObject<DeletedCustomer>> Delete(string customerId)
        {
            if (string.IsNullOrWhiteSpace(customerId)) throw new ArgumentException("customerId is required");

            var responseObject = await DeleteAsync<DeletedCustomer>(CUSTOMERS_URL, customerId);

            return responseObject;
        }

        public async Task<ResponseObject<Customer>> Restore(string customerId)
        {
            if (string.IsNullOrWhiteSpace(customerId)) throw new ArgumentException("customerId is required");

            var url = $"{CUSTOMERS_URL}/{customerId}/restore";
            var responseObject = await PostAsync<Customer>(url, new object());

            return responseObject;
        }
    }
}