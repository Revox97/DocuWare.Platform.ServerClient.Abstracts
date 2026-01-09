using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IDocumentLink
    {
		Link[] Links { get; set; }
		string Id { get; set; }
		string Name { get; set; }
		bool IsInvalid { get; set; }
		string TargetFileCabinet { get; set; }
		string TargetResultList { get; set; }

		void SetProxy(HttpClientProxy proxy);
		IDocumentsQueryResult GetDocumentsQueryResultFromResultRelation();
		Task<DeserializedHttpResponse<IDocumentsQueryResult>> GetDocumentsQueryResultFromResultRelationAsync();
		Task<DeserializedHttpResponse<IDocumentsQueryResult>> GetDocumentsQueryResultFromResultRelationAsync(CancellationToken cancellationToken);
		IDocumentsQueryResult PostToResultRelationForDocumentsQueryResult(IResultListQuery dataToSend);
		Task<DeserializedHttpResponse<IDocumentsQueryResult>> PostToResultRelationForDocumentsQueryResultAsync(IResultListQuery dataToSend);
		Task<DeserializedHttpResponse<IDocumentsQueryResult>> PostToResultRelationForDocumentsQueryResultAsync(CancellationToken cancellationToken, IResultListQuery dataToSend);
		IDocumentsQueryResult PostToResultRelationForDocumentsQueryResult(IDocumentLinkExpressionQuery dataToSend);
		Task<DeserializedHttpResponse<IDocumentsQueryResult>> PostToResultRelationForDocumentsQueryResultAsync(IDocumentLinkExpressionQuery dataToSend);
		Task<DeserializedHttpResponse<IDocumentsQueryResult>> PostToResultRelationForDocumentsQueryResultAsync(CancellationToken cancellationToken, IDocumentLinkExpressionQuery dataToSend);
		IDialog GetDialogFromResultDialogRelation();
		Task<DeserializedHttpResponse<IDialog>> GetDialogFromResultDialogRelationAsync();
		Task<DeserializedHttpResponse<IDialog>> GetDialogFromResultDialogRelationAsync(CancellationToken cancellationToken);
    }
}
