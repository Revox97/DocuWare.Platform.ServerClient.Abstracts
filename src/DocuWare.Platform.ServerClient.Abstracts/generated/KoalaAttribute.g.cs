using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class KoalaAttribute(DocuWare.Platform.ServerClient.KoalaAttribute obj) : IKoalaAttribute
    {
        internal DocuWare.Platform.ServerClient.KoalaAttribute Obj { get; } = obj;
    }
}
