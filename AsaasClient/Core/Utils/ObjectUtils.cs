using System;

namespace AsaasClient.Core.Utils
{
    internal static class ObjectUtils
    {
        public static T Cast<T>(this object obj)
        {
            return (T)obj;
        }

        public static bool IsNullableEnum(this Type t)
        {
            Type type = Nullable.GetUnderlyingType(t);
            return type != null && type.IsEnum;
        }
    }
}