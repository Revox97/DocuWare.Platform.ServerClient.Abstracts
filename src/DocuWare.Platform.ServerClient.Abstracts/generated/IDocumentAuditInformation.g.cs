using DocuWare.Platform.ServerClient;
using DocuWare.Platform.ServerClient.Abstracts.Content;
using DocuWare.Platform.ServerClient.Abstracts.Policy.CircuitBreaker;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Resilience;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Retry;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IDocumentAuditInformation
    {
		List<IDocumentAuditEvent> Events { get; set; }
		Link[] Links { get; set; }

		void SetProxy(HttpClientProxy proxy);
		IDocumentAuditInformation GetDocumentAuditInformationFromNextRelation();
		Task<DeserializedHttpResponse<IDocumentAuditInformation>> GetDocumentAuditInformationFromNextRelationAsync();
		Task<DeserializedHttpResponse<IDocumentAuditInformation>> GetDocumentAuditInformationFromNextRelationAsync(CancellationToken cancellationToken);
		IDocumentAuditInformation GetDocumentAuditInformationFromPrevRelation();
		Task<DeserializedHttpResponse<IDocumentAuditInformation>> GetDocumentAuditInformationFromPrevRelationAsync();
		Task<DeserializedHttpResponse<IDocumentAuditInformation>> GetDocumentAuditInformationFromPrevRelationAsync(CancellationToken cancellationToken);
		IDocumentAuditInformation GetDocumentAuditInformationFromFirstRelation();
		Task<DeserializedHttpResponse<IDocumentAuditInformation>> GetDocumentAuditInformationFromFirstRelationAsync();
		Task<DeserializedHttpResponse<IDocumentAuditInformation>> GetDocumentAuditInformationFromFirstRelationAsync(CancellationToken cancellationToken);
    }
}
