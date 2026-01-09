using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IFileCabinet{3}
    {
		Link[] Links { get; set; }
		List<IFileCabinetField> Fields { get; set; }
		string Color { get; set; }
		string Name { get; set; }
		string Id { get; set; }
		bool IsBasket { get; set; }
		bool Usable { get; set; }
		bool Default { get; set; }
		string AssignedCabinetId { get; set; }
		string IntellixDialogId { get; set; }
		VersionManagementMode VersionManagement { get; set; }
		string VersionHistoryResultListId { get; set; }
		bool WindowsExplorerClientAccess { get; set; }
		bool AddIndexEntriesInUpperCase { get; set; }
		bool DocumentAuditingEnabled { get; set; }
		bool HasFullTextSupport { get; set; }

		void SetProxy(HttpClientProxy proxy);
		IDocumentsQueryResult GetDocumentsQueryResultFromDocumentsRelation();
		Task<DeserializedHttpResponse<IDocumentsQueryResult>> GetDocumentsQueryResultFromDocumentsRelationAsync();
		Task<DeserializedHttpResponse<IDocumentsQueryResult>> GetDocumentsQueryResultFromDocumentsRelationAsync(CancellationToken cancellationToken);
		IDocument PostToDocumentsRelationForDocument(IDocument dataToSend);
		Task<DeserializedHttpResponse<IDocument>> PostToDocumentsRelationForDocumentAsync(IDocument dataToSend);
		Task<DeserializedHttpResponse<IDocument>> PostToDocumentsRelationForDocumentAsync(CancellationToken cancellationToken, IDocument dataToSend);
		IDocumentsQueryTableResult GetDocumentsQueryTableResultFromDocumentsTableRelation();
		Task<DeserializedHttpResponse<IDocumentsQueryTableResult>> GetDocumentsQueryTableResultFromDocumentsTableRelationAsync();
		Task<DeserializedHttpResponse<IDocumentsQueryTableResult>> GetDocumentsQueryTableResultFromDocumentsTableRelationAsync(CancellationToken cancellationToken);
		IDocument PutToContentMergeOperationRelationForDocument(IContentMergeOperationInfo dataToSend);
		Task<DeserializedHttpResponse<IDocument>> PutToContentMergeOperationRelationForDocumentAsync(IContentMergeOperationInfo dataToSend);
		Task<DeserializedHttpResponse<IDocument>> PutToContentMergeOperationRelationForDocumentAsync(CancellationToken cancellationToken, IContentMergeOperationInfo dataToSend);
		IDocument PostToAdvancedDocumentUploadRelationForDocument(string requestedContentType, Stream dataToSend);
		Task<DeserializedHttpResponse<IDocument>> PostToAdvancedDocumentUploadRelationForDocumentAsync(string requestedContentType, Stream dataToSend);
		Task<DeserializedHttpResponse<IDocument>> PostToAdvancedDocumentUploadRelationForDocumentAsync(CancellationToken cancellationToken, string requestedContentType, Stream dataToSend);
		IImportResult PostToImportDocumentsRelationForImportResult(IImportSettings dataToSend);
		Task<DeserializedHttpResponse<IImportResult>> PostToImportDocumentsRelationForImportResultAsync(IImportSettings dataToSend);
		Task<DeserializedHttpResponse<IImportResult>> PostToImportDocumentsRelationForImportResultAsync(CancellationToken cancellationToken, IImportSettings dataToSend);
		IImportResult PostToImportDocumentsRelationForImportResult(ISynchronizationSettings dataToSend);
		Task<DeserializedHttpResponse<IImportResult>> PostToImportDocumentsRelationForImportResultAsync(ISynchronizationSettings dataToSend);
		Task<DeserializedHttpResponse<IImportResult>> PostToImportDocumentsRelationForImportResultAsync(CancellationToken cancellationToken, ISynchronizationSettings dataToSend);
		IDocument PostToUnprocessedDocumentUploadRelationForDocument(string requestedContentType, Stream dataToSend);
		Task<DeserializedHttpResponse<IDocument>> PostToUnprocessedDocumentUploadRelationForDocumentAsync(string requestedContentType, Stream dataToSend);
		Task<DeserializedHttpResponse<IDocument>> PostToUnprocessedDocumentUploadRelationForDocumentAsync(CancellationToken cancellationToken, string requestedContentType, Stream dataToSend);
		IDocumentsQueryTableResult GetDocumentsQueryTableResultFromQueryRelation();
		Task<DeserializedHttpResponse<IDocumentsQueryTableResult>> GetDocumentsQueryTableResultFromQueryRelationAsync();
		Task<DeserializedHttpResponse<IDocumentsQueryTableResult>> GetDocumentsQueryTableResultFromQueryRelationAsync(CancellationToken cancellationToken);
		IDocumentsQueryResult GetDocumentsQueryResultFromQueryRelation();
		Task<DeserializedHttpResponse<IDocumentsQueryResult>> GetDocumentsQueryResultFromQueryRelationAsync();
		Task<DeserializedHttpResponse<IDocumentsQueryResult>> GetDocumentsQueryResultFromQueryRelationAsync(CancellationToken cancellationToken);
		IDocumentsQueryResult PostToQueryRelationForDocumentsQueryResult(IFunctionExpressionQuery dataToSend);
		Task<DeserializedHttpResponse<IDocumentsQueryResult>> PostToQueryRelationForDocumentsQueryResultAsync(IFunctionExpressionQuery dataToSend);
		Task<DeserializedHttpResponse<IDocumentsQueryResult>> PostToQueryRelationForDocumentsQueryResultAsync(CancellationToken cancellationToken, IFunctionExpressionQuery dataToSend);
		IDocumentsQueryTableResult PostToQueryRelationForDocumentsQueryTableResult(IFunctionExpressionQuery dataToSend);
		Task<DeserializedHttpResponse<IDocumentsQueryTableResult>> PostToQueryRelationForDocumentsQueryTableResultAsync(IFunctionExpressionQuery dataToSend);
		Task<DeserializedHttpResponse<IDocumentsQueryTableResult>> PostToQueryRelationForDocumentsQueryTableResultAsync(CancellationToken cancellationToken, IFunctionExpressionQuery dataToSend);
		IDialogInfos GetDialogInfosFromDialogsRelation();
		Task<DeserializedHttpResponse<IDialogInfos>> GetDialogInfosFromDialogsRelationAsync();
		Task<DeserializedHttpResponse<IDialogInfos>> GetDialogInfosFromDialogsRelationAsync(CancellationToken cancellationToken);
		IDialogInfos GetDialogInfosFromSearchesRelation();
		Task<DeserializedHttpResponse<IDialogInfos>> GetDialogInfosFromSearchesRelationAsync();
		Task<DeserializedHttpResponse<IDialogInfos>> GetDialogInfosFromSearchesRelationAsync(CancellationToken cancellationToken);
		IDialog GetDialogFromCustomSearchRelation();
		Task<DeserializedHttpResponse<IDialog>> GetDialogFromCustomSearchRelationAsync();
		Task<DeserializedHttpResponse<IDialog>> GetDialogFromCustomSearchRelationAsync(CancellationToken cancellationToken);
		IDialogInfos GetDialogInfosFromResultTreesRelation();
		Task<DeserializedHttpResponse<IDialogInfos>> GetDialogInfosFromResultTreesRelationAsync();
		Task<DeserializedHttpResponse<IDialogInfos>> GetDialogInfosFromResultTreesRelationAsync(CancellationToken cancellationToken);
		IDialogInfos GetDialogInfosFromStoresRelation();
		Task<DeserializedHttpResponse<IDialogInfos>> GetDialogInfosFromStoresRelationAsync();
		Task<DeserializedHttpResponse<IDialogInfos>> GetDialogInfosFromStoresRelationAsync(CancellationToken cancellationToken);
		IDialogInfos GetDialogInfosFromTaskListsRelation();
		Task<DeserializedHttpResponse<IDialogInfos>> GetDialogInfosFromTaskListsRelationAsync();
		Task<DeserializedHttpResponse<IDialogInfos>> GetDialogInfosFromTaskListsRelationAsync(CancellationToken cancellationToken);
		IFileCabinet GetFileCabinetFromSelfRelation();
		Task<DeserializedHttpResponse<IFileCabinet>> GetFileCabinetFromSelfRelationAsync();
		Task<DeserializedHttpResponse<IFileCabinet>> GetFileCabinetFromSelfRelationAsync(CancellationToken cancellationToken);
		IStamps GetStampsFromStampsRelation();
		Task<DeserializedHttpResponse<IStamps>> GetStampsFromStampsRelationAsync();
		Task<DeserializedHttpResponse<IStamps>> GetStampsFromStampsRelationAsync(CancellationToken cancellationToken);
		INotifications GetNotificationsFromNotificationsRelation();
		Task<DeserializedHttpResponse<INotifications>> GetNotificationsFromNotificationsRelationAsync();
		Task<DeserializedHttpResponse<INotifications>> GetNotificationsFromNotificationsRelationAsync(CancellationToken cancellationToken);
		INotifications PostToNotificationsRelationForNotifications(INotifications dataToSend);
		Task<DeserializedHttpResponse<INotifications>> PostToNotificationsRelationForNotificationsAsync(INotifications dataToSend);
		Task<DeserializedHttpResponse<INotifications>> PostToNotificationsRelationForNotificationsAsync(CancellationToken cancellationToken, INotifications dataToSend);
		IDocumentsQueryResult PostToTransferRelationForDocumentsQueryResult(IFileCabinetTransferInfo dataToSend);
		Task<DeserializedHttpResponse<IDocumentsQueryResult>> PostToTransferRelationForDocumentsQueryResultAsync(IFileCabinetTransferInfo dataToSend);
		Task<DeserializedHttpResponse<IDocumentsQueryResult>> PostToTransferRelationForDocumentsQueryResultAsync(CancellationToken cancellationToken, IFileCabinetTransferInfo dataToSend);
		IDocumentsQueryResult PostToTransferRelationForDocumentsQueryResult(IDocumentsTransferInfo dataToSend);
		Task<DeserializedHttpResponse<IDocumentsQueryResult>> PostToTransferRelationForDocumentsQueryResultAsync(IDocumentsTransferInfo dataToSend);
		Task<DeserializedHttpResponse<IDocumentsQueryResult>> PostToTransferRelationForDocumentsQueryResultAsync(CancellationToken cancellationToken, IDocumentsTransferInfo dataToSend);
		IDialogInfo GetDialogInfoFromVersionHistoryResultListRelation();
		Task<DeserializedHttpResponse<IDialogInfo>> GetDialogInfoFromVersionHistoryResultListRelationAsync();
		Task<DeserializedHttpResponse<IDialogInfo>> GetDialogInfoFromVersionHistoryResultListRelationAsync(CancellationToken cancellationToken);
		IBatchUpdateIndexFieldsResult PostToBatchUpdateRelationForBatchUpdateIndexFieldsResult(IBatchUpdateProcess dataToSend);
		Task<DeserializedHttpResponse<IBatchUpdateIndexFieldsResult>> PostToBatchUpdateRelationForBatchUpdateIndexFieldsResultAsync(IBatchUpdateProcess dataToSend);
		Task<DeserializedHttpResponse<IBatchUpdateIndexFieldsResult>> PostToBatchUpdateRelationForBatchUpdateIndexFieldsResultAsync(CancellationToken cancellationToken, IBatchUpdateProcess dataToSend);
		IBatchUpdateIndexFieldsResult PostToBatchUpdateRelationForBatchUpdateIndexFieldsResult(IBatchAppendKeywordValues dataToSend);
		Task<DeserializedHttpResponse<IBatchUpdateIndexFieldsResult>> PostToBatchUpdateRelationForBatchUpdateIndexFieldsResultAsync(IBatchAppendKeywordValues dataToSend);
		Task<DeserializedHttpResponse<IBatchUpdateIndexFieldsResult>> PostToBatchUpdateRelationForBatchUpdateIndexFieldsResultAsync(CancellationToken cancellationToken, IBatchAppendKeywordValues dataToSend);
		IFieldValueStatisticsResult PostToFieldValueStatisticsRelationForFieldValueStatisticsResult(IFieldValueStatisticsExpression dataToSend);
		Task<DeserializedHttpResponse<IFieldValueStatisticsResult>> PostToFieldValueStatisticsRelationForFieldValueStatisticsResultAsync(IFieldValueStatisticsExpression dataToSend);
		Task<DeserializedHttpResponse<IFieldValueStatisticsResult>> PostToFieldValueStatisticsRelationForFieldValueStatisticsResultAsync(CancellationToken cancellationToken, IFieldValueStatisticsExpression dataToSend);
		Stream PostToReplicationDataRelationForStream(Stream dataToSend);
		Task<DeserializedHttpResponse<Stream>> PostToReplicationDataRelationForStreamAsync(Stream dataToSend);
		Task<DeserializedHttpResponse<Stream>> PostToReplicationDataRelationForStreamAsync(CancellationToken cancellationToken, Stream dataToSend);
		Stream PostToReplicationDeleteDataRelationForStream(Stream dataToSend);
		Task<DeserializedHttpResponse<Stream>> PostToReplicationDeleteDataRelationForStreamAsync(Stream dataToSend);
		Task<DeserializedHttpResponse<Stream>> PostToReplicationDeleteDataRelationForStreamAsync(CancellationToken cancellationToken, Stream dataToSend);
		string PostToSetupReplicationRelationForString(Stream dataToSend);
		Task<DeserializedHttpResponse<string>> PostToSetupReplicationRelationForStringAsync(Stream dataToSend);
		Task<DeserializedHttpResponse<string>> PostToSetupReplicationRelationForStringAsync(CancellationToken cancellationToken, Stream dataToSend);
		Stream GetStreamFromReplicationInfoRelation();
		Task<DeserializedHttpResponse<Stream>> GetStreamFromReplicationInfoRelationAsync();
		Task<DeserializedHttpResponse<Stream>> GetStreamFromReplicationInfoRelationAsync(CancellationToken cancellationToken);
		ISequenceResult PostToNextSequenceElementRelationForSequenceResult(ISequenceRequest dataToSend);
		Task<DeserializedHttpResponse<ISequenceResult>> PostToNextSequenceElementRelationForSequenceResultAsync(ISequenceRequest dataToSend);
		Task<DeserializedHttpResponse<ISequenceResult>> PostToNextSequenceElementRelationForSequenceResultAsync(CancellationToken cancellationToken, ISequenceRequest dataToSend);
    }
}
