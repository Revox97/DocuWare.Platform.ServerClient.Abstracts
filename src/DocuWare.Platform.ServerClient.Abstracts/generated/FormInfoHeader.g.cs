using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class FormInfoHeader(SDK.FormInfoHeader obj) : IFormInfoHeader
    {
        internal SDK.FormInfoHeader Obj { get; } = obj;
    }
}
