using AsaasClient.V3.Models.Common;
using AsaasClient.V3.Models.Invoice.Enums;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;

namespace AsaasClient.V3.Models.Invoice
{
    public class Invoice
    {
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        [JsonProperty(PropertyName = "status")]
        [JsonConverter(typeof(StringEnumConverter))]
        public InvoiceStatus Status { get; set; }

        [JsonProperty(PropertyName = "customer")]
        public string CustomerId { get; set; }

        [JsonProperty(PropertyName = "installment")]
        public string InstallmentId { get; set; }

        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }

        [JsonProperty(PropertyName = "statusDescription")]
        public string StatusDescription { get; set; }

        [JsonProperty(PropertyName = "serviceDescription")]
        public string ServiceDescription { get; set; }

        [JsonProperty(PropertyName = "pdfUrl")]
        public string PdfUrl { get; set; }

        [JsonProperty(PropertyName = "xmlUrl")]
        public string XmlUrl { get; set; }

        [JsonProperty(PropertyName = "rpsSerie")]
        public string RpsSerie { get; set; }

        [JsonProperty(PropertyName = "rpsNumber")]
        public string RpsNumber { get; set; }

        [JsonProperty(PropertyName = "number")]
        public string Number { get; set; }

        [JsonProperty(PropertyName = "validationCode")]
        public string ValidationCode { get; set; }

        [JsonProperty(PropertyName = "value")]
        public decimal Value { get; set; }

        [JsonProperty(PropertyName = "deductions")]
        public decimal Deductions { get; set; }

        [JsonProperty(PropertyName = "effectiveDate")]
        public DateTime EffectiveDate { get; set; }

        [JsonProperty(PropertyName = "observations")]
        public string Observations { get; set; }

        [JsonProperty(PropertyName = "estimatedTaxesDescription")]
        public string EstimatedTaxesDescription { get; set; }

        [JsonProperty(PropertyName = "municipalServiceId")]
        public string MunicipalServiceId { get; set; }

        [JsonProperty(PropertyName = "municipalServiceCode")]
        public string MunicipalServiceCode { get; set; }

        [JsonProperty(PropertyName = "municipalServiceName")]
        public string MunicipalServiceName { get; set; }

        [JsonProperty(PropertyName = "taxes")]
        public Taxes Taxes { get; set; }
    }
}
