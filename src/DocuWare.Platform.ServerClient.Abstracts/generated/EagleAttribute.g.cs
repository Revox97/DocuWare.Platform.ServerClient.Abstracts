using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class EagleAttribute(SDK.EagleAttribute obj) : IEagleAttribute
    {
        internal SDK.EagleAttribute Obj { get; } = obj;
    }
}
