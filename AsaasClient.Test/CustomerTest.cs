using AsaasClient.Core.Response;
using AsaasClient.Models.Customer;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace AsaasClient.Test
{
    public class CustomerTest : BaseTest
    {
        [Fact]
        public async Task Test()
        {
            Customer customer = await TestCreate();

            Customer updatedCustomer = await TestUpdate(customer);
            await TestDelete(updatedCustomer);
            Customer restoredCustomer = await TestRestore(updatedCustomer);

            await TestFind(restoredCustomer);
            await TestList();
        }

        private async Task<Customer> TestCreate()
        {
            CreateCustomerRequest createCustomerRequest = new CreateCustomerRequest
            {
                Name = "Douglas Giovanella",
                CpfCnpj = "42071704053",
                Email = "email@test.com",
                Observations = "obs",
                ExternalReference = "abc",
                PostalCode = "89223005",
                Address = "Street test",
                AddressNumber = "123",
                Complement = "Building",
                Phone = "4734444444",
                MobilePhone = "47999999999",
                Province = "SC",
                StateInscription = "123",
                MunicipalInscription = "321",
                AdditionalEmails = "email2@test.com;email3@test.com",
                GroupName = "Test group",
                NotificationDisabled = false,
                ForeignCustomer = true
            };

            ResponseObject<Customer> createResponse = await AsaasClient.Customer.Create(createCustomerRequest);
            ValidateResponseStatus(createResponse);

            Assert.Equal(createCustomerRequest.Name, createResponse.Data.Name);
            Assert.Equal(createCustomerRequest.CpfCnpj, createResponse.Data.CpfCnpj);
            Assert.Equal(createCustomerRequest.Email, createResponse.Data.Email);
            Assert.Equal(createCustomerRequest.Observations, createResponse.Data.Observations);
            Assert.Equal(createCustomerRequest.ExternalReference, createResponse.Data.ExternalReference);
            Assert.Equal(createCustomerRequest.PostalCode, createResponse.Data.PostalCode);
            Assert.Equal(createCustomerRequest.Address, createResponse.Data.Address);
            Assert.Equal(createCustomerRequest.AddressNumber, createResponse.Data.AddressNumber);
            Assert.Equal(createCustomerRequest.Complement, createResponse.Data.Complement);
            Assert.Equal(createCustomerRequest.Phone, createResponse.Data.Phone);
            Assert.Equal(createCustomerRequest.MobilePhone, createResponse.Data.MobilePhone);
            Assert.Equal(createCustomerRequest.Province, createResponse.Data.Province);
            Assert.Equal(createCustomerRequest.AdditionalEmails, createResponse.Data.AdditionalEmails);
            Assert.Equal(createCustomerRequest.NotificationDisabled, createResponse.Data.NotificationDisabled);
            Assert.Equal(createCustomerRequest.ForeignCustomer, createResponse.Data.ForeignCustomer);
            Assert.Single(createResponse.Data.Groups);
            Assert.Equal(createCustomerRequest.GroupName, createResponse.Data.Groups.First().Name);

            return createResponse.Data;
        }

        private async Task<Customer> TestUpdate(Customer customer)
        {
            UpdateCustomerRequest updateCustomerRequest = new UpdateCustomerRequest(customer);

            ResponseObject<Customer> noChangesUpdateResponse = await AsaasClient.Customer.Update(customer.Id, updateCustomerRequest);
            ValidateResponseStatus(noChangesUpdateResponse);
            ValidateCustomers(customer, noChangesUpdateResponse.Data);

            updateCustomerRequest.Name = "Andre W";
            updateCustomerRequest.Email = null;

            ResponseObject<Customer> changesUpdateResponse = await AsaasClient.Customer.Update(customer.Id, updateCustomerRequest);
            ValidateResponseStatus(changesUpdateResponse);

            Assert.Equal(updateCustomerRequest.Name, changesUpdateResponse.Data.Name);
            Assert.Equal(updateCustomerRequest.Email, changesUpdateResponse.Data.Email);

            return changesUpdateResponse.Data;
        }

        private async Task TestDelete(Customer customer)
        {
            ResponseObject<DeletedCustomer> deleteResponse = await AsaasClient.Customer.Delete(customer.Id);
            ValidateResponseStatus(deleteResponse);

            Assert.Equal(deleteResponse.Data.Id, customer.Id);
            Assert.True(deleteResponse.Data.Deleted);
        }

        private async Task TestList()
        {
            ResponseList<Customer> listResponse = await AsaasClient.Customer.List(0, 15);

            Assert.NotEmpty(listResponse.Data);

            ResponseList<Customer> listFilterWithItemsResponse = await AsaasClient.Customer.List(0, 15, new CustomerListFilter
            {
                Name = "Douglas",
                Email = "email@test.com"
            });
            ValidateResponseStatus(listFilterWithItemsResponse);

            Assert.NotEmpty(listFilterWithItemsResponse.Data);

            ResponseList<Customer> listFilterWithoutItemsResponse = await AsaasClient.Customer.List(0, 2, new CustomerListFilter
            {
                Name = "Andrew",
                Email = "email@test.com"
            });
            ValidateResponseStatus(listFilterWithoutItemsResponse);

            Assert.Empty(listFilterWithoutItemsResponse.Data);
        }

        private async Task TestFind(Customer customer)
        {
            ResponseObject<Customer> findResponse = await AsaasClient.Customer.Find(customer.Id);
            ValidateResponseStatus(findResponse);

            ValidateCustomers(customer, findResponse.Data);
        }


        private async Task<Customer> TestRestore(Customer customer)
        {
            ResponseObject<Customer> restoreResponse = await AsaasClient.Customer.Restore(customer.Id);
            ValidateResponseStatus(restoreResponse);
            Assert.False(restoreResponse.Data.Deleted);

            return restoreResponse.Data;
        }

        private void ValidateCustomers(Customer expectedCustomer, Customer currentCustomer)
        {
            Assert.Equal(expectedCustomer.Id, currentCustomer.Id);
            Assert.Equal(expectedCustomer.Name, currentCustomer.Name);
            Assert.Equal(expectedCustomer.CpfCnpj, currentCustomer.CpfCnpj);
            Assert.Equal(expectedCustomer.Email, currentCustomer.Email);
            Assert.Equal(expectedCustomer.Observations, currentCustomer.Observations);
            Assert.Equal(expectedCustomer.ExternalReference, currentCustomer.ExternalReference);
            Assert.Equal(expectedCustomer.PostalCode, currentCustomer.PostalCode);
            Assert.Equal(expectedCustomer.Address, currentCustomer.Address);
            Assert.Equal(expectedCustomer.AddressNumber, currentCustomer.AddressNumber);
            Assert.Equal(expectedCustomer.Complement, currentCustomer.Complement);
            Assert.Equal(expectedCustomer.Phone, currentCustomer.Phone);
            Assert.Equal(expectedCustomer.MobilePhone, currentCustomer.MobilePhone);
            Assert.Equal(expectedCustomer.Province, currentCustomer.Province);
            Assert.Equal(expectedCustomer.AdditionalEmails, currentCustomer.AdditionalEmails);
            Assert.Equal(expectedCustomer.NotificationDisabled, currentCustomer.NotificationDisabled);
            Assert.Equal(expectedCustomer.ForeignCustomer, currentCustomer.ForeignCustomer);
            Assert.Equal(expectedCustomer.Groups.First().Name, currentCustomer.Groups.First().Name);
            Assert.Equal(expectedCustomer.PersonType, currentCustomer.PersonType);
            Assert.Equal(expectedCustomer.Deleted, currentCustomer.Deleted);
            Assert.Equal(expectedCustomer.CityId, currentCustomer.CityId);
        }
    }
}