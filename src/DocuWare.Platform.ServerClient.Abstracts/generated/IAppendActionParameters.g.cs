using DocuWare.Platform.ServerClient;
using DocuWare.Platform.ServerClient.Abstracts.Content;
using DocuWare.Platform.ServerClient.Abstracts.Policy.CircuitBreaker;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Resilience;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Retry;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IAppendActionParameters : IDocumentActionParameters
    {
		bool RemoveSourceDocuments { get; set; }
		List<IAppendActionDocuments> DocumentsInFront { get; set; }
		List<IAppendActionDocuments> DocumentsAtBack { get; set; }
    }
}
