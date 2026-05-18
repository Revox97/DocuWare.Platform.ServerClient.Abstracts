using DocuWare.Platform.ServerClient;
using DocuWare.Platform.ServerClient.Abstracts.Content;
using DocuWare.Platform.ServerClient.Abstracts.Policy.CircuitBreaker;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Resilience;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Retry;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IBatchAppendKeywordValues
    {
		List<int> DocId { get; set; }
		List<string> Keyword { get; set; }
		string FieldName { get; set; }
		bool BreakOnError { get; set; }
		string StoreDialogId { get; set; }
		bool ForceUpdate { get; set; }
    }
}
