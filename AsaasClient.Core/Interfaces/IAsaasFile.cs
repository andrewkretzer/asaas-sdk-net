namespace AsaasClient.Core.Interfaces
{
    public interface IAsaasFile
    {
        string FileName { get; set; }

        byte[] FileContent { get; set; }
    }
}
