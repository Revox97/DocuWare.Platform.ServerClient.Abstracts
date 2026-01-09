using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IDocumentsQueryResult{3}
    {
		List<IDocument> Items { get; set; }
		Link[] Links { get; set; }
		string Title { get; set; }
		string OrganizationGuid { get; set; }
		string FileCabinetId { get; set; }
		DateTime TimeStamp { get; set; }

		void SetProxy(HttpClientProxy proxy);
		IDocumentsQueryResult GetDocumentsQueryResultFromNextRelation();
		Task<DeserializedHttpResponse<IDocumentsQueryResult>> GetDocumentsQueryResultFromNextRelationAsync();
		Task<DeserializedHttpResponse<IDocumentsQueryResult>> GetDocumentsQueryResultFromNextRelationAsync(CancellationToken cancellationToken);
		IDocumentsQueryResult GetDocumentsQueryResultFromPrevRelation();
		Task<DeserializedHttpResponse<IDocumentsQueryResult>> GetDocumentsQueryResultFromPrevRelationAsync();
		Task<DeserializedHttpResponse<IDocumentsQueryResult>> GetDocumentsQueryResultFromPrevRelationAsync(CancellationToken cancellationToken);
		IDocumentsQueryResult GetDocumentsQueryResultFromSelfRelation();
		Task<DeserializedHttpResponse<IDocumentsQueryResult>> GetDocumentsQueryResultFromSelfRelationAsync();
		Task<DeserializedHttpResponse<IDocumentsQueryResult>> GetDocumentsQueryResultFromSelfRelationAsync(CancellationToken cancellationToken);
		IDocumentsQueryResult GetDocumentsQueryResultFromFirstRelation();
		Task<DeserializedHttpResponse<IDocumentsQueryResult>> GetDocumentsQueryResultFromFirstRelationAsync();
		Task<DeserializedHttpResponse<IDocumentsQueryResult>> GetDocumentsQueryResultFromFirstRelationAsync(CancellationToken cancellationToken);
		XElementWrapper GetXElementWrapperFromFeedRelation();
		Task<DeserializedHttpResponse<XElementWrapper>> GetXElementWrapperFromFeedRelationAsync();
		Task<DeserializedHttpResponse<XElementWrapper>> GetXElementWrapperFromFeedRelationAsync(CancellationToken cancellationToken);
		IDocumentsQueryResult GetDocumentsQueryResultFromDownloadRelation();
		Task<DeserializedHttpResponse<IDocumentsQueryResult>> GetDocumentsQueryResultFromDownloadRelationAsync();
		Task<DeserializedHttpResponse<IDocumentsQueryResult>> GetDocumentsQueryResultFromDownloadRelationAsync(CancellationToken cancellationToken);
		IBatchUpdateIndexFieldsResult PostToBatchUpdateRelationForBatchUpdateIndexFieldsResult(IBatchUpdateProcessData dataToSend);
		Task<DeserializedHttpResponse<IBatchUpdateIndexFieldsResult>> PostToBatchUpdateRelationForBatchUpdateIndexFieldsResultAsync(IBatchUpdateProcessData dataToSend);
		Task<DeserializedHttpResponse<IBatchUpdateIndexFieldsResult>> PostToBatchUpdateRelationForBatchUpdateIndexFieldsResultAsync(CancellationToken cancellationToken, IBatchUpdateProcessData dataToSend);
		IDialog PostToCreateUserDefinedSearchRelationForDialog(IUserDefinedSearchInfo dataToSend);
		Task<DeserializedHttpResponse<IDialog>> PostToCreateUserDefinedSearchRelationForDialogAsync(IUserDefinedSearchInfo dataToSend);
		Task<DeserializedHttpResponse<IDialog>> PostToCreateUserDefinedSearchRelationForDialogAsync(CancellationToken cancellationToken, IUserDefinedSearchInfo dataToSend);
		Stream PostToExportDocumentsRelationForStream(IExportSettings dataToSend);
		Task<DeserializedHttpResponse<Stream>> PostToExportDocumentsRelationForStreamAsync(IExportSettings dataToSend);
		Task<DeserializedHttpResponse<Stream>> PostToExportDocumentsRelationForStreamAsync(CancellationToken cancellationToken, IExportSettings dataToSend);
    }
}
