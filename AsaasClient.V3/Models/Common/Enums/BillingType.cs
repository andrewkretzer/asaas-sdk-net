namespace AsaasClient.V3.Models.Common.Enums
{
    public enum BillingType
    {
        BOLETO, CREDIT_CARD, UNDEFINED
    }

    public static class BillingTypeExtension
    {
        public static bool IsBoleto(this BillingType billingType)
        {
            return billingType == BillingType.BOLETO;
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
