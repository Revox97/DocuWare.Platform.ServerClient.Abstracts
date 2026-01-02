using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class DocumentsQueryExtensionsBase(DocuWare.Platform.ServerClient.DocumentsQueryExtensionsBase obj) : IDocumentsQueryExtensionsBase
    {
        internal DocuWare.Platform.ServerClient.DocumentsQueryExtensionsBase Obj { get; } = obj;
    }
}
