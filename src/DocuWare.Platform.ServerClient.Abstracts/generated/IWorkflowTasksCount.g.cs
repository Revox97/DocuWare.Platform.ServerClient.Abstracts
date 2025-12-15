using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IWorkflowTasksCount
    {
		int Count { get; set; }
		DateTime TimeStamp { get; set; }
    }
}
