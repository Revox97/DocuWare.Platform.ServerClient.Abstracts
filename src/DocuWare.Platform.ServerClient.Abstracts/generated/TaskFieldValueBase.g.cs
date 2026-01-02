using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class TaskFieldValueBase(DocuWare.Platform.ServerClient.TaskFieldValueBase obj) : ITaskFieldValueBase
    {
        internal DocuWare.Platform.ServerClient.TaskFieldValueBase Obj { get; } = obj;

        public object Item
        {
            get => Obj.Item;
            set => Obj.Item = value;
        }
    }
}
