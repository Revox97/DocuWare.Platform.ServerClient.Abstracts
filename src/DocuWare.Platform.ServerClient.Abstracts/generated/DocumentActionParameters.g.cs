using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class DocumentActionParameters(SDK.DocumentActionParameters obj) : IDocumentActionParameters
    {
        internal SDK.DocumentActionParameters Obj { get; } = obj;
    }
}
