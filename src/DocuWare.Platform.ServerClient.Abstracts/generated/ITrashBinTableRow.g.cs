using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface ITrashBinTableRow{3}
    {
		List<object> Items { get; set; }
		Link[] Links { get; set; }
		string Id { get; set; }

		void SetProxy(HttpClientProxy proxy);
		IDocument GetDocumentFromDocumentRelation();
		Task<DeserializedHttpResponse<IDocument>> GetDocumentFromDocumentRelationAsync();
		Task<DeserializedHttpResponse<IDocument>> GetDocumentFromDocumentRelationAsync(CancellationToken cancellationToken);
		Stream GetStreamFromLowQualityImageRelation();
		Task<DeserializedHttpResponse<Stream>> GetStreamFromLowQualityImageRelationAsync();
		Task<DeserializedHttpResponse<Stream>> GetStreamFromLowQualityImageRelationAsync(CancellationToken cancellationToken);
		Stream GetStreamFromAnnotationAsSvgRelation();
		Task<DeserializedHttpResponse<Stream>> GetStreamFromAnnotationAsSvgRelationAsync();
		Task<DeserializedHttpResponse<Stream>> GetStreamFromAnnotationAsSvgRelationAsync(CancellationToken cancellationToken);
    }
}
