using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IWordSearchResult
    {
		List<IWordSearchResultPageHit> PageHits { get; set; }
		Link[] Links { get; set; }

		void SetProxy(HttpClientProxy proxy);
		IWordSearchResult GetWordSearchResultFromNextRelation();
		Task<DeserializedHttpResponse<IWordSearchResult>> GetWordSearchResultFromNextRelationAsync();
		Task<DeserializedHttpResponse<IWordSearchResult>> GetWordSearchResultFromNextRelationAsync(CancellationToken cancellationToken);
    }
}
