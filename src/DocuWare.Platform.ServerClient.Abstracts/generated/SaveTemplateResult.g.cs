using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class SaveTemplateResult(DocuWare.Platform.ServerClient.SaveTemplateResult obj) : ISaveTemplateResult
    {
        internal DocuWare.Platform.ServerClient.SaveTemplateResult Obj { get; } = obj;
    }
}
