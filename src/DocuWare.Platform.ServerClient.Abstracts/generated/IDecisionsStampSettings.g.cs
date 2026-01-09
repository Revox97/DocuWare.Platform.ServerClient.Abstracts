using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IDecisionsStampSettings{3}
    {
		List<IDecision> DecisionStamps { get; set; }
		string WorkflowId { get; set; }
		string InstanceId { get; set; }
		string TaskId { get; set; }
		string ActivityName { get; set; }

		void SetProxy(HttpClientProxy proxy);
    }
}
