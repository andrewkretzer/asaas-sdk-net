namespace AsaasClient.Models.Bill.Enums
{
    public enum BillPaymentStatus
    {
        PENDING,
        BANK_PROCESSING,
        PAID,
        FAILED,
        CANCELLED
    }

    public static class BillPaymentStatusExtension
    {
        public static bool IsPending(this BillPaymentStatus status)
        {
            return status == BillPaymentStatus.PENDING;
        }

        public static bool IsBankProcessing(this BillPaymentStatus status)
        {
            return status == BillPaymentStatus.BANK_PROCESSING;
        }

        public static bool IsPaid(this BillPaymentStatus status)
        {
            return status == BillPaymentStatus.PAID;
        }

        public static bool IsFailed(this BillPaymentStatus status)
        {
            return status == BillPaymentStatus.FAILED;
        }

        public static bool IsCancelled(this BillPaymentStatus status)
        {
            return status == BillPaymentStatus.CANCELLED;
        }
    }
}
