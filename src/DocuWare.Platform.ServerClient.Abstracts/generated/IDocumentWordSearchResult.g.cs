using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IDocumentWordSearchResult
    {
		bool FoundInAnnotations { get; set; }
		string Search { get; set; }
		List<IDocumentWordSearchResultSectionHits> SectionHits { get; set; }
		Link[] Links { get; set; }
		string NextRelationLink { get; }

		void SetProxy(HttpClientProxy proxy);
		IDocumentWordSearchResult GetDocumentWordSearchResultFromNextRelation();
		Task<DeserializedHttpResponse<IDocumentWordSearchResult>> GetDocumentWordSearchResultFromNextRelationAsync();
		Task<DeserializedHttpResponse<IDocumentWordSearchResult>> GetDocumentWordSearchResultFromNextRelationAsync(CancellationToken cancellationToken);
    }
}
