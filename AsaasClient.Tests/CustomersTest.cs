using System;
using System.Threading.Tasks;
using AsaasClient.Models.Customer;
using Bogus;
using Bogus.Extensions.Brazil;
using Xunit;

namespace AsaasClient.Tests
{
    public class CustomersTest : BaseTest
    {
        [Fact]
        public async Task Test()
        {
            var saveResponse = await AsaasClient.Customer.Create(new CreateCustomerRequest
            {
                Name = Faker.Name.FullName(),
                Email = Faker.Person.Email,
                Phone = Faker.Person.Phone,
                MobilePhone = Faker.Person.Phone,
                CpfCnpj = Faker.Random.Bool() ? Faker.Person.Cpf() : Faker.Company.Cnpj(),
                PostalCode = Faker.Address.ZipCode(),
                Address = Faker.Address.StreetAddress(),
                AddressNumber = Faker.Address.BuildingNumber(),
                Complement = Faker.Lorem.Sentence(),
                Province = Faker.Address.City(),
                ExternalReference = Faker.Random.Hash(),
                NotificationDisabled = Faker.Random.Bool(),
                AdditionalEmails = Faker.Person.Email,
                MunicipalInscription = Faker.Random.Hash(5),
                StateInscription = Faker.Random.Hash(5),
                Observations = Faker.Lorem.Sentence(),
                GroupName = Faker.Commerce.Department(),
            });

            EnsureSuccessResponse(saveResponse);

            var findResponse = await AsaasClient.Customer.Find(saveResponse.Data.Id);
            EnsureSuccessResponse(findResponse);

            var listResponse = await AsaasClient.Customer.List(0, 15);
            EnsureSuccessResponse(listResponse);

            var updateResponse = await AsaasClient.Customer.Update(saveResponse.Data.Id, new UpdateCustomerRequest
            {
                Name = Faker.Name.FullName(),
                Email = Faker.Person.Email,
                Phone = Faker.Person.Phone,
                MobilePhone = Faker.Person.Phone,
                CpfCnpj = Faker.Random.Bool() ? Faker.Person.Cpf() : Faker.Company.Cnpj(),
                PostalCode = Faker.Address.ZipCode(),
                Address = Faker.Address.StreetAddress(),
                AddressNumber = Faker.Address.BuildingNumber(),
                Complement = Faker.Lorem.Sentence(),
                Province = Faker.Address.City(),
                ExternalReference = Faker.Random.Hash(),
                NotificationDisabled = Faker.Random.Bool(),
                AdditionalEmails = Faker.Person.Email,
                MunicipalInscription = Faker.Random.Hash(5),
                StateInscription = Faker.Random.Hash(5),
                Observations = Faker.Lorem.Sentence()
            });
            EnsureSuccessResponse(updateResponse);

            var deleteResponse = await AsaasClient.Customer.Delete(saveResponse.Data.Id);
            EnsureSuccessResponse(deleteResponse);

            var restoreResponse = await AsaasClient.Customer.Restore(saveResponse.Data.Id);
            EnsureSuccessResponse(restoreResponse);
        }
    }
}