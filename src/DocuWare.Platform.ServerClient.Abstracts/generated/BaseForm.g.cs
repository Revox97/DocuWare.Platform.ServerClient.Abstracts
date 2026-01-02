using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class BaseForm(DocuWare.Platform.ServerClient.BaseForm obj) : IBaseForm
    {
        internal DocuWare.Platform.ServerClient.BaseForm Obj { get; } = obj;

        public DocuWare.Platform.ServerClient.FormTypeEnum FormFieldType
        {
            get => Obj.FormFieldType;
            set => Obj.FormFieldType = value;
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
