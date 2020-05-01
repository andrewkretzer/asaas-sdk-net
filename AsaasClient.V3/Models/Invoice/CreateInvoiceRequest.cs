using AsaasClient.V3.Models.Common;
using Newtonsoft.Json;
using System;

namespace AsaasClient.V3.Models.Invoice
{
    public class CreateInvoiceRequest
    {
        [JsonProperty(PropertyName = "payment")]
        public string PaymentId { get; set; }

        [JsonProperty(PropertyName = "installment")]
        public string InstallmentId { get; set; }

        [JsonProperty(PropertyName = "customer")]
        public string CustomerId { get; set; }

        [JsonProperty(PropertyName = "serviceDescription")]
        public string ServiceDescription { get; set; }

        [JsonProperty(PropertyName = "observations")]
        public string Observations { get; set; }

        [JsonProperty(PropertyName = "value")]
        public decimal Value { get; set; }

        [JsonProperty(PropertyName = "deductions")]
        public decimal Deductions { get; set; }

        [JsonProperty(PropertyName = "effectiveDate")]
        public DateTime EffectiveDate { get; set; }

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
