using AsaasClient.Models.Common;
using AsaasClient.Models.Invoice.Enums;
using System.Text.Json.Serialization;
using System;

namespace AsaasClient.Models.Invoice
{
    public class Invoice
    {
        public string Id { get; set; }

        public InvoiceStatus Status { get; set; }

        [JsonPropertyName( "customer")]
        public string CustomerId { get; set; }

        [JsonPropertyName( "payment")]
        public string PaymentId { get; set; }

        [JsonPropertyName( "installment")]
        public string InstallmentId { get; set; }

        public string Type { get; set; }

        public string StatusDescription { get; set; }

        public string ServiceDescription { get; set; }

        public string PdfUrl { get; set; }

        public string XmlUrl { get; set; }

        public string RpsSerie { get; set; }

        public string RpsNumber { get; set; }

        public string Number { get; set; }

        public string ValidationCode { get; set; }

        public decimal Value { get; set; }

        public decimal Deductions { get; set; }

        public DateTime EffectiveDate { get; set; }

        public string Observations { get; set; }

        public string EstimatedTaxesDescription { get; set; }

        public string MunicipalServiceId { get; set; }

        public string MunicipalServiceCode { get; set; }

        public string MunicipalServiceName { get; set; }

        public Taxes Taxes { get; set; }
    }
}
