using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IMultiColSelectListValuesQuery
    {
		List<IMultiColSelectListExpressionCondition> Condition { get; set; }
		string StartsWithColumn { get; set; }
		string StartsWithValue { get; set; }
		int Start { get; set; }
		int Count { get; set; }
		DialogExpressionOperation Operation { get; set; }
    }
}
