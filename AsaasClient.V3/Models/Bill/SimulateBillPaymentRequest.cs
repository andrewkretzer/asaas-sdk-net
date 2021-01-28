using Newtonsoft.Json;

namespace AsaasClient.V3.Models.Bill
{
    public class SimulateBillPaymentRequest
    {
        public string IdentificationField { get; set; }

        public string BarCode { get; set; }
    }
}
