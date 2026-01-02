using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class QuokkaAttribute(DocuWare.Platform.ServerClient.QuokkaAttribute obj) : IQuokkaAttribute
    {
        internal DocuWare.Platform.ServerClient.QuokkaAttribute Obj { get; } = obj;
    }
}
