using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class DocumentActionParameters(DocuWare.Platform.ServerClient.DocumentActionParameters obj) : IDocumentActionParameters
    {
        internal DocuWare.Platform.ServerClient.DocumentActionParameters Obj { get; } = obj;
    }
}
