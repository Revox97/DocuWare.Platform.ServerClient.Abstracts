using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class Zone(SDK.Zone obj) : IZone
    {
        internal SDK.Zone Obj { get; } = obj;
    }
}
