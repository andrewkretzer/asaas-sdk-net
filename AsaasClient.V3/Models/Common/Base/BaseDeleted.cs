using Newtonsoft.Json;

namespace AsaasClient.V3.Models.Common.Base
{
    public abstract class BaseDeleted
    {
        public string Id { get; set; }

        public bool Deleted { get; set; }
    }
}