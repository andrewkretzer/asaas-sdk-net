using System.Collections.Generic;
using System.Net;
using System.Text.Json;

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

            using JsonDocument document = JsonDocument.Parse(AsaasResponse);
            JsonElement root = document.RootElement;

            if (root.TryGetProperty("errors", out JsonElement errorsElement))
            {
                Errors = JsonSerializer.Deserialize<List<Error>>(errorsElement.GetRawText());
            }
        }

        public bool WasSucessfull() => StatusCode == HttpStatusCode.OK;
    }
}
