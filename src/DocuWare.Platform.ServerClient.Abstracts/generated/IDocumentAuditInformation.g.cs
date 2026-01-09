using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IDocumentAuditInformation{3}
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
