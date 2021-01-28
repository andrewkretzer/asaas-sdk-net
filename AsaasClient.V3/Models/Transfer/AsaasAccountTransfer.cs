using AsaasClient.V3.Models.Transfer.Base;
using AsaasClient.V3.Models.Transfer.Enums;

namespace AsaasClient.V3.Models.Transfer {
    public class AsaasAccountTransfer : BaseTransfer {
        public string WalletId { get; set; }

        public AsaasAccountTransferStatus Status { get; set; }

        public AsaasAccount Account { get; set; }
    }
}
