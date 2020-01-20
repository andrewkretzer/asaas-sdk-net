using System.Net;

namespace AsaasClient.Core.Extension
{
    public static class HttpStatusCodeExtension
    {
        public static bool IsSuccessful(this HttpStatusCode statusCode)
        {
            return statusCode == HttpStatusCode.OK;
        }

        public static bool IsBadRequest(this HttpStatusCode statusCode)
        {
            return statusCode == HttpStatusCode.BadRequest;
        }

        public static bool IsUnauthorized(this HttpStatusCode statusCode)
        {
            return statusCode == HttpStatusCode.Unauthorized;
        }

        public static bool IsForbidden(this HttpStatusCode statusCode)
        {
            return statusCode == HttpStatusCode.Forbidden;
        }

        public static bool IsNotFound(this HttpStatusCode statusCode)
        {
            return statusCode == HttpStatusCode.NotFound;
        }

        public static bool IsRequestTimeout(this HttpStatusCode statusCode)
        {
            return statusCode == HttpStatusCode.RequestTimeout;
        }

        public static bool IsBadGateway(this HttpStatusCode statusCode)
        {
            return statusCode == HttpStatusCode.BadGateway;
        }
    }
}
