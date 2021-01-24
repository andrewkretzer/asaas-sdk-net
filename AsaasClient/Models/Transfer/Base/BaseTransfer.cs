using AsaasClient.Models.Transfer.Enums;
using System;

namespace AsaasClient.Models.Transfer.Base {
    public abstract class BaseTransfer {
        public string Id { get; set; }

        public TransferType Type { get; set; }

        public DateTime DateCreated { get; set; }

        public decimal Value { get; set; }

        public decimal TransferFee { get; set; }

        public DateTime? EffectiveDate { get; set; }

        public DateTime? ScheduleDate { get; set; }

        public bool Authorized { get; set; }

        public string TransactionReceiptUrl { get; set; }
    }
}
