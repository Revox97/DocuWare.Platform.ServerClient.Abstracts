using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class IdentityServiceInfo(SDK.IdentityServiceInfo obj) : IIdentityServiceInfo
    {
        internal SDK.IdentityServiceInfo Obj { get; } = obj;
    }
}
