using AsaasClient.Models.Common;
using AsaasClient.Models.PaymentDunning.Enums;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace AsaasClient.Models.PaymentDunning {
    public class CreatePaymentDunningRequest {

        [JsonProperty(PropertyName = "payment")]
        public string PaymentId { get; set; }

        public PaymentDunningType Type { get; set; }

        public string Description { get; set; }

        public string CustomerName { get; set; }

        public string CustomerCpfCnpj { get; set; }

        public string CustomerPrimaryPhone { get; set; }

        public string CustomerSecondaryPhone { get; set; }

        public string CustomerPostalCode { get; set; }

        public string CustomerAddress { get; set; }

        public string CustomerAddressNumber { get; set; }

        public string CustomerComplement { get; set; }

        public string CustomerProvince { get; set; }

        public List<AsaasFile> Documents { get; set; }
    }
}
