using AsaasClient.V3.Models.Transfer.Base;
using AsaasClient.V3.Models.Transfer.Enums;

namespace AsaasClient.V3.Models.Transfer {
    public class BankAccountTransfer : BaseTransfer {
        public decimal NetValue { get; set; }

        public BankAccountTransferStatus Status { get; set; }

        public BankAccount BankAccount { get; set; }
    }
}
