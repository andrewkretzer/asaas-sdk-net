using Newtonsoft.Json;

namespace AsaasClient.V3.Models.Common
{
    public class Taxes
    {
        public bool RetainIss { get; set; }

        public decimal Iss { get; set; }

        public decimal Cofins { get; set; }

        public decimal Csll { get; set; }

        public decimal Inss { get; set; }

        public decimal Ir { get; set; }

        public decimal Pis { get; set; }
    }
}
