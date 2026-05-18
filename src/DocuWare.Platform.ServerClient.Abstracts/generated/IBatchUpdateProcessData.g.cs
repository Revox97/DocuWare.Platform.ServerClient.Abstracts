using DocuWare.Platform.ServerClient;
using DocuWare.Platform.ServerClient.Abstracts.Content;
using DocuWare.Platform.ServerClient.Abstracts.Policy.CircuitBreaker;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Resilience;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Retry;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IBatchUpdateProcessData
    {
		List<IDocumentIndexField> Field { get; set; }
		string StoreDialogId { get; set; }
		int? BatchSize { get; set; }
		bool BreakOnError { get; set; }
		bool ForceUpdate { get; set; }
    }
}
