using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class TaskTableColumnBase(DocuWare.Platform.ServerClient.TaskTableColumnBase obj) : ITaskTableColumnBase
    {
        internal DocuWare.Platform.ServerClient.TaskTableColumnBase Obj { get; } = obj;

        public ICommonFormField Item
        {
            get => new CommonFormField(Obj.Item);
            set => Obj.Item = ((CommonFormField)value).Obj;
        }
    }
}
