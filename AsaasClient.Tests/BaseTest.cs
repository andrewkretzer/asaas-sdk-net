using System.Net;
using AsaasClient.Core;
using AsaasClient.Core.Response.Base;
using Bogus;
using Xunit;

namespace AsaasClient.Tests
{
    public abstract class BaseTest
    {
        protected readonly AsaasClient AsaasClient;
        protected readonly Faker Faker;

        public BaseTest() {
            //https://sandbox.asaas.com
            //asaassdkdemo@sdk.com
            //12345678

            ApiSettings apiSettings = new ApiSettings("45d300d6240a6211ca4273395e5e6647023c129cfb82577ee4759c61638da310", AsaasEnvironment.SANDBOX);
            AsaasClient = new AsaasClient(apiSettings);

            Faker = new Faker("pt_BR");
        }

        protected void EnsureSuccessResponse(BaseResponse baseResponse) {

            Assert.Equal(HttpStatusCode.OK, baseResponse.StatusCode);
        }

    }
}