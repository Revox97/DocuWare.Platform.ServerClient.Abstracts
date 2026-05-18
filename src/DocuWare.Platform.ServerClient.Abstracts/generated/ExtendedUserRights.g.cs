using SDK = DocuWare.Platform.ServerClient;
using DocuWare.Platform.ServerClient.Abstracts.Content;
using DocuWare.Platform.ServerClient.Abstracts.Policy.CircuitBreaker;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Resilience;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Retry;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class ExtendedUserRights(SDK.ExtendedUserRights obj) : IExtendedUserRights
    {
        internal SDK.ExtendedUserRights Obj { get; } = obj;

        public bool AllowViewAuditData
        {
            get => Obj.AllowViewAuditData;
            set => Obj.AllowViewAuditData = value;
        }
    }
}
