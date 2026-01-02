using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class Position(DocuWare.Platform.ServerClient.Position obj) : IPosition
    {
        internal DocuWare.Platform.ServerClient.Position Obj { get; } = obj;
    }
}
