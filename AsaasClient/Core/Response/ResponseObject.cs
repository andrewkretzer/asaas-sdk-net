using AsaasClient.Core.Response.Base;
using System.Net;

namespace AsaasClient.Core.Response
{
    public class ResponseObject<T> : BaseResponse
    {
        public T Data { get; }

        public ResponseObject(HttpStatusCode httpStatusCode, string content) : base(httpStatusCode, content)
        {
            if (httpStatusCode != HttpStatusCode.OK) return;

            Data = System.Text.Json.JsonSerializer.Deserialize<T>(content);
        }
    }
}
