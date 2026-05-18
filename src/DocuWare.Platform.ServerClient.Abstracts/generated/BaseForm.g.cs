using SDK = DocuWare.Platform.ServerClient;
using DocuWare.Platform.ServerClient.Abstracts.Content;
using DocuWare.Platform.ServerClient.Abstracts.Policy.CircuitBreaker;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Resilience;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Retry;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class BaseForm(SDK.BaseForm obj) : IBaseForm
    {
        internal SDK.BaseForm Obj { get; } = obj;

        public FormTypeEnum FormFieldType
        {
            get => (FormTypeEnum)Obj.FormFieldType;
            set => Obj.FormFieldType = (DocuWare.Platform.ServerClient.FormTypeEnum)value;
        }

        public string Label
        {
            get => Obj.Label;
            set => Obj.Label = value;
        }

        public int Id
        {
            get => Obj.Id;
            set => Obj.Id = value;
        }
    }
}
