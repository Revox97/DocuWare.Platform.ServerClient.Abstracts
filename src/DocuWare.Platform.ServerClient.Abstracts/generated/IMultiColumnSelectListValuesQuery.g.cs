using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IMultiColumnSelectListValuesQuery : ISelectListValuesQuery
    {
		List<IMultiColumnSelectListExpressionCondition> Condition { get; set; }
		DialogExpressionOperation Operation { get; set; }
		string SourceColumn { get; set; }
    }
}
