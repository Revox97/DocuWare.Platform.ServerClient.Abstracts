using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class Zone(DocuWare.Platform.ServerClient.Zone obj) : IZone
    {
        internal DocuWare.Platform.ServerClient.Zone Obj { get; } = obj;
    }
}
