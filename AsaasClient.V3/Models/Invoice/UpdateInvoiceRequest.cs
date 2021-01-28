using AsaasClient.V3.Models.Common;
using Newtonsoft.Json;
using System;

namespace AsaasClient.V3.Models.Invoice
{
    public class UpdateInvoiceRequest
    {
        public string ServiceDescription { get; set; }

        public string Observations { get; set; }

        public decimal Value { get; set; }

        public decimal Deductions { get; set; }

        public DateTime EffectiveDate { get; set; }

        public Taxes Taxes { get; set; }
    }
}
