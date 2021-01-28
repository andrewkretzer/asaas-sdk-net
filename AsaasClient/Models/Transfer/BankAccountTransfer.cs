using AsaasClient.Models.Transfer.Base;
using AsaasClient.Models.Transfer.Enums;

namespace AsaasClient.Models.Transfer {
    public class BankAccountTransfer : BaseTransfer {
        public decimal NetValue { get; set; }

        public BankAccountTransferStatus Status { get; set; }

        public BankAccount BankAccount { get; set; }
    }
}
