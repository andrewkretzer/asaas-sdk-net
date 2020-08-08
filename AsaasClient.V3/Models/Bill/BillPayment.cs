using AsaasClient.V3.Models.Bill.Enums;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;

namespace AsaasClient.V3.Models.Bill
{
    public class BillPayment
    {
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        [JsonProperty(PropertyName = "status")]
        [JsonConverter(typeof(StringEnumConverter))]
        public BillPaymentStatus Status { get; set; }

        [JsonProperty(PropertyName = "value")]
        public decimal Value { get; set; }

        [JsonProperty(PropertyName = "discount")]
        public decimal Discount { get; set; }

        [JsonProperty(PropertyName = "identificationField")]
        public string IdentificationField { get; set; }

        [JsonProperty(PropertyName = "dueDate")]
        public DateTime DueDate { get; set; }

        [JsonProperty(PropertyName = "scheduleDate")]
        public DateTime ScheduleDate { get; set; }

        [JsonProperty(PropertyName = "fee")]
        public decimal Fee { get; set; }

        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        [JsonProperty(PropertyName = "companyName")]
        public string CompanyName { get; set; }

        [JsonProperty(PropertyName = "transactionReceiptUrl")]
        public string TransactionReceiptUrl { get; set; }

        [JsonProperty(PropertyName = "canBeCancelled")]
        public bool CanBeCancelled { get; set; }

        [JsonProperty(PropertyName = "failReasons")]
        public string FailReasons { get; set; }
    }
}
