using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class RaccoonAttribute(SDK.RaccoonAttribute obj) : IRaccoonAttribute
    {
        internal SDK.RaccoonAttribute Obj { get; } = obj;
    }
}
