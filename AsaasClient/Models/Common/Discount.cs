using AsaasClient.Models.Common.Enums;
using Newtonsoft.Json;

namespace AsaasClient.Models.Common
{
    public class Discount
    {
        [JsonProperty(PropertyName = "value")]
        public decimal Value { get; set; }

        [JsonProperty(PropertyName = "dueDateLimitDays")]
        public int DueDateLimitDays { get; set; }

        [JsonProperty(PropertyName = "type")]
        public DiscountType Type { get; set; }
    }
}
