using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IDocument
    {
		string MediaType { get; }
		IDocumentIndexField Item { get; set; }
		List<IDocumentIndexField> Fields { get; set; }
		IChecksumInfo ChecksumInfo { get; set; }
		List<ISuggestionField> Suggestions { get; set; }
		List<ISuggestionTableField> TableFieldSuggestions { get; set; }
		IDocumentFlags Flags { get; set; }
		IDocumentVersion Version { get; set; }
		List<IDocumentContent> TextShot { get; set; }
		Link[] Links { get; set; }
		List<ISection> Sections { get; set; }
		XElementWrapper Preview { get; set; }
		string ContentType { get; set; }
		IUploadedFileChunk FileChunk { get; set; }
		List<IDocumentApplicationProperty> ApplicationProperties { get; set; }
		string FileCabinetId { get; set; }
		string OrganizationGuid { get; set; }
		bool HaveMoreTotalPages { get; set; }
		bool HasTextAnnotation { get; set; }
		bool HasXmlDigitalSignatures { get; set; }
		bool AnnotationsPreview { get; set; }
		int TotalPages { get; set; }
		int Id { get; set; }
		string Title { get; set; }
		DateTime LastModified { get; set; }
		bool LastModifiedSpecified { get; set; }
		DateTime CreatedAt { get; set; }
		bool CreatedAtSpecified { get; set; }
		long FileSize { get; set; }
		int SectionCount { get; set; }
		IntellixTrust IntellixTrust { get; set; }
		VersionManagementStatus VersionStatus { get; set; }
		string ExternalContentLocation { get; set; }
		string SelfRelationLink { get; }
		string ContentDivideOperationRelationLink { get; }
		string ClippedDocumentsRelationLink { get; }
		string UnclipRelationLink { get; }
		string PositionsRelationLink { get; }
		string LockRelationLink { get; }
		string ThumbnailRelationLink { get; }
		string ThumbnailWithoutAnnotationRelationLink { get; }
		string AnnotationAsSvgRelationLink { get; }
		string LowQualityImageRelationLink { get; }
		string DeepZoomImageRelationLink { get; }
		string DeepZoomImageWithAnnotationRelationLink { get; }
		string ResultListIconRelationLink { get; }
		string FieldsRelationLink { get; }
		string SuggestionsRelationLink { get; }
		string TableFieldsSuggestionsRelationLink { get; }
		string SectionsRelationLink { get; }
		string ContentRelationLink { get; }
		string FileDownloadRelationLink { get; }
		string TextAnnotationRelationLink { get; }
		string ChecksumStatusRelationLink { get; }
		string XmlDSigContentRelationLink { get; }
		string RightsRelationLink { get; }
		string ProcessDocumentActionRelationLink { get; }
		string AppPropertiesRelationLink { get; }
		string DocumentLinksRelationLink { get; }
		string LatestVersionRelationLink { get; }
		string VersionHistoryRelationLink { get; }
		string IntellixRelationLink { get; }
		string CheckoutDocumentRelationLink { get; }
		string CheckoutToFileSystemRelationLink { get; }
		string CheckInFromFileSystemRelationLink { get; }
		string DownloadAsArchiveRelationLink { get; }
		string AnnotationRelationLink { get; }
		string WorkflowHistoryRelationLink { get; }
		string AuditInformationRelationLink { get; }

		string ToString();
		void SetProxy(HttpClientProxy proxy);
		IDocument GetDocumentFromSelfRelation();
		Task<DeserializedHttpResponse<IDocument>> GetDocumentFromSelfRelationAsync();
		Task<DeserializedHttpResponse<IDocument>> GetDocumentFromSelfRelationAsync(CancellationToken cancellationToken);
		string DeleteSelfRelation();
		Task<DeserializedHttpResponse<string>> DeleteSelfRelationAsync();
		Task<DeserializedHttpResponse<string>> DeleteSelfRelationAsync(CancellationToken cancellationToken);
		IDocument PostToSelfRelationForDocument(string requestedContentType, Stream dataToSend);
		Task<DeserializedHttpResponse<IDocument>> PostToSelfRelationForDocumentAsync(string requestedContentType, Stream dataToSend);
		Task<DeserializedHttpResponse<IDocument>> PostToSelfRelationForDocumentAsync(CancellationToken cancellationToken, string requestedContentType, Stream dataToSend);
		IDocumentsQueryResult PutToContentDivideOperationRelationForDocumentsQueryResult(IContentDivideOperationInfo dataToSend);
		Task<DeserializedHttpResponse<IDocumentsQueryResult>> PutToContentDivideOperationRelationForDocumentsQueryResultAsync(IContentDivideOperationInfo dataToSend);
		Task<DeserializedHttpResponse<IDocumentsQueryResult>> PutToContentDivideOperationRelationForDocumentsQueryResultAsync(CancellationToken cancellationToken, IContentDivideOperationInfo dataToSend);
		IDocument PutToClippedDocumentsRelationForDocument(IIntegerList dataToSend);
		Task<DeserializedHttpResponse<IDocument>> PutToClippedDocumentsRelationForDocumentAsync(IIntegerList dataToSend);
		Task<DeserializedHttpResponse<IDocument>> PutToClippedDocumentsRelationForDocumentAsync(CancellationToken cancellationToken, IIntegerList dataToSend);
		IDocumentWordSearchResult GetDocumentWordSearchResultFromPositionsRelation();
		Task<DeserializedHttpResponse<IDocumentWordSearchResult>> GetDocumentWordSearchResultFromPositionsRelationAsync();
		Task<DeserializedHttpResponse<IDocumentWordSearchResult>> GetDocumentWordSearchResultFromPositionsRelationAsync(CancellationToken cancellationToken);
		IDocumentWordSearchResult PostToPositionsRelationForDocumentWordSearchResult(ISearchPositionQuery dataToSend);
		Task<DeserializedHttpResponse<IDocumentWordSearchResult>> PostToPositionsRelationForDocumentWordSearchResultAsync(ISearchPositionQuery dataToSend);
		Task<DeserializedHttpResponse<IDocumentWordSearchResult>> PostToPositionsRelationForDocumentWordSearchResultAsync(CancellationToken cancellationToken, ISearchPositionQuery dataToSend);
		string PostToLockRelationForString(ILockInfo dataToSend);
		Task<DeserializedHttpResponse<string>> PostToLockRelationForStringAsync(ILockInfo dataToSend);
		Task<DeserializedHttpResponse<string>> PostToLockRelationForStringAsync(CancellationToken cancellationToken, ILockInfo dataToSend);
		string DeleteLockRelation();
		Task<DeserializedHttpResponse<string>> DeleteLockRelationAsync();
		Task<DeserializedHttpResponse<string>> DeleteLockRelationAsync(CancellationToken cancellationToken);
		Stream GetStreamFromThumbnailRelation();
		Task<DeserializedHttpResponse<Stream>> GetStreamFromThumbnailRelationAsync();
		Task<DeserializedHttpResponse<Stream>> GetStreamFromThumbnailRelationAsync(CancellationToken cancellationToken);
		Stream GetStreamFromThumbnailWithoutAnnotationRelation();
		Task<DeserializedHttpResponse<Stream>> GetStreamFromThumbnailWithoutAnnotationRelationAsync();
		Task<DeserializedHttpResponse<Stream>> GetStreamFromThumbnailWithoutAnnotationRelationAsync(CancellationToken cancellationToken);
		Stream GetStreamFromAnnotationAsSvgRelation();
		Task<DeserializedHttpResponse<Stream>> GetStreamFromAnnotationAsSvgRelationAsync();
		Task<DeserializedHttpResponse<Stream>> GetStreamFromAnnotationAsSvgRelationAsync(CancellationToken cancellationToken);
		Stream GetStreamFromLowQualityImageRelation();
		Task<DeserializedHttpResponse<Stream>> GetStreamFromLowQualityImageRelationAsync();
		Task<DeserializedHttpResponse<Stream>> GetStreamFromLowQualityImageRelationAsync(CancellationToken cancellationToken);
		Stream GetStreamFromDeepZoomImageRelation();
		Task<DeserializedHttpResponse<Stream>> GetStreamFromDeepZoomImageRelationAsync();
		Task<DeserializedHttpResponse<Stream>> GetStreamFromDeepZoomImageRelationAsync(CancellationToken cancellationToken);
		Stream GetStreamFromDeepZoomImageWithAnnotationRelation();
		Task<DeserializedHttpResponse<Stream>> GetStreamFromDeepZoomImageWithAnnotationRelationAsync();
		Task<DeserializedHttpResponse<Stream>> GetStreamFromDeepZoomImageWithAnnotationRelationAsync(CancellationToken cancellationToken);
		Stream GetStreamFromResultListIconRelation();
		Task<DeserializedHttpResponse<Stream>> GetStreamFromResultListIconRelationAsync();
		Task<DeserializedHttpResponse<Stream>> GetStreamFromResultListIconRelationAsync(CancellationToken cancellationToken);
		IDocumentIndexFields GetDocumentIndexFieldsFromFieldsRelation();
		Task<DeserializedHttpResponse<IDocumentIndexFields>> GetDocumentIndexFieldsFromFieldsRelationAsync();
		Task<DeserializedHttpResponse<IDocumentIndexFields>> GetDocumentIndexFieldsFromFieldsRelationAsync(CancellationToken cancellationToken);
		IDocumentIndexFields PutToFieldsRelationForDocumentIndexFields(IDocumentIndexFields dataToSend);
		Task<DeserializedHttpResponse<IDocumentIndexFields>> PutToFieldsRelationForDocumentIndexFieldsAsync(IDocumentIndexFields dataToSend);
		Task<DeserializedHttpResponse<IDocumentIndexFields>> PutToFieldsRelationForDocumentIndexFieldsAsync(CancellationToken cancellationToken, IDocumentIndexFields dataToSend);
		IDocumentIndexFields PutToFieldsRelationForDocumentIndexFields(IUpdateIndexFieldsInfo dataToSend);
		Task<DeserializedHttpResponse<IDocumentIndexFields>> PutToFieldsRelationForDocumentIndexFieldsAsync(IUpdateIndexFieldsInfo dataToSend);
		Task<DeserializedHttpResponse<IDocumentIndexFields>> PutToFieldsRelationForDocumentIndexFieldsAsync(CancellationToken cancellationToken, IUpdateIndexFieldsInfo dataToSend);
		ISuggestionFields GetSuggestionFieldsFromSuggestionsRelation();
		Task<DeserializedHttpResponse<ISuggestionFields>> GetSuggestionFieldsFromSuggestionsRelationAsync();
		Task<DeserializedHttpResponse<ISuggestionFields>> GetSuggestionFieldsFromSuggestionsRelationAsync(CancellationToken cancellationToken);
		ISuggestionTableFields GetSuggestionTableFieldsFromTableFieldsSuggestionsRelation();
		Task<DeserializedHttpResponse<ISuggestionTableFields>> GetSuggestionTableFieldsFromTableFieldsSuggestionsRelationAsync();
		Task<DeserializedHttpResponse<ISuggestionTableFields>> GetSuggestionTableFieldsFromTableFieldsSuggestionsRelationAsync(CancellationToken cancellationToken);
		ISections GetSectionsFromSectionsRelation();
		Task<DeserializedHttpResponse<ISections>> GetSectionsFromSectionsRelationAsync();
		Task<DeserializedHttpResponse<ISections>> GetSectionsFromSectionsRelationAsync(CancellationToken cancellationToken);
		ISection PostToSectionsRelationForSection(string requestedContentType, Stream dataToSend);
		Task<DeserializedHttpResponse<ISection>> PostToSectionsRelationForSectionAsync(string requestedContentType, Stream dataToSend);
		Task<DeserializedHttpResponse<ISection>> PostToSectionsRelationForSectionAsync(CancellationToken cancellationToken, string requestedContentType, Stream dataToSend);
		Stream GetStreamFromContentRelation();
		Task<DeserializedHttpResponse<Stream>> GetStreamFromContentRelationAsync();
		Task<DeserializedHttpResponse<Stream>> GetStreamFromContentRelationAsync(CancellationToken cancellationToken);
		Stream PostToContentRelationForStream(IIntegerList dataToSend);
		Task<DeserializedHttpResponse<Stream>> PostToContentRelationForStreamAsync(IIntegerList dataToSend);
		Task<DeserializedHttpResponse<Stream>> PostToContentRelationForStreamAsync(CancellationToken cancellationToken, IIntegerList dataToSend);
		Stream GetStreamFromFileDownloadRelation();
		Task<DeserializedHttpResponse<Stream>> GetStreamFromFileDownloadRelationAsync();
		Task<DeserializedHttpResponse<Stream>> GetStreamFromFileDownloadRelationAsync(CancellationToken cancellationToken);
		Stream PostToFileDownloadRelationForStream(IFileDownload dataToSend);
		Task<DeserializedHttpResponse<Stream>> PostToFileDownloadRelationForStreamAsync(IFileDownload dataToSend);
		Task<DeserializedHttpResponse<Stream>> PostToFileDownloadRelationForStreamAsync(CancellationToken cancellationToken, IFileDownload dataToSend);
		Stream GetStreamFromTextAnnotationRelation();
		Task<DeserializedHttpResponse<Stream>> GetStreamFromTextAnnotationRelationAsync();
		Task<DeserializedHttpResponse<Stream>> GetStreamFromTextAnnotationRelationAsync(CancellationToken cancellationToken);
		Stream PostToTextAnnotationRelationForStream(Stream dataToSend);
		Task<DeserializedHttpResponse<Stream>> PostToTextAnnotationRelationForStreamAsync(Stream dataToSend);
		Task<DeserializedHttpResponse<Stream>> PostToTextAnnotationRelationForStreamAsync(CancellationToken cancellationToken, Stream dataToSend);
		string GetStringFromChecksumStatusRelation();
		Task<DeserializedHttpResponse<string>> GetStringFromChecksumStatusRelationAsync();
		Task<DeserializedHttpResponse<string>> GetStringFromChecksumStatusRelationAsync(CancellationToken cancellationToken);
		IXmlDSigContentType GetXmlDSigContentTypeFromXmlDSigContentRelation();
		Task<DeserializedHttpResponse<IXmlDSigContentType>> GetXmlDSigContentTypeFromXmlDSigContentRelationAsync();
		Task<DeserializedHttpResponse<IXmlDSigContentType>> GetXmlDSigContentTypeFromXmlDSigContentRelationAsync(CancellationToken cancellationToken);
		IRights PostToRightsRelationForRights(IRights dataToSend);
		Task<DeserializedHttpResponse<IRights>> PostToRightsRelationForRightsAsync(IRights dataToSend);
		Task<DeserializedHttpResponse<IRights>> PostToRightsRelationForRightsAsync(CancellationToken cancellationToken, IRights dataToSend);
		IDocument PutToProcessDocumentActionRelationForDocument(IDocumentActionInfo dataToSend);
		Task<DeserializedHttpResponse<IDocument>> PutToProcessDocumentActionRelationForDocumentAsync(IDocumentActionInfo dataToSend);
		Task<DeserializedHttpResponse<IDocument>> PutToProcessDocumentActionRelationForDocumentAsync(CancellationToken cancellationToken, IDocumentActionInfo dataToSend);
		IDocumentApplicationProperties GetDocumentApplicationPropertiesFromAppPropertiesRelation();
		Task<DeserializedHttpResponse<IDocumentApplicationProperties>> GetDocumentApplicationPropertiesFromAppPropertiesRelationAsync();
		Task<DeserializedHttpResponse<IDocumentApplicationProperties>> GetDocumentApplicationPropertiesFromAppPropertiesRelationAsync(CancellationToken cancellationToken);
		IDocumentApplicationProperties PostToAppPropertiesRelationForDocumentApplicationProperties(IDocumentApplicationProperties dataToSend);
		Task<DeserializedHttpResponse<IDocumentApplicationProperties>> PostToAppPropertiesRelationForDocumentApplicationPropertiesAsync(IDocumentApplicationProperties dataToSend);
		Task<DeserializedHttpResponse<IDocumentApplicationProperties>> PostToAppPropertiesRelationForDocumentApplicationPropertiesAsync(CancellationToken cancellationToken, IDocumentApplicationProperties dataToSend);
		IDocumentLinks GetDocumentLinksFromDocumentLinksRelation();
		Task<DeserializedHttpResponse<IDocumentLinks>> GetDocumentLinksFromDocumentLinksRelationAsync();
		Task<DeserializedHttpResponse<IDocumentLinks>> GetDocumentLinksFromDocumentLinksRelationAsync(CancellationToken cancellationToken);
		IDocument GetDocumentFromLatestVersionRelation();
		Task<DeserializedHttpResponse<IDocument>> GetDocumentFromLatestVersionRelationAsync();
		Task<DeserializedHttpResponse<IDocument>> GetDocumentFromLatestVersionRelationAsync(CancellationToken cancellationToken);
		IDocumentsQueryResult GetDocumentsQueryResultFromVersionHistoryRelation();
		Task<DeserializedHttpResponse<IDocumentsQueryResult>> GetDocumentsQueryResultFromVersionHistoryRelationAsync();
		Task<DeserializedHttpResponse<IDocumentsQueryResult>> GetDocumentsQueryResultFromVersionHistoryRelationAsync(CancellationToken cancellationToken);
		IDocumentsQueryResult PostToVersionHistoryRelationForDocumentsQueryResult(IResultListQuery dataToSend);
		Task<DeserializedHttpResponse<IDocumentsQueryResult>> PostToVersionHistoryRelationForDocumentsQueryResultAsync(IResultListQuery dataToSend);
		Task<DeserializedHttpResponse<IDocumentsQueryResult>> PostToVersionHistoryRelationForDocumentsQueryResultAsync(CancellationToken cancellationToken, IResultListQuery dataToSend);
		Stream PostToCheckoutDocumentRelationForStream(ICheckOutToFileSystemInfo dataToSend);
		Task<DeserializedHttpResponse<Stream>> PostToCheckoutDocumentRelationForStreamAsync(ICheckOutToFileSystemInfo dataToSend);
		Task<DeserializedHttpResponse<Stream>> PostToCheckoutDocumentRelationForStreamAsync(CancellationToken cancellationToken, ICheckOutToFileSystemInfo dataToSend);
		Stream PostToCheckoutToFileSystemRelationForStream(ICheckOutToFileSystemInfo dataToSend);
		Task<DeserializedHttpResponse<Stream>> PostToCheckoutToFileSystemRelationForStreamAsync(ICheckOutToFileSystemInfo dataToSend);
		Task<DeserializedHttpResponse<Stream>> PostToCheckoutToFileSystemRelationForStreamAsync(CancellationToken cancellationToken, ICheckOutToFileSystemInfo dataToSend);
		IDocument PostToCheckInFromFileSystemRelationForDocument(Stream dataToSend);
		Task<DeserializedHttpResponse<IDocument>> PostToCheckInFromFileSystemRelationForDocumentAsync(Stream dataToSend);
		Task<DeserializedHttpResponse<IDocument>> PostToCheckInFromFileSystemRelationForDocumentAsync(CancellationToken cancellationToken, Stream dataToSend);
		Stream PostToDownloadAsArchiveRelationForStream(IExportSettings dataToSend);
		Task<DeserializedHttpResponse<Stream>> PostToDownloadAsArchiveRelationForStreamAsync(IExportSettings dataToSend);
		Task<DeserializedHttpResponse<Stream>> PostToDownloadAsArchiveRelationForStreamAsync(CancellationToken cancellationToken, IExportSettings dataToSend);
		IDocumentAnnotations GetDocumentAnnotationsFromAnnotationRelation();
		Task<DeserializedHttpResponse<IDocumentAnnotations>> GetDocumentAnnotationsFromAnnotationRelationAsync();
		Task<DeserializedHttpResponse<IDocumentAnnotations>> GetDocumentAnnotationsFromAnnotationRelationAsync(CancellationToken cancellationToken);
		IDocumentAnnotations PostToAnnotationRelationForDocumentAnnotations(IDocumentAnnotationsPlacement dataToSend);
		Task<DeserializedHttpResponse<IDocumentAnnotations>> PostToAnnotationRelationForDocumentAnnotationsAsync(IDocumentAnnotationsPlacement dataToSend);
		Task<DeserializedHttpResponse<IDocumentAnnotations>> PostToAnnotationRelationForDocumentAnnotationsAsync(CancellationToken cancellationToken, IDocumentAnnotationsPlacement dataToSend);
		IWorkflowDocumentHistory GetWorkflowDocumentHistoryFromWorkflowHistoryRelation();
		Task<DeserializedHttpResponse<IWorkflowDocumentHistory>> GetWorkflowDocumentHistoryFromWorkflowHistoryRelationAsync();
		Task<DeserializedHttpResponse<IWorkflowDocumentHistory>> GetWorkflowDocumentHistoryFromWorkflowHistoryRelationAsync(CancellationToken cancellationToken);
		IDocumentAuditInformation GetDocumentAuditInformationFromAuditInformationRelation();
		Task<DeserializedHttpResponse<IDocumentAuditInformation>> GetDocumentAuditInformationFromAuditInformationRelationAsync();
		Task<DeserializedHttpResponse<IDocumentAuditInformation>> GetDocumentAuditInformationFromAuditInformationRelationAsync(CancellationToken cancellationToken);
		IDocumentAuditInformation PostToAuditInformationRelationForDocumentAuditInformation(IDocumentAuditQuery dataToSend);
		Task<DeserializedHttpResponse<IDocumentAuditInformation>> PostToAuditInformationRelationForDocumentAuditInformationAsync(IDocumentAuditQuery dataToSend);
		Task<DeserializedHttpResponse<IDocumentAuditInformation>> PostToAuditInformationRelationForDocumentAuditInformationAsync(CancellationToken cancellationToken, IDocumentAuditQuery dataToSend);
    }
}
