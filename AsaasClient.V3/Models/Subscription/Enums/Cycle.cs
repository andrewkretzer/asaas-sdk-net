namespace AsaasClient.V3.Models.Subscription.Enums
{
    public enum Cycle
    {
        WEEKLY,
        BIWEEKLY,
        MONTHLY,
        QUARTERLY,
        SEMIANNUALLY,
        YEARLY
    }

    public static class CycleExtension
    {
        public static bool IsWeekly(this Cycle cycle)
        {
            return cycle == Cycle.WEEKLY;
        }

        public static bool IsBiweekly(this Cycle cycle)
        {
            return cycle == Cycle.BIWEEKLY;
        }

        public static bool IsMonthly(this Cycle cycle)
        {
            return cycle == Cycle.MONTHLY;
        }

        public static bool IsQuarterly(this Cycle cycle)
        {
            return cycle == Cycle.QUARTERLY;
        }

        public static bool IsSemiannually(this Cycle cycle)
        {
            return cycle == Cycle.SEMIANNUALLY;
        }

        public static bool IsYearly(this Cycle cycle)
        {
            return cycle == Cycle.YEARLY;
        }
    }
}
