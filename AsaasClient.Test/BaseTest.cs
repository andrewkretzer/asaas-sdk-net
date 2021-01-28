using AsaasClient.Core;
using AsaasClient.Core.Response.Base;
using System.Net;
using Xunit;

namespace AsaasClient.Test {
    public abstract class BaseTest {

        protected AsaasClient AsaasClient;

        public BaseTest() {
            ApiSettings apiSettings = new ApiSettings("a4ac50ed5c79c52c59d5fab936e155fcad81ad1b17793ab678734b82dc3d34e5", AsaasEnvironment.SANDBOX);

            AsaasClient = new AsaasClient(apiSettings);
        }

        protected void ValidateResponseStatus(BaseResponse baseResponse) {
            Assert.Equal(HttpStatusCode.OK, baseResponse.StatusCode);
        }
    }
}
