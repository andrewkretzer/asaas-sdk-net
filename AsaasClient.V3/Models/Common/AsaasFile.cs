using AsaasClient.Core.Interfaces;

namespace AsaasClient.V3.Models.Common
{
    public class AsaasFile : IAsaasFile
    {
        public string FileName { get; set; }

        public byte[] FileContent { get; set; }
    }
}
