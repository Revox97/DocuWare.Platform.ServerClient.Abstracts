using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class WorkflowBehaviorOptions(SDK.WorkflowBehaviorOptions obj) : IWorkflowBehaviorOptions
    {
        internal SDK.WorkflowBehaviorOptions Obj { get; } = obj;

		public bool AllowReassign
		{
			get => Obj.AllowReassign;
			set => Obj.AllowReassign = value;
		}

		public bool AllowWorkflowHistory
		{
			get => Obj.AllowWorkflowHistory;
			set => Obj.AllowWorkflowHistory = value;
		}

		public bool AllowMarkAsReadUnread
		{
			get => Obj.AllowMarkAsReadUnread;
			set => Obj.AllowMarkAsReadUnread = value;
		}
    }
}
