using System;

namespace AsaasClient.Core.Extension
{
    public static class DateTimeExternsions
    {
        public static string ToApiRequest(this DateTime dateTime)
        {
            return dateTime.ToString("yyyy-MM-dd");
        }
    }
}