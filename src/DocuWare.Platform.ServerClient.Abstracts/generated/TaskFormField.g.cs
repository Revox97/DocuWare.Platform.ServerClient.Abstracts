using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class TaskFormField(SDK.TaskFormField obj) : ITaskFormField
    {
        internal SDK.TaskFormField Obj { get; } = obj;

        public IBaseForm Item
        {
            get => new BaseForm(Obj.Item);
            set => Obj.Item = ((BaseForm)value).Obj;
        }
    }
}
