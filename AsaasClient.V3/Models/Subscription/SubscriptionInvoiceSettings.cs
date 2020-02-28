using AsaasClient.V3.Models.Common;
using AsaasClient.V3.Models.Subscription.Enums;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace AsaasClient.V3.Models.Subscription
{
    public class SubscriptionInvoiceSettings
    {
        [JsonProperty(PropertyName = "municipalServiceId")]
        public string MunicipalServiceId { get; set; }

        [JsonProperty(PropertyName = "municipalServiceCode")]
        public string MunicipalServiceCode { get; set; }

        [JsonProperty(PropertyName = "municipalServiceName")]
        public string MunicipalServiceName { get; set; }

        [JsonProperty(PropertyName = "deductions")]
        public decimal Deductions { get; set; }

        [JsonProperty(PropertyName = "invoiceCreationPeriod")]
        [JsonConverter(typeof(StringEnumConverter))]
        public EffectiveDatePeriod InvoiceCreationPeriod { get; set; }

        [JsonProperty(PropertyName = "daysBeforeDueDate")]
        public int DaysBeforeDueDate { get; set; }

        [JsonProperty(PropertyName = "receivedOnly")]
        public bool ReceivedOnly { get; set; }

        [JsonProperty(PropertyName = "observations")]
        public string Observations { get; set; }

        [JsonProperty(PropertyName = "taxes")]
        public Taxes Taxes { get; set; }
    }
}
