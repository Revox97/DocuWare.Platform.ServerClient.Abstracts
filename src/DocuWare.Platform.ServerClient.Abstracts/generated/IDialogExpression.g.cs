using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IDialogExpression
    {
		List<IDialogExpressionCondition> Condition { get; set; }
		List<string> AdditionalCabinets { get; set; }
		string CompleteCondition { get; set; }
		DocuWare.Platform.ServerClient.DialogExpressionOperation Operation { get; set; }
		bool CompleteConditionInInvariantCulture { get; set; }
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
