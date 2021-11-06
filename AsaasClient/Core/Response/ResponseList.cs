using AsaasClient.Core.Response.Base;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Net;

namespace AsaasClient.Core.Response
{
    public class ResponseList<T> : BaseResponse
    {
        public bool HasMore { get; }

        public int TotalCount { get; }

        public int Limit { get; }

        public int Offset { get; }

        public List<T> Data { get; }

        public ResponseList(HttpStatusCode httpStatusCode, string content) : base(httpStatusCode, content)
        {
            if (httpStatusCode != HttpStatusCode.OK) return;

            JObject listObject = JObject.Parse(content);
            
            HasMore = listObject.GetValue("hasMore").ToObject<bool>();
            TotalCount = listObject.GetValue("totalCount").ToObject<int>();
            Limit = listObject.GetValue("limit").ToObject<int>();
            Offset = listObject.GetValue("offset").ToObject<int>();
            Data = JsonConvert.DeserializeObject<List<T>>(listObject.GetValue("data").ToString());
        }
    }
}
