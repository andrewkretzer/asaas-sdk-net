namespace AsaasClient.V3.Models.PaymentDunning.Enums
{
    public enum PaymentDunningStatus
    {
        PENDING,
        AWAITING_APPROVAL,
        AWAITING_CANCELLATION,
        PROCESSED,
        PAID,
        PARTIALLY_PAID,
        DENIED,
        CANCELLED
    }

    public static class PaymentDunningStatusExtension
    {
        public static bool IsPending(this PaymentDunningStatus status)
        {
            return status == PaymentDunningStatus.PENDING;
        }

        public static bool IsAwaitingApproval(this PaymentDunningStatus status)
        {
            return status == PaymentDunningStatus.AWAITING_APPROVAL;
        }

        public static bool IsAwaitingCancellation(this PaymentDunningStatus status)
        {
            return status == PaymentDunningStatus.AWAITING_CANCELLATION;
        }

        public static bool IsProcessed(this PaymentDunningStatus status)
        {
            return status == PaymentDunningStatus.PROCESSED;
        }

        public static bool IsPaid(this PaymentDunningStatus status)
        {
            return status == PaymentDunningStatus.PAID;
        }

        public static bool IsPartiallyPaid(this PaymentDunningStatus status)
        {
            return status == PaymentDunningStatus.PARTIALLY_PAID;
        }

        public static bool IsDenied(this PaymentDunningStatus status)
        {
            return status == PaymentDunningStatus.DENIED;
        }

        public static bool IsCancelled(this PaymentDunningStatus status)
        {
            return status == PaymentDunningStatus.CANCELLED;
        }
    }
}
