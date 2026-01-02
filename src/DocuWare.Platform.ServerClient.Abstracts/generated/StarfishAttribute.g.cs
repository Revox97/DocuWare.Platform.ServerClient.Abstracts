using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class StarfishAttribute(SDK.StarfishAttribute obj) : IStarfishAttribute
    {
        internal SDK.StarfishAttribute Obj { get; } = obj;
    }
}
