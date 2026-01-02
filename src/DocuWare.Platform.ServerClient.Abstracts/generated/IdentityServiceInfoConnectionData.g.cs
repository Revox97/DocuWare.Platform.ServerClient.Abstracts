using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class IdentityServiceInfoConnectionData(SDK.IdentityServiceInfoConnectionData obj) : IIdentityServiceInfoConnectionData
    {
        internal SDK.IdentityServiceInfoConnectionData Obj { get; } = obj;
    }
}
