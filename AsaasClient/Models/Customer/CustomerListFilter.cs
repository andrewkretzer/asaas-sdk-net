﻿using AsaasClient.Core;

namespace AsaasClient.Models.Customer
{
    public class CustomerListFilter : RequestParameters
    {
        public string Name
        {
            get => this["name"];
            set => Add("name", value);
        }

        public string Email
        {
            get => this["email"];
            set => Add("email", value);
        }

        public string CpfCnpj
        {
            get => this["cpfCnpj"];
            set => Add("cpfCnpj", value);
        }

        public string ExternalReference
        {
            get => this["externalReference"];
            set => Add("externalReference", value);
        }

        public string GroupName 
        {
            get => this["groupName"];
            set => Add("groupName", value);
        }
    }
}
