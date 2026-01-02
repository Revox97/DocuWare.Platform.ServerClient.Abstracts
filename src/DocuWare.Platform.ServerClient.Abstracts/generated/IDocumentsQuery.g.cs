using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IDocumentsQuery
    {
		bool ForceRefresh { get; set; }
		List<string> Fields { get; set; }
		List<ISortedField> SortOrder { get; set; }
		Link[] Links { get; set; }
		bool ExcludeSystemFields { get; set; }
		bool IncludeSuggestions { get; set; }
		bool CalculateTotalCount { get; set; }

		void SetProxy(HttpClientProxy proxy);
		IDocumentsQueryResult GetDocumentsQueryResultFromResultRelation();
		Task<DeserializedHttpResponse<IDocumentsQueryResult>> GetDocumentsQueryResultFromResultRelationAsync();
		Task<DeserializedHttpResponse<IDocumentsQueryResult>> GetDocumentsQueryResultFromResultRelationAsync(CancellationToken cancellationToken);
		IDocumentsQueryResult PostToDialogExpressionRelationForDocumentsQueryResult(IDialogExpression dataToSend);
		Task<DeserializedHttpResponse<IDocumentsQueryResult>> PostToDialogExpressionRelationForDocumentsQueryResultAsync(IDialogExpression dataToSend);
		Task<DeserializedHttpResponse<IDocumentsQueryResult>> PostToDialogExpressionRelationForDocumentsQueryResultAsync(CancellationToken cancellationToken, IDialogExpression dataToSend);
		IDocumentsQueryTableResult GetDocumentsQueryTableResultFromTableResultRelation();
		Task<DeserializedHttpResponse<IDocumentsQueryTableResult>> GetDocumentsQueryTableResultFromTableResultRelationAsync();
		Task<DeserializedHttpResponse<IDocumentsQueryTableResult>> GetDocumentsQueryTableResultFromTableResultRelationAsync(CancellationToken cancellationToken);
		IDocumentsQueryTableResult PostToTableDialogExpressionRelationForDocumentsQueryTableResult(IDialogExpression dataToSend);
		Task<DeserializedHttpResponse<IDocumentsQueryTableResult>> PostToTableDialogExpressionRelationForDocumentsQueryTableResultAsync(IDialogExpression dataToSend);
		Task<DeserializedHttpResponse<IDocumentsQueryTableResult>> PostToTableDialogExpressionRelationForDocumentsQueryTableResultAsync(CancellationToken cancellationToken, IDialogExpression dataToSend);
		ISelectListResult PostToIdsResultRelationForSelectListResult(ISelectListExpression dataToSend);
		Task<DeserializedHttpResponse<ISelectListResult>> PostToIdsResultRelationForSelectListResultAsync(ISelectListExpression dataToSend);
		Task<DeserializedHttpResponse<ISelectListResult>> PostToIdsResultRelationForSelectListResultAsync(CancellationToken cancellationToken, ISelectListExpression dataToSend);
		IBatchUpdateIndexFieldsResult PostToBatchUpdateRelationForBatchUpdateIndexFieldsResult(IBatchUpdateProcess dataToSend);
		Task<DeserializedHttpResponse<IBatchUpdateIndexFieldsResult>> PostToBatchUpdateRelationForBatchUpdateIndexFieldsResultAsync(IBatchUpdateProcess dataToSend);
		Task<DeserializedHttpResponse<IBatchUpdateIndexFieldsResult>> PostToBatchUpdateRelationForBatchUpdateIndexFieldsResultAsync(CancellationToken cancellationToken, IBatchUpdateProcess dataToSend);
    }
}
