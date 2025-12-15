using SDK = DocuWare.Platform.ServerClient;

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
