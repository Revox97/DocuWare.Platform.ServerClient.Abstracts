using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IWorkflowBehaviorOptions
    {
		bool AllowReassign { get; set; }
		bool AllowWorkflowHistory { get; set; }
		bool AllowMarkAsReadUnread { get; set; }
    }
}
