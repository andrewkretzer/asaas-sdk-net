using AsaasClient.Models.Transfer.Base;
using AsaasClient.Models.Transfer.Enums;

namespace AsaasClient.Models.Transfer {
    public class AsaasAccountTransfer : BaseTransfer {
        public string WalletId { get; set; }

        public AsaasAccountTransferStatus Status { get; set; }

        public AsaasAccount Account { get; set; }
    }
}
