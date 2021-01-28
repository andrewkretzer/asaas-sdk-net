namespace AsaasClient.Models.Payment
{
    public class Split
    {
        public string WalletId { get; set; }

        public decimal FixedValue { get; set; }

        public decimal PercentualValue { get; set; }
    }
}
