namespace AsaasClient.Models.Invoice.Enums
{
    public enum InvoiceStatus
    {
        SCHEDULED,
        AUTHORIZED,
        PROCESSING_CANCELLATION,
        CANCELED,
        CANCELLATION_DENIED,
        ERROR
    }
}
