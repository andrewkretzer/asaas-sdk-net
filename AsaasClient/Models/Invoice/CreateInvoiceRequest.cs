using AsaasClient.Models.Common;
using System.Text.Json.Serialization;
using System;

namespace AsaasClient.Models.Invoice
{
    public class CreateInvoiceRequest
    {
        [JsonPropertyName( "payment")]
        public string PaymentId { get; set; }

        [JsonPropertyName( "installment")]
        public string InstallmentId { get; set; }

        [JsonPropertyName( "customer")]
        public string CustomerId { get; set; }

        public string ServiceDescription { get; set; }

        public string Observations { get; set; }

        public decimal Value { get; set; }

        public decimal Deductions { get; set; }

        public DateTime EffectiveDate { get; set; }

        public string MunicipalServiceId { get; set; }

        public string MunicipalServiceCode { get; set; }

        public string MunicipalServiceName { get; set; }

        public Taxes Taxes { get; set; }
    }
}
