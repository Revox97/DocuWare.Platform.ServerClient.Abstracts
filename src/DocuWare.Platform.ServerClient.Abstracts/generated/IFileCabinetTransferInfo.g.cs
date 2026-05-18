using DocuWare.Platform.ServerClient;
using DocuWare.Platform.ServerClient.Abstracts.Content;
using DocuWare.Platform.ServerClient.Abstracts.Policy.CircuitBreaker;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Resilience;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Retry;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IFileCabinetTransferInfo
    {
		List<int> SourceDocId { get; set; }
		string SourceFileCabinetId { get; set; }
		bool KeepSource { get; set; }
		bool FillIntellix { get; set; }
    }
}
