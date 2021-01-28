using AsaasClient.Core;
using AsaasClient.Models.Transfer.Enums;
using System;

namespace AsaasClient.Models.Transfer
{
    public class TransferListFilter : RequestParameters
    {
        public DateTime? DateCreated
        {
            get => Get<DateTime?>("dateCreated");
            set => Add("dateCreated", value);
        }

        public TransferType? TransferType
        {
            get => Get<TransferType?>("type");
            set => Add("type", value);
        }
    }
}
