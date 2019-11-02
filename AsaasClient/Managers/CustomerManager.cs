using AsaasClient.Core;
using AsaasClient.Core.Extension;
using AsaasClient.Core.Response;
using AsaasClient.Models.Customer;
using System;
using System.Threading.Tasks;

namespace AsaasClient.Managers
{
    public class CustomerManager : BaseManager
    {
        private const string CUSTOMERS_URL = "/customers";

        public CustomerManager(ApiSettings settings) : base(settings) { }

        public async Task<ResponseObject<CreatedCustomer>> Create(CreateCustomerRequest requestObj)
        {
            var responseObject = await PostAsync<CreatedCustomer>(CUSTOMERS_URL, requestObj);

            return responseObject;
        }

        public async Task<ResponseObject<RetrievedCustomer>> Find(string customerId)
        {
            if (string.IsNullOrWhiteSpace(customerId)) throw new ArgumentException("customerId is required");

            var responseObject = await GetAsync<RetrievedCustomer>(CUSTOMERS_URL, customerId);

            return responseObject;
        }

        public async Task<ResponseList<RetrievedCustomer>> List(int offset, int limit, CustomerListFilter filter = null)
        {
            var queryMap = new Map();

            if (filter != null)
            {
                if (!string.IsNullOrEmpty(filter.Name)) queryMap.Add("name", filter.Name);
                if (!string.IsNullOrEmpty(filter.Email)) queryMap.Add("email", filter.Email);
                if (!string.IsNullOrEmpty(filter.CpfCnpj)) queryMap.Add("cpfCnpj", filter.CpfCnpj);
                if (!string.IsNullOrEmpty(filter.ExternalReference)) queryMap.Add("externalReference", filter.ExternalReference);
            }

            var responseList = await GetListAsync<RetrievedCustomer>(CUSTOMERS_URL, offset, limit, queryMap);

            return responseList;
        }

        public async Task<ResponseObject<UpdatedCustomer>> Update(string customerId, UpdateCustomerRequest requestObj)
        {
            if (string.IsNullOrWhiteSpace(customerId)) throw new ArgumentException("customerId is required");

            var url = $"{CUSTOMERS_URL}/{customerId}";
            var responseObject = await PostAsync<UpdatedCustomer>(url, requestObj);

            return responseObject;
        }

        public async Task<ResponseObject<DeletedCustomer>> Delete(string customerId)
        {
            if (string.IsNullOrWhiteSpace(customerId)) throw new ArgumentException("customerId is required");

            var responseObject = await DeleteAsync<DeletedCustomer>(CUSTOMERS_URL, customerId);

            return responseObject;
        }

        public async Task<ResponseObject<RestoredCustomer>> Restore(string customerId)
        {
            if (string.IsNullOrWhiteSpace(customerId)) throw new ArgumentException("customerId is required");

            var url = $"{CUSTOMERS_URL}/{customerId}/restore";
            var responseObject = await PostAsync<RestoredCustomer>(url, new object());

            return responseObject;
        }
    }
}
