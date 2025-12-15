using SDK = DocuWare.Platform.ServerClient;

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
    }
}
