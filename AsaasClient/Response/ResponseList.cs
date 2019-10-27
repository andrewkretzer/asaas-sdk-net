using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using Newtonsoft.Json;

namespace AsaasClient.Response
{
    public class ResponseList<T> : BaseResponse
    {
        [JsonProperty(PropertyName = "hasMore")]
        public bool HasMore { get; private set; }

        [JsonProperty(PropertyName = "totalCount")]
        public int TotalCount { get; private set; }

        [JsonProperty(PropertyName = "limit")]
        public int Limit { get; private set; }

        [JsonProperty(PropertyName = "offset")]
        public int Offset { get; private set; }

        [JsonProperty(PropertyName = "data")]
        public List<T> Data { get; private set; }

        public ResponseList(HttpResponseMessage httpResponseMessage) : base(httpResponseMessage)
        {
            BuildData(httpResponseMessage);
        }

        private void BuildData(HttpResponseMessage httpResponseMessage)
        {
            if (httpResponseMessage.StatusCode != HttpStatusCode.OK) return;

            var content = httpResponseMessage.Content.ReadAsStringAsync().Result;
            Data = JsonConvert.DeserializeObject<List<T>>(content);
        }
    }
}
