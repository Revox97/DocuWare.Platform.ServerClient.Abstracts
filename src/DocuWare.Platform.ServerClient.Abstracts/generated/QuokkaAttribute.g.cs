using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class QuokkaAttribute(SDK.QuokkaAttribute obj) : IQuokkaAttribute
    {
        internal SDK.QuokkaAttribute Obj { get; } = obj;
    }
}
