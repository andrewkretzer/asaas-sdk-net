using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net;

namespace AsaasClient.Response
{
    public class BaseResponse
    {
        public HttpStatusCode StatusCode { get; private set; }

        public List<Error> Errors { get; private set; } = new List<Error>();

        public BaseResponse(HttpStatusCode httpStatusCode, string content)
        {
            StatusCode = httpStatusCode;
            BuildErrors(content);
        }

        private void BuildErrors(string content)
        {
            if (StatusCode != HttpStatusCode.BadRequest) return;

            Errors = JsonConvert.DeserializeObject<List<Error>>(content);
        }
    }
}
