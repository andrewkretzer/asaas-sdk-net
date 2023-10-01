namespace AsaasClient.Models.Common.Enums
{
    public enum BillingType
    {
        BOLETO, CREDIT_CARD, PIX, UNDEFINED
    }

    public static class BillingTypeExtension
    {
        public static bool IsBoleto(this BillingType billingType)
        {
            return billingType == BillingType.BOLETO;
        }

        public static bool IsPix(this BillingType billingType)
        {
            return billingType == BillingType.PIX;
        }

        public static bool IsCreditCard(this BillingType billingType)
        {
            return billingType == BillingType.CREDIT_CARD;
        }

        public static bool IsUndefined(this BillingType billingType)
        {
            return billingType == BillingType.UNDEFINED;
        }
    }
}
