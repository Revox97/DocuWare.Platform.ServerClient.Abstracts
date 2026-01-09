using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IDocumentWordSearchResult{3}
    {
		List<IDocumentWordSearchResultSectionHits> SectionHits { get; set; }
		Link[] Links { get; set; }

		void SetProxy(HttpClientProxy proxy);
		IDocumentWordSearchResult GetDocumentWordSearchResultFromNextRelation();
		Task<DeserializedHttpResponse<IDocumentWordSearchResult>> GetDocumentWordSearchResultFromNextRelationAsync();
		Task<DeserializedHttpResponse<IDocumentWordSearchResult>> GetDocumentWordSearchResultFromNextRelationAsync(CancellationToken cancellationToken);
    }
}
