using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IResultListQuery
    {
		List<ISortedField> SortOrder { get; set; }
		List<string> AdditionalResultFields { get; set; }
		int Start { get; set; }
		int Count { get; set; }
		bool ExcludeDefaultSystemFields { get; set; }
		bool WithoutLinks { get; set; }
		bool IncludeSuggestions { get; set; }
		bool CalculateTotalCount { get; set; }
    }
}
