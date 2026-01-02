using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class JellyfishAttribute(DocuWare.Platform.ServerClient.JellyfishAttribute obj) : IJellyfishAttribute
    {
        internal DocuWare.Platform.ServerClient.JellyfishAttribute Obj { get; } = obj;
    }
}
