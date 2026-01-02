using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class ImpalaAttribute(SDK.ImpalaAttribute obj) : IImpalaAttribute
    {
        internal SDK.ImpalaAttribute Obj { get; } = obj;
    }
}
