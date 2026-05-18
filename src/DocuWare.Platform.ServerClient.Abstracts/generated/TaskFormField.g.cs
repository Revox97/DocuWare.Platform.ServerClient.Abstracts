using SDK = DocuWare.Platform.ServerClient;
using DocuWare.Platform.ServerClient.Abstracts.Content;
using DocuWare.Platform.ServerClient.Abstracts.Policy.CircuitBreaker;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Resilience;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Retry;

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
