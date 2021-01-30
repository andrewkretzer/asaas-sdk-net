using AsaasClient.Core.Response;
using AsaasClient.Models.AsaasAccount;
using System;
using System.Threading.Tasks;
using Xunit;

namespace AsaasClient.Test
{
    public class AsaasAccountTest : BaseTest
    {
        [Fact]
        public async Task Test()
        {
            await TestCreate();
            await TestList();
        }

        private async Task<Account> TestCreate()
        {
            int randomSeed = new Random().Next(00000000, 99999999);
            CreateAccountRequest createAccountRequest = new CreateAccountRequest
            {
                Name = "Kelson Lanches",
                Email = $"lanches{randomSeed}@join.com",
                CpfCnpj = "86239744000189",
                Phone = "47999999998",
                MobilePhone = $"479{randomSeed}",
                PostalCode = "89223005",
                Province = "RS",
                Address = "Test Street",
                AddressNumber = "123",
                CompanyType = Models.Common.Enums.CompanyType.LIMITED,
                Complement = "Shop",
                LoginEmail = $"login_{randomSeed}@email.com"
            };

            ResponseObject<Account> createResponse = await AsaasClient.AsaasAccount.Create(createAccountRequest);
            ValidateResponseStatus(createResponse);

            Assert.Equal(createAccountRequest.Name, createResponse.Data.Name);
            Assert.Equal(createAccountRequest.Email, createResponse.Data.Email);
            Assert.Equal(createAccountRequest.CpfCnpj, createResponse.Data.CpfCnpj);
            Assert.Equal(createAccountRequest.Phone, createResponse.Data.Phone);
            Assert.Equal(createAccountRequest.MobilePhone, createResponse.Data.MobilePhone);
            Assert.Equal(createAccountRequest.PostalCode, createResponse.Data.PostalCode);
            Assert.Equal(createAccountRequest.Province, createResponse.Data.Province);
            Assert.Equal(createAccountRequest.Address, createResponse.Data.Address);
            Assert.Equal(createAccountRequest.AddressNumber, createResponse.Data.AddressNumber);
            Assert.Equal(createAccountRequest.CompanyType, createResponse.Data.CompanyType);
            Assert.Equal(createAccountRequest.Complement, createResponse.Data.Complement);
            Assert.Equal(createAccountRequest.LoginEmail, createResponse.Data.LoginEmail);
            Assert.NotNull(createResponse.Data.WalletId);
            Assert.NotNull(createResponse.Data.ApiKey);

            return createResponse.Data;
        }

        private async Task TestList()
        {
            ResponseList<Account> responseList = await AsaasClient.AsaasAccount.List(0, 15);
            ValidateResponseStatus(responseList);
            Assert.NotEmpty(responseList.Data);

            Assert.NotNull(responseList.Data[0].Name);
            Assert.NotNull(responseList.Data[0].Email);
            Assert.NotNull(responseList.Data[0].CpfCnpj);
            Assert.NotNull(responseList.Data[0].Phone);
            Assert.NotNull(responseList.Data[0].MobilePhone);
            Assert.NotNull(responseList.Data[0].PostalCode);
            Assert.NotNull(responseList.Data[0].Province);
            Assert.NotNull(responseList.Data[0].Address);
            Assert.NotNull(responseList.Data[0].AddressNumber);
            Assert.NotNull(responseList.Data[0].CompanyType);
            Assert.NotNull(responseList.Data[0].Complement);
            Assert.NotNull(responseList.Data[0].LoginEmail);
            Assert.NotNull(responseList.Data[0].WalletId);
            Assert.Null(responseList.Data[0].ApiKey);

        }
    }
}
