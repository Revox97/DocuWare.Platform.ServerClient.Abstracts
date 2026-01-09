using DocuWare.Platform.ServerClient;

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
