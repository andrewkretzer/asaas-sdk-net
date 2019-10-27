using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using Newtonsoft.Json;

namespace AsaasClient.Response
{
    public class BaseResponse
    {
        public HttpStatusCode StatusCode { get; private set; }

        public List<Error> Errors { get; private set; } = new List<Error>();

        public BaseResponse(HttpResponseMessage httpResponseMessage)
        {
            StatusCode = httpResponseMessage.StatusCode;
            BuildErrors(httpResponseMessage);
        }

        private void BuildErrors(HttpResponseMessage httpResponseMessage)
        {
            if (httpResponseMessage.StatusCode != HttpStatusCode.BadRequest) return;

            var content = httpResponseMessage.Content.ReadAsStringAsync().Result;
            Errors = JsonConvert.DeserializeObject<List<Error>>(content);
        }
    }
}
