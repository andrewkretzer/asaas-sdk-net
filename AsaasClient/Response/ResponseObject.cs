using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using Newtonsoft.Json;

namespace AsaasClient.Response
{
    public class ResponseObject<T>
    {
        #region Public Properties
        public HttpStatusCode StatusCode { get; private set; }

        public List<Error> Errors { get; private set; } = new List<Error>();

        public T Data { get; private set; }
        #endregion

        public ResponseObject(HttpResponseMessage httpResponseMessage)
        {
            StatusCode = httpResponseMessage.StatusCode;
            BuildErrors(httpResponseMessage);
            BuildData(httpResponseMessage);
        }

        private void BuildErrors(HttpResponseMessage httpResponseMessage)
        {
            if (httpResponseMessage.StatusCode != HttpStatusCode.BadRequest) return;

            var content = httpResponseMessage.Content.ReadAsStringAsync().Result;
            Errors = JsonConvert.DeserializeObject<List<Error>>(content);
        }

        private void BuildData(HttpResponseMessage httpResponseMessage)
        {
            if (httpResponseMessage.StatusCode != HttpStatusCode.OK) return;

            var content = httpResponseMessage.Content.ReadAsStringAsync().Result;
            Data = JsonConvert.DeserializeObject<T>(content);
        }
    }
}
