using AsaasClient.Core.Response.Base;
using System.Collections.Generic;
using System.Net;
using System.Text.Json;

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

            using JsonDocument document = JsonDocument.Parse(content);
            JsonElement root = document.RootElement;

            HasMore = root.GetProperty("hasMore").GetBoolean();
            TotalCount = root.GetProperty("totalCount").GetInt32();
            Limit = root.GetProperty("limit").GetInt32();
            Offset = root.GetProperty("offset").GetInt32();

            if (root.TryGetProperty("data", out JsonElement dataElement))
            {
                Data = JsonSerializer.Deserialize<List<T>>(dataElement.GetRawText());
            }
        }
    }
}