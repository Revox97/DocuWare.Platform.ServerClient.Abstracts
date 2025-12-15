using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class CopyTemplateResult(SDK.CopyTemplateResult obj) : ICopyTemplateResult
    {
        internal SDK.CopyTemplateResult Obj { get; } = obj;

        public string TemplateGUID
        {
            get => Obj.TemplateGUID;
            set => Obj.TemplateGUID = value;
        }
    }
}
