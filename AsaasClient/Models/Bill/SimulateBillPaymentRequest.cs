using Newtonsoft.Json;

namespace AsaasClient.Models.Bill
{
    public class SimulateBillPaymentRequest
    {
        public string IdentificationField { get; set; }

        public string BarCode { get; set; }
    }
}
