using AsaasClient.V3.Models.Common;
using AsaasClient.V3.Models.Invoice.Enums;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;

namespace AsaasClient.V3.Models.Invoice
{
    public class Invoice
    {
        public string Id { get; set; }

        public InvoiceStatus Status { get; set; }

        [JsonProperty(PropertyName = "customer")]
        public string CustomerId { get; set; }

        [JsonProperty(PropertyName = "payment")]
        public string PaymentId { get; set; }

        [JsonProperty(PropertyName = "installment")]
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
