using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class LinkForm(DocuWare.Platform.ServerClient.LinkForm obj) : ILinkForm
    {
        internal DocuWare.Platform.ServerClient.LinkForm Obj { get; } = obj;

        public string Url
        {
            get => Obj.Url;
            set => Obj.Url = value;
        }

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
