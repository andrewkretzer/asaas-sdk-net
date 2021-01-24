namespace AsaasClient.Models.Transfer {
    public class BankAccountTransferRequest {
        public decimal Value { get; set; }

        public BankAccount BankAccount { get; set; }
    }
}
