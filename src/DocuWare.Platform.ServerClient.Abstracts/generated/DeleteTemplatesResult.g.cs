using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class DeleteTemplatesResult(SDK.DeleteTemplatesResult obj) : IDeleteTemplatesResult
    {
        internal SDK.DeleteTemplatesResult Obj { get; } = obj;
    }
}
