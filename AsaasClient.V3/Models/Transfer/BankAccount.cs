using AsaasClient.V3.Models.Transfer.Enums;
using System;

namespace AsaasClient.V3.Models.Transfer {
    public class BankAccount {
        public Bank Bank { get; set; }

        public string AccountName { get; set; }

        public string OwnerName { get; set; }

        public DateTime? OwnerBirthDate { get; set; }

        public string CpfCnpj { get; set; }

        public string Agency { get; set; }

        public string Account { get; set; }

        public string AccountDigit { get; set; }

        public BankAccountType BankAccountType { get; set; }
    }
}
