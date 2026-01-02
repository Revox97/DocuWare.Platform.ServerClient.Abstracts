using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class CopyTemplateResult(DocuWare.Platform.ServerClient.CopyTemplateResult obj) : ICopyTemplateResult
    {
        internal DocuWare.Platform.ServerClient.CopyTemplateResult Obj { get; } = obj;

        public string TemplateGUID
        {
            get => Obj.TemplateGUID;
            set => Obj.TemplateGUID = value;
        }
    }
}
