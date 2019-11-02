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
            var responseObject = await PostAsync<CreatedCustomer>(CUSTOMERS_URL, requestObj);

            return responseObject;
        }

        public async Task<ResponseObject<RetrievedCustomer>> FindById(string customerId)
        {
            if (string.IsNullOrWhiteSpace(customerId)) throw new ArgumentException("customerId is required");

            var responseObject = await GetAsync<RetrievedCustomer>(CUSTOMERS_URL, customerId);

            return responseObject;
        }

        public async Task<ResponseList<RetrievedCustomer>> List(int offset, int limit, CustomerListFilter filter)
        {
            var queryMap = new Map();

            if (filter != null)
            {
                if (filter.Names.IsNullOrEmpty()) queryMap.Add("name", filter.Names);
                if (filter.Emails.IsNullOrEmpty()) queryMap.Add("email", filter.Emails);
                if (filter.CpfCnpjs.IsNullOrEmpty()) queryMap.Add("cpfCnpj", filter.CpfCnpjs);
                if (filter.ExternalReferences.IsNullOrEmpty()) queryMap.Add("externalReference", filter.ExternalReferences);
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
