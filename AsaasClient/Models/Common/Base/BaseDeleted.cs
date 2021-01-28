namespace AsaasClient.Models.Common.Base
{
    public abstract class BaseDeleted
    {
        public string Id { get; set; }

        public bool Deleted { get; set; }
    }
}