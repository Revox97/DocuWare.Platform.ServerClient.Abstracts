using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class TaskFieldValue(DocuWare.Platform.ServerClient.TaskFieldValue obj) : ITaskFieldValue
    {
        internal DocuWare.Platform.ServerClient.TaskFieldValue Obj { get; } = obj;

        public object Item
        {
            get => Obj.Item;
            set => Obj.Item = value;
        }
    }
}
