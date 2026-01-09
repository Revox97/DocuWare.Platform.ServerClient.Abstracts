using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IDocumentAuditEvent{3}
    {
		Link[] Links { get; set; }

		void SetProxy(HttpClientProxy proxy);
		IDocumentAuditEventInformation GetDocumentAuditEventInformationFromAuditEventInformationRelation();
		Task<DeserializedHttpResponse<IDocumentAuditEventInformation>> GetDocumentAuditEventInformationFromAuditEventInformationRelationAsync();
		Task<DeserializedHttpResponse<IDocumentAuditEventInformation>> GetDocumentAuditEventInformationFromAuditEventInformationRelationAsync(CancellationToken cancellationToken);
    }
}
