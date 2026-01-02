using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class NumbatAttribute(DocuWare.Platform.ServerClient.NumbatAttribute obj) : INumbatAttribute
    {
        internal DocuWare.Platform.ServerClient.NumbatAttribute Obj { get; } = obj;
    }
}
