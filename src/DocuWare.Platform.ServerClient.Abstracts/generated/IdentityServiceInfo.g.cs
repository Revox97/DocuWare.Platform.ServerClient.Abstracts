using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class IdentityServiceInfo(DocuWare.Platform.ServerClient.IdentityServiceInfo obj) : IIdentityServiceInfo
    {
        internal DocuWare.Platform.ServerClient.IdentityServiceInfo Obj { get; } = obj;
    }
}
