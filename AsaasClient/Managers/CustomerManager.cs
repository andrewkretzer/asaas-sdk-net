using AsaasClient.Core;
using AsaasClient.Core.Response;
using AsaasClient.Models.Customer;
using System;
using System.Threading.Tasks;

namespace AsaasClient.Managers
{
    public class CustomerManager : BaseManager
    {
        private const string CustomersRoute = "/customers";

        public CustomerManager(ApiSettings settings) : base(settings) { }

        public async Task<ResponseObject<Customer>> Create(CreateCustomerRequest requestObj)
        {
            return await PostAsync<Customer>(CustomersRoute, requestObj);
        }

        public async Task<ResponseObject<Customer>> Find(string customerId)
        {
            var route = $"{CustomersRoute}/{customerId}";

            return await GetAsync<Customer>(route);
        }

        public async Task<ResponseList<Customer>> List(int offset, int limit, CustomerListFilter filter = null)
        {
            var queryMap = new RequestParameters();
            if (filter != null) queryMap.AddRange(filter);

            return await GetListAsync<Customer>(CustomersRoute, offset, limit, queryMap);
        }

        public async Task<ResponseObject<Customer>> Update(string customerId, UpdateCustomerRequest requestObj)
        {
            var route = $"{CustomersRoute}/{customerId}";

            return await PostAsync<Customer>(route, requestObj);
        }

        public async Task<ResponseObject<DeletedCustomer>> Delete(string customerId)
        {
            return await DeleteAsync<DeletedCustomer>(CustomersRoute, customerId);
        }

        public async Task<ResponseObject<Customer>> Restore(string customerId)
        {
            var route = $"{CustomersRoute}/{customerId}/restore";

            return await PostAsync<Customer>(route, new RequestParameters());
        }
    }
}