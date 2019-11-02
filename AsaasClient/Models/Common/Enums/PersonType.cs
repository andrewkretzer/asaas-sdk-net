namespace AsaasClient.Models.Common.Enums
{
    public enum PersonType
    {
        FISICA, JURIDICA
    }

    public static class PersonTypeExtension
    {
        public static bool IsLegalPerson(this PersonType personType)
        {
            return personType == PersonType.JURIDICA;
        }

        public static bool IsIndividualPerson(this PersonType personType)
        {
            return personType == PersonType.FISICA;
        }
    }
}
