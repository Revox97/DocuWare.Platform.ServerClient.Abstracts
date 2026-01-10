using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IDocumentsQueryTableResult
    {
		ICountPlusValue Count { get; set; }
		List<ITableResultHeader> Headers { get; set; }
		List<ITableResultRow> Rows { get; set; }
		Link[] Links { get; set; }
		string FileCabinetId { get; set; }
		string OrganizationGuid { get; set; }
		DateTime TimeStamp { get; set; }

		void SetProxy(HttpClientProxy proxy);
		IDocumentsQueryTableResult GetDocumentsQueryTableResultFromNextRelation();
		Task<DeserializedHttpResponse<IDocumentsQueryTableResult>> GetDocumentsQueryTableResultFromNextRelationAsync();
		Task<DeserializedHttpResponse<IDocumentsQueryTableResult>> GetDocumentsQueryTableResultFromNextRelationAsync(CancellationToken cancellationToken);
		IDocumentsQueryTableResult GetDocumentsQueryTableResultFromPrevRelation();
		Task<DeserializedHttpResponse<IDocumentsQueryTableResult>> GetDocumentsQueryTableResultFromPrevRelationAsync();
		Task<DeserializedHttpResponse<IDocumentsQueryTableResult>> GetDocumentsQueryTableResultFromPrevRelationAsync(CancellationToken cancellationToken);
		IDocumentsQueryTableResult GetDocumentsQueryTableResultFromSelfRelation();
		Task<DeserializedHttpResponse<IDocumentsQueryTableResult>> GetDocumentsQueryTableResultFromSelfRelationAsync();
		Task<DeserializedHttpResponse<IDocumentsQueryTableResult>> GetDocumentsQueryTableResultFromSelfRelationAsync(CancellationToken cancellationToken);
		IDocumentsQueryTableResult GetDocumentsQueryTableResultFromFirstRelation();
		Task<DeserializedHttpResponse<IDocumentsQueryTableResult>> GetDocumentsQueryTableResultFromFirstRelationAsync();
		Task<DeserializedHttpResponse<IDocumentsQueryTableResult>> GetDocumentsQueryTableResultFromFirstRelationAsync(CancellationToken cancellationToken);
		XElementWrapper GetXElementWrapperFromFeedRelation();
		Task<DeserializedHttpResponse<XElementWrapper>> GetXElementWrapperFromFeedRelationAsync();
		Task<DeserializedHttpResponse<XElementWrapper>> GetXElementWrapperFromFeedRelationAsync(CancellationToken cancellationToken);
		IDocumentsQueryTableResult GetDocumentsQueryTableResultFromDownloadRelation();
		Task<DeserializedHttpResponse<IDocumentsQueryTableResult>> GetDocumentsQueryTableResultFromDownloadRelationAsync();
		Task<DeserializedHttpResponse<IDocumentsQueryTableResult>> GetDocumentsQueryTableResultFromDownloadRelationAsync(CancellationToken cancellationToken);
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
