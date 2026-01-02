using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class CopyTemplateInput(DocuWare.Platform.ServerClient.CopyTemplateInput obj) : ICopyTemplateInput
    {
        internal DocuWare.Platform.ServerClient.CopyTemplateInput Obj { get; } = obj;

        public string TemplateGUID
        {
            get => Obj.TemplateGUID;
            set => Obj.TemplateGUID = value;
        }
    }
}
