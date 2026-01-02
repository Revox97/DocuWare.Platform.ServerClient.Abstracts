using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IRequestDecisionsStampSettings
    {
		List<IDecision> DecisionStamps { get; set; }
		string WorkflowId { get; set; }
		string TaskId { get; set; }

		void SetProxy(HttpClientProxy proxy);
    }
}
