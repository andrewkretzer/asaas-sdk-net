namespace AsaasClient.Core.Utils
{
    public static class ObjectUtils
    {
        public static T Cast<T>(this object obj)
        {
            return (T)obj;
        }
    }
}