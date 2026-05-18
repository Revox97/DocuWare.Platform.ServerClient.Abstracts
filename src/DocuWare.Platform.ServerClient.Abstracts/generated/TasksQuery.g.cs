using SDK = DocuWare.Platform.ServerClient;
using DocuWare.Platform.ServerClient.Abstracts.Content;
using DocuWare.Platform.ServerClient.Abstracts.Policy.CircuitBreaker;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Resilience;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Retry;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class TasksQuery(SDK.TasksQuery obj) : ITasksQuery
    {
        internal SDK.TasksQuery Obj { get; } = obj;

        public List<string> Instances
        {
            get => Obj.Instances;
            set => Obj.Instances = value;
        }

        public List<IColumnSortOrder> SortOrder
        {
            get => Obj.SortOrder.Select(x => new ColumnSortOrder(x) as IColumnSortOrder).ToList();
            set => Obj.SortOrder = value.Select(x => ((ColumnSortOrder)x).Obj).ToList();
        }

        public List<ITaskExpressionCondition> TaskExpressionCondition
        {
            get => Obj.TaskExpressionCondition.Select(x => new TaskExpressionCondition(x) as ITaskExpressionCondition).ToList();
            set => Obj.TaskExpressionCondition = value.Select(x => ((TaskExpressionCondition)x).Obj).ToList();
        }

        public int Start
        {
            get => Obj.Start;
            set => Obj.Start = value;
        }

        public int Count
        {
            get => Obj.Count;
            set => Obj.Count = value;
        }

        public bool RemoveLinks
        {
            get => Obj.RemoveLinks;
            set => Obj.RemoveLinks = value;
        }

        public TaskExpressionOperation Operation
        {
            get => (TaskExpressionOperation)Obj.Operation;
            set => Obj.Operation = (DocuWare.Platform.ServerClient.TaskExpressionOperation)value;
        }
    }
}
