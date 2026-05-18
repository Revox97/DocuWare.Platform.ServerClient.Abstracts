using DocuWare.Platform.ServerClient;
using DocuWare.Platform.ServerClient.Abstracts.Content;
using DocuWare.Platform.ServerClient.Abstracts.Policy.CircuitBreaker;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Resilience;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Retry;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IDecisionsStampSettings
    {
		IWorkflowStampsSettings StampsSettings { get; set; }
		List<IDecision> DecisionStamps { get; set; }
		string WorkflowId { get; set; }
		string InstanceId { get; set; }
		string TaskId { get; set; }
		string ActivityName { get; set; }

		void SetProxy(HttpClientProxy proxy);
    }
}
