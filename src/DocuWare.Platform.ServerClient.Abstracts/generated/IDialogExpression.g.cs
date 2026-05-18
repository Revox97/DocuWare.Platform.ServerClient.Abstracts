using DocuWare.Platform.ServerClient;
using DocuWare.Platform.ServerClient.Abstracts.Content;
using DocuWare.Platform.ServerClient.Abstracts.Policy.CircuitBreaker;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Resilience;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Retry;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IDialogExpression : IResultListQuery
    {
		List<IDialogExpressionCondition> Condition { get; set; }
		List<string> AdditionalCabinets { get; set; }
		string CompleteCondition { get; set; }
		DialogExpressionOperation Operation { get; set; }
		bool CompleteConditionInInvariantCulture { get; set; }
    }
}
