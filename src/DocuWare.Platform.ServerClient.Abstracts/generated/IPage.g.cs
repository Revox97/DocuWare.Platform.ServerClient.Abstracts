using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IPage
    {
		IPageData Data { get; set; }
		Link[] Links { get; set; }
		int PageNum { get; set; }
		bool HasAnnotation { get; set; }
		string ThumbnailRelationLink { get; }
		string IconRelationLink { get; }
		string DeepZoomImageRelationLink { get; }
		string DeepZoomImageWithAnnotationRelationLink { get; }
		string LowQualityImageRelationLink { get; }
		string LowQualityImageWithAnnotationRelationLink { get; }
		string TextshotRelationLink { get; }
		string FileDownloadRelationLink { get; }
		string AnnotationRelationLink { get; }
		string AnnotationAsSvgRelationLink { get; }
		string AnnotationAsXamlRelationLink { get; }
		string StampRelationLink { get; }
		string StampBestPositionRelationLink { get; }
		string SelfRelationLink { get; }

		void SetProxy(HttpClientProxy proxy);
		Stream GetStreamFromThumbnailRelation();
		Task<DeserializedHttpResponse<Stream>> GetStreamFromThumbnailRelationAsync();
		Task<DeserializedHttpResponse<Stream>> GetStreamFromThumbnailRelationAsync(CancellationToken cancellationToken);
		Stream GetStreamFromIconRelation();
		Task<DeserializedHttpResponse<Stream>> GetStreamFromIconRelationAsync();
		Task<DeserializedHttpResponse<Stream>> GetStreamFromIconRelationAsync(CancellationToken cancellationToken);
		Stream GetStreamFromDeepZoomImageRelation();
		Task<DeserializedHttpResponse<Stream>> GetStreamFromDeepZoomImageRelationAsync();
		Task<DeserializedHttpResponse<Stream>> GetStreamFromDeepZoomImageRelationAsync(CancellationToken cancellationToken);
		Stream GetStreamFromDeepZoomImageWithAnnotationRelation();
		Task<DeserializedHttpResponse<Stream>> GetStreamFromDeepZoomImageWithAnnotationRelationAsync();
		Task<DeserializedHttpResponse<Stream>> GetStreamFromDeepZoomImageWithAnnotationRelationAsync(CancellationToken cancellationToken);
		Stream GetStreamFromLowQualityImageRelation();
		Task<DeserializedHttpResponse<Stream>> GetStreamFromLowQualityImageRelationAsync();
		Task<DeserializedHttpResponse<Stream>> GetStreamFromLowQualityImageRelationAsync(CancellationToken cancellationToken);
		Stream GetStreamFromLowQualityImageWithAnnotationRelation();
		Task<DeserializedHttpResponse<Stream>> GetStreamFromLowQualityImageWithAnnotationRelationAsync();
		Task<DeserializedHttpResponse<Stream>> GetStreamFromLowQualityImageWithAnnotationRelationAsync(CancellationToken cancellationToken);
		IPageContent GetPageContentFromTextshotRelation();
		Task<DeserializedHttpResponse<IPageContent>> GetPageContentFromTextshotRelationAsync();
		Task<DeserializedHttpResponse<IPageContent>> GetPageContentFromTextshotRelationAsync(CancellationToken cancellationToken);
		Stream GetStreamFromFileDownloadRelation();
		Task<DeserializedHttpResponse<Stream>> GetStreamFromFileDownloadRelationAsync();
		Task<DeserializedHttpResponse<Stream>> GetStreamFromFileDownloadRelationAsync(CancellationToken cancellationToken);
		Stream PostToFileDownloadRelationForStream(IFileDownloadPage dataToSend);
		Task<DeserializedHttpResponse<Stream>> PostToFileDownloadRelationForStreamAsync(IFileDownloadPage dataToSend);
		Task<DeserializedHttpResponse<Stream>> PostToFileDownloadRelationForStreamAsync(CancellationToken cancellationToken, IFileDownloadPage dataToSend);
		IAnnotation GetAnnotationFromAnnotationRelation();
		Task<DeserializedHttpResponse<IAnnotation>> GetAnnotationFromAnnotationRelationAsync();
		Task<DeserializedHttpResponse<IAnnotation>> GetAnnotationFromAnnotationRelationAsync(CancellationToken cancellationToken);
		IAnnotation PostToAnnotationRelationForAnnotation(IAnnotationsPlacement dataToSend);
		Task<DeserializedHttpResponse<IAnnotation>> PostToAnnotationRelationForAnnotationAsync(IAnnotationsPlacement dataToSend);
		Task<DeserializedHttpResponse<IAnnotation>> PostToAnnotationRelationForAnnotationAsync(CancellationToken cancellationToken, IAnnotationsPlacement dataToSend);
		IAnnotation PostToAnnotationRelationForAnnotation(IAnnotation dataToSend);
		Task<DeserializedHttpResponse<IAnnotation>> PostToAnnotationRelationForAnnotationAsync(IAnnotation dataToSend);
		Task<DeserializedHttpResponse<IAnnotation>> PostToAnnotationRelationForAnnotationAsync(CancellationToken cancellationToken, IAnnotation dataToSend);
		Stream GetStreamFromAnnotationAsSvgRelation();
		Task<DeserializedHttpResponse<Stream>> GetStreamFromAnnotationAsSvgRelationAsync();
		Task<DeserializedHttpResponse<Stream>> GetStreamFromAnnotationAsSvgRelationAsync(CancellationToken cancellationToken);
		XElementWrapper GetXElementWrapperFromAnnotationAsXamlRelation();
		Task<DeserializedHttpResponse<XElementWrapper>> GetXElementWrapperFromAnnotationAsXamlRelationAsync();
		Task<DeserializedHttpResponse<XElementWrapper>> GetXElementWrapperFromAnnotationAsXamlRelationAsync(CancellationToken cancellationToken);
		IAnnotation PostToStampRelationForAnnotation(IStampPlacement dataToSend);
		Task<DeserializedHttpResponse<IAnnotation>> PostToStampRelationForAnnotationAsync(IStampPlacement dataToSend);
		Task<DeserializedHttpResponse<IAnnotation>> PostToStampRelationForAnnotationAsync(CancellationToken cancellationToken, IStampPlacement dataToSend);
		IDWPoint PostToStampBestPositionRelationForDWPoint(IStampFormFieldValues dataToSend);
		Task<DeserializedHttpResponse<IDWPoint>> PostToStampBestPositionRelationForDWPointAsync(IStampFormFieldValues dataToSend);
		Task<DeserializedHttpResponse<IDWPoint>> PostToStampBestPositionRelationForDWPointAsync(CancellationToken cancellationToken, IStampFormFieldValues dataToSend);
		IPage GetPageFromSelfRelation();
		Task<DeserializedHttpResponse<IPage>> GetPageFromSelfRelationAsync();
		Task<DeserializedHttpResponse<IPage>> GetPageFromSelfRelationAsync(CancellationToken cancellationToken);
    }
}
