using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class IdentityServiceInfoConnectionData(DocuWare.Platform.ServerClient.IdentityServiceInfoConnectionData obj) : IIdentityServiceInfoConnectionData
    {
        internal DocuWare.Platform.ServerClient.IdentityServiceInfoConnectionData Obj { get; } = obj;
    }
}
