namespace AsaasClient.Models.Enums
{
    public enum AsaasEnvironment
    {
        SANDBOX, PRODUCTION
    }

    public static class AsaasEnvironmentExtension
    {
        public static bool IsProduction(this AsaasEnvironment asaasEnvironment)
        {
            return asaasEnvironment == AsaasEnvironment.PRODUCTION;
        }

        public static bool IsSandbox(this AsaasEnvironment asaasEnvironment)
        {
            return asaasEnvironment == AsaasEnvironment.SANDBOX;
        }
    }
}
