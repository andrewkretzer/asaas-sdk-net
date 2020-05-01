using AsaasClient.Core;
using AsaasClient.V3.Models.Transfer.Enums;
using System;

namespace AsaasClient.V3.Models.Transfer
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
