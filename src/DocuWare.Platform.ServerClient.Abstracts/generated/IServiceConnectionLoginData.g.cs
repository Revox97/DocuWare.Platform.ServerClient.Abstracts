using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IServiceConnectionLoginData : IServiceConnectionLicenseBoundData
    {
		string Organization { get; set; }
    }
}
