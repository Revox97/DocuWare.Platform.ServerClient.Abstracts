using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class DocumentIndexFieldExtensions(DocuWare.Platform.ServerClient.DocumentIndexFieldExtensions obj) : IDocumentIndexFieldExtensions
    {
        internal DocuWare.Platform.ServerClient.DocumentIndexFieldExtensions Obj { get; } = obj;
    }
}
