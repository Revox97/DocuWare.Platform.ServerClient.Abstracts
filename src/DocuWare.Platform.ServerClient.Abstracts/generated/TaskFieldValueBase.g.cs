using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class TaskFieldValueBase(SDK.TaskFieldValueBase obj) : ITaskFieldValueBase
    {
        internal SDK.TaskFieldValueBase Obj { get; } = obj;

        public object Item
        {
            get => Obj.Item;
            set => Obj.Item = value;
        }

        public DocuWare.Platform.ServerClient.ItemChoiceType1 ItemElementName
        {
            get => Obj.ItemElementName;
            set => Obj.ItemElementName = value;
        }
    }
}
