using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class Position(SDK.Position obj) : IPosition
    {
        internal SDK.Position Obj { get; } = obj;
    }
}
