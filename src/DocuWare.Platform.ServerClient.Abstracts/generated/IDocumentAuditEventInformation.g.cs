using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IDocumentAuditEventInformation
    {
		List<IDocumentAuditEventProperty> DocumentAuditEventProperties { get; set; }
		List<IDocumentAuditEventTableProperty> DocumentAuditEventTableProperties { get; set; }
    }
}
