using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class LobsterAttribute(DocuWare.Platform.ServerClient.LobsterAttribute obj) : ILobsterAttribute
    {
        internal DocuWare.Platform.ServerClient.LobsterAttribute Obj { get; } = obj;
    }
}
