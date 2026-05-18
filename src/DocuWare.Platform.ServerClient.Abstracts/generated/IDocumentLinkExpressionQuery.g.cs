using DocuWare.Platform.ServerClient;
using DocuWare.Platform.ServerClient.Abstracts.Content;
using DocuWare.Platform.ServerClient.Abstracts.Policy.CircuitBreaker;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Resilience;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Retry;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IDocumentLinkExpressionQuery
    {
		List<ISortedField> SortOrder { get; set; }
		List<string> ResultFields { get; set; }
		List<IDialogExpressionCondition> Condition { get; set; }
		DialogExpressionOperation Operation { get; set; }
		int Start { get; set; }
		int Count { get; set; }
		bool CalculateTotalCount { get; set; }
		bool WithoutLinks { get; set; }
    }
}
