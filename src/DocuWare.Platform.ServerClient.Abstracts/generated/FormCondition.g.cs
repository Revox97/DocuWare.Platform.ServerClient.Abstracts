using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class FormCondition(SDK.FormCondition obj) : IFormCondition
    {
        internal SDK.FormCondition Obj { get; } = obj;
    }
}
