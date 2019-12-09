namespace AsaasClient.V3.Models.Common.Enums
{
    public enum DiscountType
    {
        FIXED, PERCENTAGE
    }

    public static class DiscountTypeExtension
    {
        public static bool IsFixed(this DiscountType discountType)
        {
            return discountType == DiscountType.FIXED;
        }

        public static bool IsPercentage(this DiscountType discountType)
        {
            return discountType == DiscountType.PERCENTAGE;
        }
    }
}
