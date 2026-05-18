using DocuWare.Platform.ServerClient;
using DocuWare.Platform.ServerClient.Abstracts.Content;
using DocuWare.Platform.ServerClient.Abstracts.Policy.CircuitBreaker;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Resilience;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Retry;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IDocumentWordSearchResult
    {
		bool FoundInAnnotations { get; set; }
		string Search { get; set; }
		List<IDocumentWordSearchResultSectionHits> SectionHits { get; set; }
		Link[] Links { get; set; }

		void SetProxy(HttpClientProxy proxy);
		IDocumentWordSearchResult GetDocumentWordSearchResultFromNextRelation();
		Task<DeserializedHttpResponse<IDocumentWordSearchResult>> GetDocumentWordSearchResultFromNextRelationAsync();
		Task<DeserializedHttpResponse<IDocumentWordSearchResult>> GetDocumentWordSearchResultFromNextRelationAsync(CancellationToken cancellationToken);
    }
}
