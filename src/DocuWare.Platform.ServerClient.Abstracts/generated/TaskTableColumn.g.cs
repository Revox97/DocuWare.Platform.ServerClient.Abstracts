using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class TaskTableColumn(DocuWare.Platform.ServerClient.TaskTableColumn obj) : ITaskTableColumn
    {
        internal DocuWare.Platform.ServerClient.TaskTableColumn Obj { get; } = obj;

        public bool IsHidden
        {
            get => Obj.IsHidden;
            set => Obj.IsHidden = value;
        }
    }
}
