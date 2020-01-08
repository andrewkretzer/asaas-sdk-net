using System;

namespace AsaasClient.Core.Utils
{
    public static class DateTimeUtils
    {

        public static DateTime? Parse(string date)
        {
            if (string.IsNullOrEmpty(date))
            {
                return null;
            }

            return DateTime.Parse(date);
        }

    }
}