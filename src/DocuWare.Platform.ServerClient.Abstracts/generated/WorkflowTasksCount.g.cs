using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class WorkflowTasksCount(SDK.WorkflowTasksCount obj) : IWorkflowTasksCount
    {
        internal SDK.WorkflowTasksCount Obj { get; } = obj;

		public int Count
		{
			get => Obj.Count;
			set => Obj.Count = value;
		}

		public DateTime TimeStamp
		{
			get => Obj.TimeStamp;
			set => Obj.TimeStamp = value;
		}
    }
}
