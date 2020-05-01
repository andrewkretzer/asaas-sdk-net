using AsaasClient.V3.Models.Transfer.Enums;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;

namespace AsaasClient.V3.Models.Transfer.Base
{
    public abstract class BaseTransfer
    {
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        [JsonProperty(PropertyName = "type")]
        [JsonConverter(typeof(StringEnumConverter))]
        public TransferType Type { get; set; }

        [JsonProperty(PropertyName = "dateCreated")]
        public DateTime DateCreated { get; set; }

        [JsonProperty(PropertyName = "value")]
        public decimal Value { get; set; }

        [JsonProperty(PropertyName = "transferFee")]
        public decimal TransferFee { get; set; }

        [JsonProperty(PropertyName = "effectiveDate")]
        public DateTime? EffectiveDate { get; set; }

        [JsonProperty(PropertyName = "scheduleDate")]
        public DateTime? ScheduleDate { get; set; }

        [JsonProperty(PropertyName = "authorized")]
        public bool Authorized { get; set; }

        [JsonProperty(PropertyName = "transactionReceiptUrl")]
        public string TransactionReceiptUrl { get; set; }
    }
}
