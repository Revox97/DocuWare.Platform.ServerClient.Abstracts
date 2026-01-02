using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface ISection
    {
		List<DocuWare.Platform.ServerClient.SignatureStatus> SignatureStatus { get; set; }
		IUploadedFileChunk FileChunk { get; set; }
		Link[] Links { get; set; }
		string Id { get; set; }
		string ContentType { get; set; }
		bool HaveMorePages { get; set; }
		int PageCount { get; set; }
		long FileSize { get; set; }
		string OriginalFileName { get; set; }
		DateTime ContentModified { get; set; }
		bool HasTextAnnotation { get; set; }
		bool AnnotationsPreview { get; set; }

		void SetProxy(HttpClientProxy proxy);
		IDocument GetDocumentFromDocumentRelation();
		Task<DeserializedHttpResponse<IDocument>> GetDocumentFromDocumentRelationAsync();
		Task<DeserializedHttpResponse<IDocument>> GetDocumentFromDocumentRelationAsync(CancellationToken cancellationToken);
		Stream GetStreamFromDeepZoomImageRelation();
		Task<DeserializedHttpResponse<Stream>> GetStreamFromDeepZoomImageRelationAsync();
		Task<DeserializedHttpResponse<Stream>> GetStreamFromDeepZoomImageRelationAsync(CancellationToken cancellationToken);
		Stream GetStreamFromDeepZoomImageWithAnnotationRelation();
		Task<DeserializedHttpResponse<Stream>> GetStreamFromDeepZoomImageWithAnnotationRelationAsync();
		Task<DeserializedHttpResponse<Stream>> GetStreamFromDeepZoomImageWithAnnotationRelationAsync(CancellationToken cancellationToken);
		IWordSearchResult GetWordSearchResultFromPositionsRelation();
		Task<DeserializedHttpResponse<IWordSearchResult>> GetWordSearchResultFromPositionsRelationAsync();
		Task<DeserializedHttpResponse<IWordSearchResult>> GetWordSearchResultFromPositionsRelationAsync(CancellationToken cancellationToken);
		IWordSearchResult PostToPositionsRelationForWordSearchResult(ISearchPositionQuery dataToSend);
		Task<DeserializedHttpResponse<IWordSearchResult>> PostToPositionsRelationForWordSearchResultAsync(ISearchPositionQuery dataToSend);
		Task<DeserializedHttpResponse<IWordSearchResult>> PostToPositionsRelationForWordSearchResultAsync(CancellationToken cancellationToken, ISearchPositionQuery dataToSend);
		IDocumentContent GetDocumentContentFromTextshotRelation();
		Task<DeserializedHttpResponse<IDocumentContent>> GetDocumentContentFromTextshotRelationAsync();
		Task<DeserializedHttpResponse<IDocumentContent>> GetDocumentContentFromTextshotRelationAsync(CancellationToken cancellationToken);
		string PutToTextshotRelationForString(IDocumentContent dataToSend);
		Task<DeserializedHttpResponse<string>> PutToTextshotRelationForStringAsync(IDocumentContent dataToSend);
		Task<DeserializedHttpResponse<string>> PutToTextshotRelationForStringAsync(CancellationToken cancellationToken, IDocumentContent dataToSend);
		Stream GetStreamFromContentRelation();
		Task<DeserializedHttpResponse<Stream>> GetStreamFromContentRelationAsync();
		Task<DeserializedHttpResponse<Stream>> GetStreamFromContentRelationAsync(CancellationToken cancellationToken);
		ISection PutToContentRelationForSection(string requestedContentType, Stream dataToSend);
		Task<DeserializedHttpResponse<ISection>> PutToContentRelationForSectionAsync(string requestedContentType, Stream dataToSend);
		Task<DeserializedHttpResponse<ISection>> PutToContentRelationForSectionAsync(CancellationToken cancellationToken, string requestedContentType, Stream dataToSend);
		ISection PostToContentRelationForSection(string requestedContentType, Stream dataToSend);
		Task<DeserializedHttpResponse<ISection>> PostToContentRelationForSectionAsync(string requestedContentType, Stream dataToSend);
		Task<DeserializedHttpResponse<ISection>> PostToContentRelationForSectionAsync(CancellationToken cancellationToken, string requestedContentType, Stream dataToSend);
		Stream GetStreamFromFileDownloadRelation();
		Task<DeserializedHttpResponse<Stream>> GetStreamFromFileDownloadRelationAsync();
		Task<DeserializedHttpResponse<Stream>> GetStreamFromFileDownloadRelationAsync(CancellationToken cancellationToken);
		Stream PostToFileDownloadRelationForStream(IFileDownload dataToSend);
		Task<DeserializedHttpResponse<Stream>> PostToFileDownloadRelationForStreamAsync(IFileDownload dataToSend);
		Task<DeserializedHttpResponse<Stream>> PostToFileDownloadRelationForStreamAsync(CancellationToken cancellationToken, IFileDownload dataToSend);
		ISection GetSectionFromSelfRelation();
		Task<DeserializedHttpResponse<ISection>> GetSectionFromSelfRelationAsync();
		Task<DeserializedHttpResponse<ISection>> GetSectionFromSelfRelationAsync(CancellationToken cancellationToken);
		string DeleteSelfRelation();
		Task<DeserializedHttpResponse<string>> DeleteSelfRelationAsync();
		Task<DeserializedHttpResponse<string>> DeleteSelfRelationAsync(CancellationToken cancellationToken);
		Stream GetStreamFromThumbnailRelation();
		Task<DeserializedHttpResponse<Stream>> GetStreamFromThumbnailRelationAsync();
		Task<DeserializedHttpResponse<Stream>> GetStreamFromThumbnailRelationAsync(CancellationToken cancellationToken);
		Stream GetStreamFromIconRelation();
		Task<DeserializedHttpResponse<Stream>> GetStreamFromIconRelationAsync();
		Task<DeserializedHttpResponse<Stream>> GetStreamFromIconRelationAsync(CancellationToken cancellationToken);
		Stream GetStreamFromTextAnnotationRelation();
		Task<DeserializedHttpResponse<Stream>> GetStreamFromTextAnnotationRelationAsync();
		Task<DeserializedHttpResponse<Stream>> GetStreamFromTextAnnotationRelationAsync(CancellationToken cancellationToken);
		Stream PostToTextAnnotationRelationForStream(Stream dataToSend);
		Task<DeserializedHttpResponse<Stream>> PostToTextAnnotationRelationForStreamAsync(Stream dataToSend);
		Task<DeserializedHttpResponse<Stream>> PostToTextAnnotationRelationForStreamAsync(CancellationToken cancellationToken, Stream dataToSend);
		IPages PostToPagesBlockRelationForPages(IPagesBlockQuery dataToSend);
		Task<DeserializedHttpResponse<IPages>> PostToPagesBlockRelationForPagesAsync(IPagesBlockQuery dataToSend);
		Task<DeserializedHttpResponse<IPages>> PostToPagesBlockRelationForPagesAsync(CancellationToken cancellationToken, IPagesBlockQuery dataToSend);
		Stream GetStreamFromAnnotationAsSvgRelation();
		Task<DeserializedHttpResponse<Stream>> GetStreamFromAnnotationAsSvgRelationAsync();
		Task<DeserializedHttpResponse<Stream>> GetStreamFromAnnotationAsSvgRelationAsync(CancellationToken cancellationToken);
		IDocumentApplicationProperties GetDocumentApplicationPropertiesFromAppPropertiesRelation();
		Task<DeserializedHttpResponse<IDocumentApplicationProperties>> GetDocumentApplicationPropertiesFromAppPropertiesRelationAsync();
		Task<DeserializedHttpResponse<IDocumentApplicationProperties>> GetDocumentApplicationPropertiesFromAppPropertiesRelationAsync(CancellationToken cancellationToken);
		IDocumentApplicationProperties PostToAppPropertiesRelationForDocumentApplicationProperties(IDocumentApplicationProperties dataToSend);
		Task<DeserializedHttpResponse<IDocumentApplicationProperties>> PostToAppPropertiesRelationForDocumentApplicationPropertiesAsync(IDocumentApplicationProperties dataToSend);
		Task<DeserializedHttpResponse<IDocumentApplicationProperties>> PostToAppPropertiesRelationForDocumentApplicationPropertiesAsync(CancellationToken cancellationToken, IDocumentApplicationProperties dataToSend);
    }
}
