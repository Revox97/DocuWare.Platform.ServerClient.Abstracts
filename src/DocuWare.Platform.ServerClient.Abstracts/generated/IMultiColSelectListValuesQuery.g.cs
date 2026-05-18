using DocuWare.Platform.ServerClient;
using DocuWare.Platform.ServerClient.Abstracts.Content;
using DocuWare.Platform.ServerClient.Abstracts.Policy.CircuitBreaker;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Resilience;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Retry;

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
