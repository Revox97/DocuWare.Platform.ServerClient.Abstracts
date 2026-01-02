using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class FoxAttribute(SDK.FoxAttribute obj) : IFoxAttribute
    {
        internal SDK.FoxAttribute Obj { get; } = obj;
    }
}
