using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IFileDownloadPage : IFileDownloadBase
    {
		bool AutoPrint { get; set; }
		bool SendByEmail { get; set; }
    }
}
