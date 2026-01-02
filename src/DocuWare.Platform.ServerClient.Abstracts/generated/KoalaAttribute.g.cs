using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class KoalaAttribute(SDK.KoalaAttribute obj) : IKoalaAttribute
    {
        internal SDK.KoalaAttribute Obj { get; } = obj;
    }
}
