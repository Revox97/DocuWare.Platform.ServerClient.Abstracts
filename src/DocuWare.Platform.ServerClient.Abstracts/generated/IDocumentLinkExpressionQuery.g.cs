using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IDocumentLinkExpressionQuery{3}
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
