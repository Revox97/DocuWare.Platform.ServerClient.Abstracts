using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class TaskFormField(DocuWare.Platform.ServerClient.TaskFormField obj) : ITaskFormField
    {
        internal DocuWare.Platform.ServerClient.TaskFormField Obj { get; } = obj;

        public IBaseForm Item
        {
            get => new BaseForm(Obj.Item);
            set => Obj.Item = ((BaseForm)value).Obj;
        }
    }
}
