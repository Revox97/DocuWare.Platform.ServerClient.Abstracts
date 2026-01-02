using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class NumbatAttribute(SDK.NumbatAttribute obj) : INumbatAttribute
    {
        internal SDK.NumbatAttribute Obj { get; } = obj;
    }
}
