using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class MinimalVersionAttribute(SDK.MinimalVersionAttribute obj) : IMinimalVersionAttribute
    {
        internal SDK.MinimalVersionAttribute Obj { get; } = obj;
    }
}
