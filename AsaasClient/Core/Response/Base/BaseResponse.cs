using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using System.Net;

namespace AsaasClient.Core.Response.Base
{
    public abstract class BaseResponse
    {
        public HttpStatusCode StatusCode { get; }

        public List<Error> Errors { get; private set; } = new();

        public string AsaasResponse { get; }

        protected BaseResponse(HttpStatusCode httpStatusCode, string content)
        {
            StatusCode = httpStatusCode;
            AsaasResponse = content;
            BuildErrors();
        }

        private void BuildErrors()
        {
            if (StatusCode != HttpStatusCode.BadRequest) return;

            JObject jObject = JObject.Parse(AsaasResponse);

            Errors = JsonConvert.DeserializeObject<List<Error>>(jObject.GetValue("errors").ToString());
        }
    }
}
