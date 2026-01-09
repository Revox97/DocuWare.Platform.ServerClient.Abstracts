using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IMultiColumnSelectListValuesQuery: ISelectListValuesQuery
    {
		List<IMultiColumnSelectListExpressionCondition> Condition { get; set; }
		DialogExpressionOperation Operation { get; set; }
		string SourceColumn { get; set; }
		int Start { get; set; }
		int Count { get; set; }
		string ValuePrefix { get; set; }
		string ReturnType { get; set; }
    }
}
