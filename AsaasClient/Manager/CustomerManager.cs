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
            using var httpResponseMessage = await PostAsync(CUSTOMERS_URL, requestObj);

            var responseObject = new ResponseObject<CreatedCustomer>(httpResponseMessage);
            return responseObject;
        }

        public async Task<ResponseObject<RetrievedCustomer>> FindById(string customerId)
        {
            if (string.IsNullOrWhiteSpace(customerId)) throw new ArgumentException("customerId is required");

            var url = $"{CUSTOMERS_URL}/{customerId}";
            using var httpResponseMessage = await GetAsync(url);

            var responseObject = new ResponseObject<RetrievedCustomer>(httpResponseMessage);
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

            using var httpResponseMessage = await GetListAsync(CUSTOMERS_URL, offset, limit, queryMap);

            var responseList = new ResponseList<RetrievedCustomer>(httpResponseMessage);
            return responseList;
        }

        public async Task<ResponseObject<UpdatedCustomer>> Update(string customerId, UpdateCustomerRequest requestObj)
        {
            if (string.IsNullOrWhiteSpace(customerId)) throw new ArgumentException("customerId is required");

            var url = $"{CUSTOMERS_URL}/{customerId}";
            using var httpResponseMessage = await PostAsync(url, requestObj);

            var responseObject = new ResponseObject<UpdatedCustomer>(httpResponseMessage);
            return responseObject;
        }

        public async Task<ResponseObject<DeletedCustomer>> Delete(string customerId)
        {
            if (string.IsNullOrWhiteSpace(customerId)) throw new ArgumentException("customerId is required");

            var url = $"{CUSTOMERS_URL}/{customerId}";
            using var httpResponseMessage = await DeleteAsync(url);

            var responseObject = new ResponseObject<DeletedCustomer>(httpResponseMessage);
            return responseObject;
        }

        public async Task<ResponseObject<RestoredCustomer>> Restore(string customerId)
        {
            if (string.IsNullOrWhiteSpace(customerId)) throw new ArgumentException("customerId is required");

            var url = $"{CUSTOMERS_URL}/{customerId}/restore";
            using var httpResponseMessage = await PostAsync(url);

            var responseObject = new ResponseObject<RestoredCustomer>(httpResponseMessage);
            return responseObject;
        }
    }
}
