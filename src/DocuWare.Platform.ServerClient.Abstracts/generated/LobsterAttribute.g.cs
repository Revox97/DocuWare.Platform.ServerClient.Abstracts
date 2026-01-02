using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class LobsterAttribute(SDK.LobsterAttribute obj) : ILobsterAttribute
    {
        internal SDK.LobsterAttribute Obj { get; } = obj;
    }
}
