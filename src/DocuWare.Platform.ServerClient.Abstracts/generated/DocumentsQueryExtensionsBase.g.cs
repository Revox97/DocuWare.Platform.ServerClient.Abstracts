using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class DocumentsQueryExtensionsBase(SDK.DocumentsQueryExtensionsBase obj) : IDocumentsQueryExtensionsBase
    {
        internal SDK.DocumentsQueryExtensionsBase Obj { get; } = obj;
    }
}
