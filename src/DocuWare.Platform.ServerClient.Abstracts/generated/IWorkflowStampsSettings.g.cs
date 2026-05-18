using DocuWare.Platform.ServerClient;
using DocuWare.Platform.ServerClient.Abstracts.Content;
using DocuWare.Platform.ServerClient.Abstracts.Policy.CircuitBreaker;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Resilience;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Retry;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IWorkflowStampsSettings
    {
		IFont InfoFontFamily { get; set; }
		IFont StampFont { get; set; }
		bool UseFrame { get; set; }
		bool UseDate { get; set; }
		bool UseTime { get; set; }
		bool IsSignature { get; set; }
		bool UseUserName { get; set; }
		bool UseDecisionName { get; set; }
		bool UseActivityName { get; set; }
    }
}
