using DocuWare.Platform.ServerClient;
using DocuWare.Platform.ServerClient.Abstracts.Content;
using DocuWare.Platform.ServerClient.Abstracts.Policy.CircuitBreaker;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Resilience;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Retry;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IDecisionStampPlacement : IStampPlacement
    {
		string WorkflowId { get; set; }
		string InstanceId { get; set; }
		string TaskId { get; set; }
		int DecisionId { get; set; }
		bool IsController { get; set; }
    }
}
