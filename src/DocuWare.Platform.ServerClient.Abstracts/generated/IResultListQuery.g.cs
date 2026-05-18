using DocuWare.Platform.ServerClient;
using DocuWare.Platform.ServerClient.Abstracts.Content;
using DocuWare.Platform.ServerClient.Abstracts.Policy.CircuitBreaker;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Resilience;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Retry;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IResultListQuery
    {
		List<ISortedField> SortOrder { get; set; }
		List<string> AdditionalResultFields { get; set; }
		IFlagConditions FlagConditions { get; set; }
		int Start { get; set; }
		int Count { get; set; }
		bool ExcludeDefaultSystemFields { get; set; }
		bool WithoutLinks { get; set; }
		bool IncludeSuggestions { get; set; }
		bool CalculateTotalCount { get; set; }
    }
}
