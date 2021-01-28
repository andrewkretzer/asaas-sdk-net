namespace AsaasClient.Models.PaymentDunning.Enums
{
    public enum PaymentDunningType
    {
        CREDIT_BUREAU
    }

    public static class PaymentDunningTypeExtension
    {
        public static bool IsCreditBureau(this PaymentDunningType type)
        {
            return type == PaymentDunningType.CREDIT_BUREAU;
        }
    }
}
