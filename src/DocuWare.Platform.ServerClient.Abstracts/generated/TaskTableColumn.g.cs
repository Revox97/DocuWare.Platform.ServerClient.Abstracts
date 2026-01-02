using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class TaskTableColumn(SDK.TaskTableColumn obj) : ITaskTableColumn
    {
        internal SDK.TaskTableColumn Obj { get; } = obj;

        public bool IsHidden
        {
            get => Obj.IsHidden;
            set => Obj.IsHidden = value;
        }
    }
}
