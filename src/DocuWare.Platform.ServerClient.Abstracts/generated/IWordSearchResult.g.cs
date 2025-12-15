using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IWordSearchResult
    {
		string Search { get; set; }
		List<IWordSearchResultPageHit> PageHits { get; set; }
		Link[] Links { get; set; }
		string NextRelationLink { get; }

		void SetProxy(HttpClientProxy proxy);
		IWordSearchResult GetWordSearchResultFromNextRelation();
		Task<DeserializedHttpResponse<IWordSearchResult>> GetWordSearchResultFromNextRelationAsync();
		Task<DeserializedHttpResponse<IWordSearchResult>> GetWordSearchResultFromNextRelationAsync(CancellationToken cancellationToken);
    }
}
