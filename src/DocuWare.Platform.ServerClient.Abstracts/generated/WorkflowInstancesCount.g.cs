using SDK = DocuWare.Platform.ServerClient;
using DocuWare.Platform.ServerClient.Abstracts.Content;
using DocuWare.Platform.ServerClient.Abstracts.Policy.CircuitBreaker;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Resilience;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Retry;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class WorkflowInstancesCount(SDK.WorkflowInstancesCount obj) : IWorkflowInstancesCount
    {
        internal SDK.WorkflowInstancesCount Obj { get; } = obj;

        public int TasksCount
        {
            get => Obj.TasksCount;
            set => Obj.TasksCount = value;
        }

        public int GeneralErrorCount
        {
            get => Obj.GeneralErrorCount;
            set => Obj.GeneralErrorCount = value;
        }

        public int WaitingCount
        {
            get => Obj.WaitingCount;
            set => Obj.WaitingCount = value;
        }

        public int EventWaitingCount
        {
            get => Obj.EventWaitingCount;
            set => Obj.EventWaitingCount = value;
        }

        public int FinishedCount
        {
            get => Obj.FinishedCount;
            set => Obj.FinishedCount = value;
        }

        public DateTime TimeStamp
        {
            get => Obj.TimeStamp;
            set => Obj.TimeStamp = value;
        }
    }
}
