using DocuWare.Platform.ServerClient;
using DocuWare.Platform.ServerClient.Abstracts.Content;
using DocuWare.Platform.ServerClient.Abstracts.Policy.CircuitBreaker;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Resilience;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Retry;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IDocumentsTransferInfo
    {
		List<IDocument> Documents { get; set; }
		string SourceFileCabinetId { get; set; }
		bool UseDefaultDialog { get; set; }
		bool KeepSource { get; set; }
		bool FillIntellix { get; set; }

		void SetProxy(HttpClientProxy proxy);
    }
}
