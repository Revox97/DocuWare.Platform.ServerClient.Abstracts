using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class HawkAttribute(SDK.HawkAttribute obj) : IHawkAttribute
    {
        internal SDK.HawkAttribute Obj { get; } = obj;
    }
}
