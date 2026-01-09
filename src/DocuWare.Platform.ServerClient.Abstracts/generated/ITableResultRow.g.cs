using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface ITableResultRow{3}
    {
		List<object> Items { get; set; }
		Link[] Links { get; set; }
		List<ISuggestionField> Suggestions { get; set; }
		List<ISuggestionTableField> TableFieldSuggestions { get; set; }
		int Id { get; set; }
		bool AnnotationsPreview { get; set; }

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
		IDocument PutToClippedDocumentsRelationForDocument(IIntegerList dataToSend);
		Task<DeserializedHttpResponse<IDocument>> PutToClippedDocumentsRelationForDocumentAsync(IIntegerList dataToSend);
		Task<DeserializedHttpResponse<IDocument>> PutToClippedDocumentsRelationForDocumentAsync(CancellationToken cancellationToken, IIntegerList dataToSend);
		ISections GetSectionsFromSectionsRelation();
		Task<DeserializedHttpResponse<ISections>> GetSectionsFromSectionsRelationAsync();
		Task<DeserializedHttpResponse<ISections>> GetSectionsFromSectionsRelationAsync(CancellationToken cancellationToken);
		ISection PostToSectionsRelationForSection(string requestedContentType, Stream dataToSend);
		Task<DeserializedHttpResponse<ISection>> PostToSectionsRelationForSectionAsync(string requestedContentType, Stream dataToSend);
		Task<DeserializedHttpResponse<ISection>> PostToSectionsRelationForSectionAsync(CancellationToken cancellationToken, string requestedContentType, Stream dataToSend);
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
		string PostToLockRelationForString(ILockInfo dataToSend);
		Task<DeserializedHttpResponse<string>> PostToLockRelationForStringAsync(ILockInfo dataToSend);
		Task<DeserializedHttpResponse<string>> PostToLockRelationForStringAsync(CancellationToken cancellationToken, ILockInfo dataToSend);
		string DeleteLockRelation();
		Task<DeserializedHttpResponse<string>> DeleteLockRelationAsync();
		Task<DeserializedHttpResponse<string>> DeleteLockRelationAsync(CancellationToken cancellationToken);
		IRights PostToRightsRelationForRights(IRights dataToSend);
		Task<DeserializedHttpResponse<IRights>> PostToRightsRelationForRightsAsync(IRights dataToSend);
		Task<DeserializedHttpResponse<IRights>> PostToRightsRelationForRightsAsync(CancellationToken cancellationToken, IRights dataToSend);
		string GetStringFromTextshotPreviewRelation();
		Task<DeserializedHttpResponse<string>> GetStringFromTextshotPreviewRelationAsync();
		Task<DeserializedHttpResponse<string>> GetStringFromTextshotPreviewRelationAsync(CancellationToken cancellationToken);
    }
}
