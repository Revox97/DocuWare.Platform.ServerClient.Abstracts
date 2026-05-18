using DocuWare.Platform.ServerClient;
using DocuWare.Platform.ServerClient.Abstracts.Content;
using DocuWare.Platform.ServerClient.Abstracts.Policy.CircuitBreaker;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Resilience;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Retry;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IDocumentAuditEventInformation
    {
		List<IDocumentAuditEventProperty> DocumentAuditEventProperties { get; set; }
		List<IDocumentAuditEventTableProperty> DocumentAuditEventTableProperties { get; set; }
    }
}
