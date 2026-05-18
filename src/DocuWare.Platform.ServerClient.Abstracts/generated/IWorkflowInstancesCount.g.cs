using DocuWare.Platform.ServerClient;
using DocuWare.Platform.ServerClient.Abstracts.Content;
using DocuWare.Platform.ServerClient.Abstracts.Policy.CircuitBreaker;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Resilience;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Retry;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IWorkflowInstancesCount
    {
		int TasksCount { get; set; }
		int GeneralErrorCount { get; set; }
		int WaitingCount { get; set; }
		int EventWaitingCount { get; set; }
		int FinishedCount { get; set; }
		DateTime TimeStamp { get; set; }
    }
}
