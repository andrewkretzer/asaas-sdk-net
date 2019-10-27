using System.Net;
using System.Net.Http;
using Newtonsoft.Json;

namespace AsaasClient.Response
{
    public class ResponseObject<T> : BaseResponse
    {
        public T Data { get; private set; }

        public ResponseObject(HttpResponseMessage httpResponseMessage) : base(httpResponseMessage)
        {
            BuildData(httpResponseMessage);
        }

        private void BuildData(HttpResponseMessage httpResponseMessage)
        {
            if (httpResponseMessage.StatusCode != HttpStatusCode.OK) return;

            var content = httpResponseMessage.Content.ReadAsStringAsync().Result;
            Data = JsonConvert.DeserializeObject<T>(content);
        }
    }
}
