using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IWorkflowBehaviorOptions{3}
    {
		bool AllowReassign { get; set; }
		bool AllowWorkflowHistory { get; set; }
		bool AllowMarkAsReadUnread { get; set; }
    }
}
