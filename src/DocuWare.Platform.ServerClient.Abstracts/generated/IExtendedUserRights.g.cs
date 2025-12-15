using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IExtendedUserRights
    {
		bool AllowViewAuditData { get; set; }
    }
}
