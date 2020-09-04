namespace AsaasClient.V3.Models.Anticipation.Enums
{
    public enum AnticipationStatus
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
        public static bool IsPending(this AnticipationStatus receivableAnticipationStatus)
        {
            return receivableAnticipationStatus == AnticipationStatus.PENDING;
        }

        public static bool IsDenied(this AnticipationStatus receivableAnticipationStatus)
        {
            return receivableAnticipationStatus == AnticipationStatus.DENIED;
        }

        public static bool IsCredited(this AnticipationStatus receivableAnticipationStatus)
        {
            return receivableAnticipationStatus == AnticipationStatus.CREDITED;
        }

        public static bool IsDebited(this AnticipationStatus receivableAnticipationStatus)
        {
            return receivableAnticipationStatus == AnticipationStatus.DEBITED;
        }

        public static bool IsCancelled(this AnticipationStatus receivableAnticipationStatus)
        {
            return receivableAnticipationStatus == AnticipationStatus.CANCELLED;
        }

        public static bool IsOverdue(this AnticipationStatus receivableAnticipationStatus)
        {
            return receivableAnticipationStatus == AnticipationStatus.OVERDUE;
        }

        public static bool IsScheduled(this AnticipationStatus receivableAnticipationStatus)
        {
            return receivableAnticipationStatus == AnticipationStatus.SCHEDULED;
        }
    }
}
