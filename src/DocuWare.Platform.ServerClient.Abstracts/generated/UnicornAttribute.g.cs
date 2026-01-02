using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class UnicornAttribute(SDK.UnicornAttribute obj) : IUnicornAttribute
    {
        internal SDK.UnicornAttribute Obj { get; } = obj;
    }
}
