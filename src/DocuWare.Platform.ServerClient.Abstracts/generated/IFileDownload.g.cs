using DocuWare.Platform.ServerClient;
using DocuWare.Platform.ServerClient.Abstracts.Content;
using DocuWare.Platform.ServerClient.Abstracts.Policy.CircuitBreaker;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Resilience;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Retry;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IFileDownload : IFileDownloadBase
    {
		FileDownloadType TargetFileType { get; set; }
		bool DirectDownload { get; set; }
		bool AutoPrint { get; set; }
		bool SendByEmail { get; set; }
		bool Fillable { get; set; }
    }
}
