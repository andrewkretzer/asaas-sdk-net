namespace AsaasClient.V3.Models.AsaasAccount.Enums
{
    public enum CompanyType
    {
        MEI,
        LIMITED,
        INDIVIDUAL,
        ASSOCIATION
    }

    public static class CompanyTypeExtension
    {
        public static bool IsMei(this CompanyType companyType)
        {
            return companyType == CompanyType.MEI;
        }

        public static bool IsLimited(this CompanyType companyType)
        {
            return companyType == CompanyType.LIMITED;
        }

        public static bool IsIndividual(this CompanyType companyType)
        {
            return companyType == CompanyType.INDIVIDUAL;
        }

        public static bool IsAssociation(this CompanyType companyType)
        {
            return companyType == CompanyType.ASSOCIATION;
        }
    }
}
