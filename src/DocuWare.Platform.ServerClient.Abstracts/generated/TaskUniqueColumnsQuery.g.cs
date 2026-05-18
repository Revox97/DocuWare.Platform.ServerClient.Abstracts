using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class TaskUniqueColumnsQuery(DocuWare.Platform.ServerClient.TaskUniqueColumnsQuery obj) : ITaskUniqueColumnsQuery
    {
        internal DocuWare.Platform.ServerClient.TaskUniqueColumnsQuery Obj { get; } = obj;

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

        public TaskExpressionOperation Operation
        {
            get => (TaskExpressionOperation)Obj.Operation;
            set => Obj.Operation = (DocuWare.Platform.ServerClient.TaskExpressionOperation)value;
        }
    }
}
