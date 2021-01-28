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
