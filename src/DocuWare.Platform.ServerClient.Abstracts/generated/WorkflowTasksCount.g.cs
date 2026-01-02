using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class WorkflowTasksCount(DocuWare.Platform.ServerClient.WorkflowTasksCount obj) : IWorkflowTasksCount
    {
        internal DocuWare.Platform.ServerClient.WorkflowTasksCount Obj { get; } = obj;

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
