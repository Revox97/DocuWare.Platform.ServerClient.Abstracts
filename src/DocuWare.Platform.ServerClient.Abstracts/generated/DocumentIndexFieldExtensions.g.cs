using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class DocumentIndexFieldExtensions(SDK.DocumentIndexFieldExtensions obj) : IDocumentIndexFieldExtensions
    {
        internal SDK.DocumentIndexFieldExtensions Obj { get; } = obj;
    }
}
