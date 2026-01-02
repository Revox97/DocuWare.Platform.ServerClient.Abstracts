using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class ExtendedUserRights(DocuWare.Platform.ServerClient.ExtendedUserRights obj) : IExtendedUserRights
    {
        internal DocuWare.Platform.ServerClient.ExtendedUserRights Obj { get; } = obj;

        public bool AllowViewAuditData
        {
            get => Obj.AllowViewAuditData;
            set => Obj.AllowViewAuditData = value;
        }
    }
}
