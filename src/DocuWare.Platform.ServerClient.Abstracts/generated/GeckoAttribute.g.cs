using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class GeckoAttribute(DocuWare.Platform.ServerClient.GeckoAttribute obj) : IGeckoAttribute
    {
        internal DocuWare.Platform.ServerClient.GeckoAttribute Obj { get; } = obj;
    }
}
