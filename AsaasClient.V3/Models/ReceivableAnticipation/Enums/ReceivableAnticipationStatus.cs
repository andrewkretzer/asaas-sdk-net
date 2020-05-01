namespace AsaasClient.V3.Models.ReceivableAnticipation.Enums
{
    public enum ReceivableAnticipationStatus
    {
        PENDING,
        DENIED,
        CREDITED,
        DEBITED,
        CANCELLED,
        OVERDUE,
        SCHEDULED
    }

    public static class ReceivableAnticipationStatusExtension
    {
        public static bool IsPending(this ReceivableAnticipationStatus receivableAnticipationStatus)
        {
            return receivableAnticipationStatus == ReceivableAnticipationStatus.PENDING;
        }

        public static bool IsDenied(this ReceivableAnticipationStatus receivableAnticipationStatus)
        {
            return receivableAnticipationStatus == ReceivableAnticipationStatus.DENIED;
        }

        public static bool IsCredited(this ReceivableAnticipationStatus receivableAnticipationStatus)
        {
            return receivableAnticipationStatus == ReceivableAnticipationStatus.CREDITED;
        }

        public static bool IsDebited(this ReceivableAnticipationStatus receivableAnticipationStatus)
        {
            return receivableAnticipationStatus == ReceivableAnticipationStatus.DEBITED;
        }

        public static bool IsCancelled(this ReceivableAnticipationStatus receivableAnticipationStatus)
        {
            return receivableAnticipationStatus == ReceivableAnticipationStatus.CANCELLED;
        }

        public static bool IsOverdue(this ReceivableAnticipationStatus receivableAnticipationStatus)
        {
            return receivableAnticipationStatus == ReceivableAnticipationStatus.OVERDUE;
        }

        public static bool IsScheduled(this ReceivableAnticipationStatus receivableAnticipationStatus)
        {
            return receivableAnticipationStatus == ReceivableAnticipationStatus.SCHEDULED;
        }
    }
}
