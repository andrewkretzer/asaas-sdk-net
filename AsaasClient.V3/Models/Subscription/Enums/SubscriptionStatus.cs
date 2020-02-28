namespace AsaasClient.V3.Models.Subscription.Enums
{
    public enum SubscriptionStatus
    {
        ACTIVE,
        EXPIRED
    }

    public static class SubscriptionStatusExtension
    {
        public static bool IsActive(this SubscriptionStatus status)
        {
            return status == SubscriptionStatus.ACTIVE;
        }

        public static bool IsExpired(this SubscriptionStatus status)
        {
            return status == SubscriptionStatus.EXPIRED;
        }
    }
}
