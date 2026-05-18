using DocuWare.Platform.ServerClient;

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
