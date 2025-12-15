using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class SaveTemplateResult(SDK.SaveTemplateResult obj) : ISaveTemplateResult
    {
        internal SDK.SaveTemplateResult Obj { get; } = obj;
    }
}
