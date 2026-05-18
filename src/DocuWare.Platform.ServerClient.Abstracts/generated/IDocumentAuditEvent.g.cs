using DocuWare.Platform.ServerClient;
using DocuWare.Platform.ServerClient.Abstracts.Content;
using DocuWare.Platform.ServerClient.Abstracts.Policy.CircuitBreaker;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Resilience;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Retry;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IDocumentAuditEvent
    {
		IAuditEvent AuditEvent { get; set; }
		Link[] Links { get; set; }

		void SetProxy(HttpClientProxy proxy);
		IDocumentAuditEventInformation GetDocumentAuditEventInformationFromAuditEventInformationRelation();
		Task<DeserializedHttpResponse<IDocumentAuditEventInformation>> GetDocumentAuditEventInformationFromAuditEventInformationRelationAsync();
		Task<DeserializedHttpResponse<IDocumentAuditEventInformation>> GetDocumentAuditEventInformationFromAuditEventInformationRelationAsync(CancellationToken cancellationToken);
    }
}
