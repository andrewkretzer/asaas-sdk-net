namespace AsaasClient.V3.Models.Payment.Enums
{
    public enum PaymentStatus
    {
        PENDING,
        RECEIVED,
        CONFIRMED,
        OVERDUE,
        REFUNDED,
        RECEIVED_IN_CASH,
        REFUND_REQUESTED,
        CHARGEBACK_REQUESTED,
        CHARGEBACK_DISPUTE,
        AWAITING_CHARGEBACK_REVERSAL,
        DUNNING_REQUESTED,
        DUNNING_RECEIVED,
        AWAITING_RISK_ANALYSIS
    }

    public static class PaymentStatusExtension
    {
        public static bool IsPending(this PaymentStatus status)
        {
            return status == PaymentStatus.PENDING;
        }

        public static bool IsReceived(this PaymentStatus status)
        {
            return status == PaymentStatus.RECEIVED;
        }

        public static bool IsConfirmed(this PaymentStatus status)
        {
            return status == PaymentStatus.CONFIRMED;
        }

        public static bool IsOverdue(this PaymentStatus status)
        {
            return status == PaymentStatus.OVERDUE;
        }

        public static bool IsRefunded(this PaymentStatus status)
        {
            return status == PaymentStatus.REFUNDED;
        }

        public static bool IsReceivedInCash(this PaymentStatus status)
        {
            return status == PaymentStatus.RECEIVED_IN_CASH;
        }

        public static bool IsRefundRequested(this PaymentStatus status)
        {
            return status == PaymentStatus.REFUND_REQUESTED;
        }

        public static bool IsChargebackRequested(this PaymentStatus status)
        {
            return status == PaymentStatus.CHARGEBACK_REQUESTED;
        }

        public static bool IsChargebackDispute(this PaymentStatus status)
        {
            return status == PaymentStatus.CHARGEBACK_DISPUTE;
        }

        public static bool IsAwaitingChargebackReversal(this PaymentStatus status)
        {
            return status == PaymentStatus.AWAITING_CHARGEBACK_REVERSAL;
        }

        public static bool IsDunningRequested(this PaymentStatus status)
        {
            return status == PaymentStatus.DUNNING_REQUESTED;
        }

        public static bool IsDunningReceived(this PaymentStatus status)
        {
            return status == PaymentStatus.DUNNING_RECEIVED;
        }

        public static bool IsAwaitingRiskAnalysis(this PaymentStatus status)
        {
            return status == PaymentStatus.AWAITING_RISK_ANALYSIS;
        }
    }
}
