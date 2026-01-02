using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class DolphinAttribute(SDK.DolphinAttribute obj) : IDolphinAttribute
    {
        internal SDK.DolphinAttribute Obj { get; } = obj;
    }
}
