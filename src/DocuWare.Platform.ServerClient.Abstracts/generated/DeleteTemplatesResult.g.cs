using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class DeleteTemplatesResult(DocuWare.Platform.ServerClient.DeleteTemplatesResult obj) : IDeleteTemplatesResult
    {
        internal DocuWare.Platform.ServerClient.DeleteTemplatesResult Obj { get; } = obj;
    }
}
