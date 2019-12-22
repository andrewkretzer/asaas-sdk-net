using System;

namespace AsaasClient.Core.Utils
{
    public static class EnumUtils
    {
        public static T Parse<T>(string @enum)
        {
            if (string.IsNullOrEmpty(@enum))
            {
                return default;
            }

            return (T)Enum.Parse(typeof(T), @enum);
        }
    }
}