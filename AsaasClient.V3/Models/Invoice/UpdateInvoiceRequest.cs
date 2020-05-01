using AsaasClient.V3.Models.Common;
using Newtonsoft.Json;
using System;

namespace AsaasClient.V3.Models.Invoice
{
    public class UpdateInvoiceRequest
    {
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

        [JsonProperty(PropertyName = "taxes")]
        public Taxes Taxes { get; set; }
    }
}
